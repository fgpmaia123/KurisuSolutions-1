using System;
using System.Linq;
using LeagueSharp.Common;

namespace Activator.Items.Consumables
{
    internal class _2004 : item
    {
        internal override int Id
        {
            get { return 2004; }
        }
        internal override int Priority
        {
            get { return 3; }
        }

        internal override string Name
        {
            get { return "Mana Potion"; }
        }

        internal override string DisplayName
        {
            get { return "Mana Potion"; }
        }

        internal override int Duration
        {
            get { return 100; }
        }

        internal override float Range
        {
            get { return float.MaxValue; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.SelfLowMP }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.Common }; }
        }

        internal override int DefaultHP
        {
            get { return 0; }
        }

        internal override int DefaultMP
        {
            get { return 40; }
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            foreach (var hero in Activator.Allies())
            {
                if (hero.Player.NetworkId == Player.NetworkId)
                {
                    if (hero.Player.MaxMana <= 200)
                        continue;

                    if (hero.Player.HasBuff("FlaskOfCrystalWater", true) || hero.Player.HasBuff("ItemCrystalFlask", true))
                        return;

                    if (hero.Player.Mana/hero.Player.MaxMana*100 <= 
                        Menu.Item("selflowmp" + Name + "pct").GetValue<Slider>().Value)
                    {
                        if (!hero.Player.IsRecalling() && !hero.Player.InFountain())
                            UseItem();
                    }
                }
            }
        }
    }
}
