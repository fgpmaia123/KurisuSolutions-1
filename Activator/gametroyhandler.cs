#region Copyright © 2015 Kurisu Solutions
// All rights are reserved. Transmission or reproduction in part or whole,
// any form or by any means, mechanical, electronical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Document:	activator/gametroyhandler.cs
// Date:		01/07/2015
// Author:		Robin Kurisu
#endregion

using System;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator
{
    public class gametroyhandler
    {
        public static void init()
        {
            Game.OnUpdate += Game_OnUpdate;
            GameObject.OnCreate += GameObject_OnCreate;
        }

        static void GameObject_OnCreate(GameObject obj, EventArgs args)
        {
            foreach (var troy in gametroy.Troys)
            {
                if (obj.Name.Contains(troy.Name))
                {
                    troy.Obj = obj;
                    troy.Start = Utils.GameTimeTickCount;

                    if (!troy.Included)
                         troy.Included = true;
                }
            }
        }

        static void Game_OnUpdate(EventArgs args)
        {
            foreach (var troy in gametroy.Troys.Where(x => x.Included))
            {
                if (troy.Owner.IsAlly)
                    continue;

                foreach (var hero in Activator.Allies())
                {
                    if (troy.Owner != null && troy.Obj != null && troy.Obj.IsValid)
                    {
                        foreach (var item in gametroydata.troydata.Where(x => x.Name == troy.Name))
                        {
                            if (hero.Player.Distance(troy.Obj.Position, true) <= item.Radius * item.Radius)
                            {
                                if (Utils.GameTimeTickCount - troy.Start >= item.DelayFromStart)
                                {
                                    foreach (var ii in item.HitType)
                                    {
                                        if (!hero.HitTypes.Contains(ii))
                                             hero.HitTypes.Add(ii);
                                    }

                                    if (Utils.GameTimeTickCount - item.TickLimiter >= item.Interval * 1000)
                                    {
                                        hero.Attacker = troy.Owner;
                                        hero.IncomeDamage += 15; // todo: get actuall spell damage
                                        hero.TroyTicks += 1;

                                        item.TickLimiter = Utils.GameTimeTickCount;
                                    }
                                }

                                return;
                            }
                        }
                    }

                    if (hero.TroyTicks > 0)
                    {
                        hero.IncomeDamage -= 15;
                        hero.TroyTicks -= 1;

                        if (hero.TroyTicks == 0)
                            hero.HitTypes.Clear();
                    }
                }
            }
        }       
    }
}