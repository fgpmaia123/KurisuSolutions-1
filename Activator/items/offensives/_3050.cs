using System;
using System.Linq;
using LeagueSharp.Common;

namespace Activator.Items.Offensives
{
    class _3050 : item
    {
        internal override int Id
        {
            get { return 3050; }
        }

        internal override string Name
        {
            get { return "Zekes"; }
        }

        internal override string DisplayName
        {
            get { return "Zeke's Harbringer"; }
        }

        internal override int Duration
        {
            get { return 100; }
        }

        internal override int Priority
        {
            get { return 5; }
        }

        internal override float Range
        {
            get { return 1000f; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.ActiveCheck }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.Common }; }
        }

        internal override int DefaultHP
        {
            get { return 99; }
        }

        internal override int DefaultMP
        {
            get { return 99; }
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            var highadhero =
                Activator.Heroes.Where(x => x.Player.IsAlly && !x.Player.IsDead)
                    .OrderByDescending(x => x.Player.FlatPhysicalDamageMod + x.Player.BaseAttackDamage)
                    .FirstOrDefault();

            if (!highadhero.Player.IsMe && highadhero.Player.Distance(Player.ServerPosition) <= Range)
            {
                if (!highadhero.Player.HasBuff("rallyingbanneraurafriend", true))
                {
                    UseItem(highadhero.Player, Menu.Item("mode" + Name).GetValue<StringList>().SelectedIndex == 1);
                }
            }
        }
    }
}
