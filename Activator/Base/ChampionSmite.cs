using System.Collections.Generic;
using LeagueSharp;

namespace Activator.Handlers
{
    public class ChampionSmite
    {
        public string Name;
        public float CastRange;
        public SpellSlot Slot;
        public int Stage;
        public SpellDataTargetType Type;

        public static List<ChampionSmite> SpellList = new List<ChampionSmite>();

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
                    if (Activator.Player.CharData.BaseSkinName != "elisespider")
                        return false;
                    break;
            }

            return true;
        }

        static ChampionSmite()
        {
            SpellList.Add(new ChampionSmite
            {
                Name = "FiddleSticks",
                CastRange = 750f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "JarvanIV",
                CastRange = 770f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Twitch",
                CastRange = 950f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Riven",
                CastRange = 150f,
                Slot = SpellSlot.W,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Malphite",
                CastRange = 200f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Nunu",
                CastRange = 200f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Olaf",
                CastRange = 325f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Elise",
                CastRange = 475f,
                Slot = SpellSlot.Q,
                Stage = 1,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Warwick",
                CastRange = 400f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "MasterYi",
                CastRange = 600f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Kayle",
                CastRange = 650f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Khazix",
                CastRange = 325f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "MonkeyKing",
                CastRange = 300f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Darius",
                CastRange = 425f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Diana",
                CastRange = 825f,
                Slot = SpellSlot.R,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Fizz",
                CastRange = 550f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Evelynn",
                CastRange = 225f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });


            SpellList.Add(new ChampionSmite
            {
                Name = "Maokai",
                CastRange = 600f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Nocturne",
                CastRange = 500f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Pantheon",
                CastRange = 600f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Volibear",
                CastRange = 400f,
                Slot = SpellSlot.W,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Tryndamere",
                CastRange = 400f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Zac",
                CastRange = 550f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Location
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Shen",
                CastRange = 475f,
                Slot = SpellSlot.Q,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "XinZhao",
                CastRange = 600f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Unit
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "Amumu",
                CastRange = 150f,
                Slot = SpellSlot.E,
                Stage = 0,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new ChampionSmite
            {
                Name = "LeeSin",
                CastRange = 1300f,
                Slot = SpellSlot.Q,
                Stage = 1,
                Type = SpellDataTargetType.Self
            });

            SpellList.Add(new ChampionSmite
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