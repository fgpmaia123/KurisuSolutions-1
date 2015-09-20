using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Summoners
{
    class snowball : summoner
    {
        internal override string Name
        {
            get { return "summonersnowball"; }
        }

        internal override string DisplayName
        {
            get { return "Mark"; }
        }

        internal override float Range
        {
            get { return 1500f; }
        }

        internal override int Duration
        {
            get { return 100; }
        }

        private static Spell mark;

        public snowball()
        {
            mark = new Spell(Player.GetSpellSlot(Name), Range);
            mark.SetSkillshot(0f, 60f, 1500f, true, SkillshotType.SkillshotLine);
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !mark.IsReady())
                return;

            if (Player.GetSpell(mark.Slot).Name.ToLower() != Name)
                return;

            foreach (var tar in Activator.Heroes.Where(hero => hero.Player.IsValidTarget(Range)))
            {
                if (Parent.Item(Parent.Name + "useon" + tar.Player.ChampionName).GetValue<bool>())
                    mark.CastIfHitchanceEquals(tar.Player, HitChance.Medium);
            }
        }
    }
}
