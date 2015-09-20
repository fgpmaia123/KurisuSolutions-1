using System;
using System.Linq;
using LeagueSharp.Common;

namespace Activator.Items.Defensives
{
    class _3401 : item
    {
        internal override int Id
        {
            get { return 3401; }
        }
        internal override int Priority
        {
            get { return 6; }
        }

        internal override string Name
        {
            get { return "Mountain"; }
        }

        internal override string DisplayName
        {
            get { return "Face of the Mountain"; }
        }

        internal override int Duration
        {
            get { return 2000; }
        }

        internal override float Range
        {
            get { return 700f; }
        }

        internal override int DefaultHP
        {
            get { return 20; }
        }

        internal override int DefaultMP
        {
            get { return 0; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.SelfLowHP, MenuType.Zhonyas }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.Common }; }
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
                    if (Menu.Item("use" + Name + "norm").GetValue<bool>())
                        if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Danger))
                            UseItem(hero.Player);

                    if (Menu.Item("use" + Name + "ulti").GetValue<bool>())
                        if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Ultimate))
                            UseItem(hero.Player);

                    if (hero.Player.Health/hero.Player.MaxHealth*100 <=
                        Menu.Item("selflowhp" + Name + "pct").GetValue<Slider>().Value)
                    {
                        if (hero.IncomeDamage > 0 || hero.MinionDamage > hero.Player.Health)
                            UseItem(hero.Player);
                    }
                }
            }
        }
    }
}
