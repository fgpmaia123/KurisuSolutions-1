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

namespace Activator
{
    public class spelldata
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

        static spelldata()
        {
            spells.Add(new spelldata
            {
                SDataName = "aatroxq",
                ChampionName = "aatrox",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 2000
            });

            spells.Add(new spelldata
            {
                SDataName = "aatroxw",
                ChampionName = "aatrox",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "aatroxw2",
                ChampionName = "aatrox",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "aatroxe",
                ChampionName = "aatrox",
                Slot = SpellSlot.E,
                CastRange = 1025f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "aatroxeconemissile",
                MissileSpeed = 1250
            });

            spells.Add(new spelldata
            {
                SDataName = "aatroxr",
                ChampionName = "aatrox",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "ahrifoxfire",
                ChampionName = "ahri",
                Slot = SpellSlot.W,
                CastRange = 550f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1800
            });

            spells.Add(new spelldata
            {
                SDataName = "ahriseduce",
                ChampionName = "ahri",
                Slot = SpellSlot.E,
                CastRange = 975f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileName = "ahriseducemissile",
                MissileSpeed = 1550
            });

            spells.Add(new spelldata
            {
                SDataName = "ahritumble",
                ChampionName = "ahri",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            spells.Add(new spelldata
            {
                SDataName = "akalimota",
                ChampionName = "akali",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 650f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            spells.Add(new spelldata
            {
                SDataName = "akalismokebomb",
                ChampionName = "akali",
                Slot = SpellSlot.W,
                CastRange = 1000f, // Range: 700 + additional for stealth detection
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "akalishadowswipe",
                ChampionName = "akali",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "akalishadowdance",
                ChampionName = "akali",
                Slot = SpellSlot.R,
                CastRange = 710f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            spells.Add(new spelldata
            {
                SDataName = "pulverize",
                ChampionName = "alistar",
                Slot = SpellSlot.Q,
                CastRange = 365f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "headbutt",
                ChampionName = "alistar",
                Slot = SpellSlot.W,
                CastRange = 650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "triumphantroar",
                ChampionName = "alistar",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "feroucioushowl",
                ChampionName = "alistar",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 828
            });

            spells.Add(new spelldata
            {
                SDataName = "bandagetoss",
                ChampionName = "amumu",
                Slot = SpellSlot.Q,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileName = "sadmummybandagetoss",
                MissileSpeed = 2000
            });

            spells.Add(new spelldata
            {
                SDataName = "auraofdespair",
                ChampionName = "amumu",
                Slot = SpellSlot.W,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "tantrum",
                ChampionName = "amumu",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 150f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "curseofthesadmummy",
                ChampionName = "amumu",
                Slot = SpellSlot.R,
                CastRange = 550f,
                Delay = 150f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "flashfrost",
                ChampionName = "anivia",
                Slot = SpellSlot.Q,
                CastRange = 1150f, // 1075 + Shatter Radius
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "flashfrostspell",
                MissileSpeed = 850
            });

            spells.Add(new spelldata
            {
                SDataName = "crystalize",
                ChampionName = "anivia",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "frostbite",
                ChampionName = "anivia",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = 1450
            });

            spells.Add(new spelldata
            {
                SDataName = "glacialstorm",
                ChampionName = "anivia",
                Slot = SpellSlot.R,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "disintegrate",
                ChampionName = "annie",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new [] { global::Activator.HitType.Danger },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "incinerate",
                ChampionName = "annie",
                Slot = SpellSlot.W,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "moltenshield",
                ChampionName = "annie",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "infernalguardian",
                ChampionName = "annie",
                Slot = SpellSlot.R,
                CastRange = 890f, // 600 + Cast Radius
                Delay = 0f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "frostshot",
                ChampionName = "ashe",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "frostarrow",
                ChampionName = "ashe",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 0f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "volley",
                ChampionName = "ashe",
                Slot = SpellSlot.W,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "volleyattack",
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "ashespiritofthehawk",
                ChampionName = "ashe",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
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
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileName = "enchantedcrystalarrow",
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "azirq",
                ChampionName = "azir",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitType = new[] {global::Activator.HitType.CrowdControl },
                MissileName = "azirsoldiermissile",
                FromObject = new []{ "AzirSoldier" },
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "azirr",
                ChampionName = "azir",
                Slot = SpellSlot.R,
                CastRange = 475f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "bardq",
                ChampionName = "bard",
                Slot = SpellSlot.Q,
                CastRange = 950f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "bardqmissile",
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "bardw",
                ChampionName = "bard",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1450
            });

            spells.Add(new spelldata
            {
                SDataName = "barde",
                ChampionName = "bard",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 350f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "bardr",
                ChampionName = "bard",
                Slot = SpellSlot.R,
                CastRange = 3400f,
                Delay = 450f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "bardr",
                MissileSpeed = 2100
            });

            spells.Add(new spelldata
            {
                SDataName = "rocketgrabmissile",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl, global::Activator.HitType.Danger },
                MissileSpeed = 1800
            });

            spells.Add(new spelldata
            {
                SDataName = "overdrive",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "powerfist",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.E,
                CastRange = 100f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "staticfield",
                ChampionName = "blitzcrank",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "brandblaze",
                ChampionName = "brand",
                Slot = SpellSlot.Q,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "brandblazemissile",
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "brandfissure",
                ChampionName = "brand",
                Slot = SpellSlot.W,
                CastRange = 240f,
                Delay = 550f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileName = "",
                MissileSpeed = 20
            });

            spells.Add(new spelldata
            {
                SDataName = "brandconflagration",
                ChampionName = "brand",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "brandwildfire",
                ChampionName = "brand",
                Slot = SpellSlot.R,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileSpeed = 1000
            });

            spells.Add(new spelldata
            {
                SDataName = "braumq",
                ChampionName = "braum",
                Slot = SpellSlot.Q,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileName = "braumqmissile",
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "braumqmissle",
                ChampionName = "braum",
                Slot = SpellSlot.Q,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "braumw",
                ChampionName = "braum",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "braume",
                ChampionName = "braum",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "braumrwrapper",
                ChampionName = "braum",
                Slot = SpellSlot.R,
                CastRange = 1250f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileName = "braumrmissile",
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "caitlynyordletrap",
                ChampionName = "caitlyn",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 550f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "caitlynentrapment",
                ChampionName = "caitlyn",
                Slot = SpellSlot.E,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "caitlynentrapmentmissile",
                MissileSpeed = 2000
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "cassiopeiamiasma",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.W,
                CastRange = 925f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 2500
            });

            spells.Add(new spelldata
            {
                SDataName = "cassiopeiatwinfang",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1900
            });

            spells.Add(new spelldata
            {
                SDataName = "cassiopeiapetrifyinggaze",
                ChampionName = "cassiopeia",
                Slot = SpellSlot.R,
                CastRange = 875f,
                Delay = 350f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileName = "cassiopeiapetrifyinggaze",
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "rupture",
                ChampionName = "chogath",
                Slot = SpellSlot.Q,
                CastRange = 950f,
                Delay = 1000f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileName = "rupture",
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "feralscream",
                ChampionName = "chogath",
                Slot = SpellSlot.W,
                CastRange = 675f,
                Delay = 175f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "vorpalspikes",
                ChampionName = "chogath",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 347
            });

            spells.Add(new spelldata
            {
                SDataName = "feast",
                ChampionName = "chogath",
                Slot = SpellSlot.R,
                CastRange = 500f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "carpetbomb",
                ChampionName = "corki",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 700
            });

            spells.Add(new spelldata
            {
                SDataName = "ggun",
                ChampionName = "corki",
                Slot = SpellSlot.E,
                CastRange = 750f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "dariuscleave",
                ChampionName = "darius",
                Slot = SpellSlot.Q,
                CastRange = 425f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "dariusnoxiantacticsonh",
                ChampionName = "darius",
                Slot = SpellSlot.W,
                CastRange = 205f,
                Delay = 150f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "dariusaxegrabcone",
                ChampionName = "darius",
                Slot = SpellSlot.E,
                CastRange = 555f,
                Delay = 150f,
                HitType = new[] { global::Activator.HitType.CrowdControl, global::Activator.HitType.Danger },
                MissileName = "dariusaxegrabcone",
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "dariusexecute",
                ChampionName = "darius",
                Slot = SpellSlot.R,
                CastRange = 465f,
                Delay = 450f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "dianaorbs",
                ChampionName = "diana",
                Slot = SpellSlot.W,
                CastRange = 200f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "dianavortex",
                ChampionName = "diana",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl, global::Activator.HitType.Danger,  },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "dianateleport",
                ChampionName = "diana",
                Slot = SpellSlot.R,
                CastRange = 825f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = 2200
            });

            spells.Add(new spelldata
            {
                SDataName = "dravenspinning",
                ChampionName = "draven",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "dravenfury",
                ChampionName = "draven",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "dravendoubleshot",
                ChampionName = "draven",
                Slot = SpellSlot.E,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "dravendoubleshotmissile",
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "dravenrcast",
                ChampionName = "draven",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 500f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileName = "dravenr",
                MissileSpeed = 2000
            });

            spells.Add(new spelldata
            {
                SDataName = "infectedcleavermissilecast",
                ChampionName = "drmundo",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "infectedcleavermissile",
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "burningagony",
                ChampionName = "drmundo",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "masochism",
                ChampionName = "drmundo",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "sadism",
                ChampionName = "drmundo",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "ekkoq",
                ChampionName = "ekko",
                Slot = SpellSlot.Q,
                CastRange = 1075f,
                Delay = 66f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "ekkoqmis",
                ExtraMissileNames = new []{ "ekkoqreturn" },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "ekkoeattack",
                ChampionName = "ekko",
                Slot = SpellSlot.E,
                CastRange = 300f,
                Delay = 0f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

             spells.Add(new spelldata
             {
                 SDataName = "ekkor",
                 ChampionName = "ekko",
                 Slot = SpellSlot.R,
                 CastRange = 425f,
                 Delay = 250f,
                 HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                 FromObject = new [] { "Ekko_Base_R_TrailEnd" },
                 MissileSpeed = int.MaxValue
             });

            spells.Add(new spelldata
            {
                SDataName = "elisehumanq",
                ChampionName = "elise",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 550f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            spells.Add(new spelldata
            {
                SDataName = "elisespiderqcast",
                ChampionName = "elise",
                Slot = SpellSlot.Q,
                CastRange = 475f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "elisehumanw",
                ChampionName = "elise",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = 5000
            });

            spells.Add(new spelldata
            {
                SDataName = "elisespiderw",
                ChampionName = "elise",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "elisehumane",
                ChampionName = "elise",
                Slot = SpellSlot.E,
                CastRange = 1075f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl, global::Activator.HitType.Danger },
                MissileName = "elisehumane",
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "elisespidereinitial",
                ChampionName = "elise",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "elisespideredescent",
                ChampionName = "elise",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "eliser",
                ChampionName = "elise",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "elisespiderr",
                ChampionName = "elise",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "evelynnq",
                ChampionName = "evelynn",
                Slot = SpellSlot.Q,
                CastRange = 500f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "evelynnw",
                ChampionName = "evelynn",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "evelynne",
                ChampionName = "evelynn",
                Slot = SpellSlot.E,
                CastRange = 225f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "evelynnr",
                ChampionName = "evelynn",
                Slot = SpellSlot.R,
                CastRange = 900f, // 650f + Radius
                Delay = 250f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileName = "evelynnr",
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "ezrealmysticshot",
                ChampionName = "ezreal",
                Slot = SpellSlot.Q,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger  },
                MissileName = "ezrealmysticshotmissile",
                ExtraMissileNames = new[] { "ezrealmysticshotpulsemissile" },
                MissileSpeed = 2000
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "ezrealessencemissle",
                ChampionName = "ezreal",
                Slot = SpellSlot.W,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "ezrealarcaneshift",
                ChampionName = "ezreal",
                Slot = SpellSlot.E,
                CastRange = 750f, // 475f + Bolt Range
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "ezrealtrueshotbarrage",
                ChampionName = "ezreal",
                Slot = SpellSlot.R,
                CastRange = 20000f,
                Global = true,
                Delay = 1000f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileName = "ezrealtrueshotbarrage",
                MissileSpeed = 2000
            });

            spells.Add(new spelldata
            {
                SDataName = "terrify",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.Q,
                CastRange = 575f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "drain",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.W,
                CastRange = 575f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "fiddlesticksdarkwind",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.E,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1100
            });

            spells.Add(new spelldata
            {
                SDataName = "crowstorm",
                ChampionName = "fiddlesticks",
                Slot = SpellSlot.R,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.ForceExhaust },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "fioraq",
                ChampionName = "fiora",
                Slot = SpellSlot.Q,
                CastRange = 400f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            spells.Add(new spelldata
            {
                SDataName = "fioraw",
                ChampionName = "fiora",
                Slot = SpellSlot.W,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "fiorae",
                ChampionName = "fiora",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "fiorar",
                ChampionName = "fiora",
                Slot = SpellSlot.R,
                CastRange = 500f,
                Delay = 150f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "fizzpiercingstrike",
                ChampionName = "fizz",
                Slot = SpellSlot.Q,
                CastRange = 550f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1900
            });

            spells.Add(new spelldata
            {
                SDataName = "fizzseastonepassive",
                ChampionName = "fizz",
                Slot = SpellSlot.W,
                CastRange = 175f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "fizzjump",
                ChampionName = "fizz",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 700f,
                HitType = new[] { global::Activator.HitType.CrowdControl  },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "fizzjumpbuffer",
                ChampionName = "fizz",
                Slot = SpellSlot.E,
                CastRange = 330f,
                Delay = 0f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "fizzjumptwo",
                ChampionName = "fizz",
                Slot = SpellSlot.E,
                CastRange = 270f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue 
            });

            spells.Add(new spelldata
            {
                SDataName = "fizzmarinerdoom",
                ChampionName = "fizz",
                Slot = SpellSlot.R,
                CastRange = 1275f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "fizzmarinerdoommissile",
                MissileSpeed = 1350
            });

            spells.Add(new spelldata
            {
                SDataName = "galioresolutesmite",
                ChampionName = "galio",
                Slot = SpellSlot.Q,
                CastRange = 1040f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "galioresolutesmite",
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "galiobulwark",
                ChampionName = "galio",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "galioidolofdurand",
                ChampionName = "galio",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 0f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileName = "",
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "gangplankqwrapper",
                ChampionName = "gangplank",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            spells.Add(new spelldata
            {
                SDataName = "gangplankqproceed",
                ChampionName = "gangplank",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            spells.Add(new spelldata
            {
                SDataName = "gangplankw",
                ChampionName = "gangplank",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "gangplanke",
                ChampionName = "gangplank",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "garenq",
                ChampionName = "garen",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "garenqattack",
                ChampionName = "garen",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 0f,
                HitType = new[] { global::Activator.HitType.CrowdControl, global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });


            spells.Add(new spelldata
            {
                SDataName = "gnarq",
                ChampionName = "gnar",
                Slot = SpellSlot.Q,
                CastRange = 1185f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 2400,
                MissileName = "gnarqmissile",
                ExtraMissileNames = new[] { "gnarqmissilereturn" }
            });


            spells.Add(new spelldata
            {
                SDataName = "gnarbigq",
                ChampionName = "gnar",
                Slot = SpellSlot.Q,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 2000,
                MissileName = "gnarbigqmissile"
            });

            spells.Add(new spelldata
            {
                SDataName = "gnarbigw",
                ChampionName = "gnar",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 600f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "gnarult",
                ChampionName = "gnar",
                CastRange = 600f, // 590f + 10 Better safe than sorry. :)
                Slot = SpellSlot.R,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },

                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "garenw",
                ChampionName = "garen",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "garene",
                ChampionName = "garen",
                Slot = SpellSlot.E,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "garenr",
                ChampionName = "garen",
                Slot = SpellSlot.R,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "gragasqtoggle",
                ChampionName = "gragas",
                Slot = SpellSlot.Q,
                CastRange = 1100f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "gragasw",
                ChampionName = "gragas",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "gragase",
                ChampionName = "gragas",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 200f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileName = "gragase",
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "gragasr",
                ChampionName = "gragas",
                Slot = SpellSlot.R,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileName = "gragasrboom",
                MissileSpeed = 1750
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "gravessmokegrenade",
                ChampionName = "graves",
                Slot = SpellSlot.W,
                CastRange = 1100f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileSpeed = 1650
            });

            spells.Add(new spelldata
            {
                SDataName = "gravessmokegrenadeboom",
                ChampionName = "graves",
                Slot = SpellSlot.W,
                CastRange = 1100f, // 950 + Radius
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1350
            });

            spells.Add(new spelldata
            {
                SDataName = "gravesmove",
                ChampionName = "graves",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            spells.Add(new spelldata
            {
                SDataName = "graveschargeshot",
                ChampionName = "graves",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileName = "graveschargeshotshot",
                MissileSpeed = 2100
            });

            spells.Add(new spelldata
            {
                SDataName = "hecarimrapidslash",
                ChampionName = "hecarim",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            spells.Add(new spelldata
            {
                SDataName = "hecarimw",
                ChampionName = "hecarim",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "hecarimramp",
                ChampionName = "hecarim",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "hecarimult",
                ChampionName = "hecarim",
                Slot = SpellSlot.R,
                CastRange = 1350f,
                Delay = 50f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "heimerdingerq",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "heimerdingerw",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.W,
                CastRange = 1100,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1750
            });

            spells.Add(new spelldata
            {
                SDataName = "heimerdingere",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.E,
                CastRange = 1025f, // 925 + Radius
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "heimerdingerespell",
                MissileSpeed = 1450
            });

            spells.Add(new spelldata
            {
                SDataName = "heimerdingerr",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 230f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "heimerdingereult",
                ChampionName = "heimerdinger",
                Slot = SpellSlot.E,
                CastRange = 1250f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1450
            });

            spells.Add(new spelldata
            {
                SDataName = "ireliagatotsu",
                ChampionName = "irelia",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 150f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            spells.Add(new spelldata
            {
                SDataName = "ireliahitenstyle",
                ChampionName = "irelia",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 230f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "ireliaequilibriumstrike",
                ChampionName = "irelia",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "howlinggale",
                ChampionName = "janna",
                Slot = SpellSlot.Q,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "sowthewind",
                ChampionName = "janna",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "eyeofthestorm",
                ChampionName = "janna",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "reapthewhirlwind",
                ChampionName = "janna",
                Slot = SpellSlot.R,
                CastRange = 725f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "jarvanivdragonstrike",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.Q,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 2000
            });

            spells.Add(new spelldata
            {
                SDataName = "jarvanivgoldenaegis",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "jarvanivcataclysm",
                ChampionName = "jarvaniv",
                Slot = SpellSlot.R,
                CastRange = 650f,
                Delay = 500f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "jaxleapstrike",
                ChampionName = "jax",
                Slot = SpellSlot.Q,
                CastRange = 210f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = 2200
            });

            spells.Add(new spelldata
            {
                SDataName = "jaxempowertwo",
                ChampionName = "jax",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "jaxrelentlessasssault",
                ChampionName = "jax",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "jaycetotheskies",
                ChampionName = "jayce",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl, global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "jayceshockblast",
                ChampionName = "jayce",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl, global::Activator.HitType.Danger },
                MissileName = "jayceshockblastmis",
                MissileSpeed = 2200
            });

            spells.Add(new spelldata
            {
                SDataName = "jaycestaticfield",
                ChampionName = "jayce",
                Slot = SpellSlot.W,
                CastRange = 285f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "jaycehypercharge",
                ChampionName = "jayce",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "jaycethunderingblow",
                ChampionName = "jayce",
                Slot = SpellSlot.E,
                CastRange = 300f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "jayceaccelerationgate",
                ChampionName = "jayce",
                Slot = SpellSlot.E,
                CastRange = 685f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "jaycestancehtg",
                ChampionName = "jayce",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "jaycestancegth",
                ChampionName = "jayce",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "jinxq",
                ChampionName = "jinx",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "jinxw",
                ChampionName = "jinx",
                Slot = SpellSlot.W,
                CastRange = 1550f,
                Delay = 550f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "jinxwmissile",
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "jinxwmissle",
                ChampionName = "jinx",
                Slot = SpellSlot.W,
                CastRange = 1550f,
                Delay = 500f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "jinxe",
                ChampionName = "jinx",
                Slot = SpellSlot.E,
                CastRange = 900f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1000
            });

            spells.Add(new spelldata
            {
                SDataName = "jinxr",
                ChampionName = "jinx",
                Slot = SpellSlot.R,
                CastRange = 25000f,
                Global = true,
                Delay = 600f,
                MissileName = "jinxr",
                ExtraMissileNames = new [] { "jinxrwrapper" },
                HitType = new [] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileSpeed = 1700
            });

            spells.Add(new spelldata
            {
                SDataName = "karmaq",
                ChampionName = "karma",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileName = "karmaqmissile",
                MissileSpeed = 1800
            });

            spells.Add(new spelldata
            {
                SDataName = "karmaspiritbind",
                ChampionName = "karma",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "karmasolkimshield",
                ChampionName = "karma",
                Slot = SpellSlot.E,
                CastRange = 800f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "karmamantra",
                ChampionName = "karma",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1300
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "wallofpain",
                ChampionName = "karthus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "defile",
                ChampionName = "karthus",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "nulllance",
                ChampionName = "kassadin",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl, global::Activator.HitType.Danger },
                MissileSpeed = 1900
            });

            spells.Add(new spelldata
            {
                SDataName = "netherblade",
                ChampionName = "kassadin",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "forcepulse",
                ChampionName = "kassadin",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl, global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "katarinaq",
                ChampionName = "katarina",
                Slot = SpellSlot.Q,
                CastRange = 675f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1800
            });

            spells.Add(new spelldata
            {
                SDataName = "katarinaw",
                ChampionName = "katarina",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1800
            });

            spells.Add(new spelldata
            {
                SDataName = "katarinae",
                ChampionName = "katarina",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "katarinar",
                ChampionName = "katarina",
                Slot = SpellSlot.R,
                CastRange = 550f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.ForceExhaust },
                MissileSpeed = 1450
            });

            spells.Add(new spelldata
            {
                SDataName = "judicatorreckoning",
                ChampionName = "kayle",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "judicatordevineblessing",
                ChampionName = "kayle",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 220f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "judicatorrighteousfury",
                ChampionName = "kayle",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "judicatorintervention",
                ChampionName = "kayle",
                Slot = SpellSlot.R,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "kennenbringthelight",
                ChampionName = "kennen",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "kennenlightningrush",
                ChampionName = "kennen",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "kennenshurikenstorm",
                ChampionName = "kennen",
                Slot = SpellSlot.R,
                CastRange = 550f,
                Delay = 500f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "khazixq",
                ChampionName = "khazix",
                Slot = SpellSlot.Q,
                CastRange = 325f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "khazixqlong",
                ChampionName = "khazix",
                Slot = SpellSlot.Q,
                CastRange = 375f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "khazixw",
                ChampionName = "khazix",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "khazixwmissile",
                MissileSpeed = 81700
            });

            spells.Add(new spelldata
            {
                SDataName = "khazixwlong",
                ChampionName = "khazix",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1700
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "khazixelong",
                ChampionName = "khazix",
                Slot = SpellSlot.E,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "khazixr",
                ChampionName = "khazix",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 0f,
                HitType = new [] { global::Activator.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "khazixrlong",
                ChampionName = "khazix",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 0f,
                HitType = new[] { global::Activator.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "kogmawcausticspittle",
                ChampionName = "kogmaw",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "kogmawbioarcanbarrage",
                ChampionName = "kogmaw",
                Slot = SpellSlot.W,
                CastRange = 130f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            spells.Add(new spelldata
            {
                SDataName = "kogmawvoidooze",
                ChampionName = "kogmaw",
                Slot = SpellSlot.E,
                CastRange = 1150f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "kogmawvoidoozemissile",
                MissileSpeed = 1250
            });

            spells.Add(new spelldata
            {
                SDataName = "kogmawlivingartillery",
                ChampionName = "kogmaw",
                Slot = SpellSlot.R,
                CastRange = 2200f,
                Delay = 1200f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileName = "kogmawlivingartillery",
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "leblancchaosorb",
                ChampionName = "leblanc",
                Slot = SpellSlot.Q,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            spells.Add(new spelldata
            {
                SDataName = "leblancslide",
                ChampionName = "leblanc",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileName = "leblancslide",
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "leblacslidereturn",
                ChampionName = "leblanc",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "leblancsoulshackle",
                ChampionName = "leblanc",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "leblancsoulshackle",
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "leblancchaosorbm",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileSpeed = 2000
            });

            spells.Add(new spelldata
            {
                SDataName = "leblancslidem",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileName = "leblancslidem",
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "leblancslidereturnm",
                ChampionName = "leblanc",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "blindmonkqone",
                ChampionName = "leesin",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileName = "blindmonkqone",
                MissileSpeed = 1800
            });

            spells.Add(new spelldata
            {
                SDataName = "blindmonkqtwo",
                ChampionName = "leesin",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "blindmonkwone",
                ChampionName = "leesin",
                Slot = SpellSlot.W,
                CastRange = 700f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "blindmonkwtwo",
                ChampionName = "leesin",
                Slot = SpellSlot.W,
                CastRange = 700f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "blindmonkeone",
                ChampionName = "leesin",
                Slot = SpellSlot.E,
                CastRange = 425f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "blindmonketwo",
                ChampionName = "leesin",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 0f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "blindmonkrkick",
                ChampionName = "leesin",
                Slot = SpellSlot.R,
                CastRange = 375f,
                Delay = 500f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "leonashieldofdaybreak",
                ChampionName = "leona",
                Slot = SpellSlot.Q,
                CastRange = 215f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "leonasolarbarrier",
                ChampionName = "leona",
                Slot = SpellSlot.W,
                CastRange = 250f,
                Delay = 3000f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "leonasolarflare",
                ChampionName = "leona",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 550f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileName = "leonasolarflare",
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "lissandraq",
                ChampionName = "lissandra",
                Slot = SpellSlot.Q,
                CastRange = 725f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "lissandraqmissile",
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "lissandraw",
                ChampionName = "lissandra",
                Slot = SpellSlot.W,
                CastRange = 450f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "lissandrar",
                ChampionName = "lissandra",
                Slot = SpellSlot.R,
                CastRange = 550f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "lucianq",
                ChampionName = "lucian",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileName = "lucianq",
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "luciane",
                ChampionName = "lucian",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "lucianr",
                ChampionName = "lucian",
                Slot = SpellSlot.R,
                CastRange = 1400f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileName  = "lucianrmissileoffhand",
                ExtraMissileNames = new[] { "lucianrmissile" },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "luluq",
                ChampionName = "lulu",
                Slot = SpellSlot.Q,
                CastRange = 925f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "luluqmissile",
                MissileSpeed = 1450
            });

            spells.Add(new spelldata
            {
                SDataName = "luluw",
                ChampionName = "lulu",
                Slot = SpellSlot.W,
                CastRange = 650f,
                Delay = 640f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 2000
            });

            spells.Add(new spelldata
            {
                SDataName = "lulue",
                ChampionName = "lulu",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 640f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "lulur",
                ChampionName = "lulu",
                Slot = SpellSlot.R,
                CastRange = 900f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "luxlightbinding",
                ChampionName = "lux",
                Slot = SpellSlot.Q,
                CastRange = 1300f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileName = "luxlightbindingmis",
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "luxprismaticwave",
                ChampionName = "lux",
                Slot = SpellSlot.W,
                CastRange = 1075f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "luxlightstriketoggle",
                ChampionName = "lux",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "luxmalicecannon",
                ChampionName = "lux",
                Slot = SpellSlot.R,
                CastRange = 3340f,
                Delay = 1750f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileName = "luxmalicecannonmis",
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "kalistamysticshot",
                ChampionName = "kalista",
                Slot = SpellSlot.Q,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "kalistamysticshotmis",
                ExtraMissileNames = new[] { "kalistamysticshotmistrue" },
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "kalistaw",
                ChampionName = "kalista",
                Slot = SpellSlot.W,
                CastRange = 5000f,
                Delay = 800f,
                HitType = new HitType[] { },
                MissileSpeed = 200
            });

            spells.Add(new spelldata
            {
                SDataName = "kalistaexpungewrapper",
                ChampionName = "kalista",
                Slot = SpellSlot.E,
                CastRange = 1200f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "seismicshard",
                ChampionName = "malphite",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "obduracy",
                ChampionName = "malphite",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "landslide",
                ChampionName = "malphite",
                Slot = SpellSlot.E,
                CastRange = 400f,
                Delay = 500f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "ufslash",
                ChampionName = "malphite",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileName = "ufslash",
                MissileSpeed = 2200
            });

            spells.Add(new spelldata
            {
                SDataName = "alzaharcallofthevoid",
                ChampionName = "malzahar",
                Slot = SpellSlot.Q,
                CastRange = 900f,
                Delay = 600f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "alzaharcallofthevoid",
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "alzaharnullzone",
                ChampionName = "malzahar",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "alzaharmaleficvisions",
                ChampionName = "malzahar",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "alzaharnethergrasp",
                ChampionName = "malzahar",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "maokaitrunkline",
                ChampionName = "maokai",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "maokaiunstablegrowth",
                ChampionName = "maokai",
                Slot = SpellSlot.W,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "maokaisapling2",
                ChampionName = "maokai",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            spells.Add(new spelldata
            {
                SDataName = "maokaidrain3",
                ChampionName = "maokai",
                Slot = SpellSlot.R,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "alphastrike",
                ChampionName = "masteryi",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 600f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "meditate",
                ChampionName = "masteryi",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "wujustyle",
                ChampionName = "masteryi",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 230f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "highlander",
                ChampionName = "masteryi",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 370f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "missfortunericochetshot",
                ChampionName = "missfortune",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "missfortuneviciousstrikes",
                ChampionName = "missfortune",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "missfortunescattershot",
                ChampionName = "missfortune",
                Slot = SpellSlot.E,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "missfortunebullettime",
                ChampionName = "missfortune",
                Slot = SpellSlot.R,
                CastRange = 1400f,
                Delay = 500f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "monkeykingdoubleattack",
                ChampionName = "monkeyking",
                Slot = SpellSlot.Q,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 20
            });

            spells.Add(new spelldata
            {
                SDataName = "monkeykingdecoy",
                ChampionName = "monkeyking",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "monkeykingdecoyswipe",
                ChampionName = "monkeyking",
                Slot = SpellSlot.W,
                CastRange = 325f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "monkeykingnimbus",
                ChampionName = "monkeyking",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            spells.Add(new spelldata
            {
                SDataName = "monkeykingspintowin",
                ChampionName = "monkeyking",
                Slot = SpellSlot.R,
                CastRange = 450f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "monkeykingspintowinleave",
                ChampionName = "monkeyking",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 700
            });

            spells.Add(new spelldata
            {
                SDataName = "mordekaisermaceofspades",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "mordekaisercreepindeathcast",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.W,
                CastRange = 750f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "mordekaisersyphoneofdestruction",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "mordekaiserchildrenofthegrave",
                ChampionName = "mordekaiser",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "darkbindingmissile",
                ChampionName = "morgana",
                Slot = SpellSlot.Q,
                CastRange = 1175f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileName = "darkbindingmissile",
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "tormentedsoil",
                ChampionName = "morgana",
                Slot = SpellSlot.W,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "blackshield",
                ChampionName = "morgana",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "soulshackles",
                ChampionName = "morgana",
                Slot = SpellSlot.R,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "namiq",
                ChampionName = "nami",
                Slot = SpellSlot.Q,
                CastRange = 875f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileName = "namiqmissile",
                MissileSpeed = 1750
            });

            spells.Add(new spelldata
            {
                SDataName = "namiw",
                ChampionName = "nami",
                Slot = SpellSlot.W,
                CastRange = 725f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1100
            });

            spells.Add(new spelldata
            {
                SDataName = "namie",
                ChampionName = "nami",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "namir",
                ChampionName = "nami",
                Slot = SpellSlot.R,
                CastRange = 2550f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileName = "namirmissile",
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "nasusq",
                ChampionName = "nasus",
                Slot = SpellSlot.Q,
                CastRange = 450f,
                Delay = 500f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "nasusw",
                ChampionName = "nasus",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "nasuse",
                ChampionName = "nasus",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "nasusr",
                ChampionName = "nasus",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "nautilusanchordrag",
                ChampionName = "nautilus",
                Slot = SpellSlot.Q,
                CastRange = 1080f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl, global::Activator.HitType.Danger },
                MissileName = "nautilusanchordragmissile",
                MissileSpeed = 2000
            });

            spells.Add(new spelldata
            {
                SDataName = "nautiluspiercinggaze",
                ChampionName = "nautilus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "nautilussplashzone",
                ChampionName = "nautilus",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1300
            });

            spells.Add(new spelldata
            {
                SDataName = "nautilusgandline",
                ChampionName = "nautilus",
                Slot = SpellSlot.R,
                CastRange = 1250f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "javelintoss",
                ChampionName = "nidalee",
                Slot = SpellSlot.Q,
                CastRange = 1500f,
                Delay = 125f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileName = "javelintoss",
                MissileSpeed = 1300
            });

            spells.Add(new spelldata
            {
                SDataName = "takedown",
                ChampionName = "nidalee",
                Slot = SpellSlot.Q,
                CastRange = 150f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "bushwhack",
                ChampionName = "nidalee",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1450
            });

            spells.Add(new spelldata
            {
                SDataName = "pounce",
                ChampionName = "nidalee",
                Slot = SpellSlot.W,
                CastRange = 375f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "primalsurge",
                ChampionName = "nidalee",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "swipe",
                ChampionName = "nidalee",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "aspectofthecougar",
                ChampionName = "nidalee",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "nocturneduskbringer",
                ChampionName = "nocturne",
                Slot = SpellSlot.Q,
                CastRange = 1125f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "nocturneshroudofdarkness",
                ChampionName = "nocturne",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            spells.Add(new spelldata
            {
                SDataName = "nocturneunspeakablehorror",
                ChampionName = "nocturne",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "consume",
                ChampionName = "nunu",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "bloodboil",
                ChampionName = "nunu",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "iceblast",
                ChampionName = "nunu",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1000
            });

            spells.Add(new spelldata
            {
                SDataName = "absolutezero",
                ChampionName = "nunu",
                Slot = SpellSlot.R,
                CastRange = 650f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "olafaxethrowcast",
                ChampionName = "olaf",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "olafaxethrow",
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "olaffrenziedstrikes",
                ChampionName = "olaf",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "olafrecklessstrike",
                ChampionName = "olaf",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 500f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "olafragnarok",
                ChampionName = "olaf",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "orianadissonancecommand",
                ChampionName = "orianna",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 350f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "orianadissonancecommand",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "orianadetonatecommand",
                ChampionName = "orianna",
                Slot = SpellSlot.R,
                CastRange = 425f,
                Delay = 500f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileName = "orianadetonatecommand",
                FromObject = new[] { "yomu_ring" },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "pantheonq",
                ChampionName = "pantheon",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1900
            });

            spells.Add(new spelldata
            {
                SDataName = "pantheonw",
                ChampionName = "pantheon",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "pantheone",
                ChampionName = "pantheon",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "pantheonrjump",
                ChampionName = "pantheon",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 1000f,
                HitType = new HitType[] { },
                MissileSpeed = 3000
            });

            spells.Add(new spelldata
            {
                SDataName = "pantheonrfall",
                ChampionName = "pantheon",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 1000f,
                HitType = new HitType[] { },
                MissileSpeed = 3000
            });

            spells.Add(new spelldata
            {
                SDataName = "poppydevastatingblow",
                ChampionName = "poppy",
                Slot = SpellSlot.Q,
                CastRange = 300f,
                Delay = 500f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "poppyparagonofdemacia",
                ChampionName = "poppy",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "poppyheroiccharge",
                ChampionName = "poppy",
                Slot = SpellSlot.E,
                CastRange = 525f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1450
            });

            spells.Add(new spelldata
            {
                SDataName = "poppydiplomaticimmunity",
                ChampionName = "poppy",
                Slot = SpellSlot.R,
                CastRange = 900f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl,  },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "quinnq",
                ChampionName = "quinn",
                Slot = SpellSlot.Q,
                CastRange = 1025f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "quinnqmissile",
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "quinnw",
                ChampionName = "quinn",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "quinne",
                ChampionName = "quinn",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 775
            });

            spells.Add(new spelldata
            {
                SDataName = "quinnr",
                ChampionName = "quinn",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "quinnrfinale",
                ChampionName = "quinn",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "powerball",
                ChampionName = "rammus",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 775
            });

            spells.Add(new spelldata
            {
                SDataName = "defensiveballcurl",
                ChampionName = "rammus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "puncturingtaunt",
                ChampionName = "rammus",
                Slot = SpellSlot.E,
                CastRange = 325f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "tremors2",
                ChampionName = "rammus",
                Slot = SpellSlot.R,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "renektoncleave",
                ChampionName = "renekton",
                Slot = SpellSlot.Q,
                CastRange = 225f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "renektonpreexecute",
                ChampionName = "renekton",
                Slot = SpellSlot.W,
                CastRange = 275f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "renektonsliceanddice",
                ChampionName = "renekton",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "renektonreignofthetyrant",
                ChampionName = "renekton",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "rengarq",
                ChampionName = "rengar",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "rengarw",
                ChampionName = "rengar",
                Slot = SpellSlot.W,
                CastRange = 500f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "rengare",
                ChampionName = "rengar",
                Slot = SpellSlot.E,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "rengarefinal",
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "rengarr",
                ChampionName = "rengar",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "reksaiq",
                ChampionName = "reksai",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "reksaiw",
                ChampionName = "reksai",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 350f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "reksaiwburrowed",
                ChampionName = "reksai",
                Slot = SpellSlot.W,
                CastRange = 200f,
                Delay = 500f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "reksaie",
                ChampionName = "reksai",
                Slot = SpellSlot.E,
                CastRange = 250f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "reksaieburrowed",
                ChampionName = "reksai",
                Slot = SpellSlot.E,
                CastRange = 350f,
                Delay = 900f,
                HitType = new HitType[] { },
                MissileSpeed = 1450
            });

            spells.Add(new spelldata
            {
                SDataName = "reksair",
                ChampionName = "reksai",
                Slot = SpellSlot.R,
                CastRange = 2.147484E+09f,
                Delay = 1000f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "riventricleave",
                ChampionName = "riven",
                Slot = SpellSlot.Q,
                CastRange = 270f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "rivenmartyr",
                ChampionName = "riven",
                Slot = SpellSlot.W,
                CastRange = 260f,
                Delay = 0f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "rivenfeint",
                ChampionName = "riven",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 1450
            });

            spells.Add(new spelldata
            {
                SDataName = "rivenfengshuiengine",
                ChampionName = "riven",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "rivenizunablade",
                ChampionName = "riven",
                Slot = SpellSlot.R,
                CastRange = 1075f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileName = "rivenlightsabermissile",
                ExtraMissileNames = new[] { "rivenlightsabermissileside" },
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "rumbleflamethrower",
                ChampionName = "rumble",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "rumbleshield",
                ChampionName = "rumble",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "rumbegrenade",
                ChampionName = "rumble",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "rumblecarpetbomb",
                ChampionName = "rumble",
                Slot = SpellSlot.R,
                CastRange = 1700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "ryzeq",
                ChampionName = "ryze",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "ryzew",
                ChampionName = "ryze",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl , global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "ryzee",
                ChampionName = "ryze",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1000
            });

            spells.Add(new spelldata
            {
                SDataName = "ryzer",
                ChampionName = "ryze",
                Slot = SpellSlot.R,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "sejuaniarcticassault",
                ChampionName = "sejuani",
                Slot = SpellSlot.Q,
                CastRange = 650f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 1450
            });

            spells.Add(new spelldata
            {
                SDataName = "sejuaninorthernwinds",
                ChampionName = "sejuani",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 1000f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "sejuaniwintersclaw",
                ChampionName = "sejuani",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 0f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1450
            });

            spells.Add(new spelldata
            {
                SDataName = "sejuaniglacialprisoncast",
                ChampionName = "sejuani",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileName = "sejuaniglacialprison",
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "deceive",
                ChampionName = "shaco",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "jackinthebox",
                ChampionName = "shaco",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1450
            });

            spells.Add(new spelldata
            {
                SDataName = "twoshivpoison",
                ChampionName = "shaco",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "hallucinatefull",
                ChampionName = "shaco",
                Slot = SpellSlot.R,
                CastRange = 1125f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 395
            });

            spells.Add(new spelldata
            {
                SDataName = "shenvorpalstar",
                ChampionName = "shen",
                Slot = SpellSlot.Q,
                CastRange = 475f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "shenfeint",
                ChampionName = "shen",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "shenshadowdash",
                ChampionName = "shen",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "shenshadowdash",
                MissileSpeed = 1250
            });

            spells.Add(new spelldata
            {
                SDataName = "shenstandunited",
                ChampionName = "shen",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "shyvanadoubleattack",
                ChampionName = "shyvana",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "shyvanadoubleattackdragon",
                ChampionName = "shyvana",
                Slot = SpellSlot.Q,
                CastRange = 325f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "shyvanaimmolationauraqw",
                ChampionName = "shyvana",
                Slot = SpellSlot.W,
                CastRange = 275f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "shyvanaimmolateddragon",
                ChampionName = "shyvana",
                Slot = SpellSlot.W,
                CastRange = 250f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "shyvanafireballdragon2",
                ChampionName = "shyvana",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "shyvanatransformcast",
                ChampionName = "shyvana",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 100f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl,
                        global::Activator.HitType.Ultimate
                    },
                MissileName = "shyvanatransformcast",
                MissileSpeed = 1100
            });

            spells.Add(new spelldata
            {
                SDataName = "poisentrail",
                ChampionName = "singed",
                Slot = SpellSlot.Q,
                CastRange = 250f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "megaadhesive",
                ChampionName = "singed",
                Slot = SpellSlot.W,
                CastRange = 1175f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 700
            });

            spells.Add(new spelldata
            {
                SDataName = "fling",
                ChampionName = "singed",
                Slot = SpellSlot.E,
                CastRange = 125f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "insanitypotion",
                ChampionName = "singed",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "sionq",
                ChampionName = "sion",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 2000f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "sionw",
                ChampionName = "sion",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "sione",
                ChampionName = "sion",
                Slot = SpellSlot.E,
                CastRange = 725f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "sionemissile",
                MissileSpeed = 1800
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "sivirw",
                ChampionName = "sivir",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "sivire",
                ChampionName = "sivir",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "sivirr",
                ChampionName = "sivir",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "skarnervirulentslash",
                ChampionName = "skarner",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "skarnerexoskeleton",
                ChampionName = "skarner",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "skarnerfracture",
                ChampionName = "skarner",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "skarnerfracturemissile",
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "skarnerimpale",
                ChampionName = "skarner",
                Slot = SpellSlot.R,
                CastRange = 350f,
                Delay = 350f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "sonaq",
                ChampionName = "sona",
                Slot = SpellSlot.Q,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "sonaw",
                ChampionName = "sona",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "sonae",
                ChampionName = "sona",
                Slot = SpellSlot.E,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "sonar",
                ChampionName = "sona",
                Slot = SpellSlot.R,
                CastRange = 1000f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileName = "sonar",
                MissileSpeed = 2400
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "sorakaw",
                ChampionName = "soraka",
                Slot = SpellSlot.W,
                CastRange = 750f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "sorakae",
                ChampionName = "soraka",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 1750f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "sorakar",
                ChampionName = "soraka",
                Slot = SpellSlot.R,
                CastRange = 25000f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "swaindecrepify",
                ChampionName = "swain",
                Slot = SpellSlot.Q,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "swainshadowgrasp",
                ChampionName = "swain",
                Slot = SpellSlot.W,
                CastRange = 1040f,
                Delay = 1100f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "swainshadowgrasp",
                MissileSpeed = int.MaxValue 
            });

            spells.Add(new spelldata
            {
                SDataName = "swaintorment",
                ChampionName = "swain",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "swainmetamorphism",
                ChampionName = "swain",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 950
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "syndrawcast",
                ChampionName = "syndra",
                Slot = SpellSlot.W,
                CastRange = 950f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "syndrawcast",
                MissileSpeed = 1450
            });

            spells.Add(new spelldata
            {
                SDataName = "syndrae",
                ChampionName = "syndra",
                Slot = SpellSlot.E,
                CastRange = 950f,
                Delay = 300f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "syndrae",
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "syndrar",
                ChampionName = "syndra",
                Slot = SpellSlot.R,
                CastRange = 675f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileSpeed = 1250
            });

            spells.Add(new spelldata
            {
                SDataName = "talonnoxiandiplomacy",
                ChampionName = "talon",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "talonrake",
                ChampionName = "talon",
                Slot = SpellSlot.W,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "talonrakemissileone",
                MissileSpeed = 2300
            });

            spells.Add(new spelldata
            {
                SDataName = "taloncutthroat",
                ChampionName = "talon",
                Slot = SpellSlot.E,
                CastRange = 750f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "talonshadowassault",
                ChampionName = "talon",
                Slot = SpellSlot.R,
                CastRange = 750f,
                Delay = 260f,
                HitType = new[] { global::Activator.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "imbue",
                ChampionName = "taric",
                Slot = SpellSlot.Q,
                CastRange = 750f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "shatter",
                ChampionName = "taric",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "dazzle",
                ChampionName = "taric",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "tarichammersmash",
                ChampionName = "taric",
                Slot = SpellSlot.R,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "blindingdart",
                ChampionName = "teemo",
                Slot = SpellSlot.Q,
                CastRange = 580f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "movequick",
                ChampionName = "teemo",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 943
            });

            spells.Add(new spelldata
            {
                SDataName = "toxicshot",
                ChampionName = "teemo",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "bantamtrap",
                ChampionName = "teemo",
                Slot = SpellSlot.R,
                CastRange = 230f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "threshq",
                ChampionName = "thresh",
                Slot = SpellSlot.Q,
                CastRange = 1175f,
                Delay = 500f,
                HitType = new[] { global::Activator.HitType.CrowdControl, global::Activator.HitType.Danger  },
                MissileName = "threshqmissile",
                MissileSpeed = 1900
            });

            spells.Add(new spelldata
            {
                SDataName = "threshw",
                ChampionName = "thresh",
                Slot = SpellSlot.W,
                CastRange = 950f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "threshe",
                ChampionName = "thresh",
                Slot = SpellSlot.E,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "threshemissile1",
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "threshrpenta",
                ChampionName = "thresh",
                Slot = SpellSlot.R,
                CastRange = 420f,
                Delay = 300f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "tristanaq",
                ChampionName = "tristana",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "tristanaw",
                ChampionName = "tristana",
                Slot = SpellSlot.W,
                CastRange = 900f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1150
            });

            spells.Add(new spelldata
            {
                SDataName = "tristanae",
                ChampionName = "tristana",
                Slot = SpellSlot.E,
                CastRange = 625f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "tristanar",
                ChampionName = "tristana",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "trundletrollsmash",
                ChampionName = "trundle",
                Slot = SpellSlot.Q,
                CastRange = 275f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "trundledesecrate",
                ChampionName = "trundle",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "trundlecircle",
                ChampionName = "trundle",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "trundlepain",
                ChampionName = "trundle",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 500f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "bloodlust",
                ChampionName = "tryndamere",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "mockingshout",
                ChampionName = "tryndamere",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "undyingrage",
                ChampionName = "tryndamere",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "hideinshadows",
                ChampionName = "twich",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 450f,
                HitType = new[] { global::Activator.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "twitchvenomcask",
                ChampionName = "twich",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "twitchvenomcaskmissile",
                MissileSpeed = 1750
            });

            spells.Add(new spelldata
            {
                SDataName = "twitchvenomcaskmissle",
                ChampionName = "twich",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            spells.Add(new spelldata
            {
                SDataName = "expunge",
                ChampionName = "twich",
                Slot = SpellSlot.E,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "fullautomatic",
                ChampionName = "twich",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "pickacard",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "goldcardpreattack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl, global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "redcardpreattack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "bluecardpreattack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "cardmasterstack",
                ChampionName = "twistedfate",
                Slot = SpellSlot.E,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "destiny",
                ChampionName = "twistedfate",
                Slot = SpellSlot.R,
                CastRange = 5250f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "udyrtigerstance",
                ChampionName = "udyr",
                Slot = SpellSlot.Q,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "udyrturtlestance",
                ChampionName = "udyr",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "udyrbearstanceattack",
                ChampionName = "udyr",
                Slot = SpellSlot.E,
                CastRange = 250f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "udyrphoenixstance",
                ChampionName = "udyr",
                Slot = SpellSlot.R,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "urgotheatseekinglineqqmissile",
                ChampionName = "urgot",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new [] { global::Activator.HitType.Danger,  },
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "urgotheatseekingmissile",
                ChampionName = "urgot",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "urgotterrorcapacitoractive2",
                ChampionName = "urgot",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "urgotplasmagrenadeboom",
                ChampionName = "urgot",
                Slot = SpellSlot.E,
                CastRange = 950f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1750
            });

            spells.Add(new spelldata
            {
                SDataName = "urgotswap2",
                ChampionName = "urgot",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] {  global::Activator.HitType.CrowdControl },
                MissileSpeed = 1800
            });

            spells.Add(new spelldata
            {
                SDataName = "varusq",
                ChampionName = "varus",
                Slot = SpellSlot.Q,
                CastRange = 1250f,
                Delay = 0f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileName = "varusqmissile",
                MissileSpeed = 1900
            });

            spells.Add(new spelldata
            {
                SDataName = "varusw",
                ChampionName = "varus",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "varuse",
                ChampionName = "varus",
                Slot = SpellSlot.E,
                CastRange = 925f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "varuse",
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "varusr",
                ChampionName = "varus",
                Slot = SpellSlot.R,
                CastRange = 1300f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileName = "varusrmissile",
                MissileSpeed = 1950
            });

            spells.Add(new spelldata
            {
                SDataName = "vaynetumble",
                ChampionName = "vayne",
                Slot = SpellSlot.Q,
                CastRange = 850f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "vaynesilverbolts",
                ChampionName = "vayne",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "vaynecondemnmissile",
                ChampionName = "vayne",
                Slot = SpellSlot.E,
                CastRange = 450f,
                Delay = 500f,
                HitType = new[] { global::Activator.HitType.CrowdControl, global::Activator.HitType.Danger,  },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "vayneinquisition",
                ChampionName = "vayne",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Stealth },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "veigarbalefulstrike",
                ChampionName = "veigar",
                Slot = SpellSlot.Q,
                CastRange = 950f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileName = "veigarbalefulstrikemis",
                MissileSpeed = 1750
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "veigareventhorizon",
                ChampionName = "veigar",
                Slot = SpellSlot.E,
                CastRange = 650f,
                Delay = 0f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "",
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "veigarprimordialburst",
                ChampionName = "veigar",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "velkozq",
                ChampionName = "velkoz",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 300f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "velkozqmissile",
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "velkozqmissle",
                ChampionName = "velkoz",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
            {
                SDataName = "velkozqplitactive",
                ChampionName = "velkoz",
                Slot = SpellSlot.Q,
                CastRange = 1050f,
                Delay = 0f,
                HitType = new[] { global::Activator.HitType.CrowdControl, global::Activator.HitType.Danger },
                MissileSpeed = 1200
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "velkoze",
                ChampionName = "velkoz",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 0f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "velkozemissile",
                MissileSpeed = 1700
            });

            spells.Add(new spelldata
            {
                SDataName = "velkozr",
                ChampionName = "velkoz",
                Slot = SpellSlot.R,
                CastRange = 1575f,
                Delay = 0f,
                HitType = new[] { global::Activator.HitType.Ultimate },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "viq",
                ChampionName = "vi",
                Slot = SpellSlot.Q,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "viw",
                ChampionName = "vi",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "vie",
                ChampionName = "vi",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 0f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "vir",
                ChampionName = "vi",
                Slot = SpellSlot.R,
                CastRange = 800f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "viktorpowertransfer",
                ChampionName = "viktor",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "viktorgravitonfield",
                ChampionName = "viktor",
                Slot = SpellSlot.W,
                CastRange = 815f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            spells.Add(new spelldata
            {
                SDataName = "viktordeathray",
                ChampionName = "viktor",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileName = "viktordeathraymis",
                MissileSpeed = 1210
            });

            spells.Add(new spelldata
            {
                SDataName = "viktorchaosstorm",
                ChampionName = "viktor",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 350f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.CrowdControl, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.Danger
                    },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "vladimirtransfusion",
                ChampionName = "vladimir",
                Slot = SpellSlot.Q,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "vladimirsanguinepool",
                ChampionName = "vladimir",
                Slot = SpellSlot.W,
                CastRange = 350f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "vladimirtidesofblood",
                ChampionName = "vladimir",
                Slot = SpellSlot.E,
                CastRange = 610f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1100
            });

            spells.Add(new spelldata
            {
                SDataName = "vladimirhemoplague",
                ChampionName = "vladimir",
                Slot = SpellSlot.R,
                CastRange = 875f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "volibearq",
                ChampionName = "volibear",
                Slot = SpellSlot.Q,
                CastRange = 300f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "volibearw",
                ChampionName = "volibear",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = 1450
            });

            spells.Add(new spelldata
            {
                SDataName = "volibeare",
                ChampionName = "volibear",
                Slot = SpellSlot.E,
                CastRange = 425f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 825
            });

            spells.Add(new spelldata
            {
                SDataName = "volibearr",
                ChampionName = "volibear",
                Slot = SpellSlot.R,
                CastRange = 425f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 825
            });

            spells.Add(new spelldata
            {
                SDataName = "hungeringstrike",
                ChampionName = "warwick",
                Slot = SpellSlot.Q,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "hunterscall",
                ChampionName = "warwick",
                Slot = SpellSlot.W,
                CastRange = 1000f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "bloodscent",
                ChampionName = "warwick",
                Slot = SpellSlot.E,
                CastRange = 1250f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "infiniteduress",
                ChampionName = "warwick",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });
            
            spells.Add(new spelldata
            {
                SDataName = "xeratharcanopulsechargeup",
                ChampionName = "xerath",
                Slot = SpellSlot.Q,
                CastRange = 750f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            spells.Add(new spelldata
            {
                SDataName = "xeratharcanebarrage2",
                ChampionName = "xerath",
                Slot = SpellSlot.W,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "xeratharcanebarrage2",
                MissileSpeed = 20
            });

            spells.Add(new spelldata
            {
                SDataName = "xerathmagespear",
                ChampionName = "xerath",
                Slot = SpellSlot.E,
                CastRange = 1050f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl, global::Activator.HitType.Danger },
                MissileName = "xerathmagespearmissile",
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "xerathlocusofpower2",
                ChampionName = "xerath",
                Slot = SpellSlot.R,
                CastRange = 5600f,
                Delay = 750f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            spells.Add(new spelldata
            {
                SDataName = "xenzhaothrust3",
                ChampionName = "xinzhao",
                Slot = SpellSlot.Q,
                CastRange = 400f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "xenzhaobattlecry",
                ChampionName = "xinzhao",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 0f,
                HitType = new HitType[] { },
                MissileSpeed = 2000
            });

            spells.Add(new spelldata
            {
                SDataName = "xenzhaosweep",
                ChampionName = "xinzhao",
                Slot = SpellSlot.E,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl, global::Activator.HitType.Danger },
                MissileSpeed = 1750
            });

            spells.Add(new spelldata
            {
                SDataName = "xenzhaoparry",
                ChampionName = "xinzhao",
                Slot = SpellSlot.R,
                CastRange = 375f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileSpeed = 1750
            });

            spells.Add(new spelldata
            {
                SDataName = "yasuoqw",
                ChampionName = "yasuo",
                Slot = SpellSlot.Q,
                CastRange = 475f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "yasuoq2w",
                ChampionName = "yasuo",
                Slot = SpellSlot.Q,
                CastRange = 475f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "yasuoq3",
                ChampionName = "yasuo",
                Slot = SpellSlot.Q,
                CastRange = 1000f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "yasuoq3mis",
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "yasuowmovingwall",
                ChampionName = "yasuo",
                Slot = SpellSlot.W,
                CastRange = 400f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 500
            });

            spells.Add(new spelldata
            {
                SDataName = "yasuodashwrapper",
                ChampionName = "yasuo",
                Slot = SpellSlot.E,
                CastRange = 475f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 20
            });

            spells.Add(new spelldata
            {
                SDataName = "yasuorknockupcombow",
                ChampionName = "yasuo",
                Slot = SpellSlot.R,
                CastRange = 1200f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "yorickspectral",
                ChampionName = "yorick",
                Slot = SpellSlot.Q,
                CastRange = 350f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "yorickdecayed",
                ChampionName = "yorick",
                Slot = SpellSlot.W,
                CastRange = 600f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "yorickravenous",
                ChampionName = "yorick",
                Slot = SpellSlot.E,
                CastRange = 550f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "yorickreviveally",
                ChampionName = "yorick",
                Slot = SpellSlot.R,
                CastRange = 900f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "zacq",
                ChampionName = "zac",
                Slot = SpellSlot.Q,
                CastRange = 550f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "zacq",
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "zacw",
                ChampionName = "zac",
                Slot = SpellSlot.W,
                CastRange = 350f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "zace",
                ChampionName = "zac",
                Slot = SpellSlot.E,
                CastRange = 1550f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1500
            });

            spells.Add(new spelldata
            {
                SDataName = "zacr",
                ChampionName = "zac",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "zedw",
                ChampionName = "zed",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 1600
            });

            spells.Add(new spelldata
            {
                SDataName = "zede",
                ChampionName = "zed",
                Slot = SpellSlot.E,
                CastRange = 300f,
                Delay = 0f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "zedr",
                ChampionName = "zed",
                Slot = SpellSlot.R,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.Danger },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "ziggsw",
                ChampionName = "ziggs",
                Slot = SpellSlot.W,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "ziggsw",
                MissileSpeed = 1750
            });

            spells.Add(new spelldata
            {
                SDataName = "ziggswtoggle",
                ChampionName = "ziggs",
                Slot = SpellSlot.W,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            spells.Add(new spelldata
            {
                SDataName = "ziggse",
                ChampionName = "ziggs",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "ziggse",
                MissileSpeed = 1750
            });

            spells.Add(new spelldata
            {
                SDataName = "ziggse2",
                ChampionName = "ziggs",
                Slot = SpellSlot.E,
                CastRange = 850f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1750
            });

            spells.Add(new spelldata
            {
                SDataName = "ziggsr",
                ChampionName = "ziggs",
                Slot = SpellSlot.R,
                CastRange = 2250f,
                Delay = 1800f,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                MissileName = "ziggsr",
                MissileSpeed = 1750
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "zileanw",
                ChampionName = "zilean",
                Slot = SpellSlot.W,
                CastRange = 0f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
            {
                SDataName = "zileane",
                ChampionName = "zilean",
                Slot = SpellSlot.E,
                CastRange = 700f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileSpeed = 1100
            });

            spells.Add(new spelldata
            {
                SDataName = "zileanr",
                ChampionName = "zilean",
                Slot = SpellSlot.R,
                CastRange = 780f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = int.MaxValue
            });

            spells.Add(new spelldata
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

            spells.Add(new spelldata
            {
                SDataName = "zyraseed",
                ChampionName = "zyra",
                Slot = SpellSlot.W,
                CastRange = 800f,
                Delay = 250f,
                HitType = new HitType[] { },
                MissileSpeed = 2200
            });

            spells.Add(new spelldata
            {
                SDataName = "zyragraspingroots",
                ChampionName = "zyra",
                Slot = SpellSlot.E,
                CastRange = 1100f,
                Delay = 250f,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                MissileName = "zyragraspingroots",
                MissileSpeed = 1400
            });

            spells.Add(new spelldata
            {
                SDataName = "zyrabramblezone",
                ChampionName = "zyra",
                Slot = SpellSlot.R,
                CastRange = 700f,
                Delay = 250f,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.CrowdControl
                    },
                MissileSpeed = int.MaxValue
            });
        }

        public static List<item> items = new List<item>();
        public static List<item> activeitems = new List<item>(); 
        public static List<spell> mypells = new List<spell>();
        public static List<summoner> summoners = new List<summoner>();
        public static List<spelldata> spells = new List<spelldata>();

        public static Dictionary<SpellDamageDelegate, SpellSlot> damagelib = new Dictionary<SpellDamageDelegate, SpellSlot>();

        public static spelldata GetByMissileName(string missilename)
        {
            foreach (var sdata in spells)
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
