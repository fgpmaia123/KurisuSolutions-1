#region Copyright © 2015 Kurisu Solutions
// All rights are reserved. Transmission or reproduction in part or whole,
// any form or by any means, mechanical, electronical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Document:	activator/program.cs
// Date:		01/07/2015
// Author:		Robin Kurisu
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

#region Namespaces
using LeagueSharp;
using LeagueSharp.Common;
using Activator.Base;
using Activator.Data;
using Activator.Handlers;
using Activator.Items;
using Activator.Spells;
using Activator.Summoners;
#endregion

namespace Activator
{
    internal class Activator
    {
        internal static Menu Origin;
        internal static Obj_AI_Hero Player;

        internal static int MapId;
        internal static int LastUsedTimeStamp;
        internal static int LastUsedDuration;

        internal static SpellSlot Smite;
        internal static bool SmiteInGame;
        internal static bool TroysInGame;

        public static bool UseEnemyMenu, UseAllyMenu;
        public static System.Version Version;
        public static List<Champion> Heroes = new List<Champion>(); 

        private static void Main(string[] args)
        {
            Version = Assembly.GetExecutingAssembly().GetName().Version;
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            try
            {
                Player = ObjectManager.Player;
                MapId = (int) Utility.Map.GetMap().Type;

                GetSmiteSlot();
                GetTroysInGame();
                GetHeroesInGame();
                GetComboDamage();

                Origin = new Menu("Activator", "activator", true);

                var cmenu = new Menu("Cleansers", "cleansers");
                SubMenu(cmenu, false);
                GetItemGroup("Items.Cleansers").ForEach(t => NewItem((CoreItem)NewInstance(t), cmenu));
                Origin.AddSubMenu(cmenu);

                var dmenu = new Menu("Defensives", "dmenu");
                SubMenu(dmenu, false);
                GetItemGroup("Items.Defensives").ForEach(t => NewItem((CoreItem) NewInstance(t), dmenu));
                Origin.AddSubMenu(dmenu);

                var smenu = new Menu("Summoners", "smenu");
                SubMenu(smenu, true, true);
                GetItemGroup("Summoners").ForEach(t => NewSummoner((CoreSum) NewInstance(t), smenu));
                Origin.AddSubMenu(smenu);

                var omenu = new Menu("Offensives", "omenu");
                SubMenu(omenu, true);
                GetItemGroup("Items.Offensives").ForEach(t => NewItem((CoreItem) NewInstance(t), omenu));
                Origin.AddSubMenu(omenu);

                var imenu = new Menu("Consumables", "imenu");
                GetItemGroup("Items.Consumables").ForEach(t => NewItem((CoreItem) NewInstance(t), imenu));
                Origin.AddSubMenu(imenu);

                var amenu = new Menu("Auto Spells", "amenu");
                SubMenu(amenu, false);
                GetItemGroup("Spells.Evaders").ForEach(t => NewSpell((CoreSpell) NewInstance(t), amenu));
                GetItemGroup("Spells.Shields").ForEach(t => NewSpell((CoreSpell) NewInstance(t), amenu));
                GetItemGroup("Spells.Health").ForEach(t => NewSpell((CoreSpell) NewInstance(t), amenu));
                GetItemGroup("Spells.Slows").ForEach(t => NewSpell((CoreSpell) NewInstance(t), amenu));
                GetItemGroup("Spells.Heals").ForEach(t => NewSpell((CoreSpell) NewInstance(t), amenu));
                Origin.AddSubMenu(amenu);

                var zmenu = new Menu("Misc/Settings", "settings");

                if (SmiteInGame)
                {
                    var ddmenu = new Menu("Drawings", "drawings");
                    ddmenu.AddItem(new MenuItem("drawfill", "Draw Smite Fill")).SetValue(true);
                    ddmenu.AddItem(new MenuItem("drawsmite", "Draw Smite Range")).SetValue(true);
                    zmenu.AddSubMenu(ddmenu);
                }

                zmenu.AddItem(new MenuItem("acdebug", "Debug")).SetValue(false);
                zmenu.AddItem(new MenuItem("evade", "Evade Integration")).SetValue(true);
                zmenu.AddItem(new MenuItem("healthp", "Ally Priority:")).SetValue(new StringList(new[] { "Low HP", "Most AD/AP", "Most HP" }, 1));
                zmenu.AddItem(new MenuItem("usecombo", "Combo (active)")).SetValue(new KeyBind(32, KeyBindType.Press, true));

                var uumenu = new Menu("Evade Menu", "evadem");
                LoadEvadeMenu(uumenu);
                zmenu.AddSubMenu(uumenu);

                Origin.AddSubMenu(zmenu);

                Origin.AddToMainMenu();

                // drawings
                Drawings.Load();

                // damage prediction
                Projections.Load();

                // object manager
                Gametroys.StartOnUpdate();

                Obj_AI_Base.OnLevelUp += Obj_AI_Base_OnLevelUp;
                Obj_AI_Base.OnPlaceItemInSlot += Obj_AI_Base_OnPlaceItemInSlot;

                Game.PrintChat("<b>Activator#</b> - Loaded!");
                Updater.UpdateCheck();

                foreach (var autospell in Lists.Spells)
                    if (Player.GetSpellSlot(autospell.Name) != SpellSlot.Unknown)
                        Game.OnUpdate += autospell.OnTick;

                foreach (var item in Lists.Items)
                {
                    if (!LeagueSharp.Common.Items.HasItem(item.Id)) 
                        continue;

                    if (!Lists.BoughtItems.Contains(item))
                    {
                        Game.OnUpdate += item.OnTick;
                        Lists.BoughtItems.Add(item);
                        Game.PrintChat("<b>Activator#</b> - <font color=\"#FFF280\">" + item.Name + "</font> active!");
                    }
                }

                foreach (var summoner in Lists.Summoners)
                    if (summoner.Slot != SpellSlot.Unknown ||
                        summoner.ExtraNames.Any(x => Player.GetSpellSlot(x) != SpellSlot.Unknown))
                        Game.OnUpdate += summoner.OnTick;

                Utility.DelayAction.Add(3000, CheckEvade);
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                Game.PrintChat("Fatal error loading Activator!");
            }
        }

