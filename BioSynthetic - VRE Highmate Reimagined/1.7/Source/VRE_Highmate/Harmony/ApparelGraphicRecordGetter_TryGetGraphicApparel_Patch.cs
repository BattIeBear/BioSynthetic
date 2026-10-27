using HarmonyLib;
using RimWorld;

namespace BioSynth_VRE_Highmate
{
    [HarmonyPatch(typeof(ApparelGraphicRecordGetter), nameof(ApparelGraphicRecordGetter.TryGetGraphicApparel))]
    public static class ApparelGraphicRecordGetter_TryGetGraphicApparel_Patch
    {
        public static void Prefix(ref BodyTypeDef bodyType)
        {
            if (bodyType == NewBodyTypeDefOf.BattIeBear_PerfectMale)
            {
                bodyType = BodyTypeDefOf.Male;
            }
            if (bodyType == NewBodyTypeDefOf.BattIeBear_PerfectFemale)
            {
                bodyType = BodyTypeDefOf.Female;
            }
            if (bodyType == NewBodyTypeDefOf.BattIeBear_PerfectThin)
            {
                bodyType = BodyTypeDefOf.Thin;
            }
            if (bodyType == NewBodyTypeDefOf.BattIeBear_PerfectHulk)
            {
                bodyType = BodyTypeDefOf.Hulk;
            }
            if (bodyType == NewBodyTypeDefOf.BattIeBear_PerfectFat)
            {
                bodyType = BodyTypeDefOf.Fat;
            }
        }
    }
}