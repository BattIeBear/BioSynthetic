using Verse;

namespace BioSynth_VREHussarReimagined
{
    public class BioSynthVREHussarSettings : ModSettings
    {
        public enum UhlanNames
        {
            BioSynth_VREHussar_Uhlan, BioSynth_VREHussar_Demon, BioSynth_VREHussar_Devil, BioSynth_VREHussar_Fiend, BioSynth_VREHussar_Bloodletter, BioSynth_VREHussar_Bloodthirster
        }
        ///Traits
        public static bool BattleReady = true;
        public static bool MinimizeOverlap = true;
        public static bool NoAptitude = false;

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
        public static UhlanNames UhlanName = UhlanNames.BioSynth_VREHussar_Uhlan;
        public static bool Horns = true;
        public static bool Ridges = false;
        public static bool Glidewings = true;
        public static bool Giant = true;
        public static bool Impid = true;

        ///Unstable Options
        public static int IncludeOld = 0;
        public static bool ConvertToNew = false;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref BattleReady, "BattleReady", true);
            Scribe_Values.Look(ref MinimizeOverlap, "MinimizeOverlap", true);
            Scribe_Values.Look(ref NoAptitude, "NoAptitude", false);
            Scribe_Values.Look(ref EnableDrawbacks, "EnableDrawbacks", true);
            Scribe_Values.Look(ref DrawbackChance, "DrawbackChance", 10);
            Scribe_Values.Look(ref DisablePyromania, "DisablePyromania", false);
            Scribe_Values.Look(ref UhlanName, "UhlanName", UhlanNames.BioSynth_VREHussar_Uhlan);
            Scribe_Values.Look(ref Demon, "Demon", false);
            Scribe_Values.Look(ref Devil, "Devil", false);
            Scribe_Values.Look(ref Fiend, "Fiend", false);
            Scribe_Values.Look(ref Bloodletter, "Bloodletter", false);
            Scribe_Values.Look(ref Bloodthirster, "Bloodthirster", false);
            Scribe_Values.Look(ref Horns, "Horns", true);
            //Scribe_Values.Look(ref Ridges, "Ridges", true);
            //Scribe_Values.Look(ref Glidewings, "Glidewings", true);
            //Scribe_Values.Look(ref Giant, "Giant", true);
            Scribe_Values.Look(ref Impid, "Impid", true);
            Scribe_Values.Look(ref IncludeOld, "IncludeOld", 0);
            Scribe_Values.Look(ref ConvertToNew, "ConvertToNew", false);
            base.ExposeData();
        }
    }
}
