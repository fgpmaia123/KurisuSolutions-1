using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;
using Activator.Summoners;
using Color = System.Drawing.Color;

namespace Activator
{
    class drawings
    {
        public static void init()
        {
            Drawing.OnDraw += args =>
            {
                if (Activator.Origin.Item("acdebug").GetValue<bool>())
                {
                    foreach (var hero in Activator.Allies())
                    {
                        var mpos = Drawing.WorldToScreen(hero.Player.Position);

                        if (!hero.Player.IsDead)
                        {
                            Drawing.DrawText(mpos[0] - 40, mpos[1] - 15, Color.White, "Income Damage: " + hero.IncomeDamage);
                            Drawing.DrawText(mpos[0] - 40, mpos[1] + 0, Color.White, "Income Percent: " + hero.IncomeDamage / hero.Player.MaxHealth * 100);
                            Drawing.DrawText(mpos[0] - 40, mpos[1] + 15, Color.White, "QSSBuffCount: " + hero.QSSBuffCount);
                            Drawing.DrawText(mpos[0] - 40, mpos[1] + 30, Color.White, "QSSHighestBuffTime: " + hero.QSSHighestBuffTime);
                        }
                    }
                }

                if (Activator.SmiteInGame)
                {
                    if (Activator.Origin.Item("drawsmite").GetValue<bool>())
                    {
                        if (Activator.Origin.Item("usesmite").GetValue<KeyBind>().Active)
                            Render.Circle.DrawCircle(Activator.Player.Position, 500f, Color.White, 2);

                        if (!Activator.Origin.Item("usesmite").GetValue<KeyBind>().Active)
                            Render.Circle.DrawCircle(Activator.Player.Position, 500f, Color.Gray, 2);
                    }

                    if (!Activator.Player.IsDead && Activator.Origin.Item("drawfill").GetValue<bool>())
                    {
                        if (Activator.MapId != (int) MapType.SummonersRift)
                            return;
                        
                        var height = 6;
                        var width = 150;
                        var yoffset = 20;
                        var xoffset = -7;

                        foreach (
                            var minion in
                                MinionManager.GetMinions(Activator.Player.Position, 1200f, MinionTypes.All,
                                    MinionTeam.Neutral)
                                    .Where(th => (smite.LargeMinions.Any(x => th.Name.StartsWith(x)) ||
                                                    smite.EpicMinions.Any(e => th.Name.StartsWith(e))) &&
                                                    !th.Name.Contains("Mini")))
                        {
                            if (!minion.IsValidTarget(1000) || !minion.IsHPBarRendered)
                                continue;

                            var barPos = minion.HPBarPosition;
                            var smite = Activator.Player.GetSpell(Activator.Smite).State == SpellState.Ready
                                ? Activator.Player.GetSummonerSpellDamage(minion, Damage.SummonerSpell.Smite)
                                : 0;

                            var damage = smite; // + ddmg;
                            var pctafter = Math.Max(0, minion.Health - damage) / minion.MaxHealth;

                            var yaxis = barPos.Y + yoffset;
                            var xaxisdmg = (float) (barPos.X + xoffset + width * pctafter);
                            var xaxisnow = barPos.X + xoffset + width * minion.Health / minion.MaxHealth;

                            var ana = xaxisnow - xaxisdmg;
                            var pos = barPos.X + xoffset + 12 + (139 * pctafter);

                            for (var i = 0; i < ana; i++)
                            {
                                if (Activator.Origin.Item("usesmite").GetValue<KeyBind>().Active)
                                    Drawing.DrawLine((float) pos + i, yaxis, (float) pos + i, yaxis + height, 1,
                                        Color.White);
                                if (!Activator.Origin.Item("usesmite").GetValue<KeyBind>().Active)
                                    Drawing.DrawLine((float) pos + i, yaxis, (float) pos + i, yaxis + height, 1,
                                        Color.Gray);
                            }
                        }                   
                    }
                }
            };
        }
    }
}
