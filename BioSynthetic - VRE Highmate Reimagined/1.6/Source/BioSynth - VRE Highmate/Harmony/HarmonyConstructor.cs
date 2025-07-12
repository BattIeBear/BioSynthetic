using HarmonyLib;
using System.Reflection;
using Verse;

namespace BioSynth_VRE_Highmate
{
    //Setting the Harmony instance
    [StaticConstructorOnStartup]
    public class Main
    {
        static Main()
        {
            var harmony = new Harmony("com.BioSynth_VRE_Highmate");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
