using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Items.Cleansers
{
    class _3140 : item 
    {
        internal override int Id
        {
            get { return 3140; }
        }

        internal override string Name
        {
            get { return "Quicksilver"; }
        }

        internal override string DisplayName
        {
            get { return "Quicksilver Sash"; }
        }

        internal override int Priority
        {
            get { return 6; }
        }

        internal override int Duration
        {
            get { return 3000; }
        }

        internal override float Range
        {
            get { return float.MaxValue; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.Cleanse, MenuType.ActiveCheck }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.Common }; }
        }

        internal override int DefaultHP
        {
            get { return 5; }
        }

        internal override int DefaultMP
        {
            get { return 0; }
        }

        public override void OnTick(EventArgs args)
        {
            foreach (var hero in Activator.Allies())
            {
                if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                    return;

                if (hero.Player.NetworkId == Player.NetworkId)
                {
                    if (!Parent.Item(Parent.Name + "useon" + hero.Player.ChampionName).GetValue<bool>())
                        continue;

                    spelldebuffhandler.CheckQSS(hero.Player);

                    if (hero.QSSBuffCount >= Menu.Item("use" + Name + "number").GetValue<Slider>().Value &&
                        hero.QSSHighestBuffTime >= Menu.Item("use" + Name + "time").GetValue<Slider>().Value)
                    {
                        //if (!Menu.Item("use" + Name + "od").GetValue<bool>())
                        //{
                            Utility.DelayAction.Add(Game.Ping + Menu.Item("use" + Name + "delay").GetValue<Slider>().Value, delegate
                            {
                                UseItem(Menu.Item("mode" + Name).GetValue<StringList>().SelectedIndex == 1);
                                hero.QSSBuffCount = 0;
                                hero.QSSHighestBuffTime = 0;
                            });
                        //}
                    }
                }
            }
        }
    }
}
