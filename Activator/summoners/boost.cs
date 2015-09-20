using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Summoners
{
    internal class boost : summoner
    {
        internal override string Name
        {
            get { return "summonerboost"; }
        }

        internal override string DisplayName
        {
            get { return "Cleanse"; }
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
            get { return 3000; }
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
                        return;

                    if (hero.Player.Distance(Player.ServerPosition) > Range)
                        return;

                    spelldebuffhandler.CheckCleanse(hero.Player);

                    if (hero.CleanseBuffCount >= Menu.Item("use" + Name + "number").GetValue<Slider>().Value &&
                        hero.CleanseHighestBuffTime >= Menu.Item("use" + Name + "time").GetValue<Slider>().Value)
                    {
                        //if (!Menu.Item("use" + Name + "od").GetValue<bool>())
                        //{
                            Utility.DelayAction.Add(
                                Game.Ping + Menu.Item("use" + Name + "delay").GetValue<Slider>().Value, delegate
                                {
                                    UseSpell(Menu.Item("mode" + Name).GetValue<StringList>().SelectedIndex == 1);
                                    hero.CleanseBuffCount = 0;
                                    hero.CleanseHighestBuffTime = 0;
                                });
                        //}
                    }
                }
            }
        }
    }
}
