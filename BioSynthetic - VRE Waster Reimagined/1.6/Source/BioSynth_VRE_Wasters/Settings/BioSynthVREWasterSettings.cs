using Verse;

namespace BioSynth_VRE_Wasters
{
    public class BioSynthVREWasterSettings : ModSettings
    {
        ///cosmetic options
        public static bool AddNewHairColors = true;
        public static bool AddNewSkinColors = true;
        public static bool DisableGauntBody = true;

        ///gameplay options
        public static bool KeepInstability = true;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref AddNewHairColors, "AddNewHairColors");
            Scribe_Values.Look(ref AddNewSkinColors, "AddNewSkinColors");
            Scribe_Values.Look(ref DisableGauntBody, "DisableGauntBody");
            Scribe_Values.Look(ref KeepInstability, "KeepInstability");
            base.ExposeData();
        }
    }
}
