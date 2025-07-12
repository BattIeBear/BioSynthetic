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
            listingStandard.Label("BioSynth_VREWasters_TopWarning".Translate());

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_VREWasters_Label1".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREWasters_AddNewHairColors".Translate(), ref BioSynthVREWasterSettings.AddNewHairColors, "BioSynth_VREWasters_AddNewHairColorsDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREWasters_AddNewSkinColors".Translate(), ref BioSynthVREWasterSettings.AddNewSkinColors, "BioSynth_VREWasters_AddNewSkinColorsDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREWasters_DisableGauntBody".Translate(), ref BioSynthVREWasterSettings.DisableGauntBody, "BioSynth_VREWasters_DisableGauntBodyDesc".Translate());

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_VREWasters_Label2".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREWasters_KeepInstability".Translate(), ref BioSynthVREWasterSettings.KeepInstability, "BioSynth_VREWasters_KeepInstabilityDesc".Translate());

            listingStandard.Label("BioSynth_VREWasters_BottomWarning".Translate());
            listingStandard.End();
            base.DoSettingsWindowContents(inRect);
        }

        /// Override SettingsCategory to show up in the list of settings.
        /// Using .Translate() is optional, but does allow for localization.
        public override string SettingsCategory()
        {
            return "BioSynth_VREWasters_ModName".Translate();
        }
    }
}