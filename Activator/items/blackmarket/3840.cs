using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp.Common;

namespace Activator.Items.Blackmarket
{
    class _3840 : item
    {
        internal override int Id
        {
            get { return 3840; }
        }

        internal override int Priority
        {
            get { return 5; }
        }

        internal override string Name
        {
            get { return "Globe"; }
        }

        internal override string DisplayName
        {
            get { return "Globe of Trust"; }
        }

        internal override float Range
        {
            get { return 550; }
        }

        internal override int Duration
        {
            get { return 3000; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.SelfLowHP, MenuType.SelfMuchHP }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.SummonersRift }; }
        }

        internal override int DefaultHP
        {
            get { return 95; }
        }

        internal override int DefaultMP
        {
            get { return 35; }
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            foreach (var hero in Activator.Allies())
            {
                if (!Parent.Item(Parent.Name + "useon" + hero.Player.ChampionName).GetValue<bool>())
                    continue;

                if (hero.Player.Distance(Player.ServerPosition) <= Range)
                {
                    if (hero.Player.Health / hero.Player.MaxHealth * 100 <=
                        Menu.Item("selflowhp" + Name + "pct").GetValue<Slider>().Value)
                    {
                        if (hero.IncomeDamage > 0 || hero.MinionDamage > hero.Player.Health)
                            UseItem(hero.Player);
                    }

                    if (hero.IncomeDamage / hero.Player.MaxHealth * 100 >=
                        Menu.Item("selfmuchhp" + Name + "pct").GetValue<Slider>().Value)
                        UseItem(hero.Player);
                }
            }
        }
    }
}
