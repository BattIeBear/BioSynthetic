using HarmonyLib;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace BioSynth_Diablitech
{
    [HarmonyPatch(typeof(Recipe_InstallArtificialBodyPart), nameof(Recipe_InstallArtificialBodyPart.GetPartsToApplyOn))]
    class Recipe_InstallArtificialBodyPart_GetPartsToApplyOn_Patch
    {
        static string[] tagsToCheck = { "Diablitech_Eye", "Diablitech_Ear" };
        public static IEnumerable<BodyPartRecord> Postfix(IEnumerable<BodyPartRecord> ___result, ref Pawn pawn, ref RecipeDef recipe)
        {
            if(___result == Enumerable.Empty<BodyPartRecord>())
            {
                return ___result;
            }

            if (recipe.incompatibleWithHediffTags.NullOrEmpty())
            {
                return ___result;
            }

            List<string> tags = new List<string>();

            for (int i = 0; i < recipe.incompatibleWithHediffTags.Count; i++)
            {
                if (tagsToCheck.Contains(recipe.incompatibleWithHediffTags[i]))
                {
                    tags.Add(recipe.incompatibleWithHediffTags[i]);
                }
            }

            if (tags.Count == 0)
            {
                return ___result;
            }

            List<Hediff> hediffsToCheck = pawn.health.hediffSet.hediffs;

            for (int i = 0; i < hediffsToCheck.Count; i++)
            {
                if (hediffsToCheck[i].def.tags.NullOrEmpty())
                {
                    continue;
                }

                for (int j = 0; j < hediffsToCheck[i].def.tags.Count; j++)
                {
                    if (tags.Contains(hediffsToCheck[i].def.tags[j]))
                    {
                        return Enumerable.Empty<BodyPartRecord>();
                    }
                }
            }

            return ___result;
        }
    }
}
