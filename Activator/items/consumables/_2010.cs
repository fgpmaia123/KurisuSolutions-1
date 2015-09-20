using System;
using System.Linq;
using LeagueSharp.Common;

namespace Activator.Items.Consumables
{
    class _2010 : item
    {
        internal override int Id
        {
            get { return 2010; }
        }
        internal override int Priority
        {
            get { return 3; }
        }

        internal override string Name
        {
            get { return "Total Biscuit"; }
        }

        internal override string DisplayName
        {
            get { return "Total Biscuit"; }
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
            get { return new[] { MenuType.SelfLowHP, MenuType.SelfLowMP, MenuType.SelfMuchHP }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.Common }; }
        }

        internal override int DefaultHP
        {
            get { return 45; }
        }

        internal override int DefaultMP
        {
            get { return 35; }
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            foreach (var hero in Activator.Allies())
            {
                if (hero.Player.NetworkId == Player.NetworkId)
                {
                    if (hero.Player.Health/hero.Player.MaxHealth*100 <= 15 && 
                        hero.IncomeDamage > 0)
                    {
                        if (hero.IncomeDamage > 0 || hero.MinionDamage > 0)
                        {
                            if (!hero.Player.IsRecalling() && !hero.Player.InFountain())
                                UseItem();
                        }
                    }

                    if (hero.Player.HasBuff("ItemMiniRegenPotion", true))
                        return;

                    if (hero.Player.Health/hero.Player.MaxHealth*100 <=
                        Menu.Item("selflowhp" + Name + "pct").GetValue<Slider>().Value)
                    {
                        if (hero.IncomeDamage > 0 || hero.MinionDamage > 0)
                        {
                            if (!hero.Player.IsRecalling() && !hero.Player.InFountain())
                                UseItem();
                        }
                    }

                    if (hero.Player.MaxMana <= 200)
                        continue;

                    if (hero.Player.Mana / hero.Player.MaxMana * 100 <= 
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
