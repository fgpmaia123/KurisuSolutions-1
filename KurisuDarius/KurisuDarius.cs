using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using KL = KurisuDarius.KurisuLib;

namespace KurisuDarius
{
    internal class KurisuDarius
    {
        internal static Menu Config;
        internal static SpellSlot Ignite;
        internal static HpBarIndicator HPi = new HpBarIndicator();
        internal static Orbwalking.Orbwalker Orbwalker;

        public KurisuDarius()
        {
            if (ObjectManager.Player.ChampionName != "Darius")
                return;
          
            Config = new Menu("Kurisu's Darius", "darius", true);

            var drmenu = new Menu(":: Drawings", "drawings");
            drmenu.AddItem(new MenuItem("drawe", "Draw E"))
                .SetValue(new Circle(true, System.Drawing.Color.FromArgb(150, System.Drawing.Color.OrangeRed)));
            drmenu.AddItem(new MenuItem("drawq", "Draw Q"))
                .SetValue(new Circle(true, System.Drawing.Color.FromArgb(150, System.Drawing.Color.Red)));
            drmenu.AddItem(new MenuItem("drawr", "Draw R"))
                .SetValue(new Circle(true, System.Drawing.Color.FromArgb(150, System.Drawing.Color.DarkRed)));
            drmenu.AddItem(new MenuItem("drawfill", "Draw R Damage Fill")).SetValue(true);
            drmenu.AddItem(new MenuItem("drawstack", "Draw Stack Count")).SetValue(true);
            Config.AddSubMenu(drmenu);

            var omenu = new Menu(":: Orbwalker", "omenu");
            Orbwalker = new Orbwalking.Orbwalker(omenu);
            Config.AddSubMenu(omenu);

            var tsmenu = new Menu(":: Target Selector", "tmenu");
            TargetSelector.AddToMenu(tsmenu);
            Config.AddSubMenu(tsmenu);

            var cmenu = new Menu(":: Main Settings", "cmenu");
            cmenu.AddItem(new MenuItem("useq", "Use Q")).SetValue(true);
            cmenu.AddItem(new MenuItem("usew", "Use W")).SetValue(true);
            cmenu.AddItem(new MenuItem("usee", "Use E")).SetValue(true);
            cmenu.AddItem(new MenuItem("eeee", "E Logic:")).SetValue(new StringList(new[] {"Smart", "Smarter [Beta]"}));
            cmenu.AddItem(new MenuItem("user", "Use R")).SetValue(true);
            cmenu.AddItem(new MenuItem("harassq", "Harass Q")).SetValue(true);
            Config.AddSubMenu(cmenu);

            var kmenu = new Menu(":: Miscellaneous", "kmenu");
            kmenu.AddItem(new MenuItem("ksr", "Kill Secure R")).SetValue(true); 
            kmenu.AddItem(new MenuItem("ksr1", "Use early if target will bleed to death (1v1)")).SetValue(false);
            kmenu.AddItem(new MenuItem("rmodi", "Adjust ult damage (Less if target doesnt die)")).SetValue(new Slider(0, -250, 250));
            Config.AddSubMenu(kmenu);

            Config.AddToMainMenu();

            if (KL.Player.Spellbook.GetSpell(SpellSlot.Summoner1).Name.ToLower().Contains("dot"))
                Ignite = SpellSlot.Summoner1;

            if (KL.Player.Spellbook.GetSpell(SpellSlot.Summoner2).Name.ToLower().Contains("dot"))
                Ignite = SpellSlot.Summoner2;

            Game.OnUpdate += Game_OnUpdate;
            Orbwalking.AfterAttack += Orbwalking_AfterAttack;

            Drawing.OnDraw += Drawing_OnDraw;
            Drawing.OnEndScene += Drawing_OnEndScene;

            foreach (var obj in ObjectManager.Get<Obj_AI_Turret>())
            {
                if (!KL.TurretCache.ContainsKey(obj.NetworkId))
                     KL.TurretCache.Add(obj.NetworkId, obj);
            }     

            Obj_AI_Base.OnProcessSpellCast += (sender, args) =>
            {
                if (sender.IsMe && args.SData.Name == "DariusCleave")
                    Utility.DelayAction.Add(Game.Ping + 800, Orbwalking.ResetAutoAttackTimer);

                if (sender.IsMe && args.SData.Name == "DariusAxeGrabCone")
                    Utility.DelayAction.Add(Game.Ping + 100, Orbwalking.ResetAutoAttackTimer);
            };
        }

