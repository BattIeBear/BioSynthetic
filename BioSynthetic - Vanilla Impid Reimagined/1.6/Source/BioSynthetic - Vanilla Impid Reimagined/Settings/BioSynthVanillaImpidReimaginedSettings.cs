using Verse;

namespace BioSynth_VanillaImpidReimagined
{
    internal class BioSynthVanillaImpidReimaginedSettings : ModSettings
    {
        //xenotype Settings
        public static bool AddNewHairOptions = true;
        public static bool AddNewSkinOptionsYellow = true;
        public static bool AddNewSkinOptionsRed = true;
        public static bool AddBodyOptions = true;
        public static bool UseNewGenes = true;
        public static bool NakedSpeedOptions = true;

        //Faction Settings
        public static bool ModifyFaction = true;


        public override void ExposeData()
        {
            Scribe_Values.Look(ref AddNewHairOptions, "AddNewHairOptions", true);
            Scribe_Values.Look(ref AddNewSkinOptionsYellow, "AddNewSkinOptionsYellow", true);
            Scribe_Values.Look(ref AddNewSkinOptionsRed, "AddNewSkinOptionsRed", true);
            Scribe_Values.Look(ref AddBodyOptions, "AddBodyOptions", true);
            Scribe_Values.Look(ref UseNewGenes, "UseNewGenes", true);
            Scribe_Values.Look(ref NakedSpeedOptions, "NakedSpeedOptions", true);
            Scribe_Values.Look(ref ModifyFaction, "ModifyFaction", true);
            base.ExposeData();
        }
    }
}