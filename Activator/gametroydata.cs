#region Copyright © 2015 Kurisu Solutions
// All rights are reserved. Transmission or reproduction in part or whole,
// any form or by any means, mechanical, electronical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Document:	activator/gametroydata.cs
// Date:		01/07/2015
// Author:		Robin Kurisu
#endregion

using System;
using LeagueSharp;
using System.Collections.Generic;

namespace Activator
{
    public class gametroydata
    {
        public string Name { get; set; }
        public string ChampionName { get; set; }
        public SpellSlot Slot { get; set; }
        public float Radius { get; set; }
        public double Interval { get; set; }
        public int TickLimiter { get; set; }
        public bool PredictDmg { get; set; }
        public HitType[] HitType { get; set; }
        public int DelayFromStart { get; set; }
        public static List<gametroydata> troydata = new List<gametroydata>(); 


        static gametroydata()
        {
            troydata.Add(new gametroydata
            {
                Name = "Hecarim_Defile",
                ChampionName = "Hecarim",
                Radius = 500f,
                Slot = SpellSlot.W,
                HitType = new[] { global::Activator.HitType.None },
                PredictDmg = true,
                Interval = .75
            });

            troydata.Add(new gametroydata
            {
                Name = "Gangplank_Base_R_AoE",
                ChampionName = "Gangplank",
                Radius = 500f,
                Slot = SpellSlot.R,
                HitType = new[] { global::Activator.HitType.None },
                PredictDmg = true,
                Interval = 1.5
            });

            troydata.Add(new gametroydata
            {
                Name = "W_Shield",
                ChampionName = "Diana",
                Radius = 200f,
                Slot = SpellSlot.W,
                HitType = new[] { global::Activator.HitType.None },
                PredictDmg = true,
                Interval = 1.0
            });

            troydata.Add(new gametroydata
            {
                Name = "W_aoe_red",
                ChampionName = "Malzahar",
                Radius = 475f,
                Slot = SpellSlot.W,
                HitType = new[] { global::Activator.HitType.None },
                PredictDmg = true,
                Interval = 1.0
            });

            troydata.Add(new gametroydata
            {
                Name = "E_Defile",
                ChampionName = "Karthus",
                Radius = 475f,
                Slot = SpellSlot.E,
                HitType = new[] { global::Activator.HitType.None },
                PredictDmg = true,
                Interval = 1.0
            });

            troydata.Add(new gametroydata
            {
                Name = "Elise_Base_W_volatile",
                ChampionName = "Elise",
                Radius =  150f,
                Slot = SpellSlot.W,
                HitType = new[] { global::Activator.HitType.None },
                PredictDmg = true,
                Interval = 1.0
            });

            troydata.Add(new gametroydata
            {
                Name = "DarkWind_tar",
                ChampionName = "FiddleSticks",
                Radius = 250f,
                Slot = SpellSlot.E,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                PredictDmg = true,
                Interval = 1.5
            });

            troydata.Add(new gametroydata
            {
                Name = "Ahri_Base_FoxFire",
                ChampionName = "Ahri",
                Radius = 550f,
                Slot = SpellSlot.W,
                HitType = new[] { global::Activator.HitType.None },
                PredictDmg = true,
                Interval = 1.0
            });

            troydata.Add(new gametroydata
            {
                Name = "Fizz_Ring_Red",
                ChampionName = "Fizz",
                Radius = 300f,
                Slot = SpellSlot.R,
                DelayFromStart = 800,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.Ultimate },
                PredictDmg = true,
                Interval = 1.0
             });

            troydata.Add(new gametroydata
            {
                Name = "katarina_deathLotus_tar",
                ChampionName = "Katarina",
                Radius = 550f,
                Slot = SpellSlot.R,
                HitType = new[] { global::Activator.HitType.ForceExhaust, global::Activator.HitType.Danger },
                PredictDmg = true,
                Interval = 0.5
            });

            troydata.Add(new gametroydata
            {
                Name = "Nautilus_R_sequence_impact",
                ChampionName = "Nautilus",
                Radius = 250f,
                Slot = SpellSlot.R,
                HitType = new[] { global::Activator.HitType.CrowdControl, global::Activator.HitType.Danger },
                PredictDmg = false
            });

