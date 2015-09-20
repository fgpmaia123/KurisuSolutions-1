using System;
using System.Linq;
using LeagueSharp.Common;
using LeagueSharp;
using SharpDX;

namespace KurisuGraves
{                           
    // _____                     
    //|   __|___ ___ _ _ ___ ___ 
    //|  |  |  _| .'| | | -_|_ -|
    //|_____|_| |__,|\_/|___|___|
    // Copyright © Kurisu Solutions 2015
    internal class Program
    {
        internal static Menu MainMenu;
        internal static Obj_AI_Hero Target;
        internal static Orbwalking.Orbwalker Orbwalker;
        internal static readonly Obj_AI_Hero Me = ObjectManager.Player;
        internal static HpBarIndicator HPi = new HpBarIndicator();
        internal static int LE, LR, LM;

        static void Main(string[] args)
        {
            // Console.WriteLine("KurisuGraves injected..");
            CustomEvents.Game.OnGameLoad += Game_OnLoad;
        }

        internal static readonly Spell Buckshot = new Spell(SpellSlot.Q, 950f);
        internal static readonly Spell Smokescreen = new Spell(SpellSlot.W, 850f);
        internal static readonly Spell Quickdraw = new Spell(SpellSlot.E, 425f);
        internal static readonly Spell Chargeshot = new Spell(SpellSlot.R, 1000f);

        internal static void Game_OnLoad(EventArgs args)
        {
            try
            {
                // validate
                if (Me.ChampionName != "Graves")
                    return;

                // load menu
                Menu_OnLoad();

                // spell setup
                Chargeshot.SetSkillshot(
                    0.25f, 100f, 2100f, false, SkillshotType.SkillshotLine);
                Smokescreen.SetSkillshot(
                    0.25f, 250f, 1650f, false, SkillshotType.SkillshotCircle);
                Buckshot.SetSkillshot(
                    0.25f, (float) (15 * Math.PI / 180), 2000f, false, SkillshotType.SkillshotCone);

                // On Tick Event
                Game.OnUpdate += GravesOnUpdate;

                // On Draw Event
                Drawing.OnDraw += GravesOnDraw;
                Drawing.OnEndScene += GravesOnEndScene;

                // Anti-Gapclose Event
                AntiGapcloser.OnEnemyGapcloser += GravesReverseGapclose;

                // After Attack Event
                Orbwalking.AfterAttack += GravesAfterAttack;

                // On Spell Cast Event
                Obj_AI_Base.OnProcessSpellCast += GravesOnCast;
            }

            catch (Exception e)
            {
                Console.WriteLine("Fatal Error: " + e);
            }
        }

