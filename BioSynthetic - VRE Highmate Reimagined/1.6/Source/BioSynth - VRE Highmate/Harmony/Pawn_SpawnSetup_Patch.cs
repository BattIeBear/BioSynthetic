using HarmonyLib;
using RimWorld;
using Verse;

namespace BioSynth_VRE_Highmate
{
    [HarmonyPatch(typeof(Pawn), nameof(Pawn.SpawnSetup))]
    public static class Pawn_SpawnSetup_Patch
    {
        public static void Prefix(Pawn __instance)
        {
            if (__instance.RaceProps.Humanlike == false)
            {
                return;
            }
            
            if (BioSynthVREHighmateSettings.AestheticShaperUsesPerfectBody == false)
            {
                if (__instance.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectMale)
                {
                    __instance.story.bodyType = BodyTypeDefOf.Male;
                }
                if (__instance.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectFemale)
                {
                    __instance.story.bodyType = BodyTypeDefOf.Female;
                }
                if (__instance.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectThin)
                {
                    __instance.story.bodyType = BodyTypeDefOf.Thin;
                }
                if (__instance.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectHulk)
                {
                    __instance.story.bodyType = BodyTypeDefOf.Hulk;
                }
                if (__instance.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectFat)
                {
                    __instance.story.bodyType = BodyTypeDefOf.Fat;
                }
                __instance.Drawer.renderer.SetAllGraphicsDirty();
                return;
            }

            foreach (Hediff hediff in __instance.health.hediffSet.hediffs)
            {
                if (hediff.def.defName == "AestheticShaper")
                {
                    if (__instance.story.bodyType == BodyTypeDefOf.Male)
                    {
                        __instance.story.bodyType = NewBodyTypeDefOf.BattIeBear_PerfectMale;
                    }
                    if (__instance.story.bodyType == BodyTypeDefOf.Female)
                    {
                        __instance.story.bodyType = NewBodyTypeDefOf.BattIeBear_PerfectFemale;
                    }
                    if (__instance.story.bodyType == BodyTypeDefOf.Thin)
                    {
                        __instance.story.bodyType = NewBodyTypeDefOf.BattIeBear_PerfectThin;
                    }
                    if (__instance.story.bodyType == BodyTypeDefOf.Hulk)
                    {
                        __instance.story.bodyType = NewBodyTypeDefOf.BattIeBear_PerfectHulk;
                    }
                    if (__instance.story.bodyType == BodyTypeDefOf.Fat)
                    {
                        __instance.story.bodyType = NewBodyTypeDefOf.BattIeBear_PerfectFat;
                    }
                    __instance.Drawer.renderer.SetAllGraphicsDirty();
                    return;
                }
            }
        }
    }
}
