using HarmonyLib;
using System.Reflection;
using Verse;

namespace BioSynth_MidasGland
{
    //Setting the Harmony instance
    [StaticConstructorOnStartup]
    public class Main
    {
        static Main()
        {
            var harmony = new Harmony("com.BioSynth_MidasGland");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}