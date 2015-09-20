using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;
using SPrediction;

namespace KurisuMorgana
{
    internal class Program
    {
        private static Menu _menu;
        private static Spell _q, _w, _e, _r;
        private static Orbwalking.Orbwalker _orbwalker;
        private static readonly Obj_AI_Hero Me = ObjectManager.Player;

        static void Main(string[] args)
        {
            Console.WriteLine("Morgana injected...");
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            if (Me.ChampionName != "Morgana")
                return;

            // set spells
            _q = new Spell(SpellSlot.Q, 1175f);
            _q.SetSkillshot(0.25f, 80f, 1200f, true, SkillshotType.SkillshotLine);

            _w = new Spell(SpellSlot.W, 900f);
            _w.SetSkillshot(0.50f, 400f, 2200f, false, SkillshotType.SkillshotCircle);

            _e = new Spell(SpellSlot.E, 750f);
            _r = new Spell(SpellSlot.R, 600f);

            _menu = new Menu("KurisuMorgana", "morgana", true);

            SPrediction.Prediction.Initialize(_menu);

            // Change menu name
            if (_menu.SubMenu("SPRED") != null)
            {
                _menu.SubMenu("SPRED").DisplayName = ":: SPrediction";
                _menu.Item("SPREDREACTIONDELAY").SetValue(new Slider(0, 0, 200));
            }

            var orbmenu = new Menu(":: Orbwalker", "orbwalker");
            _orbwalker = new Orbwalking.Orbwalker(orbmenu);
            _menu.AddSubMenu(orbmenu);

            var tsmenu = new Menu(":: Target Selector", "selector");
            TargetSelector.AddToMenu(tsmenu);
            _menu.AddSubMenu(tsmenu);

            var spellmenu = new Menu(":: Main Settings", "spells");

            var ccmenu = new Menu(":: Combo Settings", "ccmenu");

            var menuQ = new Menu("Dark Binding (Q)", "qmenu");
            menuQ.AddItem(new MenuItem("hitchanceq", "Binding hitchance ")).SetValue(new Slider(4, 1, 4));
            menuQ.AddItem(new MenuItem("useqcombo", "Use in combo")).SetValue(true);
            menuQ.AddItem(new MenuItem("useharassq", "Use in harass")).SetValue(true);
            menuQ.AddItem(new MenuItem("useqanti", "Use on gapcloser")).SetValue(true);
            menuQ.AddItem(new MenuItem("useqauto", "Use on immobile")).SetValue(true);
            menuQ.AddItem(new MenuItem("useqdash", "Use on dashing")).SetValue(true);
            ccmenu.AddSubMenu(menuQ);

            var menuW = new Menu("Tormented Soil (W)", "wmenu");
            menuW.AddItem(new MenuItem("hitchancew", "Tormentsoil hitchance ")).SetValue(new Slider(3, 1, 4));
            menuW.AddItem(new MenuItem("usewcombo", "Use in combo")).SetValue(true);
            menuW.AddItem(new MenuItem("useharassw", "Use in harass")).SetValue(true);       
            menuW.AddItem(new MenuItem("usewauto", "Use on immobile")).SetValue(true);
            menuW.AddItem(new MenuItem("waitfor", "Cast only on if immobile")).SetValue(true);
            menuW.AddItem(new MenuItem("calcw", "Calculated ticks")).SetValue(new Slider(6, 3, 10));
            ccmenu.AddSubMenu(menuW);

            var menuE = new Menu("BlackShield (E)", "emenu");

            var newmenu = new Menu("Allies", "usefor");
            foreach (var frn in ObjectManager.Get<Obj_AI_Hero>().Where(x => x.Team == Me.Team))
                newmenu.AddItem(new MenuItem("useon" + frn.ChampionName, "Shield " + frn.ChampionName)).SetValue(true);
            menuE.AddSubMenu(newmenu);

            foreach (var ene in ObjectManager.Get<Obj_AI_Hero>().Where(x => x.Team != Me.Team))
            {
                // create menu per enemy
                var champMenu = new Menu(ene.ChampionName, "cm" + ene.NetworkId);

                // check if spell is supported in lib
                foreach (var lib in KurisuLib.CCList.Where(x => x.HeroName == ene.ChampionName))
                {
                    var skillMenu = new Menu(lib.Slot + " - " + lib.SpellMenuName, "sm" + lib.SDataName);
                    skillMenu.AddItem(new MenuItem(lib.SDataName + "on", "Enable")).SetValue(true);
                    skillMenu.AddItem(new MenuItem(lib.SDataName + "waitz", "Humanize (Disabled)")).SetValue(true);
                    skillMenu.AddItem(new MenuItem(lib.SDataName + "pr", "Priority"))
                        .SetValue(new Slider(lib.DangerLevel, 1, 5));
                    champMenu.AddSubMenu(skillMenu);
                }

                menuE.AddSubMenu(champMenu);
            }

            ccmenu.AddSubMenu(menuE);

            var menuR = new Menu("Soul Shackles (R)", "rmenu");
            menuR.AddItem(new MenuItem("usercombo", "Enable")).SetValue(true);
            menuR.AddItem(new MenuItem("rkill", "Use in combo if killable")).SetValue(true);
            menuR.AddItem(new MenuItem("rcount", "Use in combo if enemies >= ")).SetValue(new Slider(3, 1, 5));
            menuR.AddItem(new MenuItem("useautor", "Use automatic if enemies >= ")).SetValue(new Slider(4, 2, 5));
            ccmenu.AddSubMenu(menuR);

            var kbmenu = new Menu(":: Keybinds", "keybinds");
            kbmenu.AddItem(new MenuItem("combokey", "Combo (active)")).SetValue(new KeyBind(32, KeyBindType.Press));
            kbmenu.AddItem(new MenuItem("harasskey", "Harass (active)")).SetValue(new KeyBind('C', KeyBindType.Press));
            spellmenu.AddSubMenu(kbmenu);

            ccmenu.AddItem(new MenuItem("harassmana", "Harass mana %")).SetValue(new Slider(55, 0, 99));
            spellmenu.AddSubMenu(ccmenu);


            spellmenu.AddItem(new MenuItem("support", ":: Support Mode")).SetValue(false);
            spellmenu.AddItem(new MenuItem("dp", ":: Drawings")).SetValue(true);
            _menu.AddSubMenu(spellmenu);
            _menu.AddToMainMenu();

            Game.PrintChat("<font color=\"#FF33D6\"><b>KurisuMorgana</b></font> - Loaded!");

            // events
            Drawing.OnDraw += Drawing_OnDraw;
            Game.OnUpdate += Game_OnGameUpdate;
            AntiGapcloser.OnEnemyGapcloser += AntiGapcloser_OnEnemyGapcloser;
            Orbwalking.BeforeAttack += Orbwalking_BeforeAttack;

            try
            {
                Obj_AI_Base.OnProcessSpellCast += Obj_AI_Base_OnProcessSpellCast;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception thrown KurisuMorgana: (BlackShield: {0})", e);
            }
        }