        internal static void GravesOnUpdate(EventArgs args)
        {
            Target = TargetSelector.GetTarget(Chargeshot.Range, TargetSelector.DamageType.Physical);

            if (Orbwalker.ActiveMode == Orbwalking.OrbwalkingMode.Combo)
                GravesCombo();

            if (MainMenu.Item("autosmoke").GetValue<bool>() && Smokescreen.IsReady())
                foreach (var hero in HeroManager.Enemies.Where(x => x.IsValidTarget(Smokescreen.Range)))
                    Smokescreen.CastIfHitchanceEquals(hero, HitChance.Immobile);

            if (MainMenu.Item("fleekey").GetValue<KeyBind>().Active)
            {
                if (Utils.GameTimeTickCount - LM >= 100)
                {
                    Me.IssueOrder(GameObjectOrder.MoveTo, Game.CursorPos);
                    LM = Utils.GameTimeTickCount;
                }

                if (Smokescreen.IsReady() && Target.IsValidTarget(Smokescreen.Range))
                    Smokescreen.CastIfHitchanceEquals(Target, HitChance.Medium);

                else if (Quickdraw.IsReady())
                {
                    if (Utils.GameTimeTickCount - LE > 500)
                        Quickdraw.Cast(Game.CursorPos);
                }
            }

            if (MainMenu.Item("allin").GetValue<KeyBind>().Active)
            {
                if (!Me.Spellbook.IsCastingSpell)
                     Orbwalking.Orbwalk(Target, Game.CursorPos);

                if (Target.IsValidTarget(Chargeshot.Range))
                {
                    var rpred = Prediction.GetPrediction(Target, 0.25f).UnitPosition;
                    if (rpred.Distance(Me.ServerPosition) <= Quickdraw.Range + 200)
                    {
                        if (Chargeshot.IsReady() && Quickdraw.IsReady() && Buckshot.IsReady())
                        {
                            Chargeshot.CastIfHitchanceEquals(Target, HitChance.High);
                        }
                    }
                }
            }

            if (Target.IsValidTarget() && Chargeshot.IsReady())
            {
                foreach (var hero in HeroManager.Enemies.Where(x => x.IsValidTarget(Chargeshot.Range)))
                {
                    if (GetRDamage(hero) >= hero.Health && MainMenu.Item("secure").GetValue<bool>())
                    {
                        var pred = Prediction.GetPrediction(hero, 0.25f).UnitPosition;
                        if (pred.Distance(Me.ServerPosition) <= Me.AttackRange)
                        {
                            if (Me.GetAutoAttackDamage(hero, true) * 2 >= hero.Health)
                                return;
                        }

                        Chargeshot.CastIfHitchanceEquals(hero, HitChance.High);
                    }
                }

                if (MainMenu.Item("shootr").GetValue<KeyBind>().Active)
                    Chargeshot.CastIfHitchanceEquals(Target, HitChance.VeryHigh);

                if (MainMenu.Item("usercombo").GetValue<bool>())
                {
                    if (Proj1(Target.ServerPosition, Chargeshot.Width, Chargeshot.Range) >=
                        MainMenu.Item("rmulti").GetValue<Slider>().Value)
                    {
                        if (Orbwalker.ActiveMode == Orbwalking.OrbwalkingMode.Combo)
                        {
                            if (Target.CountAlliesInRange(650) >= 2)
                                Chargeshot.CastIfHitchanceEquals(Target, HitChance.Medium);
                        }
                    }
                }
            }
        }

        #region Anti-Gapclose
        static void GravesReverseGapclose(ActiveGapcloser gapcloser)
        {
            var attacker = gapcloser.Sender;
            if (attacker.IsValidTarget())
            {
                if (Buckshot.IsReady() && attacker.Distance(Me.ServerPosition) <= 475)
                    Buckshot.Cast(attacker);

                if (Smokescreen.IsReady() && MainMenu.Item("usewongap").GetValue<bool>())
                {
                    if (attacker.Distance(Me.ServerPosition) < 420 &&
                        attacker.Distance(Me.ServerPosition) > 300)
                    {
                        Smokescreen.Cast(attacker);
                    }
                }
            }      
        }

        #endregion

        #region After Attack
        static void GravesAfterAttack(AttackableUnit unit, AttackableUnit target)
        {
            var hero = target as Obj_AI_Hero;
            if (hero == null)
            {
                return;
            }

            if (Orbwalker.ActiveMode == Orbwalking.OrbwalkingMode.Mixed ||
                Orbwalker.ActiveMode == Orbwalking.OrbwalkingMode.LaneClear)
            {
                if (hero.Mana/hero.MaxMana*100 > 65)
                {
                    if (hero.IsValidTarget() && Buckshot.IsReady())
                        Buckshot.CastIfHitchanceEquals(hero, HitChance.High);
                }
            }

            if (MainMenu.Item("allin").GetValue<KeyBind>().Active)
            {
                if (hero.IsValidTarget() && Buckshot.IsReady())
                    Buckshot.CastIfHitchanceEquals(hero, HitChance.High);
            }

            if (Orbwalker.ActiveMode == Orbwalking.OrbwalkingMode.Combo)
            {
                if (hero.IsValidTarget() && Buckshot.IsReady())
                    Buckshot.CastIfHitchanceEquals(hero, HitChance.High);

                if (MainMenu.Item("useecombo").GetValue<bool>())
                {
                    if (hero.IsValidTarget() && !Buckshot.IsReady())
                        if (MainMenu.Item("useeafter").GetValue<bool>())
                            CastE(hero);
                }
            }
        }

