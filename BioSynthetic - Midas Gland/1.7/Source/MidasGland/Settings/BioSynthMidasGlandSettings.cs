using Verse;

namespace BioSynth_MidasGland
{
    internal class BioSynthMidasGlandSettings : ModSettings
    {
        /// Choices for Perfect Body gene graphics
        public static bool RoyalGold = false;
        public static bool RoyalGoldGlandOnly = false;
        public static bool ConsistantSilver = false;
        public static bool GraySilver = false;
        public static bool GraySilverGlandOnly = false;
        public static bool ChromeSilver = false;
        public static bool ChromeSilverGlandOnly = false;


        /// The part that writes our settings to file. Note that saving is by ref.
        public override void ExposeData()
        {
            Scribe_Values.Look(ref RoyalGold, "RoyalGold");
            Scribe_Values.Look(ref RoyalGoldGlandOnly, "RoyalGoldGlandOnly");
            Scribe_Values.Look(ref ConsistantSilver, "ConsistantSilver");
            Scribe_Values.Look(ref GraySilver, "GraySilver");
            Scribe_Values.Look(ref GraySilverGlandOnly, "GraySilverGlandOnly");
            Scribe_Values.Look(ref ChromeSilver, "ChromeSilver");
            Scribe_Values.Look(ref ChromeSilverGlandOnly, "ChromeSilverGlandOnly");
            base.ExposeData();
        }
    }
}