using UnityEngine;
using Verse;

namespace BioSynth_VRE_Wasters
{
    public class BioSynthVREWasterSettingsWindow : Mod
    {
        /// A reference to our settings.
        BioSynthVREWasterSettings settings;

        /// A mandatory constructor which resolves the reference to our settings.
        public BioSynthVREWasterSettingsWindow(ModContentPack content) : base(content)
        {
            this.settings = GetSettings<BioSynthVREWasterSettings>();
        }

        /// The (optional) GUI part to set your settings.
        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            listingStandard.Label("BioSynth_Wasters_TopWarning".Translate());

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_Wasters_Label1".Translate());
            listingStandard.CheckboxLabeled("BioSynth_Wasters_AddNewHairColors".Translate(), ref BioSynthVREWasterSettings.AddNewHairColors, "BioSynth_Wasters_AddNewHairColorsDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_Wasters_AddNewSkinColors".Translate(), ref BioSynthVREWasterSettings.AddNewSkinColors, "BioSynth_Wasters_AddNewSkinColorsDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_Wasters_DisableGauntBody".Translate(), ref BioSynthVREWasterSettings.DisableGauntBody, "BioSynth_Wasters_DisableGauntBodyDesc".Translate());

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_Wasters_Label2".Translate());
            listingStandard.CheckboxLabeled("BioSynth_Wasters_KeepInstability".Translate(), ref BioSynthVREWasterSettings.KeepInstability, "BioSynth_Wasters_KeepInstabilityDesc".Translate());

            listingStandard.Label("BioSynth_Wasters_BottomWarning".Translate());
            listingStandard.End();
            base.DoSettingsWindowContents(inRect);
        }

        /// Override SettingsCategory to show up in the list of settings.
        /// Using .Translate() is optional, but does allow for localization.
        public override string SettingsCategory()
        {
            return "BioSynth_Wasters_ModName".Translate();
        }
    }
}