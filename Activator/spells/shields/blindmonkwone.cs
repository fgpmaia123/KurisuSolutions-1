using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Spells.Shields
{
    class blindmonkwone : spell
    {
        internal override string Name
        {
            get { return "blindmonkwone"; }
        }

        internal override string DisplayName
        {
            get { return "Safegaurd | W"; }
        }

        internal override float Range
        {
            get { return 700f; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.SelfLowHP, MenuType.SelfMuchHP, MenuType.SelfMinMP }; }
        }

        internal override int DefaultHP
        {
            get { return 95; }
        }

        internal override int DefaultMP
        {
            get { return 45; }
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            if (Player.Mana / Player.MaxMana * 100 <
                Menu.Item("selfminmp" + Name + "pct").GetValue<Slider>().Value)
                return;

            foreach (var hero in Activator.Allies())
            {                    
                if (!Parent.Item(Parent.Name + "useon" + hero.Player.ChampionName).GetValue<bool>())
                    continue;

                if (Player.GetSpell(SpellSlot.W).Name.ToLower() != "blindmonkwone")
                    return;

                if (hero.Player.Distance(Player.ServerPosition) <= Range)
                {
                    if (hero.IncomeDamage / hero.Player.MaxHealth * 100 >=
                        Menu.Item("selfmuchhp" + Name + "pct").GetValue<Slider>().Value)
                        UseSpellOn(hero.Player);

                    if (hero.Player.Health / hero.Player.MaxHealth * 100 <=
                        Menu.Item("selflowhp" + Name + "pct").GetValue<Slider>().Value)
                    {
                        if (hero.IncomeDamage > 0 || hero.MinionDamage > hero.Player.Health)
                            UseSpellOn(hero.Player);
                    }
                }
            }
        }
    }
}
