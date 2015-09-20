#region Copyright © 2015 Kurisu Solutions
// All rights are reserved. Transmission or reproduction in part or whole,
// any form or by any means, mechanical, electronical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Document:	activator/spelldata.cs
// Date:		01/07/2015
// Author:		Robin Kurisu
#endregion

using LeagueSharp;
using LeagueSharp.Common;
using Activator.Items;
using Activator.Spells;
using Activator.Summoners;
using System.Collections.Generic;
using System.Linq;
using Activator.Handlers;

namespace Activator.Data
{
    public class SpellData
    {
        public string SDataName { get; set; }
        public string ChampionName { get; set; }
        public SpellSlot Slot { get; set; }
        public float CastRange { get; set; }
        public bool Global { get; set; }
        public float Delay { get; set; }
        public string MissileName { get; set; }
        public string[] ExtraMissileNames { get; set; }
        public int MissileSpeed { get; set; }
        public string[] FromObject { get; set; }
        public HitType[] HitType { get; set; }

        public static List<SpellData> Spells = new List<SpellData>();
        public static Dictionary<SpellDamageDelegate, SpellSlot> DamageLib = new Dictionary<SpellDamageDelegate, SpellSlot>();


        static SpellData()
        {
            Spells.Add(new SpellData
            {
                SDataName = "aatroxq",
                ChampionName = "aatrox",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "aatroxw",
                ChampionName = "aatrox",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "aatroxw2",
                ChampionName = "aatrox",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "aatroxe",
                ChampionName = "aatrox",
                Slot = SpellSlot.E,
                CastRange = 1025f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "aatroxeconemissile",
                MissileSpeed = 1250
            });

            Spells.Add(new SpellData
            {
                SDataName = "aatroxr",
                ChampionName = "aatrox",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "ahriorbofdeception",
                ChampionName = "ahri",
                Slot = SpellSlot.Q,
                CastRange = 880f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "ahriorbmissile",
                ExtraMissileNames = new [] { "ahriorbreturn" },
                MissileSpeed = 1450
            });

            Spells.Add(new SpellData
            {
                SDataName = "ahrifoxfire",
                ChampionName = "ahri",
                Slot = SpellSlot.W,
                CastRange = 550f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1800
            });

            Spells.Add(new SpellData
            {
                SDataName = "ahriseduce",
                ChampionName = "ahri",
                Slot = SpellSlot.E,
                CastRange = 975f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileName = "ahriseducemissile",
                MissileSpeed = 1550
            });

            Spells.Add(new SpellData
            {
                SDataName = "ahritumble",
                ChampionName = "ahri",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new SpellData
            {
                SDataName = "akalimota",
                ChampionName = "akali",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 650f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new SpellData
            {
                SDataName = "akalismokebomb",
                ChampionName = "akali",
                Slot = SpellSlot.W,
                CastRange = 1000f, // Range: 700 + additional for stealth detection
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "akalishadowswipe",
                ChampionName = "akali",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "akalishadowdance",
                ChampionName = "akali",
                Slot = SpellSlot.R,
                CastRange = 710f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new SpellData
            {
                SDataName = "pulverize",
                ChampionName = "alistar",
                Slot = SpellSlot.Q,
                CastRange = 365f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "headbutt",
                ChampionName = "alistar",
                Slot = SpellSlot.W,
                CastRange = 650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "triumphantroar",
                ChampionName = "alistar",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "feroucioushowl",
                ChampionName = "alistar",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 828
            });

            Spells.Add(new SpellData
            {
                SDataName = "bandagetoss",
                ChampionName = "amumu",
                Slot = SpellSlot.Q,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileName = "sadmummybandagetoss",
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "auraofdespair",
                ChampionName = "amumu",
                Slot = SpellSlot.W,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "tantrum",
                ChampionName = "amumu",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 150f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "curseofthesadmummy",
                ChampionName = "amumu",
                Slot = SpellSlot.R,
                CastRange = 550f,
                Delay = 150f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "flashfrost",
                ChampionName = "anivia",
                Slot = SpellSlot.Q,
                CastRange = 1150f, // 1075 + Shatter Radius
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "flashfrostspell",
                MissileSpeed = 850
            });

            Spells.Add(new SpellData
            {
                SDataName = "crystalize",
                ChampionName = "anivia",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "frostbite",
                ChampionName = "anivia",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = 1450
            });

            Spells.Add(new SpellData
            {
                SDataName = "glacialstorm",
                ChampionName = "anivia",
                Slot = SpellSlot.R,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "disintegrate",
                ChampionName = "annie",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new [] { Handlers.HitType.Danger },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "incinerate",
                ChampionName = "annie",
                Slot = SpellSlot.W,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "moltenshield",
                ChampionName = "annie",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "infernalguardian",
                ChampionName = "annie",
                Slot = SpellSlot.R,
                CastRange = 890f, // 600 + Cast Radius
                Delay = 0f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "frostshot",
                ChampionName = "ashe",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "frostarrow",
                ChampionName = "ashe",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 0f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "volley",
                ChampionName = "ashe",
                Slot = SpellSlot.W,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "volleyattack",
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "ashespiritofthehawk",
                ChampionName = "ashe",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "enchantedcrystalarrow",
                ChampionName = "ashe",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileName = "enchantedcrystalarrow",
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "azirq",
                ChampionName = "azir",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitType = new[] {Handlers.HitType.CrowdControl },
                MissileName = "azirsoldiermissile",
                FromObject = new []{ "AzirSoldier" },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "azirr",
                ChampionName = "azir",
                Slot = SpellSlot.R,
                CastRange = 475f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "bardq",
                ChampionName = "bard",
                Slot = SpellSlot.Q,
                CastRange = 950f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "bardqmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "bardw",
                ChampionName = "bard",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1450
            });

            Spells.Add(new SpellData
            {
                SDataName = "barde",
                ChampionName = "bard",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 350f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "bardr",
                ChampionName = "bard",
                Slot = SpellSlot.R,
                CastRange = 3400f,
                Delay = 450f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "bardr",
                MissileSpeed = 2100
            });

            Spells.Add(new SpellData
            {
                SDataName = "rocketgrabmissile",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl, Handlers.HitType.Danger },
                MissileSpeed = 1800
            });

            Spells.Add(new SpellData
            {
                SDataName = "overdrive",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "powerfist",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.E,
                CastRange = 100f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "staticfield",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "brandblaze",
                ChampionName = "brand",
                Slot = SpellSlot.Q,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "brandblazemissile",
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "brandfissure",
                ChampionName = "brand",
                Slot = SpellSlot.W,
                CastRange = 240f,
                Delay = 550f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileName = "",
                MissileSpeed = 20
            });

            Spells.Add(new SpellData
            {
                SDataName = "brandconflagration",
                ChampionName = "brand",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "brandwildfire",
                ChampionName = "brand",
                Slot = SpellSlot.R,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileSpeed = 1000
            });

            Spells.Add(new SpellData
            {
                SDataName = "braumq",
                ChampionName = "braum",
                Slot = SpellSlot.Q,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileName = "braumqmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "braumqmissle",
                ChampionName = "braum",
                Slot = SpellSlot.Q,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "braumw",
                ChampionName = "braum",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "braume",
                ChampionName = "braum",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "braumrwrapper",
                ChampionName = "braum",
                Slot = SpellSlot.R,
                CastRange = 1250f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileName = "braumrmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "caitlynpiltoverpeacemaker",
                ChampionName = "caitlyn",
                Slot = SpellSlot.Q,
                CastRange = 2000f,
                Delay = 625f,
                HitType = new HitType[] { },
                MissileName = "caitlynpiltoverpeacemaker",
                MissileSpeed = 2200
            });

            Spells.Add(new SpellData
            {
                SDataName = "caitlynyordletrap",
                ChampionName = "caitlyn",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 550f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "caitlynentrapment",
                ChampionName = "caitlyn",
                Slot = SpellSlot.E,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "caitlynentrapmentmissile",
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "cassiopeianoxiousblast",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.Q,
                CastRange = 925f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "cassiopeianoxiousblast",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "cassiopeiamiasma",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.W,
                CastRange = 925f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 2500
            });

            Spells.Add(new SpellData
            {
                SDataName = "cassiopeiatwinfang",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1900
            });

            Spells.Add(new SpellData
            {
                SDataName = "cassiopeiapetrifyinggaze",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.R,
                CastRange = 875f,
                Delay = 350f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileName = "cassiopeiapetrifyinggaze",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "rupture",
                ChampionName = "chogath",
                Slot = SpellSlot.Q,
                CastRange = 950f,
                Delay = 1000f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileName = "rupture",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "feralscream",
                ChampionName = "chogath",
                Slot = SpellSlot.W,
                CastRange = 675f,
                Delay = 175f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "vorpalspikes",
                ChampionName = "chogath",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 347
            });

            Spells.Add(new SpellData
            {
                SDataName = "feast",
                ChampionName = "chogath",
                Slot = SpellSlot.R,
                CastRange = 500f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "phosphorusbomb",
                ChampionName = "corki",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "phosphorusbombmissile",
                MissileSpeed = 1125
            });

            Spells.Add(new SpellData
            {
                SDataName = "carpetbomb",
                ChampionName = "corki",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 700
            });

            Spells.Add(new SpellData
            {
                SDataName = "ggun",
                ChampionName = "corki",
                Slot = SpellSlot.E,
                CastRange = 750f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "missilebarrage",
                ChampionName = "corki",
                Slot = SpellSlot.R,
                CastRange = 1225f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "missilebarragemissile",
                MissileSpeed = 828
            });

            Spells.Add(new SpellData
            {
                SDataName = "dariuscleave",
                ChampionName = "darius",
                Slot = SpellSlot.Q,
                CastRange = 425f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "dariusnoxiantacticsonh",
                ChampionName = "darius",
                Slot = SpellSlot.W,
                CastRange = 205f,
                Delay = 150f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "dariusaxegrabcone",
                ChampionName = "darius",
                Slot = SpellSlot.E,
                CastRange = 555f,
                Delay = 150f,
                HitType = new[] { Handlers.HitType.CrowdControl, Handlers.HitType.Danger },
                MissileName = "dariusaxegrabcone",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "dariusexecute",
                ChampionName = "darius",
                Slot = SpellSlot.R,
                CastRange = 465f,
                Delay = 450f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "dianaarc",
                ChampionName = "diana",
                Slot = SpellSlot.Q,
                CastRange = 830f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileName = "dianaarc",
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "dianaorbs",
                ChampionName = "diana",
                Slot = SpellSlot.W,
                CastRange = 200f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "dianavortex",
                ChampionName = "diana",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl, Handlers.HitType.Danger,  },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "dianateleport",
                ChampionName = "diana",
                Slot = SpellSlot.R,
                CastRange = 825f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = 2200
            });

            Spells.Add(new SpellData
            {
                SDataName = "dravenspinning",
                ChampionName = "draven",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "dravenfury",
                ChampionName = "draven",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "dravendoubleshot",
                ChampionName = "draven",
                Slot = SpellSlot.E,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "dravendoubleshotmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "dravenrcast",
                ChampionName = "draven",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 500f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileName = "dravenr",
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "infectedcleavermissilecast",
                ChampionName = "drmundo",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "infectedcleavermissile",
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "burningagony",
                ChampionName = "drmundo",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "masochism",
                ChampionName = "drmundo",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "sadism",
                ChampionName = "drmundo",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "ekkoq",
                ChampionName = "ekko",
                Slot = SpellSlot.Q,
                CastRange = 1075f,
                Delay = 66f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "ekkoqmis",
                ExtraMissileNames = new []{ "ekkoqreturn" },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "ekkoeattack",
                ChampionName = "ekko",
                Slot = SpellSlot.E,
                CastRange = 300f,
                Delay = 0f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

             Spells.Add(new SpellData
             {
                 SDataName = "ekkor",
                 ChampionName = "ekko",
                 Slot = SpellSlot.R,
                 CastRange = 425f,
                 Delay = 250f,
                 HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                 FromObject = new [] { "Ekko_Base_R_TrailEnd" },
                 MissileSpeed = int.MaxValue
             });

            Spells.Add(new SpellData
            {
                SDataName = "elisehumanq",
                ChampionName = "elise",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 550f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new SpellData
            {
                SDataName = "elisespiderqcast",
                ChampionName = "elise",
                Slot = SpellSlot.Q,
                CastRange = 475f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "elisehumanw",
                ChampionName = "elise",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = 5000
            });

            Spells.Add(new SpellData
            {
                SDataName = "elisespiderw",
                ChampionName = "elise",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "elisehumane",
                ChampionName = "elise",
                Slot = SpellSlot.E,
                CastRange = 1075f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl, Handlers.HitType.Danger },
                MissileName = "elisehumane",
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "elisespidereinitial",
                ChampionName = "elise",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "elisespideredescent",
                ChampionName = "elise",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "eliser",
                ChampionName = "elise",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "elisespiderr",
                ChampionName = "elise",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "evelynnq",
                ChampionName = "evelynn",
                Slot = SpellSlot.Q,
                CastRange = 500f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "evelynnw",
                ChampionName = "evelynn",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "evelynne",
                ChampionName = "evelynn",
                Slot = SpellSlot.E,
                CastRange = 225f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "evelynnr",
                ChampionName = "evelynn",
                Slot = SpellSlot.R,
                CastRange = 900f, // 650f + Radius
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileName = "evelynnr",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "ezrealmysticshot",
                ChampionName = "ezreal",
                Slot = SpellSlot.Q,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger  },
                MissileName = "ezrealmysticshotmissile",
                ExtraMissileNames = new[] { "ezrealmysticshotpulsemissile" },
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "ezrealessenceflux",
                ChampionName = "ezreal",
                Slot = SpellSlot.W,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "ezrealessencefluxmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "ezrealessencemissle",
                ChampionName = "ezreal",
                Slot = SpellSlot.W,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "ezrealarcaneshift",
                ChampionName = "ezreal",
                Slot = SpellSlot.E,
                CastRange = 750f, // 475f + Bolt Range
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "ezrealtrueshotbarrage",
                ChampionName = "ezreal",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 1000f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileName = "ezrealtrueshotbarrage",
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "terrify",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.Q,
                CastRange = 575f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "drain",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.W,
                CastRange = 575f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "fiddlesticksdarkwind",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.E,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1100
            });

            Spells.Add(new SpellData
            {
                SDataName = "crowstorm",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.R,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.ForceExhaust },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "fioraq",
                ChampionName = "fiora",
                Slot = SpellSlot.Q,
                CastRange = 400f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new SpellData
            {
                SDataName = "fioraw",
                ChampionName = "fiora",
                Slot = SpellSlot.W,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "fiorae",
                ChampionName = "fiora",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "fiorar",
                ChampionName = "fiora",
                Slot = SpellSlot.R,
                CastRange = 500f,
                Delay = 150f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "fizzpiercingstrike",
                ChampionName = "fizz",
                Slot = SpellSlot.Q,
                CastRange = 550f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1900
            });

            Spells.Add(new SpellData
            {
                SDataName = "fizzseastonepassive",
                ChampionName = "fizz",
                Slot = SpellSlot.W,
                CastRange = 175f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "fizzjump",
                ChampionName = "fizz",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 700f,
                HitType = new[] { Handlers.HitType.CrowdControl  },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "fizzjumpbuffer",
                ChampionName = "fizz",
                Slot = SpellSlot.E,
                CastRange = 330f,
                Delay = 0f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "fizzjumptwo",
                ChampionName = "fizz",
                Slot = SpellSlot.E,
                CastRange = 270f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue 
            });

            Spells.Add(new SpellData
            {
                SDataName = "fizzmarinerdoom",
                ChampionName = "fizz",
                Slot = SpellSlot.R,
                CastRange = 1275f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "fizzmarinerdoommissile",
                MissileSpeed = 1350
            });

            Spells.Add(new SpellData
            {
                SDataName = "galioresolutesmite",
                ChampionName = "galio",
                Slot = SpellSlot.Q,
                CastRange = 1040f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "galioresolutesmite",
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "galiobulwark",
                ChampionName = "galio",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "galiorighteousgust",
                ChampionName = "galio",
                Slot = SpellSlot.E,
                CastRange = 1280f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "galiorighteousgust",
                MissileSpeed = 1300
            });

            Spells.Add(new SpellData
            {
                SDataName = "galioidolofdurand",
                ChampionName = "galio",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 0f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "gangplankqwrapper",
                ChampionName = "gangplank",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "gangplankqproceed",
                ChampionName = "gangplank",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "gangplankw",
                ChampionName = "gangplank",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "gangplanke",
                ChampionName = "gangplank",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "gangplankr",
                ChampionName = "gangplank",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new SpellData
            {
                SDataName = "garenq",
                ChampionName = "garen",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "garenqattack",
                ChampionName = "garen",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 0f,
                HitType = new[] { Handlers.HitType.CrowdControl, Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });


            Spells.Add(new SpellData
            {
                SDataName = "gnarq",
                ChampionName = "gnar",
                Slot = SpellSlot.Q,
                CastRange = 1185f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 2400,
                MissileName = "gnarqmissile",
                ExtraMissileNames = new[] { "gnarqmissilereturn" }
            });


            Spells.Add(new SpellData
            {
                SDataName = "gnarbigq",
                ChampionName = "gnar",
                Slot = SpellSlot.Q,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 2000,
                MissileName = "gnarbigqmissile"
            });

            Spells.Add(new SpellData
            {
                SDataName = "gnarbigw",
                ChampionName = "gnar",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 600f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "gnarult",
                ChampionName = "gnar",
                CastRange = 600f, // 590f + 10 Better safe than sorry. :)
                Slot = SpellSlot.R,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },

                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "garenw",
                ChampionName = "garen",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "garene",
                ChampionName = "garen",
                Slot = SpellSlot.E,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "garenr",
                ChampionName = "garen",
                Slot = SpellSlot.R,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "gragasq",
                ChampionName = "gragas",
                Slot = SpellSlot.Q,
                CastRange = 1000, // 850f + Radius
                Delay = 500f,
                HitType = new HitType[] { },
                MissileName = "gragasqmissile",
                MissileSpeed = 1000
            });

            Spells.Add(new SpellData
            {
                SDataName = "gragasqtoggle",
                ChampionName = "gragas",
                Slot = SpellSlot.Q,
                CastRange = 1100f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "gragasw",
                ChampionName = "gragas",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "gragase",
                ChampionName = "gragas",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 200f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileName = "gragase",
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "gragasr",
                ChampionName = "gragas",
                Slot = SpellSlot.R,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileName = "gragasrboom",
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "gravesclustershot",
                ChampionName = "graves",
                Slot = SpellSlot.Q,
                CastRange = 1025,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "gravesclustershotattack",
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "gravessmokegrenade",
                ChampionName = "graves",
                Slot = SpellSlot.W,
                CastRange = 1100f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileSpeed = 1650
            });

            Spells.Add(new SpellData
            {
                SDataName = "gravessmokegrenadeboom",
                ChampionName = "graves",
                Slot = SpellSlot.W,
                CastRange = 1100f, // 950 + Radius
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1350
            });

            Spells.Add(new SpellData
            {
                SDataName = "gravesmove",
                ChampionName = "graves",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new SpellData
            {
                SDataName = "graveschargeshot",
                ChampionName = "graves",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileName = "graveschargeshotshot",
                MissileSpeed = 2100
            });

            Spells.Add(new SpellData
            {
                SDataName = "hecarimrapidslash",
                ChampionName = "hecarim",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new SpellData
            {
                SDataName = "hecarimw",
                ChampionName = "hecarim",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "hecarimramp",
                ChampionName = "hecarim",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "hecarimult",
                ChampionName = "hecarim",
                Slot = SpellSlot.R,
                CastRange = 1350f,
                Delay = 50f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "heimerdingerq",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "heimerdingerw",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.W,
                CastRange = 1100,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "heimerdingere",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.E,
                CastRange = 1025f, // 925 + Radius
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "heimerdingerespell",
                MissileSpeed = 1450
            });

            Spells.Add(new SpellData
            {
                SDataName = "heimerdingerr",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 230f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "heimerdingereult",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.E,
                CastRange = 1250f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1450
            });

            Spells.Add(new SpellData
            {
                SDataName = "ireliagatotsu",
                ChampionName = "irelia",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 150f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new SpellData
            {
                SDataName = "ireliahitenstyle",
                ChampionName = "irelia",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 230f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "ireliaequilibriumstrike",
                ChampionName = "irelia",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "ireliatranscendentblades",
                ChampionName = "irelia",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "ireliatranscendentblades",
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "howlinggale",
                ChampionName = "janna",
                Slot = SpellSlot.Q,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "sowthewind",
                ChampionName = "janna",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "eyeofthestorm",
                ChampionName = "janna",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "reapthewhirlwind",
                ChampionName = "janna",
                Slot = SpellSlot.R,
                CastRange = 725f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "jarvanivdragonstrike",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.Q,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "jarvanivgoldenaegis",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "jarvanivdemacianstandard",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.E,
                CastRange = 830f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "jarvanivdemacianstandard",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "jarvanivcataclysm",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.R,
                CastRange = 650f,
                Delay = 500f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "jaxleapstrike",
                ChampionName = "jax",
                Slot = SpellSlot.Q,
                CastRange = 210f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = 2200
            });

            Spells.Add(new SpellData
            {
                SDataName = "jaxempowertwo",
                ChampionName = "jax",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "jaxrelentlessasssault",
                ChampionName = "jax",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "jaycetotheskies",
                ChampionName = "jayce",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl, Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "jayceshockblast",
                ChampionName = "jayce",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl, Handlers.HitType.Danger },
                MissileName = "jayceshockblastmis",
                MissileSpeed = 2200
            });

            Spells.Add(new SpellData
            {
                SDataName = "jaycestaticfield",
                ChampionName = "jayce",
                Slot = SpellSlot.W,
                CastRange = 285f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "jaycehypercharge",
                ChampionName = "jayce",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "jaycethunderingblow",
                ChampionName = "jayce",
                Slot = SpellSlot.E,
                CastRange = 300f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "jayceaccelerationgate",
                ChampionName = "jayce",
                Slot = SpellSlot.E,
                CastRange = 685f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "jaycestancehtg",
                ChampionName = "jayce",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "jaycestancegth",
                ChampionName = "jayce",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "jinxq",
                ChampionName = "jinx",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "jinxw",
                ChampionName = "jinx",
                Slot = SpellSlot.W,
                CastRange = 1550f,
                Delay = 550f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "jinxwmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "jinxwmissle",
                ChampionName = "jinx",
                Slot = SpellSlot.W,
                CastRange = 1550f,
                Delay = 500f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "jinxe",
                ChampionName = "jinx",
                Slot = SpellSlot.E,
                CastRange = 900f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1000
            });

            Spells.Add(new SpellData
            {
                SDataName = "jinxr",
                ChampionName = "jinx",
                Slot = SpellSlot.R,
                CastRange = 25000f,
                Global = true,
                Delay = 600f,
                MissileName = "jinxr",
                ExtraMissileNames = new [] { "jinxrwrapper" },
                HitType = new [] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileSpeed = 1700
            });

            Spells.Add(new SpellData
            {
                SDataName = "karmaq",
                ChampionName = "karma",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileName = "karmaqmissile",
                MissileSpeed = 1800
            });

            Spells.Add(new SpellData
            {
                SDataName = "karmaspiritbind",
                ChampionName = "karma",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "karmasolkimshield",
                ChampionName = "karma",
                Slot = SpellSlot.E,
                CastRange = 800f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "karmamantra",
                ChampionName = "karma",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1300
            });

            Spells.Add(new SpellData
            {
                SDataName = "laywaste",
                ChampionName = "karthus",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitType = new HitType[] { },
                ExtraMissileNames = new[]  {
                            "karthuslaywastea3", "karthuslaywastea1", "karthuslaywastedeada1", "karthuslaywastedeada2",
                            "karthuslaywastedeada3"
                        },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "wallofpain",
                ChampionName = "karthus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "defile",
                ChampionName = "karthus",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new SpellData
            {
                SDataName = "fallenone",
                ChampionName = "karthus",
                Slot = SpellSlot.R,
                CastRange = 22000f,
                Global = true,
                Delay = 2800f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "nulllance",
                ChampionName = "kassadin",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl, Handlers.HitType.Danger },
                MissileSpeed = 1900
            });

            Spells.Add(new SpellData
            {
                SDataName = "netherblade",
                ChampionName = "kassadin",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "forcepulse",
                ChampionName = "kassadin",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl, Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "riftwalk",
                ChampionName = "kassadin",
                Slot = SpellSlot.R,
                CastRange = 675f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "riftwalk",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "katarinaq",
                ChampionName = "katarina",
                Slot = SpellSlot.Q,
                CastRange = 675f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1800
            });

            Spells.Add(new SpellData
            {
                SDataName = "katarinaw",
                ChampionName = "katarina",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1800
            });

            Spells.Add(new SpellData
            {
                SDataName = "katarinae",
                ChampionName = "katarina",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "katarinar",
                ChampionName = "katarina",
                Slot = SpellSlot.R,
                CastRange = 550f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.ForceExhaust },
                MissileSpeed = 1450
            });

            Spells.Add(new SpellData
            {
                SDataName = "judicatorreckoning",
                ChampionName = "kayle",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "judicatordevineblessing",
                ChampionName = "kayle",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 220f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "judicatorrighteousfury",
                ChampionName = "kayle",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "judicatorintervention",
                ChampionName = "kayle",
                Slot = SpellSlot.R,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "kennenshurikenhurlmissile1",
                ChampionName = "kennen",
                Slot = SpellSlot.Q,
                CastRange = 1175f,
                Delay = 180f,
                HitType = new HitType[] { },
                MissileName = "kennenshurikenhurlmissile1",
                MissileSpeed = 1700
            });

            Spells.Add(new SpellData
            {
                SDataName = "kennenbringthelight",
                ChampionName = "kennen",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "kennenlightningrush",
                ChampionName = "kennen",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "kennenshurikenstorm",
                ChampionName = "kennen",
                Slot = SpellSlot.R,
                CastRange = 550f,
                Delay = 500f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "khazixq",
                ChampionName = "khazix",
                Slot = SpellSlot.Q,
                CastRange = 325f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "khazixqlong",
                ChampionName = "khazix",
                Slot = SpellSlot.Q,
                CastRange = 375f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "khazixw",
                ChampionName = "khazix",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "khazixwmissile",
                MissileSpeed = 81700
            });

            Spells.Add(new SpellData
            {
                SDataName = "khazixwlong",
                ChampionName = "khazix",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1700
            });

            Spells.Add(new SpellData
            {
                SDataName = "khazixe",
                ChampionName = "khazix",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "khazixe",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "khazixelong",
                ChampionName = "khazix",
                Slot = SpellSlot.E,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "khazixr",
                ChampionName = "khazix",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 0f,
                HitType = new [] { Handlers.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "khazixrlong",
                ChampionName = "khazix",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 0f,
                HitType = new[] { Handlers.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "kogmawcausticspittle",
                ChampionName = "kogmaw",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "kogmawbioarcanbarrage",
                ChampionName = "kogmaw",
                Slot = SpellSlot.W,
                CastRange = 130f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "kogmawvoidooze",
                ChampionName = "kogmaw",
                Slot = SpellSlot.E,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "kogmawvoidoozemissile",
                MissileSpeed = 1250
            });

            Spells.Add(new SpellData
            {
                SDataName = "kogmawlivingartillery",
                ChampionName = "kogmaw",
                Slot = SpellSlot.R,
                CastRange = 2200f,
                Delay = 1200f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileName = "kogmawlivingartillery",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "leblancchaosorb",
                ChampionName = "leblanc",
                Slot = SpellSlot.Q,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "leblancslide",
                ChampionName = "leblanc",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileName = "leblancslide",
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "leblacslidereturn",
                ChampionName = "leblanc",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "leblancsoulshackle",
                ChampionName = "leblanc",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "leblancsoulshackle",
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "leblancchaosorbm",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "leblancslidem",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileName = "leblancslidem",
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "leblancslidereturnm",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "leblancsoulshacklem",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                CastRange = 925f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "leblancsoulshacklem",
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "blindmonkqone",
                ChampionName = "leesin",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileName = "blindmonkqone",
                MissileSpeed = 1800
            });

            Spells.Add(new SpellData
            {
                SDataName = "blindmonkqtwo",
                ChampionName = "leesin",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "blindmonkwone",
                ChampionName = "leesin",
                Slot = SpellSlot.W,
                CastRange = 700f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "blindmonkwtwo",
                ChampionName = "leesin",
                Slot = SpellSlot.W,
                CastRange = 700f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "blindmonkeone",
                ChampionName = "leesin",
                Slot = SpellSlot.E,
                CastRange = 425f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "blindmonketwo",
                ChampionName = "leesin",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 0f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "blindmonkrkick",
                ChampionName = "leesin",
                Slot = SpellSlot.R,
                CastRange = 375f,
                Delay = 500f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "leonashieldofdaybreak",
                ChampionName = "leona",
                Slot = SpellSlot.Q,
                CastRange = 215f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "leonasolarbarrier",
                ChampionName = "leona",
                Slot = SpellSlot.W,
                CastRange = 250f,
                Delay = 3000f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "leonazenithblade",
                ChampionName = "leona",
                Slot = SpellSlot.E,
                CastRange = 900f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileName = "leonazenithblademissile",
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "leonasolarflare",
                ChampionName = "leona",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 550f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileName = "leonasolarflare",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "lissandraq",
                ChampionName = "lissandra",
                Slot = SpellSlot.Q,
                CastRange = 725f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "lissandraqmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "lissandraw",
                ChampionName = "lissandra",
                Slot = SpellSlot.W,
                CastRange = 450f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "lissandrae",
                ChampionName = "lissandra",
                Slot = SpellSlot.E,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "lissandraemissile",
                MissileSpeed = 850
            });

            Spells.Add(new SpellData
            {
                SDataName = "lissandrar",
                ChampionName = "lissandra",
                Slot = SpellSlot.R,
                CastRange = 550f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "lucianq",
                ChampionName = "lucian",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileName = "lucianq",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "lucianw",
                ChampionName = "lucian",
                Slot = SpellSlot.W,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "lucianwmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "luciane",
                ChampionName = "lucian",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "lucianr",
                ChampionName = "lucian",
                Slot = SpellSlot.R,
                CastRange = 1400f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileName  = "lucianrmissileoffhand",
                ExtraMissileNames = new[] { "lucianrmissile" },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "luluq",
                ChampionName = "lulu",
                Slot = SpellSlot.Q,
                CastRange = 925f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "luluqmissile",
                MissileSpeed = 1450
            });

            Spells.Add(new SpellData
            {
                SDataName = "luluw",
                ChampionName = "lulu",
                Slot = SpellSlot.W,
                CastRange = 650f,
                Delay = 640f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "lulue",
                ChampionName = "lulu",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 640f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "lulur",
                ChampionName = "lulu",
                Slot = SpellSlot.R,
                CastRange = 900f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "luxlightbinding",
                ChampionName = "lux",
                Slot = SpellSlot.Q,
                CastRange = 1300f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileName = "luxlightbindingmis",
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "luxprismaticwave",
                ChampionName = "lux",
                Slot = SpellSlot.W,
                CastRange = 1075f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "luxlightstrikekugel",
                ChampionName = "lux",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "luxlightstrikekugel",
                MissileSpeed = 1300
            });

            Spells.Add(new SpellData
            {
                SDataName = "luxlightstriketoggle",
                ChampionName = "lux",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "luxmalicecannon",
                ChampionName = "lux",
                Slot = SpellSlot.R,
                CastRange = 3340f,
                Delay = 1750f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileName = "luxmalicecannonmis",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "kalistamysticshot",
                ChampionName = "kalista",
                Slot = SpellSlot.Q,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "kalistamysticshotmis",
                ExtraMissileNames = new[] { "kalistamysticshotmistrue" },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "kalistaw",
                ChampionName = "kalista",
                Slot = SpellSlot.W,
                CastRange = 5000f,
                Delay = 800f,
                HitType = new HitType[] { },
                MissileSpeed = 200
            });

            Spells.Add(new SpellData
            {
                SDataName = "kalistaexpungewrapper",
                ChampionName = "kalista",
                Slot = SpellSlot.E,
                CastRange = 1200f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "seismicshard",
                ChampionName = "malphite",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "obduracy",
                ChampionName = "malphite",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "landslide",
                ChampionName = "malphite",
                Slot = SpellSlot.E,
                CastRange = 400f,
                Delay = 500f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "ufslash",
                ChampionName = "malphite",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileName = "ufslash",
                MissileSpeed = 2200
            });

            Spells.Add(new SpellData
            {
                SDataName = "alzaharcallofthevoid",
                ChampionName = "malzahar",
                Slot = SpellSlot.Q,
                CastRange = 900f,
                Delay = 600f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "alzaharcallofthevoid",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "alzaharnullzone",
                ChampionName = "malzahar",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "alzaharmaleficvisions",
                ChampionName = "malzahar",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "alzaharnethergrasp",
                ChampionName = "malzahar",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "maokaitrunkline",
                ChampionName = "maokai",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "maokaiunstablegrowth",
                ChampionName = "maokai",
                Slot = SpellSlot.W,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "maokaisapling2",
                ChampionName = "maokai",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "maokaidrain3",
                ChampionName = "maokai",
                Slot = SpellSlot.R,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "alphastrike",
                ChampionName = "masteryi",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 600f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "meditate",
                ChampionName = "masteryi",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "wujustyle",
                ChampionName = "masteryi",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 230f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "highlander",
                ChampionName = "masteryi",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 370f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "missfortunericochetshot",
                ChampionName = "missfortune",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "missfortuneviciousstrikes",
                ChampionName = "missfortune",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "missfortunescattershot",
                ChampionName = "missfortune",
                Slot = SpellSlot.E,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "missfortunebullettime",
                ChampionName = "missfortune",
                Slot = SpellSlot.R,
                CastRange = 1400f,
                Delay = 500f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "monkeykingdoubleattack",
                ChampionName = "monkeyking",
                Slot = SpellSlot.Q,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 20
            });

            Spells.Add(new SpellData
            {
                SDataName = "monkeykingdecoy",
                ChampionName = "monkeyking",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "monkeykingdecoyswipe",
                ChampionName = "monkeyking",
                Slot = SpellSlot.W,
                CastRange = 325f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "monkeykingnimbus",
                ChampionName = "monkeyking",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new SpellData
            {
                SDataName = "monkeykingspintowin",
                ChampionName = "monkeyking",
                Slot = SpellSlot.R,
                CastRange = 450f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "monkeykingspintowinleave",
                ChampionName = "monkeyking",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 700
            });

            Spells.Add(new SpellData
            {
                SDataName = "mordekaisermaceofspades",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "mordekaisercreepindeathcast",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.W,
                CastRange = 750f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "mordekaisersyphoneofdestruction",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "mordekaiserchildrenofthegrave",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "darkbindingmissile",
                ChampionName = "morgana",
                Slot = SpellSlot.Q,
                CastRange = 1175f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileName = "darkbindingmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "tormentedsoil",
                ChampionName = "morgana",
                Slot = SpellSlot.W,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "blackshield",
                ChampionName = "morgana",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "soulshackles",
                ChampionName = "morgana",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "namiq",
                ChampionName = "nami",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileName = "namiqmissile",
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "namiw",
                ChampionName = "nami",
                Slot = SpellSlot.W,
                CastRange = 725f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1100
            });

            Spells.Add(new SpellData
            {
                SDataName = "namie",
                ChampionName = "nami",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "namir",
                ChampionName = "nami",
                Slot = SpellSlot.R,
                CastRange = 2550f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileName = "namirmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "nasusq",
                ChampionName = "nasus",
                Slot = SpellSlot.Q,
                CastRange = 450f,
                Delay = 500f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "nasusw",
                ChampionName = "nasus",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "nasuse",
                ChampionName = "nasus",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "nasusr",
                ChampionName = "nasus",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "nautilusanchordrag",
                ChampionName = "nautilus",
                Slot = SpellSlot.Q,
                CastRange = 1080f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl, Handlers.HitType.Danger },
                MissileName = "nautilusanchordragmissile",
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "nautiluspiercinggaze",
                ChampionName = "nautilus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "nautilussplashzone",
                ChampionName = "nautilus",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1300
            });

            Spells.Add(new SpellData
            {
                SDataName = "nautilusgandline",
                ChampionName = "nautilus",
                Slot = SpellSlot.R,
                CastRange = 1250f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "javelintoss",
                ChampionName = "nidalee",
                Slot = SpellSlot.Q,
                CastRange = 1500f,
                Delay = 125f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileName = "javelintoss",
                MissileSpeed = 1300
            });

            Spells.Add(new SpellData
            {
                SDataName = "takedown",
                ChampionName = "nidalee",
                Slot = SpellSlot.Q,
                CastRange = 150f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "bushwhack",
                ChampionName = "nidalee",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1450
            });

            Spells.Add(new SpellData
            {
                SDataName = "pounce",
                ChampionName = "nidalee",
                Slot = SpellSlot.W,
                CastRange = 375f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "primalsurge",
                ChampionName = "nidalee",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "swipe",
                ChampionName = "nidalee",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "aspectofthecougar",
                ChampionName = "nidalee",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "nocturneduskbringer",
                ChampionName = "nocturne",
                Slot = SpellSlot.Q,
                CastRange = 1125f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "nocturneshroudofdarkness",
                ChampionName = "nocturne",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new SpellData
            {
                SDataName = "nocturneunspeakablehorror",
                ChampionName = "nocturne",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "nocturneparanoia",
                ChampionName = "nocturne",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new SpellData
            {
                SDataName = "consume",
                ChampionName = "nunu",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "bloodboil",
                ChampionName = "nunu",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "iceblast",
                ChampionName = "nunu",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1000
            });

            Spells.Add(new SpellData
            {
                SDataName = "absolutezero",
                ChampionName = "nunu",
                Slot = SpellSlot.R,
                CastRange = 650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "olafaxethrowcast",
                ChampionName = "olaf",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "olafaxethrow",
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "olaffrenziedstrikes",
                ChampionName = "olaf",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "olafrecklessstrike",
                ChampionName = "olaf",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 500f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "olafragnarok",
                ChampionName = "olaf",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "orianaizunacommand",
                ChampionName = "orianna",
                Slot = SpellSlot.Q,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "orianaizuna",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "orianadissonancecommand",
                ChampionName = "orianna",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 350f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "orianadissonancecommand",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "orianaredactcommand",
                ChampionName = "orianna",
                Slot = SpellSlot.E,
                CastRange = 1095f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "orianaredact",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "orianadetonatecommand",
                ChampionName = "orianna",
                Slot = SpellSlot.R,
                CastRange = 425f,
                Delay = 500f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileName = "orianadetonatecommand",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "pantheonq",
                ChampionName = "pantheon",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1900
            });

            Spells.Add(new SpellData
            {
                SDataName = "pantheonw",
                ChampionName = "pantheon",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "pantheone",
                ChampionName = "pantheon",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "pantheonrjump",
                ChampionName = "pantheon",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 1000f,
                HitType = new HitType[] { },
                MissileSpeed = 3000
            });

            Spells.Add(new SpellData
            {
                SDataName = "pantheonrfall",
                ChampionName = "pantheon",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 1000f,
                HitType = new HitType[] { },
                MissileSpeed = 3000
            });

            Spells.Add(new SpellData
            {
                SDataName = "poppydevastatingblow",
                ChampionName = "poppy",
                Slot = SpellSlot.Q,
                CastRange = 300f,
                Delay = 500f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "poppyparagonofdemacia",
                ChampionName = "poppy",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "poppyheroiccharge",
                ChampionName = "poppy",
                Slot = SpellSlot.E,
                CastRange = 525f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1450
            });

            Spells.Add(new SpellData
            {
                SDataName = "poppydiplomaticimmunity",
                ChampionName = "poppy",
                Slot = SpellSlot.R,
                CastRange = 900f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl,  },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "quinnq",
                ChampionName = "quinn",
                Slot = SpellSlot.Q,
                CastRange = 1025f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "quinnqmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "quinnw",
                ChampionName = "quinn",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "quinne",
                ChampionName = "quinn",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 775
            });

            Spells.Add(new SpellData
            {
                SDataName = "quinnr",
                ChampionName = "quinn",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "quinnrfinale",
                ChampionName = "quinn",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "powerball",
                ChampionName = "rammus",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 775
            });

            Spells.Add(new SpellData
            {
                SDataName = "defensiveballcurl",
                ChampionName = "rammus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "puncturingtaunt",
                ChampionName = "rammus",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "tremors2",
                ChampionName = "rammus",
                Slot = SpellSlot.R,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "renektoncleave",
                ChampionName = "renekton",
                Slot = SpellSlot.Q,
                CastRange = 225f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "renektonpreexecute",
                ChampionName = "renekton",
                Slot = SpellSlot.W,
                CastRange = 275f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "renektonsliceanddice",
                ChampionName = "renekton",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "renektonreignofthetyrant",
                ChampionName = "renekton",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "rengarq",
                ChampionName = "rengar",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "rengarw",
                ChampionName = "rengar",
                Slot = SpellSlot.W,
                CastRange = 500f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "rengare",
                ChampionName = "rengar",
                Slot = SpellSlot.E,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "rengarefinal",
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "rengarr",
                ChampionName = "rengar",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "reksaiq",
                ChampionName = "reksai",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "reksaiqburrowed",
                ChampionName = "reksai",
                Slot = SpellSlot.W,
                CastRange = 1650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "reksaiqburrowedmis",
                MissileSpeed = 1950
            });

            Spells.Add(new SpellData
            {
                SDataName = "reksaiw",
                ChampionName = "reksai",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 350f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "reksaiwburrowed",
                ChampionName = "reksai",
                Slot = SpellSlot.W,
                CastRange = 200f,
                Delay = 500f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "reksaie",
                ChampionName = "reksai",
                Slot = SpellSlot.E,
                CastRange = 250f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "reksaieburrowed",
                ChampionName = "reksai",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 900f,
                HitType = new HitType[] { },
                MissileSpeed = 1450
            });

            Spells.Add(new SpellData
            {
                SDataName = "reksair",
                ChampionName = "reksai",
                Slot = SpellSlot.R,
                CastRange = 2.147484E+09f,
                Delay = 1000f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "riventricleave",
                ChampionName = "riven",
                Slot = SpellSlot.Q,
                CastRange = 270f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "rivenmartyr",
                ChampionName = "riven",
                Slot = SpellSlot.W,
                CastRange = 260f,
                Delay = 0f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "rivenfeint",
                ChampionName = "riven",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 1450
            });

            Spells.Add(new SpellData
            {
                SDataName = "rivenfengshuiengine",
                ChampionName = "riven",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "rivenizunablade",
                ChampionName = "riven",
                Slot = SpellSlot.R,
                CastRange = 1075f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileName = "rivenlightsabermissile",
                ExtraMissileNames = new[] { "rivenlightsabermissileside" },
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "rumbleflamethrower",
                ChampionName = "rumble",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "rumbleshield",
                ChampionName = "rumble",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "rumbegrenade",
                ChampionName = "rumble",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "rumblecarpetbomb",
                ChampionName = "rumble",
                Slot = SpellSlot.R,
                CastRange = 1700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "ryzeq",
                ChampionName = "ryze",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "ryzew",
                ChampionName = "ryze",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl , Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "ryzee",
                ChampionName = "ryze",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            Spells.Add(new SpellData
            {
                SDataName = "ryzer",
                ChampionName = "ryze",
                Slot = SpellSlot.R,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "sejuaniarcticassault",
                ChampionName = "sejuani",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 1450
            });

            Spells.Add(new SpellData
            {
                SDataName = "sejuaninorthernwinds",
                ChampionName = "sejuani",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 1000f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "sejuaniwintersclaw",
                ChampionName = "sejuani",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 0f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1450
            });

            Spells.Add(new SpellData
            {
                SDataName = "sejuaniglacialprisoncast",
                ChampionName = "sejuani",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileName = "sejuaniglacialprison",
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "deceive",
                ChampionName = "shaco",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "jackinthebox",
                ChampionName = "shaco",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1450
            });

            Spells.Add(new SpellData
            {
                SDataName = "twoshivpoison",
                ChampionName = "shaco",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "hallucinatefull",
                ChampionName = "shaco",
                Slot = SpellSlot.R,
                CastRange = 1125f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 395
            });

            Spells.Add(new SpellData
            {
                SDataName = "shenvorpalstar",
                ChampionName = "shen",
                Slot = SpellSlot.Q,
                CastRange = 475f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "shenfeint",
                ChampionName = "shen",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "shenshadowdash",
                ChampionName = "shen",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "shenshadowdash",
                MissileSpeed = 1250
            });

            Spells.Add(new SpellData
            {
                SDataName = "shenstandunited",
                ChampionName = "shen",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "shyvanadoubleattack",
                ChampionName = "shyvana",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "shyvanadoubleattackdragon",
                ChampionName = "shyvana",
                Slot = SpellSlot.Q,
                CastRange = 325f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "shyvanaimmolationauraqw",
                ChampionName = "shyvana",
                Slot = SpellSlot.W,
                CastRange = 275f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "shyvanaimmolateddragon",
                ChampionName = "shyvana",
                Slot = SpellSlot.W,
                CastRange = 250f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "shyvanafireball",
                ChampionName = "shyvana",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "shyvanafireballmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "shyvanafireballdragon2",
                ChampionName = "shyvana",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "shyvanatransformcast",
                ChampionName = "shyvana",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 100f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.CrowdControl,
                        Handlers.HitType.Ultimate
                    },
                MissileName = "shyvanatransformcast",
                MissileSpeed = 1100
            });

            Spells.Add(new SpellData
            {
                SDataName = "poisentrail",
                ChampionName = "singed",
                Slot = SpellSlot.Q,
                CastRange = 250f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "megaadhesive",
                ChampionName = "singed",
                Slot = SpellSlot.W,
                CastRange = 1175f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 700
            });

            Spells.Add(new SpellData
            {
                SDataName = "fling",
                ChampionName = "singed",
                Slot = SpellSlot.E,
                CastRange = 125f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "insanitypotion",
                ChampionName = "singed",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "sionq",
                ChampionName = "sion",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 2000f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "sionw",
                ChampionName = "sion",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "sione",
                ChampionName = "sion",
                Slot = SpellSlot.E,
                CastRange = 725f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "sionemissile",
                MissileSpeed = 1800
            });

            Spells.Add(new SpellData
            {
                SDataName = "sionr",
                ChampionName = "sion",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "",
                MissileSpeed = 500
            });

            Spells.Add(new SpellData
            {
                SDataName = "sivirq",
                ChampionName = "sivir",
                Slot = SpellSlot.Q,
                CastRange = 1165f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "sivirqmissile",
                ExtraMissileNames = new []{ "sivirqmissilereturn" },
                MissileSpeed = 1350
            });

            Spells.Add(new SpellData
            {
                SDataName = "sivirw",
                ChampionName = "sivir",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "sivire",
                ChampionName = "sivir",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "sivirr",
                ChampionName = "sivir",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "skarnervirulentslash",
                ChampionName = "skarner",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "skarnerexoskeleton",
                ChampionName = "skarner",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "skarnerfracture",
                ChampionName = "skarner",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "skarnerfracturemissile",
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "skarnerimpale",
                ChampionName = "skarner",
                Slot = SpellSlot.R,
                CastRange = 350f,
                Delay = 350f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "sonaq",
                ChampionName = "sona",
                Slot = SpellSlot.Q,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "sonaw",
                ChampionName = "sona",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "sonae",
                ChampionName = "sona",
                Slot = SpellSlot.E,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "sonar",
                ChampionName = "sona",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileName = "sonar",
                MissileSpeed = 2400
            });

            Spells.Add(new SpellData
            {
                SDataName = "sorakaq",
                ChampionName = "soraka",
                Slot = SpellSlot.Q,
                CastRange = 970f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "",
                MissileSpeed = 1100
            });

            Spells.Add(new SpellData
            {
                SDataName = "sorakaw",
                ChampionName = "soraka",
                Slot = SpellSlot.W,
                CastRange = 750f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "sorakae",
                ChampionName = "soraka",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 1750f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "sorakar",
                ChampionName = "soraka",
                Slot = SpellSlot.R,
                CastRange = 25000f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "swaindecrepify",
                ChampionName = "swain",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "swainshadowgrasp",
                ChampionName = "swain",
                Slot = SpellSlot.W,
                CastRange = 1040f,
                Delay = 1100f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "swainshadowgrasp",
                MissileSpeed = int.MaxValue 
            });

            Spells.Add(new SpellData
            {
                SDataName = "swaintorment",
                ChampionName = "swain",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "swainmetamorphism",
                ChampionName = "swain",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 950
            });

            Spells.Add(new SpellData
            {
                SDataName = "syndraq",
                ChampionName = "syndra",
                Slot = SpellSlot.Q,
                CastRange = 800f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "syndraq",
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "syndrawcast",
                ChampionName = "syndra",
                Slot = SpellSlot.W,
                CastRange = 950f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "syndrawcast",
                MissileSpeed = 1450
            });

            Spells.Add(new SpellData
            {
                SDataName = "syndrae",
                ChampionName = "syndra",
                Slot = SpellSlot.E,
                CastRange = 950f,
                Delay = 300f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "syndrae",
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "syndrar",
                ChampionName = "syndra",
                Slot = SpellSlot.R,
                CastRange = 675f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileSpeed = 1250
            });

            Spells.Add(new SpellData
            {
                SDataName = "talonnoxiandiplomacy",
                ChampionName = "talon",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "talonrake",
                ChampionName = "talon",
                Slot = SpellSlot.W,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "talonrakemissileone",
                MissileSpeed = 2300
            });

            Spells.Add(new SpellData
            {
                SDataName = "taloncutthroat",
                ChampionName = "talon",
                Slot = SpellSlot.E,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "talonshadowassault",
                ChampionName = "talon",
                Slot = SpellSlot.R,
                CastRange = 750f,
                Delay = 260f,
                HitType = new[] { Handlers.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "imbue",
                ChampionName = "taric",
                Slot = SpellSlot.Q,
                CastRange = 750f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "shatter",
                ChampionName = "taric",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "dazzle",
                ChampionName = "taric",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "tarichammersmash",
                ChampionName = "taric",
                Slot = SpellSlot.R,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "blindingdart",
                ChampionName = "teemo",
                Slot = SpellSlot.Q,
                CastRange = 580f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "movequick",
                ChampionName = "teemo",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 943
            });

            Spells.Add(new SpellData
            {
                SDataName = "toxicshot",
                ChampionName = "teemo",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "bantamtrap",
                ChampionName = "teemo",
                Slot = SpellSlot.R,
                CastRange = 230f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "threshq",
                ChampionName = "thresh",
                Slot = SpellSlot.Q,
                CastRange = 1175f,
                Delay = 500f,
                HitType = new[] { Handlers.HitType.CrowdControl, Handlers.HitType.Danger  },
                MissileName = "threshqmissile",
                MissileSpeed = 1900
            });

            Spells.Add(new SpellData
            {
                SDataName = "threshw",
                ChampionName = "thresh",
                Slot = SpellSlot.W,
                CastRange = 950f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "threshe",
                ChampionName = "thresh",
                Slot = SpellSlot.E,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "threshemissile1",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "threshrpenta",
                ChampionName = "thresh",
                Slot = SpellSlot.R,
                CastRange = 420f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "tristanaq",
                ChampionName = "tristana",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "tristanaw",
                ChampionName = "tristana",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1150
            });

            Spells.Add(new SpellData
            {
                SDataName = "tristanae",
                ChampionName = "tristana",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "tristanar",
                ChampionName = "tristana",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "trundletrollsmash",
                ChampionName = "trundle",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "trundledesecrate",
                ChampionName = "trundle",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "trundlecircle",
                ChampionName = "trundle",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "trundlepain",
                ChampionName = "trundle",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 500f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "bloodlust",
                ChampionName = "tryndamere",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "mockingshout",
                ChampionName = "tryndamere",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "slashcast",
                ChampionName = "tryndamere",
                Slot = SpellSlot.E,
                CastRange = 660f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "slashcast",
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "undyingrage",
                ChampionName = "tryndamere",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "hideinshadows",
                ChampionName = "twich",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 450f,
                HitType = new[] { Handlers.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "twitchvenomcask",
                ChampionName = "twich",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "twitchvenomcaskmissile",
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "twitchvenomcaskmissle",
                ChampionName = "twich",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "expunge",
                ChampionName = "twich",
                Slot = SpellSlot.E,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "fullautomatic",
                ChampionName = "twich",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new SpellData
            {
                SDataName = "wildcards",
                ChampionName = "twistedfate",
                Slot = SpellSlot.Q,
                CastRange = 1450f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "sealfatemissile",
                MissileSpeed = 1450
            });

            Spells.Add(new SpellData
            {
                SDataName = "pickacard",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "goldcardpreattack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl, Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "redcardpreattack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "bluecardpreattack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "cardmasterstack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "destiny",
                ChampionName = "twistedfate",
                Slot = SpellSlot.R,
                CastRange = 5250f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "udyrtigerstance",
                ChampionName = "udyr",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "udyrturtlestance",
                ChampionName = "udyr",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "udyrbearstanceattack",
                ChampionName = "udyr",
                Slot = SpellSlot.E,
                CastRange = 250f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "udyrphoenixstance",
                ChampionName = "udyr",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "urgotheatseekinglineqqmissile",
                ChampionName = "urgot",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new [] { Handlers.HitType.Danger,  },
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "urgotheatseekingmissile",
                ChampionName = "urgot",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "urgotterrorcapacitoractive2",
                ChampionName = "urgot",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "urgotplasmagrenade",
                ChampionName = "urgot",
                Slot = SpellSlot.E,
                CastRange = 950f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "urgotplasmagrenadeboom",
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "urgotplasmagrenadeboom",
                ChampionName = "urgot",
                Slot = SpellSlot.E,
                CastRange = 950f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "urgotswap2",
                ChampionName = "urgot",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] {  Handlers.HitType.CrowdControl },
                MissileSpeed = 1800
            });

            Spells.Add(new SpellData
            {
                SDataName = "varusq",
                ChampionName = "varus",
                Slot = SpellSlot.Q,
                CastRange = 1250f,
                Delay = 0f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileName = "varusqmissile",
                MissileSpeed = 1900
            });

            Spells.Add(new SpellData
            {
                SDataName = "varusw",
                ChampionName = "varus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "varuse",
                ChampionName = "varus",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "varuse",
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "varusr",
                ChampionName = "varus",
                Slot = SpellSlot.R,
                CastRange = 1300f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileName = "varusrmissile",
                MissileSpeed = 1950
            });

            Spells.Add(new SpellData
            {
                SDataName = "vaynetumble",
                ChampionName = "vayne",
                Slot = SpellSlot.Q,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "vaynesilverbolts",
                ChampionName = "vayne",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "vaynecondemnmissile",
                ChampionName = "vayne",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 500f,
                HitType = new[] { Handlers.HitType.CrowdControl, Handlers.HitType.Danger,  },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "vayneinquisition",
                ChampionName = "vayne",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "veigarbalefulstrike",
                ChampionName = "veigar",
                Slot = SpellSlot.Q,
                CastRange = 950f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileName = "veigarbalefulstrikemis",
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "veigardarkmatter",
                ChampionName = "veigar",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 1200f,
                HitType = new HitType[] { },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "veigareventhorizon",
                ChampionName = "veigar",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 0f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "veigarprimordialburst",
                ChampionName = "veigar",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "velkozq",
                ChampionName = "velkoz",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 300f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "velkozqmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "velkozqmissle",
                ChampionName = "velkoz",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "velkozqplitactive",
                ChampionName = "velkoz",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 0f,
                HitType = new[] { Handlers.HitType.CrowdControl, Handlers.HitType.Danger },
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "velkozw",
                ChampionName = "velkoz",
                Slot = SpellSlot.W,
                CastRange = 1050f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileName = "velkozwmissile",
                MissileSpeed = 1200
            });

            Spells.Add(new SpellData
            {
                SDataName = "velkoze",
                ChampionName = "velkoz",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 0f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "velkozemissile",
                MissileSpeed = 1700
            });

            Spells.Add(new SpellData
            {
                SDataName = "velkozr",
                ChampionName = "velkoz",
                Slot = SpellSlot.R,
                CastRange = 1575f,
                Delay = 0f,
                HitType = new[] { Handlers.HitType.Ultimate },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "viq",
                ChampionName = "vi",
                Slot = SpellSlot.Q,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "viw",
                ChampionName = "vi",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "vie",
                ChampionName = "vi",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 0f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "vir",
                ChampionName = "vi",
                Slot = SpellSlot.R,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "viktorpowertransfer",
                ChampionName = "viktor",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "viktorgravitonfield",
                ChampionName = "viktor",
                Slot = SpellSlot.W,
                CastRange = 815f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "viktordeathray",
                ChampionName = "viktor",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileName = "viktordeathraymis",
                MissileSpeed = 1210
            });

            Spells.Add(new SpellData
            {
                SDataName = "viktorchaosstorm",
                ChampionName = "viktor",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 350f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.CrowdControl, Handlers.HitType.Ultimate,
                        Handlers.HitType.Danger
                    },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "vladimirtransfusion",
                ChampionName = "vladimir",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "vladimirsanguinepool",
                ChampionName = "vladimir",
                Slot = SpellSlot.W,
                CastRange = 350f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "vladimirtidesofblood",
                ChampionName = "vladimir",
                Slot = SpellSlot.E,
                CastRange = 610f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1100
            });

            Spells.Add(new SpellData
            {
                SDataName = "vladimirhemoplague",
                ChampionName = "vladimir",
                Slot = SpellSlot.R,
                CastRange = 875f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "volibearq",
                ChampionName = "volibear",
                Slot = SpellSlot.Q,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "volibearw",
                ChampionName = "volibear",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = 1450
            });

            Spells.Add(new SpellData
            {
                SDataName = "volibeare",
                ChampionName = "volibear",
                Slot = SpellSlot.E,
                CastRange = 425f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 825
            });

            Spells.Add(new SpellData
            {
                SDataName = "volibearr",
                ChampionName = "volibear",
                Slot = SpellSlot.R,
                CastRange = 425f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 825
            });

            Spells.Add(new SpellData
            {
                SDataName = "hungeringstrike",
                ChampionName = "warwick",
                Slot = SpellSlot.Q,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "hunterscall",
                ChampionName = "warwick",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "bloodscent",
                ChampionName = "warwick",
                Slot = SpellSlot.E,
                CastRange = 1250f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "infiniteduress",
                ChampionName = "warwick",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });
            
            Spells.Add(new SpellData
            {
                SDataName = "xeratharcanopulsechargeup",
                ChampionName = "xerath",
                Slot = SpellSlot.Q,
                CastRange = 750f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new SpellData
            {
                SDataName = "xeratharcanebarrage2",
                ChampionName = "xerath",
                Slot = SpellSlot.W,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "xeratharcanebarrage2",
                MissileSpeed = 20
            });

            Spells.Add(new SpellData
            {
                SDataName = "xerathmagespear",
                ChampionName = "xerath",
                Slot = SpellSlot.E,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl, Handlers.HitType.Danger },
                MissileName = "xerathmagespearmissile",
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "xerathlocusofpower2",
                ChampionName = "xerath",
                Slot = SpellSlot.R,
                CastRange = 5600f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new SpellData
            {
                SDataName = "xenzhaothrust3",
                ChampionName = "xinzhao",
                Slot = SpellSlot.Q,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "xenzhaobattlecry",
                ChampionName = "xinzhao",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "xenzhaosweep",
                ChampionName = "xinzhao",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl, Handlers.HitType.Danger },
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "xenzhaoparry",
                ChampionName = "xinzhao",
                Slot = SpellSlot.R,
                CastRange = 375f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "yasuoqw",
                ChampionName = "yasuo",
                Slot = SpellSlot.Q,
                CastRange = 475f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "yasuoq2w",
                ChampionName = "yasuo",
                Slot = SpellSlot.Q,
                CastRange = 475f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "yasuoq3",
                ChampionName = "yasuo",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "yasuoq3mis",
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "yasuowmovingwall",
                ChampionName = "yasuo",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            Spells.Add(new SpellData
            {
                SDataName = "yasuodashwrapper",
                ChampionName = "yasuo",
                Slot = SpellSlot.E,
                CastRange = 475f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 20
            });

            Spells.Add(new SpellData
            {
                SDataName = "yasuorknockupcombow",
                ChampionName = "yasuo",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "yorickspectral",
                ChampionName = "yorick",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "yorickdecayed",
                ChampionName = "yorick",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "yorickravenous",
                ChampionName = "yorick",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "yorickreviveally",
                ChampionName = "yorick",
                Slot = SpellSlot.R,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "zacq",
                ChampionName = "zac",
                Slot = SpellSlot.Q,
                CastRange = 550f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "zacq",
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "zacw",
                ChampionName = "zac",
                Slot = SpellSlot.W,
                CastRange = 350f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "zace",
                ChampionName = "zac",
                Slot = SpellSlot.E,
                CastRange = 1550f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            Spells.Add(new SpellData
            {
                SDataName = "zacr",
                ChampionName = "zac",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "zedq",
                ChampionName = "zed",
                Slot = SpellSlot.Q,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "zedshurikenmisone",
                FromObject = new[] { "Zed_Base_W_tar.troy", "Zed_Base_W_cloneswap_buf.troy" },
                ExtraMissileNames = new[] { "zedshurikenmistwo", "zedshurikenmisthree" },
                MissileSpeed = 1700
            });

            Spells.Add(new SpellData
            {
                SDataName = "zedw",
                ChampionName = "zed",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            Spells.Add(new SpellData
            {
                SDataName = "zede",
                ChampionName = "zed",
                Slot = SpellSlot.E,
                CastRange = 300f,
                Delay = 0f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "zedr",
                ChampionName = "zed",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "ziggsq",
                ChampionName = "ziggs",
                Slot = SpellSlot.Q,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "ziggsqspell",
                ExtraMissileNames = new[] { "ziggsqspell2", "ziggsqspell3" },
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "ziggsw",
                ChampionName = "ziggs",
                Slot = SpellSlot.W,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "ziggsw",
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "ziggswtoggle",
                ChampionName = "ziggs",
                Slot = SpellSlot.W,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "ziggse",
                ChampionName = "ziggs",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "ziggse",
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "ziggse2",
                ChampionName = "ziggs",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "ziggsr",
                ChampionName = "ziggs",
                Slot = SpellSlot.R,
                CastRange = 2250f,
                Delay = 1800f,
                HitType = new[] { Handlers.HitType.Danger, Handlers.HitType.Ultimate },
                MissileName = "ziggsr",
                MissileSpeed = 1750
            });

            Spells.Add(new SpellData
            {
                SDataName = "zileanq",
                ChampionName = "zilean",
                Slot = SpellSlot.Q,
                CastRange = 900f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileName = "zileanqmissile",
                MissileSpeed = 2000
            });

            Spells.Add(new SpellData
            {
                SDataName = "zileanw",
                ChampionName = "zilean",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "zileane",
                ChampionName = "zilean",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileSpeed = 1100
            });

            Spells.Add(new SpellData
            {
                SDataName = "zileanr",
                ChampionName = "zilean",
                Slot = SpellSlot.R,
                CastRange = 780f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            Spells.Add(new SpellData
            {
                SDataName = "zyraqfissure",
                ChampionName = "zyra",
                Slot = SpellSlot.Q,
                CastRange = 800f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileName = "zyraqfissure",
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "zyraseed",
                ChampionName = "zyra",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            Spells.Add(new SpellData
            {
                SDataName = "zyragraspingroots",
                ChampionName = "zyra",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { Handlers.HitType.CrowdControl },
                MissileName = "zyragraspingroots",
                MissileSpeed = 1400
            });

            Spells.Add(new SpellData
            {
                SDataName = "zyrabramblezone",
                ChampionName = "zyra",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        Handlers.HitType.Danger, Handlers.HitType.Ultimate,
                        Handlers.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });
        }

        public static SpellData GetByMissileName(string missilename)
        {
            foreach (var sdata in Spells)
            {
                if (sdata.MissileName != null && sdata.MissileName.ToLower() == missilename ||
                    sdata.ExtraMissileNames != null && sdata.ExtraMissileNames.Contains(missilename))
                {
                    return sdata;
                }
            }

            return null;
        }
    }
}