        private static bool Immobile(Obj_AI_Hero unit)
        {
            return unit.HasBuffOfType(BuffType.Charm) || unit.HasBuffOfType(BuffType.Fear) ||
                   unit.HasBuffOfType(BuffType.Flee) || unit.HasBuffOfType(BuffType.Stun) ||
                   unit.HasBuffOfType(BuffType.Knockup) || unit.HasBuffOfType(BuffType.Snare) ||
                   unit.HasBuffOfType(BuffType.Taunt) || unit.HasBuffOfType(BuffType.Suppression);
        }

        private static void Orbwalking_BeforeAttack(Orbwalking.BeforeAttackEventArgs args)
        {
            if (_orbwalker.ActiveMode == Orbwalking.OrbwalkingMode.Mixed)
            {
                if (args.Target.Type == GameObjectType.obj_AI_Minion)
                {
                    if (_menu.Item("support").GetValue<bool>())
                        args.Process = false;
                }
            }
        }

        private static void Game_OnGameUpdate(EventArgs args)
        {
            if (!Me.IsValidTarget(300, false))
                return;

            CheckDamage(TargetSelector.GetTarget(_q.Range + 10, TargetSelector.DamageType.Magical));

            AutoCast(_menu.Item("useqdash").GetValue<bool>(),
                     _menu.Item("useqauto").GetValue<bool>(),
                     _menu.Item("usewauto").GetValue<bool>());

            if (_menu.Item("combokey").GetValue<KeyBind>().Active)
            {
                Combo(_menu.Item("useqcombo").GetValue<bool>(),
                      _menu.Item("usewcombo").GetValue<bool>(), 
                      _menu.Item("usercombo").GetValue<bool>());
            }

            if (_menu.Item("harasskey").GetValue<KeyBind>().Active)
            {
                Harass(_menu.Item("useharassq").GetValue<bool>(),
                       _menu.Item("useharassw").GetValue<bool>());
            }
        }

