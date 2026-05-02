using Verse;

namespace BioSynth_VREHussarReimagined
{
    public class BioSynthVREHussarSettings : ModSettings
    {
        ///Traits
        public static bool BattleReady = true;
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
        public static bool Impid = true;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref BattleReady, "BattleReady", true);
            Scribe_Values.Look(ref MinimizeOverlap, "MinimizeOverlap", true);
            Scribe_Values.Look(ref EnableDrawbacks, "EnableDrawbacks", true);
            Scribe_Values.Look(ref DrawbackChance, "DrawbackChance", 10);
            Scribe_Values.Look(ref DisablePyromania, "DisablePyromania", false);
            Scribe_Values.Look(ref Demon, "Demon", false);
            Scribe_Values.Look(ref Devil, "Devil", false);
            Scribe_Values.Look(ref Fiend, "Fiend", false);
            Scribe_Values.Look(ref Bloodletter, "Bloodletter", false);
            Scribe_Values.Look(ref Bloodthirster, "Bloodthirster", false);
            Scribe_Values.Look(ref Horns, "Horns", true);
            Scribe_Values.Look(ref Impid, "Impid", true);
            base.ExposeData();
        }
    }
}