        private static void Obj_AI_Base_OnPlaceItemInSlot(Obj_AI_Base sender, Obj_AI_BasePlaceItemInSlotEventArgs args)
        {
            if (!sender.IsMe)
                return;

            foreach (var item in Lists.Items)
            {
                if (item.Id == (int) args.Id)
                {
                    if (!Lists.BoughtItems.Contains(item))
                    {
                        Game.OnUpdate += item.OnTick;
                        Lists.BoughtItems.Add(item);
                        Game.PrintChat("<b>Activator#</b> - <font color=\"#FFF280\">" + item.Name + "</font> active!");
                    }
                }
            }
        }

        private static void NewItem(CoreItem item, Menu parent)
        {
            if (item.Maps.Contains((MapType) MapId) ||
                item.Maps.Contains(MapType.Common))
            {
                Lists.Items.Add(item.CreateMenu(parent));
            }
        }

        private static void NewSpell(CoreSpell spell, Menu parent)
        {
            if (Player.GetSpellSlot(spell.Name) != SpellSlot.Unknown)
                Lists.Spells.Add(spell.CreateMenu(parent));
        }

        private static void NewSummoner(CoreSum summoner, Menu parent)
        {
            if (!summoner.Name.Contains("smite") && 
                Player.GetSpellSlot(summoner.Name) != SpellSlot.Unknown)
                Lists.Summoners.Add(summoner.CreateMenu(parent));

            if (summoner.Name.Contains("smite") && SmiteInGame)
                Lists.Summoners.Add(summoner.CreateMenu(parent));
        }

        private static List<Type> GetItemGroup(string nspace)
        {
            return
                Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .FindAll(t => t.IsClass && t.Namespace == "Activator." + nspace &&
                                  t.Name != "CoreItem" && t.Name != "CoreSpell" && t.Name != "CoreSum" &&
                                 !t.Name.Contains("c__")); // kek
        }

        private static void GetComboDamage()
        {
            foreach (KeyValuePair<string, List<DamageSpell>> entry in Damage.Spells)
            {
                if (entry.Key == Player.ChampionName)
                    foreach (DamageSpell spell in entry.Value)
                        Data.SpellData.DamageLib.Add(spell.Damage, spell.Slot);          
            }
        }

        private static void GetHeroesInGame()
        {
            foreach (var i in ObjectManager.Get<Obj_AI_Hero>().Where(i => i.Team == Player.Team))
                Heroes.Add(new Champion(i, 0));

            foreach (var i in ObjectManager.Get<Obj_AI_Hero>().Where(i => i.Team != Player.Team))
                Heroes.Add(new Champion(i, 0));
        }

        private static void GetSmiteSlot()
        {
            if (Player.GetSpell(SpellSlot.Summoner1).Name.ToLower().Contains("smite"))
            {
                SmiteInGame = true;
                Smite = SpellSlot.Summoner1;
            }

            if (Player.GetSpell(SpellSlot.Summoner2).Name.ToLower().Contains("smite"))
            {
                SmiteInGame = true;
                Smite = SpellSlot.Summoner2;
            }
        }

        private static void GetTroysInGame()
        {
            foreach (var i in ObjectManager.Get<Obj_AI_Hero>().Where(h => h.Team != Player.Team))
            {
                foreach (var item in GameTroyData.Troys.Where(x => x.ChampionName == i.ChampionName))
                {
                    TroysInGame = true;
                    Gametroy.Troys.Add(new Gametroy(i, item.Slot, item.Name, 0, false));
                }
            }
        }

