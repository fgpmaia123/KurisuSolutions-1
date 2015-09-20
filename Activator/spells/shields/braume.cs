using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Spells.Shields
{
    class bruame : spell
    {
        internal override string Name
        {
            get { return "braume"; }
        }

        internal override string DisplayName
        {
            get { return "Unbreakable | E"; }
        }

        internal override float Range
        {
            get { return float.MaxValue; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.SelfMuchHP, MenuType.Zhonyas }; }
        }

        internal override int DefaultHP
        {
            get { return 95; }
        }

        internal override int DefaultMP
        {
            get { return 55; }
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            foreach (var hero in Activator.Allies())
            {                    
                if (!Parent.Item(Parent.Name + "useon" + hero.Player.ChampionName).GetValue<bool>())
                    continue;

                if (hero.Player.Distance(Player.ServerPosition) <= hero.Player.BoundingRadius)
                {
                    if (hero.IncomeDamage/hero.Player.MaxHealth*100 >=
                        Menu.Item("selfmuchhp" + Name + "pct").GetValue<Slider>().Value)
                    {
                        if (hero.Attacker != null)
                            UseSpellTowards(hero.Attacker.ServerPosition);
                    }

                    if (Menu.Item("use" + Name + "norm").GetValue<bool>())
                        if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Danger))
                            if (hero.Attacker != null)
                                UseSpellTowards(hero.Attacker.ServerPosition);

                    if (Menu.Item("use" + Name + "ulti").GetValue<bool>())
                        if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Ultimate))
                            if (hero.Attacker != null)
                                UseSpellTowards(hero.Attacker.ServerPosition);
                }
            }
        }
    }
}
