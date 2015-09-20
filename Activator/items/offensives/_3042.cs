using System;
using LeagueSharp;
using LeagueSharp.Common;

namespace Activator.Items.Offensives
{
    class _3042 : item
    {
        internal override int Id
        {
            get { return 3042; }
        }
        internal override int Priority
        {
            get { return 7; }
        }

        internal override string Name
        {
            get { return "Muramana"; }
        }

        internal override string DisplayName
        {
            get { return "Muramana"; }
        }

        internal override float Range
        {
            get { return float.MaxValue; }
        }

        internal override int Duration
        {
            get { return 100; }
        }

        internal override MenuType[] Category
        {
            get { return new[] { MenuType.SelfMinMP,  MenuType.ActiveCheck }; }
        }

        internal override MapType[] Maps
        {
            get { return new[] { MapType.SummonersRift, MapType.HowlingAbyss }; }
        }

        internal override int DefaultHP
        {
            get { return 95; }
        }

        internal override int DefaultMP
        {
            get { return 35; }
        }

        public _3042()
        {
            Obj_AI_Base.OnProcessSpellCast += OnCast;
        }

        private bool muramana;
        public override void OnTick(EventArgs args)
        {
            if (!Menu.Item("use" + Name).GetValue<bool>())
                return;

            if (muramana)
            {
                if (Player.Mana / Player.MaxMana * 100 <
                    Menu.Item("selfminmp" + Name + "pct").GetValue<Slider>().Value)
                    return;

                if (Menu.Item("mode" + Name).GetValue<StringList>().SelectedIndex != 1 ||
                    Activator.Origin.Item("usecombo").GetValue<KeyBind>().Active)
                {
                    var manamune = Player.GetSpellSlot("Muramana");
                    if (manamune != SpellSlot.Unknown && !Player.HasBuff("Muramana"))
                    {
                        Player.Spellbook.CastSpell(manamune);
                        Utility.DelayAction.Add(500, () => muramana = false);
                    }
                }
            }

            if (!muramana && !Activator.Origin.Item("usecombo").GetValue<KeyBind>().Active)
            {
                var manamune = Player.GetSpellSlot("Muramana");
                if (manamune != SpellSlot.Unknown && Player.HasBuff("Muramana"))
                {
                    Player.Spellbook.CastSpell(manamune);
                }
            }
        }

        private void OnCast(Obj_AI_Base sender, GameObjectProcessSpellCastEventArgs args)
        {
            if (!sender.IsMe || !LeagueSharp.Common.Items.HasItem(Id))
            {
                return;
            }

            var spellslot = Player.GetSpellSlot(args.SData.Name);

            if (spellslot == SpellSlot.Q ||
                spellslot == SpellSlot.W ||
                spellslot == SpellSlot.E ||
                spellslot == SpellSlot.R)
            {
                muramana = true;
            }

            if (!args.SData.IsAutoAttack())
            {
                return;
            }

            if (Activator.Origin.Item("usecombo").GetValue<KeyBind>().Active)
            {
                muramana = true;
            }

            else if (args.Target.Type == GameObjectType.obj_AI_Hero)
            {
                muramana = true;
            }

            else
            {
                Utility.DelayAction.Add(650 + (int)(args.SData.CastFrame / 30), () => muramana = false);
            }
        }
    }
}
