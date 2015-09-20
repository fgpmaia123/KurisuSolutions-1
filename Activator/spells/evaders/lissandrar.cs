using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Spells.Evaders
{
    class lissandrar : spell
    {
        internal override string Name
        {
            get { return "lissandrar"; }
        }

        internal override string DisplayName
        {
            get { return "Frozen Tomb | R"; }
        }

        internal override float Range
        {
            get { return float.MaxValue; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.Zhonyas }; }
        }

        internal override int DefaultHP
        {
            get { return 30; }
        }

        internal override int DefaultMP
        {
            get { return 0; }
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            foreach (var hero in Activator.Allies())
            {
                if (hero.Player.NetworkId == Player.NetworkId)
                {
                    if (!Parent.Item(Parent.Name + "useon" + hero.Player.ChampionName).GetValue<bool>())
                        continue;

                    if (hero.Player.CountEnemiesInRange(425) >= 1)
                    {
                        if (Menu.Item("use" + Name + "norm").GetValue<bool>())
                            if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Danger))
                                UseSpellOn(hero.Player);

                        if (Menu.Item("use" + Name + "ulti").GetValue<bool>())
                            if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Ultimate))
                                UseSpellOn(hero.Player);
                    }
                }
            }
        }
    }
}
