using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Summoners
{
    internal class smite : summoner
    {
        internal override string Name
        {
            get { return "summonersmite"; }
        }

        internal override string DisplayName
        {
            get { return "Smite"; }
        }

        internal override float Range
        {
            get { return 500f; }
        }

        internal override int Duration
        {
            get { return 0; }
        }

        internal static readonly string[] SmallMinions =
        {
            "SRU_Murkwolf",
            "SRU_Razorbeak",
            "SRU_Krug",
            "SRU_Gromp"
        };

        internal static readonly string[] EpicMinions =
        {
            "TT_Spiderboss8.1",
            "SRU_Baron",
            "SRU_Dragon"
        };


        internal static readonly string[] LargeMinions =
        {
            "SRU_Blue",
            "SRU_Red",
            "TT_NWraith1.1",
            "TT_NWraith4.1",
            "TT_NGolem2.1", 
            "TT_NGolem5.1",
            "TT_NWolf3.1",
            "TT_NWolf6.1" 

        };

        internal override string[] ExtraNames
        {
            get
            {
                return new[]
                {
                    "s5_summonersmiteplayerganker", "s5_summonersmiteduel",
                    "s5_summonersmitequick", "itemsmiteaoe"
                };
            }
        }

        internal static void L33TSmite(Obj_AI_Base unit, float smitedmg)
        {
            foreach (var hero in championsmite.List.Where(x => x.Name == Activator.Player.ChampionName))
            {
                if (Activator.Player.GetSpellDamage(unit, hero.Slot, hero.Stage) + smitedmg >= unit.Health)
                {
                    if (unit.Distance(Activator.Player.ServerPosition) <= hero.CastRange + 
                        unit.BoundingRadius + Activator.Player.BoundingRadius)
                    {
                        if (hero.HeroReqs(unit))
                        {
                            switch (hero.Type)
                            {
                                case SpellDataTargetType.Location:
                                    Activator.Player.Spellbook.CastSpell(hero.Slot, unit.ServerPosition);
                                    break;
                                case SpellDataTargetType.Unit:
                                    Activator.Player.Spellbook.CastSpell(hero.Slot, unit);
                                    break;
                                case SpellDataTargetType.Self:
                                    Activator.Player.Spellbook.CastSpell(hero.Slot);
                                    break;
                            }
                        }
                    }
                }
            }
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("usesmite").GetValue<KeyBind>().Active)
                return;

            foreach (var minion in MinionManager.GetMinions(900f, MinionTypes.All, MinionTeam.Neutral))
            {
                var damage = Player.Spellbook.GetSpell(Activator.Smite).State == SpellState.Ready
                    ? (float) Player.GetSummonerSpellDamage(minion, Damage.SummonerSpell.Smite)
                    : 0;

                if (minion.Distance(Player.ServerPosition) <= 500 + minion.BoundingRadius + Player.BoundingRadius)
                {
                    if (LargeMinions.Any(name => minion.Name.StartsWith(name) && !minion.Name.Contains("Mini")))
                    {
                        if (Menu.Item("smitelarge").GetValue<bool>())
                        {
                            if (Menu.Item("smiteskill").GetValue<bool>())
                                L33TSmite(minion, damage);

                            if (damage >= minion.Health && IsReady())
                            {
                                Player.Spellbook.CastSpell(Activator.Smite, minion);
                            }
                        }
                    }

                    if (SmallMinions.Any(name => minion.Name.StartsWith(name) && !minion.Name.Contains("Mini")))
                    {
                        if (Menu.Item("smitesmall").GetValue<bool>())
                        {
                            if (Menu.Item("smiteskill").GetValue<bool>())
                                L33TSmite(minion, damage);

                            if (damage >= minion.Health && IsReady())
                            {
                                Player.Spellbook.CastSpell(Activator.Smite, minion);
                            }
                        }
                    }

                    if (EpicMinions.Any(name => minion.Name.StartsWith(name)))
                    {
                        if (Menu.Item("smitesuper").GetValue<bool>())
                        {
                            if (Menu.Item("smiteskill").GetValue<bool>())
                                L33TSmite(minion, damage);

                            if (damage >= minion.Health && IsReady())
                            {
                                Player.Spellbook.CastSpell(Activator.Smite, minion);
                            }
                        }
                    }
                }
            }

            // smite hero blu/red
            if (Player.GetSpell(Activator.Smite).Name.ToLower() == "s5_summonersmiteduel" ||
                Player.GetSpell(Activator.Smite).Name.ToLower() == "s5_summonersmiteplayerganker")
            {
                if (!Menu.Item("savesmite").GetValue<bool>() ||
                     Menu.Item("savesmite").GetValue<bool>() && Player.GetSpell(Activator.Smite).Ammo > 1)
                {
                    // KS Smite
                    if (Menu.Item("smitemode").GetValue<StringList>().SelectedIndex == 0 &&
                        Player.GetSpell(Activator.Smite).Name.ToLower() == "s5_summonersmiteplayerganker")
                    {
                        foreach (
                            var hero in
                                Activator.Heroes.Where(
                                    h =>
                                        h.Player.IsValidTarget(500) && !h.Player.IsZombie &&
                                        h.Player.Health <= 20 + 8 * Player.Level))
                        {
                            Player.Spellbook.CastSpell(Activator.Smite, hero.Player);
                        }
                    }

                    // Combo Smite
                    if (Menu.Item("smitemode").GetValue<StringList>().SelectedIndex == 1 ||
                        Player.GetSpell(Activator.Smite).Name.ToLower() == "s5_summonersmiteduel")
                    {
                        if (Activator.Origin.Item("usecombo").GetValue<KeyBind>().Active)
                        {
                            foreach (
                                var hero in
                                    Activator.Heroes
                                        .Where(h => h.Player.IsValidTarget(1200) && !h.Player.IsZombie)
                                        .OrderBy(h => h.Player.Distance(Game.CursorPos)))
                            {
                                if (hero.Player.Distance(Player.ServerPosition) <= 500)
                                    Player.Spellbook.CastSpell(Activator.Smite, hero.Player);
                            }
                        }
                    }
                }
            }
        }
    }
}
