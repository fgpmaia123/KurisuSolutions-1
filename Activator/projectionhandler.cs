#region Copyright © 2015 Kurisu Solutions
// All rights are reserved. Transmission or reproduction in part or whole,
// any form or by any means, mechanical, electronical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Document:	activator/projectionhandler.cs
// Date:		01/07/2015
// Author:		Robin Kurisu
#endregion

using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator
{
    public class projectionhandler
    {
        public static Obj_AI_Hero Target;
        public static int Casted;

        public static void init()
        {
            GameObject.OnCreate += GameObject_OnCreate;
            Obj_AI_Base.OnProcessSpellCast += Obj_AI_Base_OnProcessSpellCast; 
        }

        private static void GameObject_OnCreate(GameObject sender, EventArgs args)
        {
            var missile = sender as MissileClient;
            if (missile == null || !missile.IsValid)
                return;

            var caster = missile.SpellCaster as Obj_AI_Hero;
            if (caster == null || !caster.IsValid)
                return;

            if (caster.Team == Activator.Player.Team)
                return;

            var startPos = missile.StartPosition.To2D();
            var endPos = missile.EndPosition.To2D();

            var data = spelldata.GetByMissileName(missile.SData.Name.ToLower());
            if (data == null)
                return;

            var direction = (endPos - startPos).Normalized();
            if (startPos.Distance(endPos) > data.CastRange)
                endPos = startPos + direction * data.CastRange;

            #region FoW Detection
            foreach (var hero in Activator.Allies())
            {
                if (!hero.Player.IsValidTarget(float.MaxValue, false)  || hero.Player.IsZombie || hero.Immunity)
                {
                    hero.Attacker = null;
                    hero.IncomeDamage = 0;
                    hero.HitTypes.Clear();
                    continue;
                }

                if (hero.IncomeDamage < 12)
                    hero.IncomeDamage = 0;

                var distance = (1000 * (startPos.Distance(hero.Player.ServerPosition) / data.MissileSpeed));
                var endtime = - 100 + Game.Ping/2 + distance;

                // setup projection
                var proj = hero.Player.ServerPosition.To2D().ProjectOn(startPos, endPos);
                var projdist = hero.Player.ServerPosition.To2D().Distance(proj.SegmentPoint);

                // get the evade time 
                var evadetime = (int) (1000 * (missile.SData.LineWidth - projdist + hero.Player.BoundingRadius) /
                                       hero.Player.MoveSpeed);

                // check if hero on segment
                if (missile.SData.LineWidth + hero.Player.BoundingRadius <= projdist) 
                    continue;

                if (data.Global || Activator.Origin.Item("evade").GetValue<bool>())
                {
                    // ignore if can evade
                    if (hero.Player.NetworkId == Activator.Player.NetworkId)
                    {
                        if (hero.Player.CanMove && evadetime < endtime)
                        {
                            // check next player
                            continue;
                        }
                    }
                }

                if (!Activator.Origin.Item(data.SDataName + "predict").GetValue<bool>())
                    continue;

                hero.Attacker = caster;
                hero.HitTypes.Add(HitType.Spell);
                hero.IncomeDamage += 1;

                if (Activator.Origin.Item(data.SDataName + "danger").GetValue<bool>())
                    hero.HitTypes.Add(HitType.Danger);
                if (Activator.Origin.Item(data.SDataName + "crowdcontrol").GetValue<bool>())
                    hero.HitTypes.Add(HitType.CrowdControl);
                if (Activator.Origin.Item(data.SDataName + "ultimate").GetValue<bool>())
                    hero.HitTypes.Add(HitType.Ultimate);
                if (Activator.Origin.Item(data.SDataName + "forceexhaust").GetValue<bool>())
                    hero.HitTypes.Add(HitType.ForceExhaust);
                
                Utility.DelayAction.Add((int) endtime + 350, () =>
                {
                    if (hero.IncomeDamage > 0)
                        hero.IncomeDamage -= 1;

                    hero.HitTypes.Remove(HitType.Spell);

                    if (Activator.Origin.Item(data.SDataName + "danger").GetValue<bool>())
                        hero.HitTypes.Remove(HitType.Danger);
                    if (Activator.Origin.Item(data.SDataName + "crowdcontrol").GetValue<bool>())
                        hero.HitTypes.Remove(HitType.CrowdControl);
                    if (Activator.Origin.Item(data.SDataName + "ultimate").GetValue<bool>())
                        hero.HitTypes.Remove(HitType.Ultimate);
                    if (Activator.Origin.Item(data.SDataName + "forceexhaust").GetValue<bool>())
                        hero.HitTypes.Remove(HitType.ForceExhaust);
                });
            }

            #endregion
        }


        private static void Obj_AI_Base_OnProcessSpellCast(Obj_AI_Base sender, GameObjectProcessSpellCastEventArgs args)
        {
            #region Hero Detection

            if (sender.IsEnemy && sender.Type == GameObjectType.obj_AI_Hero)
            {
                Casted = Utils.GameTimeTickCount;
                foreach (var hero in Activator.Allies())
                {
                    if (!hero.Player.IsValidTarget(float.MaxValue, false) || hero.Player.IsZombie || hero.Immunity)
                    {
                        hero.Attacker = null;
                        hero.IncomeDamage = 0;
                        hero.HitTypes.Clear();
                        continue;
                    }

                    #region auto attack dectection

                    if (args.SData.IsAutoAttack())
                    {
                        if (args.Target.NetworkId == hero.Player.NetworkId)
                        {
                            float dmg = 0;

                            var enemy = sender as Obj_AI_Hero;
                            if (enemy != null)
                            {
                                if (!sender.HasBuff("lichbane") && !sender.HasBuff("sheen"))
                                    dmg = (int) Math.Abs(sender.GetAutoAttackDamage(hero.Player, true));

                                if (sender.HasBuff("sheen"))
                                    dmg = (int) Math.Abs(sender.GetAutoAttackDamage(hero.Player, true) +
                                                         enemy.GetCustomDamage("sheen", hero.Player));

                                if (sender.HasBuff("lichbane"))
                                    dmg = (int) Math.Abs(sender.GetAutoAttackDamage(hero.Player, true) +
                                                         enemy.GetCustomDamage("lichbane", hero.Player));
                            }

                            Utility.DelayAction.Add(250, () =>
                            {
                                hero.Attacker = sender;
                                hero.HitTypes.Add(HitType.AutoAttack);
                                hero.IncomeDamage += dmg;

                                Utility.DelayAction.Add(800, delegate
                                {
                                    hero.Attacker = null;
                                    hero.IncomeDamage -= dmg;
                                    hero.HitTypes.Remove(HitType.AutoAttack);
                                });
                            });
                        }
                    }

                    #endregion

                    foreach (var data in spelldata.spells.Where(x => x.SDataName == args.SData.Name.ToLower()))
                    {
                        #region self/selfaoe spell detection

                        if (args.SData.TargettingType == SpellDataTargetType.Self ||
                            args.SData.TargettingType == SpellDataTargetType.SelfAoe)
                        {
                            var fromObj =
                                ObjectManager.Get<GameObject>()
                                    .FirstOrDefault(
                                        x => data.FromObject != null && !x.IsAlly && data.FromObject.Any(y => x.Name.Contains(y)));

                            var correctpos = fromObj != null ? fromObj.Position : sender.ServerPosition;

                            if (hero.Player.Distance(correctpos) > data.CastRange)
                                continue;

                            if (data.SDataName == "kalistaexpungewrapper" && 
                                !hero.Player.HasBuff("kalistaexpungemarker", true))
                                continue;

                            var evadetime = 1000 * (data.CastRange - hero.Player.Distance(correctpos) +
                                                                     hero.Player.BoundingRadius) / hero.Player.MoveSpeed;

                            if (Activator.Origin.Item("evade").GetValue<bool>())
                            {
                                // ignore if can evade
                                if (hero.Player.NetworkId == Activator.Player.NetworkId)
                                {
                                    if (hero.Player.CanMove && evadetime < data.Delay)
                                    {
                                        // check next player
                                        continue;
                                    }
                                }
                            }

                            if (!Activator.Origin.Item(data.SDataName + "predict").GetValue<bool>())
                                continue;

                            var dmg = (int) Math.Abs(sender.GetSpellDamage(hero.Player, args.SData.Name));

                            // delay the spell a bit before missile endtime
                            Utility.DelayAction.Add((int) (data.Delay - (data.Delay * 0.7)), () =>
                            {
                                hero.Attacker = sender;
                                hero.HitTypes.Add(HitType.Spell);
                                hero.IncomeDamage += dmg;
      
                                if (Activator.Origin.Item(data.SDataName + "danger").GetValue<bool>())
                                    hero.HitTypes.Add(HitType.Danger);                     
                                if (Activator.Origin.Item(data.SDataName + "crowdcontrol").GetValue<bool>())
                                    hero.HitTypes.Add(HitType.CrowdControl);
                                if (Activator.Origin.Item(data.SDataName + "ultimate").GetValue<bool>())
                                    hero.HitTypes.Add(HitType.Ultimate);
                                if (Activator.Origin.Item(data.SDataName + "forceexhaust").GetValue<bool>())
                                    hero.HitTypes.Add(HitType.ForceExhaust);

                                // lazy safe reset
                                Utility.DelayAction.Add((int) (data.Delay + 500), () =>
                                {
                                    hero.Attacker = null;
                                    hero.IncomeDamage -= dmg;
                                    hero.HitTypes.Remove(HitType.Spell);

                                    if (Activator.Origin.Item(data.SDataName + "danger").GetValue<bool>())
                                        hero.HitTypes.Remove(HitType.Danger);
                                    if (Activator.Origin.Item(data.SDataName + "crowdcontrol").GetValue<bool>())
                                        hero.HitTypes.Remove(HitType.CrowdControl);
                                    if (Activator.Origin.Item(data.SDataName + "ultimate").GetValue<bool>())
                                        hero.HitTypes.Remove(HitType.Ultimate);
                                    if (Activator.Origin.Item(data.SDataName + "forceexhaust").GetValue<bool>())
                                        hero.HitTypes.Remove(HitType.ForceExhaust);
                                });
                            });                           
                        }

                        #endregion

                        #region skillshot detection completerino

                        if (args.SData.TargettingType == SpellDataTargetType.Cone || 
                            args.SData.TargettingType.ToString().Contains("Location") ||
                            args.SData.TargettingType ==  (SpellDataTargetType) 10 && data.SDataName == "azirq")
                        {
                            var fromObj =
                                ObjectManager.Get<GameObject>()
                                    .FirstOrDefault(
                                        x =>
                                            !x.IsAlly && data.FromObject != null &&
                                            data.FromObject.Any(y => x.Name.Contains(y)));

                            var islineskillshot = args.SData.TargettingType == SpellDataTargetType.Cone || args.SData.LineWidth != 0;
                            var startpos = fromObj != null ? fromObj.Position : sender.ServerPosition;

                            var correctwidth = islineskillshot && args.SData.TargettingType != SpellDataTargetType.Cone
                                ? args.SData.LineWidth: (args.SData.CastRadius == 0 ? args.SData.CastRadiusSecondary : args.SData.CastRadius);

                            if (data.SDataName == "azirq")
                            {
                                correctwidth = 275f;
                                islineskillshot = true;
                            }

                            if (hero.Player.Distance(startpos) > data.CastRange)
                                continue;

                            var distance = (int)(1000 * (startpos.Distance(hero.Player.ServerPosition) / data.MissileSpeed));
                            var endtime = data.Delay - 100 + Game.Ping/2 + distance - (Utils.GameTimeTickCount - Casted);

                            var direction = (args.End.To2D() - startpos.To2D()).Normalized();
                            var endpos = startpos.To2D() + direction * startpos.To2D().Distance(args.End.To2D());

                            if (startpos.To2D().Distance(endpos) > data.CastRange)
                                endpos = startpos.To2D() + direction * data.CastRange;

                            var proj = hero.Player.ServerPosition.To2D().ProjectOn(startpos.To2D(), endpos);
                            var projdist = hero.Player.ServerPosition.To2D().Distance(proj.SegmentPoint);            
                            int evadetime;

                            if (islineskillshot)
                                evadetime = (int) (1000 * (correctwidth - projdist + hero.Player.BoundingRadius) /
                                                   hero.Player.MoveSpeed);
                            else
                                evadetime = (int)(1000 *(correctwidth - hero.Player.Distance(startpos) + hero.Player.BoundingRadius) /
                                                  hero.Player.MoveSpeed);

                            if (!islineskillshot && hero.Player.Distance(endpos) <= correctwidth ||
                                 islineskillshot && correctwidth + hero.Player.BoundingRadius > projdist)
                            {
                                if (data.Global || Activator.Origin.Item("evade").GetValue<bool>())
                                {
                                    if (hero.Player.NetworkId == Activator.Player.NetworkId)
                                    {
                                        if (hero.Player.CanMove && evadetime < endtime)
                                        {
                                            continue;
                                        }
                                    }
                                }

                                if (!Activator.Origin.Item(data.SDataName + "predict").GetValue<bool>())
                                    continue;

                                var dmg = (int) Math.Abs(sender.GetSpellDamage(hero.Player, args.SData.Name));
                          
                                Utility.DelayAction.Add((int) (endtime - (endtime * 0.7)), () =>
                                {
                                    hero.Attacker = sender;
                                    hero.HitTypes.Add(HitType.Spell);
                                    hero.IncomeDamage += dmg;

                                    if (Activator.Origin.Item(data.SDataName + "danger").GetValue<bool>())
                                        hero.HitTypes.Add(HitType.Danger);
                                    if (Activator.Origin.Item(data.SDataName + "crowdcontrol").GetValue<bool>())
                                        hero.HitTypes.Add(HitType.CrowdControl);
                                    if (Activator.Origin.Item(data.SDataName + "ultimate").GetValue<bool>())
                                        hero.HitTypes.Add(HitType.Ultimate);
                                    if (Activator.Origin.Item(data.SDataName + "forceexhaust").GetValue<bool>())
                                        hero.HitTypes.Add(HitType.ForceExhaust);

                                    Utility.DelayAction.Add((int) (endtime + 500), () =>
                                    {
                                        hero.Attacker = null;
                                        hero.IncomeDamage -= dmg;
                                        hero.HitTypes.Remove(HitType.Spell);

                                        if (Activator.Origin.Item(data.SDataName + "danger").GetValue<bool>())
                                            hero.HitTypes.Remove(HitType.Danger);
                                        if (Activator.Origin.Item(data.SDataName + "crowdcontrol").GetValue<bool>())
                                            hero.HitTypes.Remove(HitType.CrowdControl);
                                        if (Activator.Origin.Item(data.SDataName + "ultimate").GetValue<bool>())
                                            hero.HitTypes.Remove(HitType.Ultimate);
                                        if (Activator.Origin.Item(data.SDataName + "forceexhaust").GetValue<bool>())
                                            hero.HitTypes.Remove(HitType.ForceExhaust);
                                    });
                                });                               
                            }                           
                        }

                        #endregion

                        #region unit type detection

                        if (args.SData.TargettingType == SpellDataTargetType.Unit ||
                            args.SData.TargettingType == SpellDataTargetType.SelfAndUnit)
                        {
                            if (args.Target == null)
                                continue;

                            // check if is targeteting the hero on our table
                            if (hero.Player.NetworkId != args.Target.NetworkId) 
                                continue;

                            // target spell dectection
                            if (hero.Player.Distance(sender.ServerPosition) > data.CastRange)
                                continue;

                            var distance = (int) (1000 * (sender.Distance(hero.Player.ServerPosition) / data.MissileSpeed));
                            var endtime = data.Delay - 100 + Game.Ping / 2 + distance - (Utils.GameTimeTickCount - Casted);

                            if (!Activator.Origin.Item(data.SDataName + "predict").GetValue<bool>())
                                continue;

                            var dmg = (int)Math.Abs(sender.GetSpellDamage(hero.Player, args.SData.Name));

                            Utility.DelayAction.Add((int)(endtime - (endtime * 0.7)), () =>
                            {
                                hero.Attacker = sender;
                                hero.HitTypes.Add(HitType.Spell);
                                hero.IncomeDamage += dmg;

                                //if (data.ChampionName == "annie" && spelldebuffhandler.Pyromania)
                                //{
                                //    hero.HitTypes.Add(HitType.CrowdControl);
                                //    spelldebuffhandler.Pyromania = false;
                                //}

                                if (Activator.Origin.Item(data.SDataName + "danger").GetValue<bool>())
                                    hero.HitTypes.Add(HitType.Danger);
                                if (Activator.Origin.Item(data.SDataName + "crowdcontrol").GetValue<bool>())
                                    hero.HitTypes.Add(HitType.CrowdControl);
                                if (Activator.Origin.Item(data.SDataName + "ultimate").GetValue<bool>())
                                    hero.HitTypes.Add(HitType.Ultimate);
                                if (Activator.Origin.Item(data.SDataName + "forceexhaust").GetValue<bool>())
                                    hero.HitTypes.Add(HitType.ForceExhaust);

                                // lazy reset
                                Utility.DelayAction.Add((int)(endtime + 500), () =>
                                {
                                    hero.Attacker = null;
                                    hero.IncomeDamage -= dmg;
                                    hero.HitTypes.Remove(HitType.Spell);

                                    if (Activator.Origin.Item(data.SDataName + "danger").GetValue<bool>())
                                        hero.HitTypes.Remove(HitType.Danger);
                                    if (Activator.Origin.Item(data.SDataName + "crowdcontrol").GetValue<bool>())
                                        hero.HitTypes.Remove(HitType.CrowdControl);
                                    if (Activator.Origin.Item(data.SDataName + "ultimate").GetValue<bool>())
                                        hero.HitTypes.Remove(HitType.Ultimate);
                                    if (Activator.Origin.Item(data.SDataName + "forceexhaust").GetValue<bool>())
                                        hero.HitTypes.Remove(HitType.ForceExhaust);
                                });
                            });                          
                        }
                        #endregion

                    }
                }

            }

            #endregion

            #region Turret Detection

            if (sender.IsEnemy && sender.Type == GameObjectType.obj_AI_Turret)
            {
                foreach (var hero in Activator.Allies())
                {
                    if (args.Target.NetworkId == hero.Player.NetworkId && !hero.Immunity)
                    {
                        var dmg = (int) Math.Abs(sender.CalcDamage(hero.Player, Damage.DamageType.Physical,
                            sender.BaseAttackDamage + sender.FlatPhysicalDamageMod));

                        if (sender.Distance(hero.Player.ServerPosition) <= 900)
                        {
                            if (Activator.Player.Distance(hero.Player.ServerPosition) <= 1000)
                            {
                                Utility.DelayAction.Add(450, () =>
                                {
                                    hero.HitTypes.Add(HitType.TurretAttack);
                                    hero.IncomeDamage += dmg;

                                    Utility.DelayAction.Add(650, () =>
                                    {
                                        hero.Attacker = null;
                                        hero.IncomeDamage -= dmg;
                                        hero.HitTypes.Remove(HitType.TurretAttack);
                                    });
                                });
                            }
                        }
                    }
                }
            }

            #endregion

            #region Minion Detection

            if (sender.IsEnemy && sender.Type == GameObjectType.obj_AI_Minion)
            {
                foreach (var hero in Activator.Allies())
                {
                    if (hero.Player.NetworkId != args.Target.NetworkId || hero.Immunity) 
                        continue;

                    if (hero.Player.Distance(sender.ServerPosition) <= 750)
                    {
                        if (Activator.Player.Distance(hero.Player.ServerPosition) <= 1000)
                        {
                            hero.HitTypes.Add(HitType.MinionAttack);
                            hero.MinionDamage =
                                (int) Math.Abs(sender.CalcDamage(hero.Player, Damage.DamageType.Physical,
                                    sender.BaseAttackDamage + sender.FlatPhysicalDamageMod));

                            Utility.DelayAction.Add(500, () =>
                            {
                                hero.HitTypes.Remove(HitType.MinionAttack);
                                hero.MinionDamage = 0;
                            });
                        }
                    }
                }
            }

            #endregion

            #region Gangplank Barell
            if (sender.IsEnemy)
            {
                var enemy = sender as Obj_AI_Hero;
                if (enemy.IsValid<Obj_AI_Hero>() && enemy.ChampionName == "Gangplank")
                {
                    foreach (var hero in Activator.Allies())
                    {
                        foreach (var b in ObjectManager.Get<GameObject>()
                                .Where(x => x.Name.Contains("E_AoE") && x.Position.Distance(x.Position) <= 400 && !x.IsAlly)
                                .OrderBy(y => y.Position.Distance(hero.Player.ServerPosition)))
                        {
                            if (hero.Player.Distance(b.Position) > 400 || args.Target.Name != "Barrel")
                            {
                                continue;
                            }

                            var dmg = (int)Math.Abs(enemy.GetAutoAttackDamage(hero.Player, true) * 1.6 + 200);

                            if (args.SData.Name.ToLower() == "gangplankcritattack")
                            {
                                dmg = dmg * 2;
                            }

                            if (!hero.Player.IsValidTarget(float.MaxValue, false) || hero.Player.IsZombie || hero.Immunity)
                            {
                                hero.Attacker = null;
                                hero.IncomeDamage = 0;
                                hero.HitTypes.Clear();
                                continue;
                            }

                            if (hero.IncomeDamage < 12)
                                hero.IncomeDamage = 0;

                            Utility.DelayAction.Add(250, () =>
                            {
                                hero.Attacker = enemy;
                                hero.HitTypes.Add(HitType.Spell);
                                hero.IncomeDamage += dmg;

                                Utility.DelayAction.Add(800, delegate
                                {
                                    hero.Attacker = null;
                                    hero.HitTypes.Remove(HitType.Spell);
                                    hero.IncomeDamage -= dmg;
                                });
                            });
                        }
                    }
                }
            }

            #endregion
        }
    }
}
