using System;
using LeagueSharp.Common;

namespace Activator.Items.Consumables
{
    class _2047 : item
    {
        internal override int Id
        {
            get { return 2047; }
        }

        internal override string Name
        {
            get { return "Oracle's Extract"; }
        }

        internal override string DisplayName
        {
            get { return "Oracle's Extract"; }
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
            get { return 600f; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.Stealth, MenuType.ActiveCheck }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.TwistedTreeline, MapType.CrystalScar, MapType.HowlingAbyss }; }
        }

        internal override int DefaultHP
        {
            get { return 0; }
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
                if (hero.Player.Distance(Player.ServerPosition) > Range)
                    continue;

                if (hero.HitTypes.Contains(HitType.Stealth) || hero.Player.HasBuff("rengarralertsound", true))
                {
                    UseItem(hero.Player.ServerPosition, Menu.Item("mode" + Name).GetValue<StringList>().SelectedIndex == 1);
                }
            }
        }
    }
}