            troydata.Add(new gametroydata
            {
                Name = "Acidtrail_buf",
                ChampionName = "Singed",
                Radius = 200f,
                Slot = SpellSlot.Q,
                HitType = new []{ global::Activator.HitType.None },
                PredictDmg = true,
                Interval = 1.0
            });

            troydata.Add(new gametroydata
            {
                Name = "Tremors_cas",
                ChampionName = "Rammus",
                Radius = 450f,
                Slot = SpellSlot.R,
                HitType = new[] { global::Activator.HitType.None },
                PredictDmg = true,
                Interval = 1.0
            });

            troydata.Add(new gametroydata
            {
                Name = "Crowstorm",
                ChampionName = "FiddleSticks",
                Radius = 450f,
                Slot = SpellSlot.R,
                HitType =
                    new[]
                    {
                        global::Activator.HitType.Danger, global::Activator.HitType.Ultimate,
                        global::Activator.HitType.ForceExhaust
                    },
                PredictDmg = true,
                Interval = 1.0
            });

            troydata.Add(new gametroydata
            {
                Name = "caitlyn_Base_yordleTrap_idle",
                ChampionName = "Caitlyn",
                Radius = 280f,
                Slot = SpellSlot.W,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                PredictDmg = false,
                Interval = 1.0
            });

            troydata.Add(new gametroydata
            {
                Name = "tar_aoe_red",
                ChampionName = "Lux",
                Radius = 400f,
                Slot = SpellSlot.E,
                HitType = new[] { global::Activator.HitType.None },
                PredictDmg = true,
                Interval = 2.0
            });

            troydata.Add(new gametroydata
            {
                Name = "Viktor_ChaosStorm",
                ChampionName = "Viktor",
                Radius = 425f,
                Slot = SpellSlot.R,
                HitType = new[] { global::Activator.HitType.Danger, global::Activator.HitType.CrowdControl },
                PredictDmg = true,
                Interval = .75
            });

            troydata.Add(new gametroydata
            {
                Name = "Viktor_Catalyst",
                ChampionName = "Viktor",
                Radius = 375f,
                Slot = SpellSlot.W,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                PredictDmg = false
            });

            troydata.Add(new gametroydata
            {
                Name = "W_AUG",
                ChampionName = "Viktor",
                Radius = 375f,
                Slot = SpellSlot.W,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                PredictDmg = false
            });

            troydata.Add(new gametroydata
            {
                Name = "cryo_storm",
                ChampionName = "Anivia",
                Radius = 450f,
                Slot = SpellSlot.R,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                PredictDmg = true,
                Interval = 1.0
            });

            troydata.Add(new gametroydata
            {
                Name = "ZiggsE",
                ChampionName = "Ziggs",
                Radius = 400f,
                Slot = SpellSlot.E,
                HitType = new []{ global::Activator.HitType.CrowdControl },
                PredictDmg = true,
                Interval = 1.0
            });

            troydata.Add(new gametroydata
            {
                Name = "ZiggsWRing",
                ChampionName = "Ziggs",
                Radius = 350f,
                Slot = SpellSlot.W,
                HitType = new []{ global::Activator.HitType.CrowdControl },
                PredictDmg = false
            });

            troydata.Add(new gametroydata
            {
                Name = "W_Miasma_tar",
                ChampionName = "Cassiopeia",
                Radius = 365f,
                Slot = SpellSlot.W,
                HitType = new[] { global::Activator.HitType.None },
                PredictDmg = true,
                Interval = 1.0
            });

            troydata.Add(new gametroydata
            {
                Name = "Soraka_Base_E_rune",
                ChampionName = "Soraka",
                Radius = 375f,
                Slot = SpellSlot.E,
                HitType = new[] { global::Activator.HitType.CrowdControl },
                PredictDmg = true,
                Interval = 1.0
            });

            troydata.Add(new gametroydata
            {
                Name = "W_Tar",
                ChampionName = "Morgana",
                Radius = 375f,
                Slot = SpellSlot.W,
                HitType = new []{ global::Activator.HitType.None },
                PredictDmg = true,
                Interval = .75
            });
        }
    }
}
