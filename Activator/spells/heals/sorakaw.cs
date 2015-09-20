using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Spells.Heals
{
    class sorakaw : spell
    {
        internal override string Name
        {
            get { return "sorakaw"; }
        }

        internal override string DisplayName
        {
            get { return "Astral Infusion | W"; }
        }

        internal override float Range
        {
            get { return 550f; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.SelfLowHP, MenuType.SelfMuchHP, MenuType.SelfMinHP }; }
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

            if (Player.Health/Player.MaxHealth*100 <
                Menu.Item("selfminhp" + Name + "pct").GetValue<Slider>().Value)
                return;

            foreach (var hero in Activator.Allies())
            {
                if (hero.Player.IsMe)
                    continue;

                if (!Parent.Item(Parent.Name + "useon" + hero.Player.ChampionName).GetValue<bool>())
                    continue;

                if (hero.Player.Distance(Player.ServerPosition) <= Range)
                {
                    if (hero.Player.Health / hero.Player.MaxHealth * 100 <=
                        Menu.Item("selflowhp" + Name + "pct").GetValue<Slider>().Value)
                        UseSpellOn(hero.Player);

                    if (hero.IncomeDamage / hero.Player.MaxHealth * 100 >=
                        Menu.Item("selfmuchhp" + Name + "pct").GetValue<Slider>().Value)
                        UseSpellOn(hero.Player);
                }
            }
        }
    }
}
