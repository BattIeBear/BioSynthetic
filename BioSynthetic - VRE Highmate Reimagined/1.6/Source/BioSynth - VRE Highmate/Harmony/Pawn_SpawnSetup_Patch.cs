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
            //AestheticShaperUsesPerfectBody Settings
            if (BioSynthVREHighmateSettings.AestheticShaperUsesPerfectBody == false)
            {
                if (__instance.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectMale)
                {
                    __instance.story.bodyType = BodyTypeDefOf.Male;
                    __instance.Drawer.renderer.SetAllGraphicsDirty();
                }
                if (__instance.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectFemale)
                {
                    __instance.story.bodyType = BodyTypeDefOf.Female;
                    __instance.Drawer.renderer.SetAllGraphicsDirty();
                }
                if (__instance.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectThin)
                {
                    __instance.story.bodyType = BodyTypeDefOf.Thin;
                    __instance.Drawer.renderer.SetAllGraphicsDirty();
                }
                if (__instance.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectHulk)
                {
                    __instance.story.bodyType = BodyTypeDefOf.Hulk;
                    __instance.Drawer.renderer.SetAllGraphicsDirty();
                }
                if (__instance.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectFat)
                {
                    __instance.story.bodyType = BodyTypeDefOf.Fat;
                    __instance.Drawer.renderer.SetAllGraphicsDirty();
                }
            }
            else
            {
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

        public static void Postfix(Pawn __instance)
        {
            if (__instance.RaceProps.Humanlike == false)
            {
                return;
            }
            
            //psychic bond options
            foreach (DirectPawnRelation relation in __instance.relations.DirectRelations)
            {
                if (Gene_PsychicBonding_BondTo_Patch.romanticDefs.Contains(relation.def))
                {
                    Log.Message("Found romantic relation: " + relation.def.defName + " with " + relation.otherPawn.Name);
                    if (InteractionWorker_RomanceAttempt.CanCreatePsychicBondBetween(__instance, relation.otherPawn))
                    {
                        Log.Message("Can create psychic bond between " + __instance.Name + " and " + relation.otherPawn.Name);
                        InteractionWorker_RomanceAttempt.TryCreatePsychicBondBetween(__instance, relation.otherPawn);
                    }
                }
            }
        }
    }
}