        #endregion

        #region OnCast
        static void GravesOnCast(Obj_AI_Base sender, GameObjectProcessSpellCastEventArgs args)
        {
            if (sender.IsMe && args.SData.Name == "GravesMove")
            {
                LE = Utils.GameTimeTickCount;
            }

            if (sender.IsMe && args.SData.Name == "GravesClusterShot")
            {
                if (Orbwalker.ActiveMode == Orbwalking.OrbwalkingMode.Combo)
                {
                    if (Target.IsValidTarget(Quickdraw.Range + 450))
                    {
                        Utility.DelayAction.Add(Game.Ping + 250, () => CastE(Target));
                    }
                }
            }

            if (sender.IsMe && args.SData.Name == "GravesSmokeGrenade")
            {
                if (MainMenu.Item("fleekey").GetValue<KeyBind>().Active)
                {
                    if (Target.IsValidTarget(Quickdraw.Range + 450))
                    {
                        Utility.DelayAction.Add(Game.Ping + 250, () => Quickdraw.Cast(Game.CursorPos));
                    }
                }

                if (Orbwalker.ActiveMode == Orbwalking.OrbwalkingMode.Combo)
                {
                    if (Target.IsValidTarget(Quickdraw.Range + 450) && !Quickdraw.IsReady())
                    {
                        Utility.DelayAction.Add(Game.Ping + 250, () => CastE(Target));
                    }
                }
            } 

            if (sender.IsEnemy && sender.Type == Me.Type)
            {
                if (sender.Distance(Me.ServerPosition) <= Smokescreen.Range)
                {
                    if ((args.SData.CastFrame / 30) > 500)
                    {
                        Smokescreen.Cast(sender.ServerPosition);
                    }
                }
            }

            if (sender.IsMe && args.SData.Name == "GravesChargeShot")
            {
                LR = Utils.GameTimeTickCount;

                if (Orbwalker.ActiveMode == Orbwalking.OrbwalkingMode.Combo ||
                    MainMenu.Item("allin").GetValue<KeyBind>().Active)
                {
                    if (Target.Distance(Me.ServerPosition) <= Chargeshot.Range)
                    {
                        Utility.DelayAction.Add(Game.Ping + 250, () =>
                        {
                            if (Target.Distance(Me.ServerPosition) > Quickdraw.Range - 55f)
                            {
                                if (Target.CountEnemiesInRange(Me.AttackRange) <= 2 && !Target.ServerPosition.UnderTurret(true))
                                {
                                    Quickdraw.Cast(Target.ServerPosition);
                                }
                            }

                            else
                            {
                                CastE(Target);
                            }
                        });
                    }
                }
            }
        }

        #endregion

        #region Drawing
        internal static void GravesOnEndScene(EventArgs args)
        {
            if (!MainMenu.Item("drawfill").GetValue<bool>())
                return;

            foreach (var enemy in HeroManager.Enemies.Where(ene => ene.IsValidTarget() && !ene.IsZombie))
            {
                HPi.unit = enemy;
                HPi.drawDmg(GetRDamage(enemy), new ColorBGRA(255, 255, 0, 90));
            }
        }

        internal static void GravesOnDraw(EventArgs args)
        {
            var acircle = MainMenu.Item("drawaa").GetValue<Circle>();
            var rcircle = MainMenu.Item("drawrrange").GetValue<Circle>();
            var qcircle = MainMenu.Item("drawqrange").GetValue<Circle>();

            if (acircle.Active)
                Render.Circle.DrawCircle(Me.Position, Me.AttackRange, acircle.Color, 3);

            if (rcircle.Active)
                Render.Circle.DrawCircle(Me.Position, Chargeshot.Range, rcircle.Color, 3);

            if (qcircle.Active)
                Render.Circle.DrawCircle(Me.Position, Buckshot.Range, qcircle.Color, 3);
        }

