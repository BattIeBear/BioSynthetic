using UnityEngine;
using Verse;

namespace BioSynth_HemogenLighting
{
    internal class BioSynthHemogenLightingSettingsWindow : Mod
    {
        /// A reference to our settings.
        BioSynthHemogenLightingSettings settings;

        /// A mandatory constructor which resolves the reference to our settings.
        public BioSynthHemogenLightingSettingsWindow(ModContentPack content) : base(content)
        {
            this.settings = GetSettings<BioSynthHemogenLightingSettings>();
        }

        /// The (optional) GUI part to set your settings.
        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);

            listingStandard.Label("BioSynth_HemogenLighting_TopWarning".Translate());

            listingStandard.GapLine();

            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();

            listingStandard.Label("BioSynth_HemogenLighting_LabelOne".Translate());
            listingStandard.CheckboxLabeled("BioSynth_HemogenLighting_RequiresBloodfeedingMeme".Translate(), ref BioSynthHemogenLightingSettings.RequiresBloodfeedingMeme, "BioSynth_HemogenLighting_RequiresBloodfeedingMemeDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_HemogenLighting_RequiresAdvancedLightsResearch".Translate(), ref BioSynthHemogenLightingSettings.RequiresAdvancedLightsResearch, "BioSynth_HemogenLighting_RequiresAdvancedLightsResearchDesc".Translate());

            listingStandard.Gap();

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_HemogenLighting_BottomWarning".Translate());

            listingStandard.End();
            base.DoSettingsWindowContents(inRect);
        }

        /// Override SettingsCategory to show up in the list of settings.
        /// Using .Translate() is optional, but does allow for localisation.
        public override string SettingsCategory()
        {
            return "BioSynth_HemogenLighting_ModName".Translate();
        }
    }
}