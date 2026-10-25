using HarmonyLib;
using System.Reflection;
using Verse;

namespace BioSynth_Diablitech
{
    [StaticConstructorOnStartup]
    public class Main
    {
        static Main()
        {
            var harmony = new Harmony("com.BioSynth_Diablitech");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
