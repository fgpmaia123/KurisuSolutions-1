using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Summoners
{
    internal class exhuast : summoner
    {
        internal override string Name
        {
            get { return "summonerexhaust"; }
        }

        internal override string DisplayName
        {
            get { return "Exhaust"; }
        }
        internal override string[] ExtraNames
        {
            get { return new[] { "" }; }
        }

        internal override float Range
        {
            get { return 650f; }
        }

        internal override int Duration
        {
            get { return 100; }
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            var hid = Activator.Heroes
                    .OrderByDescending(h => h.Player.FlatPhysicalDamageMod)
                    .FirstOrDefault(h => h.Player.IsValidTarget(Range + 250));

            foreach (var hero in Activator.Allies())
            {
                var enemy = hero.Attacker as Obj_AI_Hero;
                if (enemy == null || hid == null) 
                    continue;

                if (enemy.Distance(hero.Player.ServerPosition) > Range) 
                    continue;

                if (hero.HitTypes.Contains(HitType.ForceExhaust))
                {
                    UseSpellOn(enemy);
                }

                if (!Parent.Item(Parent.Name + "useon" + enemy.ChampionName).GetValue<bool>())
                    continue;
 
                if (Menu.Item("use" + Name + "ulti").GetValue<bool>())
                {
                    if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Ultimate))
                    {
                        if (hero.IncomeDamage / hero.Player.MaxHealth * 100 >= 45 ||
                            hero.Player.Health / hero.Player.MaxHealth * 100 <= 35 ||
                            hero.IncomeDamage >= hero.Player.Health)
                        {
                            UseSpellOn(enemy);            
                        }
                    }
                }

                if (hero.Player.Health/hero.Player.MaxHealth*100 <= Menu.Item("a" + Name + "pct").GetValue<Slider>().Value)
                {
                    if (!hero.Player.IsFacing(enemy))
                    {
                        if (enemy.NetworkId == hid.Player.NetworkId)
                        {
                            UseSpellOn(enemy);
                        }
                    }
                }

                if (enemy.Health / enemy.MaxHealth * 100 <= Menu.Item("e" + Name + "pct").GetValue<Slider>().Value)
                {
                    if (!enemy.IsFacing(hero.Player))
                    {
                        UseSpellOn(enemy);
                    }       
                }
            }
        }
    }
}