        private static void Drawing_OnDraw(EventArgs args)
        {
            if (!_menu.Item("dp").GetValue<bool>())
            {
                return;
            }

            Render.Circle.DrawCircle(Me.Position, _q.Range,
                System.Drawing.Color.FromArgb(155, System.Drawing.Color.DeepPink), 4);
        }

        private static void Combo(bool useq, bool usew, bool user)
        {
            if (useq && _q.IsReady())
            {
                var qtarget = TargetSelector.GetTargetNoCollision(_q);
                if (qtarget.IsValidTarget())
                {
                    _q.SPredictionCast(qtarget, (HitChance) _menu.Item("hitchanceq").GetValue<Slider>().Value + 2);
                }
            }

            if (usew && _w.IsReady())
            {             
                var wtarget = TargetSelector.GetTarget(_w.Range + 10, TargetSelector.DamageType.Magical);            
                if (wtarget.IsValidTarget())
                {
                    if (!_menu.Item("waitfor").GetValue<bool>() || _mw * 1 >= wtarget.Health)
                    {
                        _w.SPredictionCast(wtarget, (HitChance) _menu.Item("hitchancew").GetValue<Slider>().Value + 2);
                    }   
                }
            }

            if (user && _r.IsReady())
            {
                var ticks = _menu.Item("calcw").GetValue<Slider>().Value;
                var rtarget = TargetSelector.GetTarget(_r.Range, TargetSelector.DamageType.Magical);
                if (rtarget.IsValidTarget() && _menu.Item("rkill").GetValue<bool>())
                {
                    if (_mr + _mq + _mw * ticks + _ma * 3 + _mi + _guise >= rtarget.Health)
                    {
                        if (rtarget.Health > _mr + _ma * 2 + _mw * 2 && !rtarget.IsZombie)
                        {
                            if (_e.IsReady()) _e.CastOnUnit(Me);
                            _r.Cast();
                        }
                    }

                    if (Me.CountEnemiesInRange(_r.Range) >= _menu.Item("rcount").GetValue<Slider>().Value)
                    {
                        if (_e.IsReady())
                            _e.CastOnUnit(Me);

                        _r.Cast();
                    }
                }
            }
        }

        private static void Harass(bool useq, bool usew)
        {
            if (useq && _q.IsReady())
            {
                var qtarget = TargetSelector.GetTargetNoCollision(_q);
                if (qtarget.IsValidTarget())
                {
                    if ((int)(Me.Mana / Me.MaxMana * 100) >= _menu.Item("harassmana").GetValue<Slider>().Value)
                        _q.SPredictionCast(qtarget, (HitChance) _menu.Item("hitchanceq").GetValue<Slider>().Value + 2);
                }
            }

            if (usew && _w.IsReady())
            {
                var wtarget = TargetSelector.GetTarget(_w.Range + 200, TargetSelector.DamageType.Magical);
                if (wtarget.IsValidTarget())
                {
                    if ((int) (Me.Mana / Me.MaxMana * 100) >= _menu.Item("harassmana").GetValue<Slider>().Value)
                    {
                        if (!_menu.Item("waitfor").GetValue<bool>() || _mw * 1 >= wtarget.Health)
                        {
                            _w.SPredictionCast(wtarget,
                                (HitChance) _menu.Item("hitchancew").GetValue<Slider>().Value + 2);
                        }
                    }
                }           
            }
        }