        #endregion

        #region Combo
        internal static void GravesCombo()
        {
            if (Target.IsValidTarget(Chargeshot.Range))
            {
                var rpred = Prediction.GetPrediction(Target, 0.25f).UnitPosition;
                if (rpred.Distance(Me.ServerPosition) <= Quickdraw.Range + 200)
                {
                    if (Chargeshot.IsReady() && (Quickdraw.IsReady() && Buckshot.IsReady()))
                    {
                        if (MainMenu.Item("usercombo").GetValue<bool>())
                        {
                            if (GetComboDamage(Target) >= Target.Health)
                                Chargeshot.CastIfHitchanceEquals(Target, HitChance.High);
                        }
                    }
                }
            }

            var qtarget = TargetSelector.GetTarget(Buckshot.Range, TargetSelector.DamageType.Physical);    
            if (qtarget.IsValidTarget())
            {
                var predpros = Prediction.GetPrediction(qtarget, 0.25f).UnitPosition;
                if (predpros.Distance(Me.ServerPosition) > 535)
                {
                    if (qtarget.Distance(Me.ServerPosition) <= 675)
                    {
                        if (Utils.GameTimeTickCount - LR < 1500)
                        {
                            Buckshot.CastIfHitchanceEquals(qtarget, HitChance.High);
                        }
                    }
                }
            }

            var wtarget = TargetSelector.GetTarget(Smokescreen.Range, TargetSelector.DamageType.Magical);
            if (wtarget.IsValidTarget() && wtarget.Distance(Me.ServerPosition) <= Smokescreen.Range)
            {
                if (MainMenu.Item("usew").GetValue<bool>())
                {
                    if (Smokescreen.IsReady() && Utils.GameTimeTickCount - LR >= 1200)
                    {
                        if (Me.GetAutoAttackDamage(qtarget)*3 < qtarget.Health)
                        {
                            if (!Quickdraw.IsReady() && !Buckshot.IsReady())
                                Smokescreen.CastIfHitchanceEquals(wtarget, HitChance.VeryHigh);
                        }
                    }
                }
            }

            if (qtarget.IsValidTarget() && qtarget.Distance(Me.ServerPosition) > 535)
            {
                if (qtarget.Distance(Me.ServerPosition) <= 535 + Quickdraw.Range)
                {
                    if (Quickdraw.IsReady() && Utils.GameTimeTickCount - LR >= 1200)
                    {
                        if (Me.GetAutoAttackDamage(qtarget)*3 >= qtarget.Health)
                        {
                            CastE(qtarget);
                        }
                    }
                }
            }
        }

        #endregion

        #region Damage
        internal static float GetRDamage(Obj_AI_Hero target)
        {
            if (target == null)
                return 0f;

            // impact physical damage
            var irdmg = Chargeshot.IsReady() && Proj2(target.ServerPosition, Chargeshot.Width, Chargeshot.Range) <= 1
                ? (float) Me.CalcDamage(target, Damage.DamageType.Physical,
                    new double[] { 250, 400, 550 }[Chargeshot.Level - 1] + 1.5 * Me.FlatPhysicalDamageMod)
                : 0;

            // explosion damage
            var erdmg = Chargeshot.IsReady() && Proj2(target.ServerPosition, Chargeshot.Width, Chargeshot.Range) > 1
                ? (float) Me.CalcDamage(target, Damage.DamageType.Physical,
                    new double[] { 200, 320, 440 }[Chargeshot.Level - 1] + 1.2 * Me.FlatPhysicalDamageMod)
                : 0;

            return irdmg + erdmg;
        }

