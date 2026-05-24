using HarmonyLib;
using VanillaRacesExpandedSanguophage;

namespace BioSynth_VRE_Sanguophage
{

    [HarmonyPatch(typeof(BloodMoon_MapComponent), nameof(BloodMoon_MapComponent.MapComponentTick))]
    public static class BloodMoon_MapComponent_MapComponentTick_Prefix
    {
        public static bool Prefix(BloodMoon_MapComponent __instance)
        {
            return !BioSynthVRESanguophageSettings.RemoveBloodmoon;
        }
    }
}