        private static void AutoCast(bool dashing, bool immobile, bool soil)
        {
            if (_q.IsReady())
            {
                foreach (var itarget in HeroManager.Enemies.Where(h => h.IsValidTarget(_q.Range)))
                {
                    if (immobile)
                        _q.SPredictionCast(itarget, HitChance.Immobile);

                    if (dashing && itarget.Distance(Me.ServerPosition) <= 400f)
                        _q.SPredictionCast(itarget, HitChance.Dashing);
                }
            }

            if (_w.IsReady() && soil)
            {
                foreach (var itarget in HeroManager.Enemies.Where(h => h.IsValidTarget(_w.Range)))
                {
                    if (Immobile(itarget))
                        _w.Cast(itarget.ServerPosition);
                }
            }

            if (_r.IsReady())
            {
                if (Me.CountEnemiesInRange(_r.Range) >= _menu.Item("useautor").GetValue<Slider>().Value)
                {
                    if (_e.IsReady())
                        _e.CastOnUnit(Me);

                    _r.Cast();
                }           
            }
        }  

        private static void AntiGapcloser_OnEnemyGapcloser(ActiveGapcloser gapcloser)
        {
            if (gapcloser.Sender.IsValidTarget(250f))
            {
                if (_menu.Item("useqanti").GetValue<bool>())
                    _q.SPredictionCast(gapcloser.Sender, HitChance.Low);
            }
        }

        private static float _mq, _mw, _mr;
        private static float _ma, _mi, _guise;
        private static void CheckDamage(Obj_AI_Base target)
        {
            if (target == null)
            {
                return;
            }

            var qready = Me.Spellbook.CanUseSpell(SpellSlot.Q) == SpellState.Ready;
            var wready = Me.Spellbook.CanUseSpell(SpellSlot.W) == SpellState.Ready;
            var rready = Me.Spellbook.CanUseSpell(SpellSlot.R) == SpellState.Ready;
            var iready = Me.Spellbook.CanUseSpell(Me.GetSpellSlot("summonerdot")) == SpellState.Ready;

            _ma = (float) Me.GetAutoAttackDamage(target);
            _mq = (float) (qready ? Me.GetSpellDamage(target, SpellSlot.Q) : 0);
            _mw = (float) (wready ? Me.GetSpellDamage(target, SpellSlot.W) : 0);
            _mr = (float) (rready ? Me.GetSpellDamage(target, SpellSlot.R) : 0);
            _mi = (float) (iready ? Me.GetSummonerSpellDamage(target, Damage.SummonerSpell.Ignite) : 0);

            _guise = (float) (Items.HasItem(3151)
                ? Me.GetItemDamage(target, Damage.DamageItems.LiandrysTorment)
                : 0);
        }

        internal static void Obj_AI_Base_OnProcessSpellCast(Obj_AI_Base sender, GameObjectProcessSpellCastEventArgs args)
        {
            if (sender.Type != Me.Type || !_e.IsReady() || !sender.IsEnemy) 
                return;

            var attacker = ObjectManager.Get<Obj_AI_Hero>().First(x => x.NetworkId == sender.NetworkId);
            foreach (var ally in HeroManager.Allies.Where(x => x.IsValidTarget(_e.Range, false)))
            {
                var detectRange = ally.ServerPosition + (args.End - ally.ServerPosition).Normalized() * ally.Distance(args.End);
                if (detectRange.Distance(ally.ServerPosition) > ally.AttackRange - ally.BoundingRadius)
                    continue;

                foreach (var lib in KurisuLib.CCList.Where(x => x.HeroName == attacker.ChampionName && x.Slot == attacker.GetSpellSlot(args.SData.Name)))
                    if (_menu.Item(lib.SDataName + "on").GetValue<bool>() && _menu.Item("useon" + ally.ChampionName).GetValue<bool>())
                    {
                        Utility.DelayAction.Add(100, () => _e.CastOnUnit(ally));
                    }}
        }
    }
}
