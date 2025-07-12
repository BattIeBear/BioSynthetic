using HarmonyLib;
using RimWorld;
using Verse;

namespace BioSynth_VRE_Highmate
{
    [HarmonyPatch(typeof(Pawn_MutantTracker), nameof(Pawn_MutantTracker.Revert))]
    public static class Pawn_MutantTracker_Revert_Patch
    {
        public static void Prefix(Pawn ___pawn)
        {
            foreach (Hediff hediff in ___pawn.health.hediffSet.hediffs)
            {
                if (hediff.def.defName == "AestheticShaper")
                {
                    if (___pawn.story.bodyType == BodyTypeDefOf.Male)
                    {
                        ___pawn.story.bodyType = NewBodyTypeDefOf.BattIeBear_PerfectMale;
                        ___pawn.Drawer.renderer.SetAllGraphicsDirty();
                    }
                    if (___pawn.story.bodyType == BodyTypeDefOf.Female)
                    {
                        ___pawn.story.bodyType = NewBodyTypeDefOf.BattIeBear_PerfectFemale;
                        ___pawn.Drawer.renderer.SetAllGraphicsDirty();
                    }
                    if (___pawn.story.bodyType == BodyTypeDefOf.Thin)
                    {
                        ___pawn.story.bodyType = NewBodyTypeDefOf.BattIeBear_PerfectThin;
                        ___pawn.Drawer.renderer.SetAllGraphicsDirty();
                    }
                    if (___pawn.story.bodyType == BodyTypeDefOf.Hulk)
                    {
                        ___pawn.story.bodyType = NewBodyTypeDefOf.BattIeBear_PerfectHulk;
                        ___pawn.Drawer.renderer.SetAllGraphicsDirty();
                    }
                    if (___pawn.story.bodyType == BodyTypeDefOf.Fat)
                    {
                        ___pawn.story.bodyType = NewBodyTypeDefOf.BattIeBear_PerfectFat;
                        ___pawn.Drawer.renderer.SetAllGraphicsDirty();
                    }
                    break;
                }
            }
        }
    }
}
