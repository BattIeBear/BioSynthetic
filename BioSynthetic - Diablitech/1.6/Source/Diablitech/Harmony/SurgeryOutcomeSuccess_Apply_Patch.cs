using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using System.Threading.Tasks;
using Verse;

namespace BioSynth_Diablitech
{
    [HarmonyPatch(typeof(SurgeryOutcomeSuccess), nameof(SurgeryOutcomeSuccess.Apply))]
    class SurgeryOutcomeSuccess_Apply_Patch
    {
        public static bool Postfix(bool ___result, ref RecipeDef recipe, ref Pawn patient)
        {
            if (___result == false)
            {
                return ___result;
            }
            if (recipe.addsHediff.tags.Contains("Diablitech") || recipe.removesHediff.tags.Contains("Diablitech"))
            {
                PauseAndCount(patient);
            }
            return ___result;
        }

        static async void PauseAndCount(Pawn patient)
        {
            await Task.Delay(100);

            int hediffsWithTag = 0;

            List<Hediff> hediffsToCheck = patient.health.hediffSet.hediffs;
            for (int i = 0; i < hediffsToCheck.Count; i++)
            {
                if (hediffsToCheck[i].def.tags.NullOrEmpty())
                {
                    continue;
                }
                if (hediffsToCheck[i].def.tags.Contains("Diablitech"))
                {
                    hediffsWithTag++;
                }
            }

            patient.health.hediffSet.TryGetHediff(HeddifDefOf.biosynth_MinorSynapseOverload, out Hediff minor_hediff);
            patient.health.hediffSet.TryGetHediff(HeddifDefOf.biosynth_MajorSynapseOverload, out Hediff major_hediff);
            patient.health.hediffSet.TryGetHediff(HeddifDefOf.biosynth_ExtremeSynapseOverload, out Hediff extreme_hediff);

            int minThreshold = BioSynthDiablitechSettings.numOfImplantsBeforePain;

            if (hediffsWithTag < minThreshold)
            {

                if (minor_hediff != null)
                {
                    patient.health.RemoveHediff(minor_hediff);
                }
                if (major_hediff != null)
                {
                    patient.health.RemoveHediff(major_hediff);
                }
                if (extreme_hediff != null)
                {
                    patient.health.RemoveHediff(extreme_hediff);
                }

            }
            else if (hediffsWithTag == minThreshold)
            {

                if (minor_hediff == null)
                {
                    patient.health.AddHediff(HeddifDefOf.biosynth_MinorSynapseOverload);
                }
                if (major_hediff != null)
                {
                    patient.health.RemoveHediff(major_hediff);
                }
                if (extreme_hediff != null)
                {
                    patient.health.RemoveHediff(extreme_hediff);
                }

            }
            else if (hediffsWithTag == minThreshold + 1)
            {

                if (minor_hediff != null)
                {
                    patient.health.RemoveHediff(minor_hediff);
                }
                if (major_hediff == null)
                {
                    patient.health.AddHediff(HeddifDefOf.biosynth_MajorSynapseOverload);
                }
                if (extreme_hediff != null)
                {
                    patient.health.RemoveHediff(extreme_hediff);
                }

            }
            else if (hediffsWithTag > minThreshold + 1)
            {

                if (minor_hediff != null)
                {
                    patient.health.RemoveHediff(minor_hediff);
                }
                if (major_hediff != null)
                {
                    patient.health.RemoveHediff(major_hediff);
                }
                if (extreme_hediff == null)
                {
                    patient.health.AddHediff(HeddifDefOf.biosynth_ExtremeSynapseOverload);
                }

            }
        }
    }
}
