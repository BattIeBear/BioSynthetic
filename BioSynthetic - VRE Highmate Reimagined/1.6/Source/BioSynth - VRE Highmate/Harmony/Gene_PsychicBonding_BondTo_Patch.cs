using HarmonyLib;
using RimWorld;
using System.Collections.Generic;
using Verse;

namespace BioSynth_VRE_Highmate
{
    [HarmonyPatch(typeof(InteractionWorker_RomanceAttempt), nameof(InteractionWorker_RomanceAttempt.CanCreatePsychicBondBetween))]
    public static class Gene_PsychicBonding_BondTo_Patch
    {
        public static List<PawnRelationDef> romanticDefs = new List<PawnRelationDef>
    {
        PawnRelationDefOf.Lover,
        PawnRelationDefOf.Spouse,
        PawnRelationDefOf.Fiance
    };
        public static bool Prefix(InteractionWorker_RomanceAttempt __instance, ref Pawn initiator, ref Pawn recipient)
        {
            List<Pawn> list = new List<Pawn>();
            List<DirectPawnRelation> directRelations = initiator.relations.DirectRelations;
            for (int i = 0; i < directRelations.Count; i++)
            {
                if (directRelations[i].otherPawn == recipient)
                {
                    if (romanticDefs.Contains(directRelations[i].def))
                    {
                        return true;
                    }
                    return false;
                }
            }

            return false;
        }
    }
}
