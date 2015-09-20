using System;
using LeagueSharp.Common;

namespace Activator.Items.Defensives
{
    class _3180 : item
    {
        internal override int Id
        {
            get { return 3180; }
        }
        internal override int Priority
        {
            get { return 4; }
        }

        internal override string Name
        {
            get { return "Odyns"; }
        }

        internal override string DisplayName
        {
            get { return "Odyn's Veil"; }
        }

        internal override int Duration
        {
            get { return 1000; }
        }

        internal override float Range
        {
            get { return 525f; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.SelfLowHP, MenuType.SelfCount }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.CrystalScar }; }
        }

        internal override int DefaultHP
        {
            get { return 35; }
        }

        internal override int DefaultMP
        {
            get { return 0; }
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            if (!Parent.Item(Parent.Name + "useon" + Player.NetworkId).GetValue<bool>())
                return;

            if (Player.Health/Player.MaxHealth*100 <= Menu.Item("selflowhp" + Name + "pct").GetValue<Slider>().Value)
            {
                UseItem();
            }

            if (Player.CountEnemiesInRange(Range) >= Menu.Item("selfcount" + Name).GetValue<Slider>().Value)
            {
                UseItem();
            }
        }
    }
}
