using System;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Items.Offensives
{
    class _3800 : item
    {
        internal override int Id
        {
            get { return 3800; }
        }

        internal override int Priority
        {
            get { return 7; }
        }

        internal override string Name
        {
            get { return "Righteous"; }
        }

        internal override string DisplayName
        {
            get { return "Righteous Glory"; }
        }

        internal override int Duration
        {
            get { return 1000; }
        }

        internal override float Range
        {
            get { return 600f; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.EnemyLowHP, MenuType.SelfLowHP, MenuType.ActiveCheck }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.Common }; }
        }

        internal override int DefaultHP
        {
            get { return 55; }
        }

        internal override int DefaultMP
        {
            get { return 0; }
        }

        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>() || !IsReady())
                return;

            if (Menu.Item("use" + Name).GetValue<bool>() && Tar != null)
            {
                if (Player.Health / Player.MaxHealth * 100 <= Menu.Item("selflowhp" + Name + "pct").GetValue<Slider>().Value)
                {
                    if (Utils.GameTimeTickCount - Activator.LastUsedTimeStamp >= 3000 || Player.CountEnemiesInRange(Range) >= 1)
                    {
                        UseItem();
                    }
                }

                if (!Parent.Item(Parent.Name + "useon" + Tar.Player.ChampionName).GetValue<bool>())
                {
                    return;
                }

                if (Tar.Player.Health / Tar.Player.MaxHealth * 100 <= Menu.Item("enemylowhp" + Name + "pct").GetValue<Slider>().Value)
                {
                    if (Utils.GameTimeTickCount - Activator.LastUsedTimeStamp >= 3000 || Player.CountEnemiesInRange(Range) >= 1)
                    {
                        UseItem(Menu.Item("mode" + Name).GetValue<StringList>().SelectedIndex == 1);
                    }
                }
            }
        }
    }
}
