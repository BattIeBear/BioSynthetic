using HarmonyLib;
using RimWorld;
using System.Reflection;
using VanillaRacesExpandedHighmate;
using Verse;

namespace BioSynth_VRE_Highmate
{
    [HarmonyPatch(typeof(Need_Lovin), nameof(Need_Lovin.NeedInterval))]
    public static class Need_Lovin_GiveUpExit_Patch
    {
        public static void Prefix(Need_Lovin __instance)
        {
            if (BioSynthVREHighmateSettings.LovinDeficiencyDoesNotTriggerGiveUp == false)
            {
                return;
            }

            Pawn pawn = __instance.GetFieldValue("pawn");

            if (__instance.CurLevel < 0.01f)
            {
                TriggerBreakOverride(__instance, pawn);
            }
        }

        public static Pawn GetFieldValue(this object __instance, string fieldName)
        {
            // Set the flags so that private and public fields from instances will be found
            var bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
            var field = __instance.GetType().GetField(fieldName, bindingFlags);
            return (Pawn)field?.GetValue(__instance);
        }

        public static void TriggerBreakOverride(Need_Lovin __instance, Pawn pawn)
        {
            if (MentalStateDefOf.Wander_OwnRoom.Worker.StateCanOccur(pawn))
            {
                pawn.mindState.mentalStateHandler.TryStartMentalState(MentalStateDefOf.Wander_OwnRoom, MentalStateDefOf.Wander_OwnRoom.description + "This was caused by: Not enough lovin'", false, false, false, null, transitionSilently: false);
                __instance.CurLevel = .2f;
            }
            else if (MentalStateDefOf.Wander_Sad.Worker.StateCanOccur(pawn))
            {
                pawn.mindState.mentalStateHandler.TryStartMentalState(MentalStateDefOf.Wander_Sad, MentalStateDefOf.Wander_Sad.description + "This was caused by: Not enough lovin'", false, false, false, null, transitionSilently: false);
                __instance.CurLevel = .2f;
            }
            else
            {
                __instance.CurLevel = .2f;
            }
        }
    }
}
