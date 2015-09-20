#region Copyright © 2015 Kurisu Solutions
// All rights are reserved. Transmission or reproduction in part or whole,
// any form or by any means, mechanical, electronical or otherwise, is prohibited
// without the prior written consent of the copyright owner.
// 
// Document:	activator/spelldebuffhandler.cs
// Date:		01/07/2015
// Author:		Robin Kurisu
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator
{
    public static class spelldebuffhandler
    {
        internal static void CheckDangerousBuffs()
        {
            
        }

        #region Cleanse

        internal static void CheckCleanse(Obj_AI_Hero player)
        {
            foreach (var hero in Activator.Heroes.Where(x => x.Player.NetworkId == player.NetworkId))
            {
                hero.CleanseBuffCount = GetAuras(hero.Player, "summonerboost").Count();

                if (hero.CleanseBuffCount > 0)
                {
                    foreach (var buff in GetAuras(hero.Player, "summonerboost"))
                    {
                        var duration = (int) Math.Ceiling(buff.EndTime - buff.StartTime);
                        if (duration > hero.CleanseHighestBuffTime)
                        {
                            hero.CleanseHighestBuffTime = duration;
                        }
                    }

                    hero.LastDebuffTimestamp = Utils.GameTimeTickCount;
                }

                else
                {
                    if (hero.CleanseHighestBuffTime > 0)
                        hero.CleanseHighestBuffTime -= hero.QSSHighestBuffTime;
                    else
                        hero.CleanseHighestBuffTime = 0;
                }
            }
        }

        #endregion

        #region Dervish
        internal static void CheckDervish(Obj_AI_Hero player)
        {
            foreach (var hero in Activator.Heroes.Where(x => x.Player.NetworkId == player.NetworkId))
            {
                hero.DervishBuffCount = GetAuras(hero.Player, "Dervish").Count();

                if (hero.DervishBuffCount > 0)
                {
                    foreach (var buff in GetAuras(hero.Player, "Dervish"))
                    {
                        var duration = (int) Math.Ceiling(buff.EndTime - buff.StartTime);
                        if (duration > hero.DervishHighestBuffTime)
                        {
                            hero.DervishHighestBuffTime = duration;
                        }
                    }

                    hero.LastDebuffTimestamp = Utils.GameTimeTickCount;
                }

                else
                {
                    if (hero.DervishHighestBuffTime > 0)
                        hero.DervishHighestBuffTime -= hero.DervishHighestBuffTime;
                    else
                        hero.DervishHighestBuffTime = 0;
                }
            }
        }

        #endregion

        #region QSS
        internal static void CheckQSS(Obj_AI_Hero player)
        {
            foreach (var hero in Activator.Heroes.Where(x => x.Player.NetworkId == player.NetworkId))
            {
                hero.QSSBuffCount = GetAuras(hero.Player, "Quicksilver").Count();

                if (hero.QSSBuffCount > 0)
                {
                    foreach (var buff in GetAuras(hero.Player, "Quicksilver"))
                    {
                        var duration = (int)Math.Ceiling(buff.EndTime - buff.StartTime);
                        if (duration > hero.QSSHighestBuffTime)
                        {
                            hero.QSSHighestBuffTime = duration;
                        }
                    }

                    hero.LastDebuffTimestamp = Utils.GameTimeTickCount;
                }

                else
                {
                    if (hero.QSSHighestBuffTime > 0)
                        hero.QSSHighestBuffTime -= hero.QSSHighestBuffTime;
                    else
                        hero.QSSHighestBuffTime = 0;
                }
            }
        }

        #endregion

        #region Mikaels
        internal static void CheckMikaels(Obj_AI_Hero player)
        {
            foreach (var hero in Activator.Heroes.Where(x => x.Player.NetworkId == player.NetworkId))
            {
                hero.MikaelsBuffCount = GetAuras(hero.Player, "Mikaels").Count();
                if (hero.MikaelsBuffCount > 0)
                {
                    foreach (var buff in GetAuras(hero.Player, "Mikaels"))
                    {
                        var duration = (int) Math.Ceiling(buff.EndTime - buff.StartTime);
                        if (duration > hero.MikaelsHighestBuffTime)
                        {
                            hero.MikaelsHighestBuffTime = duration;
                        }
                    }

                    hero.LastDebuffTimestamp = Utils.GameTimeTickCount;
                }

                else
                {
                    if (hero.MikaelsHighestBuffTime > 0)
                        hero.MikaelsHighestBuffTime -= hero.MikaelsHighestBuffTime;
                    else
                        hero.MikaelsHighestBuffTime = 0;
                }
            }
        }

        #endregion

        #region Mercurial
        internal static void CheckMercurial(Obj_AI_Hero player)
        {
            foreach (var hero in Activator.Heroes.Where(x => x.Player.NetworkId == player.NetworkId))
            {
                hero.MikaelsBuffCount = GetAuras(hero.Player, "Mercurial").Count();

                if (hero.MikaelsBuffCount > 0)
                {
                    foreach (var buff in GetAuras(hero.Player, "Mercurial"))
                    {
                        var duration = (int) Math.Ceiling(buff.EndTime - buff.StartTime);
                        if (duration > hero.MercurialHighestBuffTime)
                        {
                            hero.MercurialHighestBuffTime = duration;
                        }
                    }

                    hero.LastDebuffTimestamp = Utils.GameTimeTickCount;
                }

                else
                {
                    if (hero.MercurialHighestBuffTime > 0)
                        hero.MercurialHighestBuffTime -= hero.MercurialHighestBuffTime;
                    else
                        hero.MercurialHighestBuffTime = 0;
                }
            }
        }

        #endregion

        internal static IEnumerable<BuffInstance> GetAuras(Obj_AI_Hero player, string itemname)
        {
            return player.Buffs.Where(buff => 
                   (buff.Type == BuffType.Snare &&
                    Activator.Origin.Item(itemname + "csnare").GetValue<bool>() ||
                    buff.Type == BuffType.Charm &&
                    Activator.Origin.Item(itemname + "ccharm").GetValue<bool>() ||
                    buff.Type == BuffType.Taunt &&
                    Activator.Origin.Item(itemname + "ctaunt").GetValue<bool>() ||
                    buff.Type == BuffType.Stun &&
                    Activator.Origin.Item(itemname + "cstun").GetValue<bool>() ||
                    buff.Type == BuffType.Fear &&
                    Activator.Origin.Item(itemname + "cfear").GetValue<bool>() ||
                    buff.Type == BuffType.Flee &&
                    Activator.Origin.Item(itemname + "cflee").GetValue<bool>() ||
                    buff.Type == BuffType.Polymorph &&
                    Activator.Origin.Item(itemname + "cpolymorph").GetValue<bool>() ||
                    buff.Type == BuffType.Blind &&
                    Activator.Origin.Item(itemname + "cblind").GetValue<bool>() ||
                    buff.Type == BuffType.Suppression &&
                    Activator.Origin.Item(itemname + "csupp").GetValue<bool>() ||
                    buff.Type == BuffType.Poison &&
                    Activator.Origin.Item(itemname + "cpoison").GetValue<bool>() ||
                    buff.Type == BuffType.Slow &&
                    Activator.Origin.Item(itemname + "cslow").GetValue<bool>() ||
                    buff.Name == "summonerexhaust" &&
                    Activator.Origin.Item(itemname + "cexhaust").GetValue<bool>() ||
                    buff.Name == "summonerdot" &&
                    Activator.Origin.Item(itemname + "cignote").GetValue<bool>()));
        }

        public static int GetCustomDamage(this Obj_AI_Hero source, string auraname, Obj_AI_Hero target)
        {
            switch (auraname)
            {
                case "itemsunfirecapeaura":
                    return
                        (int)
                            source.CalcDamage(target, Damage.DamageType.Magical,
                                25 + (1 * source.Level));

                case "gangplankattackdotpassive":
                    return
                        (int)
                            source.CalcDamage(target, Damage.DamageType.True,
                                20 + (10 * source.Level) + 1.2 * (source.BaseAttackDamage + source.FlatPhysicalDamageMod));

                case "bantamtraptarget":
                    return
                        (int)
                            source.CalcDamage(target, Damage.DamageType.Magical,
                                new[] { 50, 81, 112 }[source.Level / 6] + 0.25 * (source.FlatMagicDamageMod));

                case "sheen":
                    return
                        (int)
                            source.CalcDamage(target, Damage.DamageType.Physical,
                                1.0 * source.FlatPhysicalDamageMod + source.BaseAttackDamage);


                case "lichbane":
                    return
                        (int)
                            source.CalcDamage(target, Damage.DamageType.Magical,
                                (0.75*source.FlatPhysicalDamageMod + source.BaseAttackDamage) + (0.50*source.FlatMagicDamageMod));
            }

            return 0;
        }
    }

}
