using System;
using HarmonyLib;
using RimWorld;
using VanillaRacesExpandedHighmate;
using Verse;

namespace BioSynth_VRE_Highmate
{
    [HarmonyPatch(typeof(MemoryThoughtHandler))]
    [HarmonyPatch("TryGainMemory")]
    [HarmonyPatch(new Type[] { typeof(Thought_Memory), typeof(Pawn) })]
    public static class MemoryThoughtHandler_TryGainMemory_Patch
    {
        [HarmonyPostfix]
        private static void TryGainMemory_Patch(Thought_Memory newThought, Pawn otherPawn, MemoryThoughtHandler __instance)
        {
            if (BioSynthVREHighmateSettings.AestheticShaperUsesPerfectBody == false && BioSynthVREHighmateSettings.LoveEnhancerUsesPerfectBody == false)
            {
                return;
            }
            if (((Thought)newThought).def != ThoughtDefOf.GotSomeLovin)
            {
                return;
            }

            if (otherPawn.genes != null && otherPawn.genes.HasActiveGene(InternalDefOf.VRE_PerfectBody))
            {
                return;
            }

            if (BioSynthVREHighmateSettings.LoveEnhancerUsesPerfectBody)
            {
                bool foundLoveEnhancer = false;

                foreach (Hediff hediff in otherPawn.health.hediffSet.hediffs)
                {
                    if (hediff.def.defName == "LoveEnhancer")
                    {
                        foundLoveEnhancer = true;
                        break;
                    }
                }

                if (foundLoveEnhancer)
                {
                    if (__instance.OldestMemoryOfDef(ThoughtDefOf.GotSomeLovin) != null)
                    {
                        __instance.RemoveMemory(__instance.OldestMemoryOfDef(ThoughtDefOf.GotSomeLovin));
                    }

                    if (__instance.pawn.needs != null)
                    {
                        if (__instance.pawn.needs.mood != null)
                        {
                            if (__instance.pawn.needs.mood.thoughts != null)
                            {
                                if (__instance.pawn.needs.mood.thoughts.memories != null)
                                {
                                    __instance.pawn.needs.mood.thoughts.memories.TryGainMemory(InternalDefOf.VRE_GotSomeLovin, otherPawn, (Precept)null);
                                }
                            }
                        }
                    }
                }
            }

            if (BioSynthVREHighmateSettings.AestheticShaperUsesPerfectBody)
            {
                bool foundAestheticShaper = false;

                foreach (Hediff hediff in otherPawn.health.hediffSet.hediffs)
                {
                    if (hediff.def.defName == "AestheticShaper")
                    {
                        foundAestheticShaper = true;
                        break;
                    }
                }

                if (foundAestheticShaper)
                {
                    if (__instance.pawn.needs != null)
                    {
                        if (__instance.pawn.needs.mood != null)
                        {
                            if (__instance.pawn.needs.mood.thoughts != null)
                            {
                                if (__instance.pawn.needs.mood.thoughts.memories != null)
                                {
                                    __instance.pawn.needs.mood.thoughts.memories.TryGainMemory(InternalDefOf.VRE_WhatAPerfectBody, otherPawn, (Precept)null);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
