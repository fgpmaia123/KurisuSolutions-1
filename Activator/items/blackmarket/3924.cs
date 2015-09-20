using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Items.Blackmarket
{
    class _3924 : item
    {
        internal override int Id
        {
            get { return 3924; }
        }

        internal override int Priority
        {
            get { return 3; }
        }

        internal override string Name
        {
            get { return "Flesh"; }
        }

        internal override string DisplayName
        {
            get { return "Flesheater"; }
        }

        internal override float Range
        {
            get { return 150; }
        }

        internal override int Duration
        {
            get { return 100; }
        }
        internal override MenuType[] Category
        {
            get { return new[] { MenuType.ActiveCheck }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.SummonersRift }; }
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

            foreach (var minion in ObjectManager.Get<Obj_AI_Base>().Where(x => x.IsMinion && x.IsValidTarget(300)))
            {
                if (minion.Distance(Player.ServerPosition) <= 175)
                {
                    UseItem(minion);
                }
            }
        }
    }
}
