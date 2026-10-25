using Verse;

namespace BioSynth_HemogenLighting
{
    internal class BioSynthHemogenLightingSettings : ModSettings
    {
        /// Choices for Perfect Body gene graphics
        public static bool RequiresBloodfeedingMeme = true;
        public static bool RequiresAdvancedLightsResearch = true;


        /// The part that writes our settings to file. Note that saving is by ref.
        public override void ExposeData()
        {
            Scribe_Values.Look(ref RequiresBloodfeedingMeme, "RequiresBloodfeedingMeme");
            Scribe_Values.Look(ref RequiresAdvancedLightsResearch, "RequiresAdvancedLightingResearch");
            base.ExposeData();
        }
    }
}