        internal void Drawing_OnEndScene(EventArgs args)
        {
            if (!Config.Item("drawfill").GetValue<bool>())
                return;

            foreach (var enemy in HeroManager.Enemies.Where(ene => ene.IsValidTarget() && !ene.IsZombie))
            {
                HPi.unit = enemy;
                HPi.drawDmg(
                    KL.RDmg(enemy, 
                        enemy.GetBuffCount("dariushemo") <= 0 ? 0 
                      : enemy.GetBuffCount("dariushemo")),new ColorBGRA(255, 255, 0, 90));
            }
        }

        internal static bool CanE(Obj_AI_Hero target)
        {
            if (Config.Item("eeee").GetValue<StringList>().SelectedIndex == 0)
                return true;
  
            var t = KL.TurretCache.Values.FirstOrDefault(x => x.IsEnemy && x.Distance(KL.Player.ServerPosition) <= 1500);
            if (t == null || t.IsDead || !t.IsValid)
                return true;

            if (KL.Player.Distance(t) <= 1200 && target.Distance(t) <= 1200)
            {
                if (target.Distance(t) > KL.Player.Distance(t))
                {
                    if (target.IsFacing(t))
                        return false;
                }
            }
            
            return true;
        }

        internal static void Drawing_OnDraw(EventArgs args)
        {
            var acircle = Config.Item("drawe").GetValue<Circle>();
            var rcircle = Config.Item("drawr").GetValue<Circle>();
            var qcircle = Config.Item("drawq").GetValue<Circle>();

            if (acircle.Active)
                Render.Circle.DrawCircle(KL.Player.Position, KL.Spellbook["E"].Range, acircle.Color, 3);

            if (rcircle.Active)
                Render.Circle.DrawCircle(KL.Player.Position, KL.Spellbook["R"].Range, rcircle.Color, 3);

            if (qcircle.Active)
                Render.Circle.DrawCircle(KL.Player.Position, KL.Spellbook["Q"].Range, qcircle.Color, 3);

            if (!Config.Item("drawstack").GetValue<bool>())
                return;

            foreach (var enemy in HeroManager.Enemies.Where(ene => ene.IsValidTarget() && !ene.IsZombie))
            {
                var enez = Drawing.WorldToScreen(enemy.Position);
                if (enemy.GetBuffCount("dariushemo") > 0)
                {
                    Drawing.DrawText(enez[0] - 50, enez[1], System.Drawing.Color.OrangeRed, 
                        "Stack Count: " + enemy.GetBuffCount("dariushemo"));
                }
            }
        }


        internal static void Orbwalking_AfterAttack(AttackableUnit unit, AttackableUnit target)
        {
            var hero = unit as Obj_AI_Hero;
            if (hero != null && hero.Type == GameObjectType.obj_AI_Hero)
            {
                if (Orbwalker.ActiveMode == Orbwalking.OrbwalkingMode.Combo)
                {
                    if (!hero.HasBuffOfType(BuffType.Slow))
                        KL.Spellbook["W"].Cast();
                }
            }
        }


        internal static float Rmodi;
        internal static void Game_OnUpdate(EventArgs args)
        {
            Rmodi = Config.Item("rmodi").GetValue<Slider>().Value;

            if (KL.Spellbook["R"].IsReady() && Config.Item("ksr").GetValue<bool>())
            {
                foreach (var unit in HeroManager.Enemies.Where(ene => ene.IsValidTarget(KL.Spellbook["R"].Range) && !ene.IsZombie))
                {
                    int rr = unit.GetBuffCount("dariushemo") <= 0 ? 0 : unit.GetBuffCount("dariushemo");
                    if (unit.CountEnemiesInRange(1200) <= 1 && Config.Item("ksr1").GetValue<bool>())
                    {
                        if (KL.Player.Distance(unit.ServerPosition) > 265)
                        {
                            if (KL.RDmg(unit, rr) + Rmodi + KL.Hemorrhage(unit, rr) >= unit.Health)
                            {
                                if (!unit.HasBuffOfType(BuffType.Invulnerability) &&
                                    !unit.HasBuffOfType(BuffType.SpellShield))
                                {
                                    KL.Spellbook["R"].CastOnUnit(unit);
                                }
                            }
                        }
                    }

                    if (KL.RDmg(unit, rr) + Rmodi >= unit.Health +  KL.Hemorrhage(unit, 1))
                    {
                        if (!unit.HasBuffOfType(BuffType.Invulnerability) &&
                            !unit.HasBuffOfType(BuffType.SpellShield))
                        {
                            KL.Spellbook["R"].CastOnUnit(unit);
                        }
                    }
                }
            }

            switch (Orbwalker.ActiveMode)
            {
                case Orbwalking.OrbwalkingMode.Combo:
                    Combo(Config.Item("useq").GetValue<bool>(), Config.Item("usew").GetValue<bool>(),
                          Config.Item("usee").GetValue<bool>(), Config.Item("user").GetValue<bool>());
                    break;
                case Orbwalking.OrbwalkingMode.Mixed:
                    Harass();
                    break;
            }
        }

