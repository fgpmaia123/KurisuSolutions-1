using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Spells.Evaders
{
    class vladimirsanguinepool : spell
    {
        internal override string Name
        {
            get { return "vladimirsanguinepool"; }
        }

        internal override string DisplayName
        {
            get { return "Sanguine Pool | W"; }
        }

        internal override float Range
        {
            get { return float.MaxValue; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.SpellShield, MenuType.Zhonyas }; }
        }

        internal override int DefaultHP
        {
            get { return 0; }
        }

        internal override int DefaultMP
        {
            get { return 45; }
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

                if (Menu.Item("ss" + Name + "all").GetValue<bool>())
                {
                    if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Spell))
                        UseSpell();
                }

                if (Menu.Item("ss" + Name + "cc").GetValue<bool>())
                {
                    if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.CrowdControl))
                        UseSpell();
                }

                if (Menu.Item("use" + Name + "norm").GetValue<bool>())
                {
                    if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Danger))
                        UseSpell();
                }

                if (Menu.Item("use" + Name + "ulti").GetValue<bool>())
                {
                    if (hero.IncomeDamage > 0 && hero.HitTypes.Contains(HitType.Ultimate))
                        UseSpell();
                }
            }
        }
    }
}
