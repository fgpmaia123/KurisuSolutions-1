using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Spells.Heals
{
    class namiw : spell
    {
        internal override string Name
        {
            get { return "namiw"; }
        }

        internal override string DisplayName
        {
            get { return "Ebb and Flow | W"; }
        }

        internal override float Range
        {
            get { return 725f; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.SelfLowHP, MenuType.SelfMuchHP, MenuType.SelfMinMP }; }
        }

        internal override int DefaultHP
        {
            get { return 90; }
        }

        internal override int DefaultMP
        {
            get { return 55; }
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            if (Player.Mana/Player.MaxMana*100 <
                Menu.Item("selfminmp" + Name + "pct").GetValue<Slider>().Value)
                return;

            foreach (var hero in Activator.Allies())
            {
                if (!Parent.Item(Parent.Name + "useon" + hero.Player.ChampionName).GetValue<bool>())
                    continue; 

                if (hero.Player.Distance(Player.ServerPosition) <= Range)
                {
                    if (hero.Player.Health/hero.Player.MaxHealth*100 <=
                        Menu.Item("selflowhp" + Name + "pct").GetValue<Slider>().Value)
                        UseSpellOn(hero.Player);

                    if (hero.IncomeDamage/hero.Player.MaxHealth*100 >=
                        Menu.Item("selfmuchhp" + Name + "pct").GetValue<Slider>().Value)
                        UseSpellOn(hero.Player);
                }
            }
        }
    }
}
