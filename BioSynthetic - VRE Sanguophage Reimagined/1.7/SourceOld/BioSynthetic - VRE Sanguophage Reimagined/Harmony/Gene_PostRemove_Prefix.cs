using HarmonyLib;
using RimWorld;
using Verse;

namespace BioSynth_VRE_Sanguophage
{
    [HarmonyPatch(typeof(Gene), nameof(Gene.PostRemove))]
    public static class Gene_PostRemove_Prefix
    {
        public static void Prefix(Gene __instance)
        {
            if (__instance.pawn.RaceProps.Humanlike == false)
            {
                return;
            }
            if (__instance.def != GeneDefOf.Hemogenic)
            {
                return;
            }

            if (__instance.pawn.health.hediffSet.HasHediff(HediffDefOf.BattIeBear_Hemogen_HungerRemove) == true)
            {
                __instance.pawn.health.RemoveHediff(__instance.pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.BattIeBear_Hemogen_HungerRemove));
            }
            if (__instance.pawn.health.hediffSet.HasHediff(HediffDefOf.BattIeBear_Hemogen_HungerOffset) == true)
            {
                __instance.pawn.health.RemoveHediff(__instance.pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.BattIeBear_Hemogen_HungerOffset));
            }
        }
    }
}
