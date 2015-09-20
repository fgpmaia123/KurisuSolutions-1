using System;
using LeagueSharp.Common;

namespace Activator.Items.Defensives
{
    class _3364 : item
    {
        internal override int Id
        {
            get { return 3364; }
        }

        internal override int Priority
        {
            get { return 5; }
        }

        internal override string Name
        {
            get { return "Oracles"; }
        }

        internal override string DisplayName
        {
            get { return "Oracle's Lens"; }
        }

        internal override int Duration
        {
            get { return 1000; }
        }

        internal override float Range
        {
            get { return 600f; }
        }

        internal override int DefaultHP
        {
            get { return 99; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.Stealth, MenuType.ActiveCheck }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.SummonersRift }; }
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

                if (hero.HitTypes.Contains(HitType.Stealth) || hero.Player.HasBuff("rengarralertsound", true))
                {
                    UseItem(hero.Player.ServerPosition, Menu.Item("mode" + Name).GetValue<StringList>().SelectedIndex == 1);
                }
            }
        }
    }
}
