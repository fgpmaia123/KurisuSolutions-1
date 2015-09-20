using System;
using System.Linq;
using LeagueSharp.Common;

namespace Activator.Items.Defensives
{
    class _3023 : item
    {
        internal override int Id
        {
            get { return 3023; }
        }
        internal override int Priority
        {
            get { return 4; }
        }

        internal override string Name
        {
            get { return "Shadows"; }
        }

        internal override string DisplayName
        {
            get { return "Twin Shadows"; }
        }

        internal override int Duration
        {
            get { return 100; }
        }

        internal override float Range
        {
            get { return 1600f; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.EnemyLowHP, MenuType.SelfLowHP }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.SummonersRift, MapType.HowlingAbyss }; }
        }

        internal override int DefaultHP
        {
            get { return 45; }
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

                if (hero.Player.Distance(Player.ServerPosition) <= Range)
                {
                    if (hero.Player.Health / hero.Player.MaxHealth * 100 <=
                        Menu.Item("selflowhp" + Name + "pct").GetValue<Slider>().Value)
                    {
                        if (hero.IncomeDamage > 0 && hero.Attacker != null &&
                            hero.Attacker.Distance(hero.Player.ServerPosition) <= 600)
                            UseItem();
                    }
                }
            }

            if (Tar != null)
            {
                if (Tar.Player.Health / Tar.Player.MaxHealth * 100 <= Menu.Item("enemylowhp" + Name + "pct").GetValue<Slider>().Value)
                {
                    UseItem();
                }
            }
        }
    }
}
