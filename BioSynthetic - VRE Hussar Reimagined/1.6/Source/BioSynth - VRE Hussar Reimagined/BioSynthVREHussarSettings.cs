using Verse;

namespace BioSynth_VREHussarReimagined
{
    public class BioSynthVREHussarSettings : ModSettings
    {
        ///Traits
        public static bool MinimizeOverlap = true;

        ///Drawbacks
        public static bool EnableDrawbacks = true;
        public static bool DisablePyromania = false;
        public static int DrawbackChance = 10;

        ///Uhlan Alternate Names
        public static bool Demon = false;
        public static bool Devil = false;
        public static bool Fiend = false;
        public static bool Bloodletter = false;
        public static bool Bloodthirster = false;

        ///Uhlan Extra Genes
        public static bool Horns = true;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref MinimizeOverlap, "MinimizeOverlap");
            Scribe_Values.Look(ref EnableDrawbacks, "EnableDrawbacks");
            Scribe_Values.Look(ref DrawbackChance, "DrawbackChance");
            Scribe_Values.Look(ref DisablePyromania, "DisablePyromania");
            Scribe_Values.Look(ref Demon, "Demon");
            Scribe_Values.Look(ref Devil, "Devil");
            Scribe_Values.Look(ref Fiend, "Fiend");
            Scribe_Values.Look(ref Bloodletter, "Bloodletter");
            Scribe_Values.Look(ref Bloodthirster, "Bloodthirster");
            Scribe_Values.Look(ref Horns, "Horns");
            base.ExposeData();
        }
    }
}