        internal static float GetComboDamage(Obj_AI_Hero target)
        {
            if (target == null)
                return 0f;

            var edmg = Quickdraw.IsReady() ? (float) (Me.GetAutoAttackDamage(target) * 3) : 0;

            // buckshot damage
            var qdmg = Buckshot.IsReady() ? (float) (Me.GetSpellDamage(target, SpellSlot.Q)) : 0;

            // smokescreen damage
            var wdmg = Smokescreen.IsReady() ? (float) (Me.GetSpellDamage(target, SpellSlot.W)) : 0;

            // impact physical damage
            var irdmg = Chargeshot.IsReady() && Proj2(target.ServerPosition, Chargeshot.Width, Chargeshot.Range) <= 1
                ? (float) Me.CalcDamage(target, Damage.DamageType.Physical,
                    new double[] { 250, 400, 550 }[Chargeshot.Level - 1] + 1.5 * Me.FlatPhysicalDamageMod)
                : 0;
                
            // explosion damage
            var erdmg = Chargeshot.IsReady() && Proj2(target.ServerPosition, Chargeshot.Width, Chargeshot.Range) > 1
                ? (float) Me.CalcDamage(target, Damage.DamageType.Physical,
                    new double[] { 200, 320, 440 }[Chargeshot.Level - 1] + 1.2 * Me.FlatPhysicalDamageMod)
                : 0;

            return qdmg + edmg + wdmg + irdmg + erdmg;
        }

        // Counts the number of enemy objects in path of player and the spell.
        internal static int Proj1(Vector3 endpos, float width, float range, bool minion = false)
        {
            var end = endpos.To2D();
            var start = Me.ServerPosition.To2D();
            var direction = (end - start).Normalized();
            var endposition = start + direction * range;

            return (from unit in ObjectManager.Get<Obj_AI_Base>().Where(b => b.Team != Me.Team)
                where Me.ServerPosition.Distance(unit.ServerPosition) <= range
                where unit is Obj_AI_Hero || unit is Obj_AI_Minion && minion
                let proj = unit.ServerPosition.To2D().ProjectOn(start, endposition)
                let projdist = unit.Distance(proj.SegmentPoint)
                where unit.BoundingRadius + width > projdist
                select unit).Count();
        }

        // Counts the number of enemy objects in front of the player from the local player.
        internal static int Proj2(Vector3 endpos, float width, float range, bool minion = false)
        {
            var end = endpos.To2D();
            var start = Me.ServerPosition.To2D();
            var direction = (end - start).Normalized();
            var endposition = start + direction * start.Distance(endpos);

            return (from unit in ObjectManager.Get<Obj_AI_Base>().Where(b => b.Team != Me.Team)
                    where Me.ServerPosition.Distance(unit.ServerPosition) <= range
                    where unit is Obj_AI_Hero || unit is Obj_AI_Minion && minion
                    let proj = unit.ServerPosition.To2D().ProjectOn(start, endposition)
                    let projdist = unit.Distance(proj.SegmentPoint)
                    where unit.BoundingRadius + width > projdist
                    select unit).Count();
        }

        #endregion

        #region E Logic
        internal static void CastE(Obj_AI_Base target)
        {
            if (!MainMenu.Item("useecombo").GetValue<bool>() || !Quickdraw.IsReady())
            {
                return;
            }

            if (MainMenu.Item("ewherecom").GetValue<StringList>().SelectedIndex == 1)
            {
                Quickdraw.Cast(Game.CursorPos);
                return;
            }

            if (MainMenu.Item("ewherecom").GetValue<StringList>().SelectedIndex != 0)
            {
                return;
            }

            var range = Orbwalking.GetRealAutoAttackRange(target);
            var path = Geometry.CircleCircleIntersection(Me.ServerPosition.To2D(),
                Prediction.GetPrediction(target, 0.25f).UnitPosition.To2D(), Quickdraw.Range, range);

            if (path.Count() > 0)
            {
                var epos = path.MinOrDefault(x => x.Distance(Game.CursorPos));
                if (epos.To3D().UnderTurret(true) || epos.To3D().IsWall())
                {
                    return;
                }

                // intersection found
                Quickdraw.Cast(path.MinOrDefault(x => x.Distance(Game.CursorPos)));
            }

            if (path.Count() == 0)
            {
                if (Buckshot.IsReady() && target.Distance(Me.ServerPosition) <= 475)
                    Buckshot.CastIfHitchanceEquals(target, HitChance.High);

                var epos = Me.ServerPosition.Extend(target.ServerPosition, -Quickdraw.Range);
                if (epos.UnderTurret(true) || epos.IsWall())
                {
                    return;
                }

                // no intersection or target to close
                Quickdraw.Cast(Me.ServerPosition.Extend(target.ServerPosition, -Quickdraw.Range));
            }
        }

