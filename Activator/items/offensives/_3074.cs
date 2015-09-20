using System;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Items.Offensives
{
    class _3074 : item
    {
        internal override int Id
        {
            get { return 3074; }
        }

        internal override int Priority
        {
            get { return 7; }
        }

        internal override string Name
        {
            get { return "Hydra"; }
        }

        internal override string DisplayName
        {
            get { return "Ravenous Hydra"; }
        }

        internal override int Duration
        {
            get { return 100; }
        }

        internal override float Range
        {
            get { return 350f; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.SelfLowHP, MenuType.EnemyLowHP }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.Common }; }
        }

        internal override int DefaultHP
        {
            get { return 95; }
        }

        internal override int DefaultMP
        {
            get { return 0; }
        }

        public _3074()
        {
            Orbwalking.AfterAttack += Orbwalking_AfterAttack;
        }

        private void Orbwalking_AfterAttack(AttackableUnit unit, AttackableUnit target)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            var hero = target as Obj_AI_Hero;
            if (hero.IsValidTarget(Range))
            {
                if (!Parent.Item(Parent.Name + "useon" + hero.ChampionName).GetValue<bool>())
                    return;

                if (hero.Health / hero.MaxHealth * 100 <= Menu.Item("enemylowhp" + Name + "pct").GetValue<Slider>().Value)
                {
                    UseItem(Tar.Player, true);
                }

                if (Player.Health / Player.MaxHealth * 100 <= Menu.Item("selflowhp" + Name + "pct").GetValue<Slider>().Value)
                {
                    UseItem(Tar.Player, true);
                }
            }
        }

        public override void OnTick(EventArgs args)
        {
            return;
        }
    }
}
