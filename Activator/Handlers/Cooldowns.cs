using LeagueSharp;

namespace Activator.Handlers
{
    class Cooldowns
    {
        public static void Load()
        {
            Obj_AI_Base.OnProcessSpellCast += HeroOnProcessSpellCast;
        }

        private static void HeroOnProcessSpellCast(Obj_AI_Base sender, GameObjectProcessSpellCastEventArgs args)
        {

        }
    }
}