        internal static bool CanQ(Obj_AI_Base unit)
        {
            if (!unit.IsValidTarget() || unit.IsZombie)
                return false;

            var rr = unit.GetBuffCount("dariushemo") <= 0 ? 0 : unit.GetBuffCount("dariushemo");

            if (KL.WDmg(unit) >= unit.Health)
                return false;

            if (KL.Player.Distance(unit.ServerPosition) < 200)
                return false;

            if (KL.Player.Distance(unit.ServerPosition) > KL.Spellbook["Q"].Range)
                return false;

            if (KL.RDmg(unit, rr) - KL.Hemorrhage(unit, 1) >= unit.Health)
                return false;

            if (KL.Player.GetAutoAttackDamage(unit) * 2 + KL.Hemorrhage(unit, rr) >= unit.Health)
                if (KL.Player.Distance(unit.ServerPosition) <= 180)
                    return false;

            return true;
        }

        internal static void Harass()
        {
            if (Config.Item("harassq").GetValue<bool>() && KL.Spellbook["Q"].IsReady())
            {
                if (KL.Player.Mana / KL.Player.MaxMana * 100 > 60)
                {
                    if (CanQ(TargetSelector.GetTarget(KL.Spellbook["E"].Range,
                             TargetSelector.DamageType.Physical)))
                    {
                        KL.Spellbook["Q"].Cast();
                    }
                }
            }   
        }

        internal static void Combo(bool useq, bool usew, bool usee, bool user)
        {
            if (useq && KL.Spellbook["Q"].IsReady())
            {
                if (CanQ(TargetSelector.GetTarget(KL.Spellbook["E"].Range, TargetSelector.DamageType.Physical)))
                {
                    KL.Spellbook["Q"].Cast();
                }
            }

            if (usew && KL.Spellbook["W"].IsReady())
            {
                var wtarget = TargetSelector.GetTarget(KL.Spellbook["E"].Range, TargetSelector.DamageType.Physical);
                if (wtarget.IsValidTarget(KL.Spellbook["W"].Range) && !wtarget.IsZombie)
                {
                    if (wtarget.Distance(KL.Player.ServerPosition) <= 200 && KL.WDmg(wtarget) >= wtarget.Health)
                    {
                        KL.Spellbook["W"].Cast();
                    }
                }
            }

            if (usee && KL.Spellbook["E"].IsReady())
            {
                var etarget = TargetSelector.GetTarget(KL.Spellbook["E"].Range, TargetSelector.DamageType.Physical);
                if (etarget.IsValidTarget() && CanE(etarget))
                {
                    if (etarget.Distance(KL.Player.ServerPosition) > 270)
                    {
                        if (KL.Spellbook["Q"].IsReady() || KL.Spellbook["W"].IsReady())
                            KL.Spellbook["E"].Cast(etarget.ServerPosition);
                    }           
                }
            }

            if (user && KL.Spellbook["R"].IsReady())
            {
                var unit = TargetSelector.GetTarget(KL.Spellbook["E"].Range, TargetSelector.DamageType.Physical);

                if (unit.IsValidTarget(KL.Spellbook["R"].Range) && !unit.IsZombie)
                {
                    int rr = unit.GetBuffCount("dariushemo") <= 0 ? 0 : unit.GetBuffCount("dariushemo");
                    if (!unit.HasBuffOfType(BuffType.Invulnerability) && !unit.HasBuffOfType(BuffType.SpellShield))
                    {
                        if (KL.RDmg(unit, rr) + Rmodi >= unit.Health + KL.Hemorrhage(unit, 1))
                        {
                            if (!unit.HasBuffOfType(BuffType.Invulnerability) &&
                                !unit.HasBuffOfType(BuffType.SpellShield))
                            {
                                KL.Spellbook["R"].CastOnUnit(unit);
                            }
                        }
                    }
                }
            }
        }
    }
}
