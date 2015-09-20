using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Spells.Evaders
{
    class judicatorintervention : spell
    {
        internal override string Name
        {
            get { return "judicatorintervention"; }
        }

        internal override string DisplayName
        {
            get { return "Intervention | R"; }
        }

        internal override float Range
        {
            get { return 900f; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.SelfLowHP,  MenuType.Zhonyas }; }
        }

        internal override int DefaultHP
        {
            get { return 10; }
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
                if (Parent.Item(Parent.Name + "useon" + hero.Player.ChampionName).GetValue<bool>())
                {
                    if (hero.Player.Distance(Player.ServerPosition) <= Range)
                    {
                        if (hero.Player.Health / hero.Player.MaxHealth * 100 <=
                            Menu.Item("selflowhp" + Name + "pct").GetValue<Slider>().Value)
                            if (hero.IncomeDamage > 0)
                                UseSpellOn(hero.Player);

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