        public static IEnumerable<Champion> Allies()
        {
            switch (Origin.Item("healthp").GetValue<StringList>().SelectedIndex)
            {
                case 0:
                    return Heroes.Where(h => h.Player.IsAlly)
                        .OrderBy(h => h.Player.Health / h.Player.MaxHealth * 100);
                case 1:
                    return Heroes.Where(h => h.Player.IsAlly)
                        .OrderByDescending(h => h.Player.FlatPhysicalDamageMod + h.Player.FlatMagicDamageMod);
                case 2:
                    return Heroes.Where(h => h.Player.IsAlly)
                        .OrderByDescending(h => h.Player.Health);
            }

            return null;
        }

        private static void SubMenu(Menu parent, bool enemy, bool both = false)
        {
            var menu = new Menu("Config", parent.Name + "sub");

            foreach (var hero in both ? HeroManager.AllHeroes : enemy ? HeroManager.Enemies : HeroManager.Allies)
            {
                var side = hero.Team == Player.Team ? "[Ally]" : "[Enemy]";
                menu.AddItem(new MenuItem(parent.Name + "useon" + hero.ChampionName,
                    "Use for " + hero.ChampionName + " " + side).DontSave()).SetValue(true);
            }

            parent.AddSubMenu(menu);
        }

        // here we will level up our spellslot r only once!
        private static void Obj_AI_Base_OnLevelUp(Obj_AI_Base sender, EventArgs args)
        {
            var hero = sender as Obj_AI_Hero;
            if (hero == null)
                return;

            if (!hero.IsMe)
                return;

            if (hero.ChampionName == "Jayce" ||
                hero.ChampionName == "Udyr" ||
                hero.ChampionName == "Elise")
                return;

            switch (Player.Level)
            {
                case 6:
                    Player.Spellbook.LevelSpell(SpellSlot.R);
                    break;
            }
        }

        private static void LoadEvadeMenu(Menu parent)
        {
            foreach (var unit in Heroes.Where(h => h.Player.Team != Player.Team))
            {
                var menu = new Menu(unit.Player.ChampionName, unit.Player.NetworkId + "menu");

                // new menu per spell
                foreach (var entry in Data.SpellData.Spells)
                {
                    if (entry.ChampionName == unit.Player.ChampionName.ToLower())
                    {                           
                        var newmenu = new Menu(entry.SDataName, entry.SDataName);
                        
                        // activation parameters
                        newmenu.AddItem(new MenuItem(entry.SDataName + "predict", "enabled").DontSave())
                            .SetValue(entry.CastRange != 0f);
                        newmenu.AddItem(new MenuItem(entry.SDataName + "danger", "danger").DontSave())
                            .SetValue(entry.HitType.Contains(HitType.Danger));
                        newmenu.AddItem(new MenuItem(entry.SDataName + "crowdcontrol", "crowdcontrol").DontSave())
                            .SetValue(entry.HitType.Contains(HitType.CrowdControl));
                        newmenu.AddItem(new MenuItem(entry.SDataName + "ultimate", "danger ultimate").DontSave())
                            .SetValue(entry.HitType.Contains(HitType.Ultimate));
                        newmenu.AddItem(new MenuItem(entry.SDataName + "forceexhaust", "force exhuast").DontSave())
                            .SetValue(entry.HitType.Contains(HitType.ForceExhaust));
                        menu.AddSubMenu(newmenu);
                    }
                }

                parent.AddSubMenu(menu);
            }
        }

        private static void CheckEvade()
        {
            if (Menu.GetMenu("ezEvade", "ezEvade") != null)         
                Origin.Item("evade").SetValue(true);

            if (Menu.GetMenu("Evade", "Evade") != null)         
                Origin.Item("evade").SetValue(true);

            if (Menu.GetMenu("Evade", "Evade") == null &&
                Menu.GetMenu("ezEvade", "ezEvade") == null)            
                Origin.Item("evade").SetValue(false);
        }

        private static object NewInstance(Type type)
        {
            var target = type.GetConstructor(Type.EmptyTypes);
            var dynamic = new DynamicMethod(string.Empty, type, new Type[0], target.DeclaringType);
            var il = dynamic.GetILGenerator();

            il.DeclareLocal(target.DeclaringType);
            il.Emit(OpCodes.Newobj, target);
            il.Emit(OpCodes.Stloc_0);
            il.Emit(OpCodes.Ldloc_0);
            il.Emit(OpCodes.Ret);

            var method = (Func<object>) dynamic.CreateDelegate(typeof (Func<object>));
            return method();
        }
    }
}