        #endregion

        #region Menu
        internal static void Menu_OnLoad()
        {
            MainMenu = new Menu("Kurisu's Graves", "kgraves", true);

            var tsmenu = new Menu("Selector", "tsmenu");
            TargetSelector.AddToMenu(tsmenu);
            MainMenu.AddSubMenu(tsmenu);

            var owmenu = new Menu("Orbwalker", "owmenu");
            Orbwalker = new Orbwalking.Orbwalker(owmenu);
            MainMenu.AddSubMenu(owmenu);

            var drmenu = new Menu("Drawings", "drawings");
            drmenu.AddItem(new MenuItem("drawaa", "Draw AA Range"))
                .SetValue(new Circle(true, System.Drawing.Color.FromArgb(150, System.Drawing.Color.Firebrick)));
            drmenu.AddItem(new MenuItem("drawqrange", "Draw Q Range"))
                .SetValue(new Circle(true, System.Drawing.Color.FromArgb(150, System.Drawing.Color.Red)));
            drmenu.AddItem(new MenuItem("drawrrange", "Draw R Range"))
                .SetValue(new Circle(true, System.Drawing.Color.FromArgb(150, System.Drawing.Color.Firebrick)));
            drmenu.AddItem(new MenuItem("drawfill", "Draw R Damage Fill")).SetValue(true);
            MainMenu.AddSubMenu(drmenu);

            var misc = new Menu("Other/Misc", "misc");
            misc.AddItem(new MenuItem("shootr", "Shoot R")).SetValue(new KeyBind('T', KeyBindType.Press));
            misc.AddItem(new MenuItem("fleekey", "Use Flee")).SetValue(new KeyBind(65, KeyBindType.Press));
            misc.AddItem(new MenuItem("allin", "All In Combo")).SetValue(new KeyBind('G', KeyBindType.Press));
            MainMenu.AddSubMenu(misc);

            var comenu = new Menu("Combo Settings", "comenu");
            comenu.AddItem(new MenuItem("usew", "Use W in combo")).SetValue(false);
            comenu.AddItem(new MenuItem("autosmoke", "Use W on cc'd target")).SetValue(true);
            comenu.AddItem(new MenuItem("usewongap", "Use W on gapclosers")).SetValue(true);

            comenu.AddItem(new MenuItem("useecombo", "Use E in combo")).SetValue(true);
            comenu.AddItem(new MenuItem("ewherecom", "Use E to"))
                .SetValue(new StringList(new[] { "Safe Position", "Game Cursor" }));
            comenu.AddItem(new MenuItem("useeafter", "Use E after attack")).SetValue(true);

            comenu.AddItem(new MenuItem("usercombo", "Use R in combo")).SetValue(true);
            comenu.AddItem(new MenuItem("rmulti", "Use R in combo if hit >=")).SetValue(new Slider(3, 1, 5));
            comenu.AddItem(new MenuItem("secure", "Use R secure kill")).SetValue(true);
            MainMenu.AddSubMenu(comenu);

            MainMenu.AddToMainMenu();
        }

        #endregion

    }
}
