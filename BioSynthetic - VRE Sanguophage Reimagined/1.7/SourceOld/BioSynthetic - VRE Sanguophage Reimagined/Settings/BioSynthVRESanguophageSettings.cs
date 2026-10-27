using Verse;

namespace BioSynth_VRE_Sanguophage
{
    public class BioSynthVRESanguophageSettings : ModSettings
    {
        /// Bruxa options
        public static bool RemoveBruxaSoft = false;
        public static bool BruxaBodyStandard = true;
        public static bool BruxaRemoveHair = false;
        public static bool BruxaPerfectBody = true;

        /// Ekkimian options
        public static bool RemoveEkkimianSoft = false;
        public static bool EkkimianBothBatEars = false;
        public static bool EkkimianRemoveBatEars = true;
        public static bool EkkimianBeardless = true;
        public static bool EkkimianBodyPlusHulk = false;
        public static bool EkkimianBodyAny = false;
        public static bool EkkimianGauntBody = true;

        /// Strigoi options
        public static bool RemoveStrigoiSoft = false;
        public static bool StrigoiBothBatEars = true;
        public static bool StrigoiRemoveBatEars = false;
        public static bool StrigoiRemoveBatNose = false;
        public static bool StrigoiRemoveHair = true;
        public static bool StrigoiBeardless = true;
        public static bool StrigoiBodyNonSkinny = false;
        public static bool StrigoiBodyLarge = false;
        public static bool StrigoiBodyHulk = true;

        /// Bloodmoon options
        public static bool RemoveBloodmoon = false;

        /// Hunger options
        public static bool HemogenicHalfHunger = false;
        public static bool HemogenicNoHunger = false;
        public static bool HemogenicHideHediff = true;

        /// Gene Regrowth options
        public static bool GenesRegrowOneYear = false;
        public static bool GenesRegrowHalfYear = false;

        /// Gene Regrowth options
        public static bool BaselinerForced = false;

        /// The part that writes our settings to file. Note that saving is by ref.
        public override void ExposeData()
        {
            Scribe_Values.Look(ref RemoveBruxaSoft, "RemoveBruxaSoft", false);
            Scribe_Values.Look(ref BruxaBodyStandard, "BruxaBodyStandard", true);
            Scribe_Values.Look(ref BruxaRemoveHair, "BruxaRemoveHair", false);
            Scribe_Values.Look(ref BruxaPerfectBody, "BruxaPerfectBody", true);
            Scribe_Values.Look(ref RemoveEkkimianSoft, "RemoveEkkimianSoft", false);
            Scribe_Values.Look(ref EkkimianBothBatEars, "EkkimianBothBatEars", false);
            Scribe_Values.Look(ref EkkimianRemoveBatEars, "EkkimianRemoveBatEars", true);
            Scribe_Values.Look(ref EkkimianBeardless, "EkkimianBeardless", true);
            Scribe_Values.Look(ref EkkimianBodyPlusHulk, "EkkimianBodyPlusHulk", true);
            Scribe_Values.Look(ref EkkimianBodyAny, "EkkimianBodyAny", false);
            Scribe_Values.Look(ref EkkimianGauntBody, "EkkimianGauntBody", true);
            Scribe_Values.Look(ref RemoveStrigoiSoft, "RemoveStrigoiSoft", false);
            Scribe_Values.Look(ref StrigoiBothBatEars, "StrigoiBothBatEars", true);
            Scribe_Values.Look(ref StrigoiRemoveBatEars, "StrigoiRemoveBatEars", false);
            Scribe_Values.Look(ref StrigoiRemoveBatNose, "StrigoiRemoveBatNose", false);
            Scribe_Values.Look(ref StrigoiRemoveHair, "StrigoiRemoveHair", false);
            Scribe_Values.Look(ref StrigoiBeardless, "StrigoiBeardless", false);
            Scribe_Values.Look(ref StrigoiBodyNonSkinny, "StrigoiBodyNonSkinny", true);
            Scribe_Values.Look(ref StrigoiBodyLarge, "StrigoiBodyLarge", false);
            Scribe_Values.Look(ref StrigoiBodyHulk, "StrigoiBodyHulk", false);
            Scribe_Values.Look(ref RemoveBloodmoon, "RemoveBloodmoon", false);
            Scribe_Values.Look(ref HemogenicHalfHunger, "HemogenicHalfHunger", false);
            Scribe_Values.Look(ref HemogenicNoHunger, "HemogenicNoHunger", false);
            Scribe_Values.Look(ref HemogenicHideHediff, "HemogenicHideHediff", true);
            Scribe_Values.Look(ref GenesRegrowOneYear, "GenesRegrowOneYear", false);
            Scribe_Values.Look(ref GenesRegrowHalfYear, "GenesRegrowHalfYear", false);
            base.ExposeData();
        }
    }
}