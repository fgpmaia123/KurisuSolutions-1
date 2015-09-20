using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Items.Defensives
{
    class _3090 : item
    {
        internal override int Id
        {
            get { return 3090; }
        }

        internal override string Name
        {
            get { return "Wooglets"; }
        }

        internal override int Priority
        {
            get { return 7; }
        }

        internal override string DisplayName
        {
            get { return "Wooglet's Witchcap"; }
        }

        internal override int Duration
        {
            get { return 2500; }
        }

        internal override float Range
        {
            get { return 750f; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.SelfLowHP, MenuType.SelfMuchHP, MenuType.Zhonyas }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.CrystalScar, MapType.TwistedTreeline }; }
        }

        internal override int DefaultHP
        {
            get { return 20; }
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
                if (hero.Player.NetworkId == Player.NetworkId)
                {
                    if (!Parent.Item(Parent.Name + "useon" + hero.Player.ChampionName).GetValue<bool>())
                        continue;

                    if (Menu.Item("use" + Name + "norm").GetValue<bool>())
                        if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Danger))
                            UseItem();

                    if (Menu.Item("use" + Name + "ulti").GetValue<bool>())
                        if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Ultimate))
                            UseItem();

                    if (Player.Health/Player.MaxHealth*100 <=
                        Menu.Item("selflowhp" + Name + "pct").GetValue<Slider>().Value)
                    {
                        if (hero.IncomeDamage > 0 || hero.MinionDamage > hero.Player.Health)
                            UseItem();
                    }

                    if (hero.IncomeDamage/hero.Player.MaxHealth*100 >=
                        Menu.Item("selfmuchhp" + Name + "pct").GetValue<Slider>().Value)
                        UseItem();
                }
            }
        }
    }
}
