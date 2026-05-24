using HarmonyLib;
using RimWorld;
using Verse;

namespace BioSynth_VRE_Sanguophage
{

    [HarmonyPatch(typeof(Pawn), nameof(Pawn.SpawnSetup))]
    public static class Pawn_SpawnSetup_Postfix
    {
        public static void Postfix(Pawn __instance)
        {
            if (__instance.RaceProps.Humanlike == false)
            {
                return;
            }
            if (__instance.genes.HasActiveGene(GeneDefOf.Hemogenic) == false)
            {
                return;
            }

            if (BioSynthVRESanguophageSettings.HemogenicHalfHunger)
            {
                if (__instance.health.hediffSet.HasHediff(HediffDefOf.BattIeBear_Hemogen_HungerRemove) == true)
                {
                    __instance.health.RemoveHediff(__instance.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.BattIeBear_Hemogen_HungerRemove));
                }
                if (__instance.health.hediffSet.HasHediff(HediffDefOf.BattIeBear_Hemogen_HungerOffset) == false)
                {
                    __instance.health.AddHediff(HediffDefOf.BattIeBear_Hemogen_HungerOffset);
                }
            }
            else if (BioSynthVRESanguophageSettings.HemogenicNoHunger)
            {
                if (__instance.health.hediffSet.HasHediff(HediffDefOf.BattIeBear_Hemogen_HungerOffset) == true)
                {
                    __instance.health.RemoveHediff(__instance.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.BattIeBear_Hemogen_HungerOffset));
                }
                if (__instance.health.hediffSet.HasHediff(HediffDefOf.BattIeBear_Hemogen_HungerRemove) == false)
                {
                    __instance.health.AddHediff(HediffDefOf.BattIeBear_Hemogen_HungerRemove);
                }
            }
            else
            {
                if (__instance.health.hediffSet.HasHediff(HediffDefOf.BattIeBear_Hemogen_HungerOffset) == true)
                {
                    __instance.health.RemoveHediff(__instance.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.BattIeBear_Hemogen_HungerOffset));
                }
                if (__instance.health.hediffSet.HasHediff(HediffDefOf.BattIeBear_Hemogen_HungerRemove) == true)
                {
                    __instance.health.RemoveHediff(__instance.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.BattIeBear_Hemogen_HungerRemove));
                }
            }
        }
    }
}
