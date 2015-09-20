using System;
using System.Linq;
using LeagueSharp.Common;

namespace Activator.Spells.Shields
{
    class fioraw : spell
    {
        internal override string Name
        {
            get { return "fioraw"; }
        }

        internal override string DisplayName
        {
            get { return "Riposte | W"; }
        }

        internal override float Range
        {
            get { return float.MaxValue; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.SelfMuchHP, MenuType.Zhonyas, MenuType.SpellShield }; }
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
                    if (hero.IncomeDamage >= hero.Player.Health && hero.Attacker != null)
                        UseSpellTowards(hero.Attacker.ServerPosition);

                    if (hero.IncomeDamage / hero.Player.MaxHealth * 100 >=
                        Menu.Item("selfmuchhp" + Name + "pct").GetValue<Slider>().Value && hero.Attacker != null)
                        UseSpellTowards(hero.Attacker.ServerPosition);

                    if (Menu.Item("ss" + Name + "all").GetValue<bool>())
                        if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Spell) && hero.Attacker != null)
                            UseSpellTowards(hero.Attacker.ServerPosition);

                    if (Menu.Item("ss" + Name + "cc").GetValue<bool>())
                        if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.CrowdControl) && hero.Attacker != null)
                            UseSpellTowards(hero.Attacker.ServerPosition);

                    if (Menu.Item("use" + Name + "norm").GetValue<bool>())
                        if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Danger) && hero.Attacker != null)
                                UseSpellTowards(hero.Attacker.ServerPosition);

                    if (Menu.Item("use" + Name + "ulti").GetValue<bool>())
                        if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Ultimate) && hero.Attacker != null)
                                UseSpellTowards(hero.Attacker.ServerPosition);
                }
            }
        }
    }
}
