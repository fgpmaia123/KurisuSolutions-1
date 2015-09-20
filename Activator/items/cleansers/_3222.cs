using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Items.Cleansers
{
    class _3222 : item
    {
        internal override int Id
        {
            get { return 3222; }
        }

        internal override string Name
        {
            get { return "Mikaels"; }
        }

        internal override string DisplayName
        {
            get { return "Mikael's Crucible"; }
        }

        internal override int Priority
        {
            get { return 7; }
        }

        internal override int Duration
        {
            get { return 3000; }
        }

        internal override float Range
        {
            get { return 750f; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.SelfLowHP, MenuType.Cleanse, MenuType.ActiveCheck  }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.Common }; }
        }

        internal override int DefaultHP
        {
            get { return 10; }
        }

        internal override int DefaultMP
        {
            get { return 0; }
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            foreach (var hero in Activator.Allies())
            {
                if (!Parent.Item(Parent.Name + "useon" + hero.Player.ChampionName).GetValue<bool>())
                    continue;

                if (hero.Player.Distance(Player.ServerPosition) > Range)
                    continue;

                spelldebuffhandler.CheckMikaels(hero.Player);

                if (hero.MikaelsBuffCount >= Menu.Item("use" + Name + "number").GetValue<Slider>().Value &&
                    hero.MikaelsHighestBuffTime >= Menu.Item("use" + Name + "time").GetValue<Slider>().Value)
                {
                    //if (!Menu.Item("use" + Name + "od").GetValue<bool>())
                    //{
                        Utility.DelayAction.Add(Game.Ping + Menu.Item("use" + Name + "delay").GetValue<Slider>().Value, delegate
                            {
                                UseItem(hero.Player, Menu.Item("mode" + Name).GetValue<StringList>().SelectedIndex == 1);
                                hero.MikaelsBuffCount = 0;
                                hero.MikaelsHighestBuffTime = 0;
                            });
                    //}
                }

                if (hero.Player.Health / hero.Player.MaxHealth * 100 <=
                    Menu.Item("selflowhp" + Name + "pct").GetValue<Slider>().Value)
                {
                    if (hero.IncomeDamage > 0 && LeagueSharp.Common.Items.CanUseItem(Id))
                    {
                        UseItem(hero.Player, Menu.Item("mode" + Name).GetValue<StringList>().SelectedIndex == 1);
                        hero.MikaelsBuffCount = 0;
                        hero.MikaelsHighestBuffTime = 0;
                    }
                }
            }        
        }
    }
}
