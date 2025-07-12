using HarmonyLib;
using RimWorld;
using Verse;

namespace BioSynth_VRE_Highmate
{
    [HarmonyPatch(typeof(Pawn_MutantTracker), nameof(Pawn_MutantTracker.Turn))]
    public static class Pawn_MutantTracker_Turn_Patch
    {
        public static void Prefix(ref Pawn_MutantTracker __instance, Pawn ___pawn)
        {
            if (__instance.Def == MutantDefOf.Ghoul)
            {
                if (___pawn.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectMale)
                {
                    ___pawn.story.bodyType = BodyTypeDefOf.Male;
                }
                if (___pawn.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectFemale)
                {
                    ___pawn.story.bodyType = BodyTypeDefOf.Female;
                }
                if (___pawn.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectThin)
                {
                    ___pawn.story.bodyType = BodyTypeDefOf.Thin;
                }
                if (___pawn.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectHulk)
                {
                    ___pawn.story.bodyType = BodyTypeDefOf.Hulk;
                }
                if (___pawn.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectFat)
                {
                    ___pawn.story.bodyType = BodyTypeDefOf.Fat;
                }
            }
        }
    }
}
