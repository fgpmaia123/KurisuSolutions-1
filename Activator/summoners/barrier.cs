using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Summoners
{
    internal class barrier : summoner
    {
        internal override string Name
        {
            get { return "summonerbarrier"; }
        }

        internal override string DisplayName
        {
            get { return "Barrier"; }
        }

        internal override string[] ExtraNames
        {
            get { return new[] { "" }; }
        }

        internal override float Range
        {
            get { return float.MaxValue; }
        }

        internal override int Duration
        {
            get { return 1500; }
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            foreach (var hero in Activator.Allies())
            {
                if (hero.Player.NetworkId != Player.NetworkId)
                    continue;

                if (!Parent.Item(Parent.Name + "useon" + hero.Player.ChampionName).GetValue<bool>())
                    continue;

                if (hero.Player.Health / hero.Player.MaxHealth * 100 <=
                    Menu.Item("selflowhp" + Name + "pct").GetValue<Slider>().Value)
                {
                    if (hero.IncomeDamage > 0 && !hero.Player.IsRecalling() && !hero.Player.InFountain())
                        UseSpell();

                    if (hero.IncomeDamage > hero.Player.Health)
                        UseSpell();
                }

                if (hero.IncomeDamage / hero.Player.MaxHealth * 100 >=
                    Menu.Item("selfmuchhp" + Name + "pct").GetValue<Slider>().Value)
                    UseSpell();

                if (Menu.Item("use" + Name + "ulti").GetValue<bool>() &&
                    hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Ultimate))
                    UseSpell();
            }
        }
    }
}
