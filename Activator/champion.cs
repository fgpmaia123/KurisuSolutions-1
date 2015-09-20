#region Copyright © 2015 Kurisu Solutions
// All rights are reserved. Transmission or reproduction in part or whole,
// any form or by any means, mechanical, electronical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Document:	activator/champion.cs
// Date:		01/07/2015
// Author:		Robin Kurisu
#endregion

using LeagueSharp;
using System.Collections.Generic;

namespace Activator
{
    public class champion
    {
        public float IncomeDamage;
        public float MinionDamage;

        public Obj_AI_Hero Player;
        public Obj_AI_Base Attacker;

        public bool ForceQSS;
        public bool Immunity;
        public bool WalkedInTroy;
        public bool HasRecentAura;
        public string LastDebuff;

        public int DotTicks;
        public int TroyTicks;
        public int QSSBuffCount;
        public int CleanseBuffCount;
        public int DervishBuffCount;
        public int MercurialBuffCount;
        public int MikaelsBuffCount;

        public int QSSHighestBuffTime;
        public int CleanseHighestBuffTime;
        public int DervishHighestBuffTime;
        public int MercurialHighestBuffTime;
        public int MikaelsHighestBuffTime;
        public int LastDebuffTimestamp;

        public List<HitType> HitTypes = new List<HitType>();
        public champion(Obj_AI_Hero player, float incdmg)
        {
            Player = player;
            IncomeDamage = incdmg;
        }
    }

    public class championsmite
    {
        public string Name;
        public float CastRange;
        public SpellSlot Slot;
        public int Stage;
        public SpellDataTargetType Type;
        public static List<championsmite> List = new List<championsmite>();

        public bool HeroReqs(Obj_AI_Base unit)
        {
            if (unit == null)
                return false;

            switch (Activator.Player.ChampionName)
            {
                case "Twitch":
                    if (!unit.HasBuff("twitchdeadlyvenom"))
                        return false;
                    break;
                case "LeeSin":
                    if (!unit.HasBuff("blindmonkqonechaos"))
                        return false;
                    break;
                case "Diana":
                    if (!unit.HasBuff("dianamoonlight"))
                        return false;
                    break;
                case "Elise":
                    if (Activator.Player.BaseSkinName != "elisespider")
                        return false;
                    break;
            }

            return true;
        }

        static championsmite()
        {
            List.Add(new championsmite
            {
                Name = "FiddleSticks",
                CastRange = 750f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            List.Add(new championsmite
            {
                Name = "JarvanIV",
                CastRange = 770f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            List.Add(new championsmite
            {
                Name = "Twitch",
                CastRange = 950f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            List.Add(new championsmite
            {
                Name = "Riven",
                CastRange = 150f,
                Slot = SpellSlot.W,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            List.Add(new championsmite
            {
                Name = "Malphite",
                CastRange = 200f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            List.Add(new championsmite
            {
                Name = "Nunu",
                CastRange = 200f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            List.Add(new championsmite
            {
                Name = "Olaf",
                CastRange = 325f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            List.Add(new championsmite
            {
                Name = "Elise",
                CastRange = 475f,
                Slot = SpellSlot.Q,
                Stage = 1,
                Type = SpellDataTargetType.Unit
            });

            List.Add(new championsmite
            {
                Name = "Warwick",
                CastRange = 400f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            List.Add(new championsmite
            {
                Name = "MasterYi",
                CastRange = 600f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            List.Add(new championsmite
            {
                Name = "Kayle",
                CastRange = 650f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            List.Add(new championsmite
            {
                Name = "Khazix",
                CastRange = 325f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            List.Add(new championsmite
            {
                Name = "MonkeyKing",
                CastRange = 300f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            List.Add(new championsmite
            {
                Name = "Darius",
                CastRange = 425f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            List.Add(new championsmite
            {
                Name = "Diana",
                CastRange = 825f,
                Slot = SpellSlot.R,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            List.Add(new championsmite
            {
                Name = "Fizz",
                CastRange = 550f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            List.Add(new championsmite
            {
                Name = "Evelynn",
                CastRange = 225f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });


            List.Add(new championsmite
            {
                Name = "Maokai",
                CastRange = 600f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            List.Add(new championsmite
            {
                Name = "Nocturne",
                CastRange = 500f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            List.Add(new championsmite
            {
                Name = "Pantheon",
                CastRange = 600f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            List.Add(new championsmite
            {
                Name = "Volibear",
                CastRange = 400f,
                Slot = SpellSlot.W,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            List.Add(new championsmite
            {
                Name = "Tryndamere",
                CastRange = 400f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            List.Add(new championsmite
            {
                Name = "Zac",
                CastRange = 550f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            List.Add(new championsmite
            {
                Name = "Shen",
                CastRange = 475f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            List.Add(new championsmite
            {
                Name = "XinZhao",
                CastRange = 600f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            List.Add(new championsmite
            {
                Name = "Amumu",
                CastRange = 150f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            List.Add(new championsmite
            {
                Name = "LeeSin",
                CastRange = 1300f,
                Slot = SpellSlot.Q,
                Stage = 1,
                Type = SpellDataTargetType.Self
            });

            List.Add(new championsmite
            {
                Name = "Chogath",
                CastRange = 175f,
                Slot = SpellSlot.R,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });
        }
    }
}
