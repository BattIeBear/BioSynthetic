using UnityEngine;
using Verse;

namespace BioSynth_Diablitech
{
    internal class BioSynthDiablitechSettingsWindow : Mod
    {
        /// A reference to our settings.
        BioSynthDiablitechSettings settings;
        /// A mandatory constructor which resolves the reference to our settings.
        public BioSynthDiablitechSettingsWindow(ModContentPack content) : base(content)
        {
            this.settings = GetSettings<BioSynthDiablitechSettings>();
        }

        /// The (optional) GUI part to set your settings.
        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);

            listingStandard.Label("BioSynth_Diablitech_TopWarning".Translate());

            listingStandard.GapLine();

            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Label("BioSynth_Diablitech_LabelOne".Translate());
            BioSynthDiablitechSettings.numOfImplantsBeforePain = Mathf.RoundToInt(listingStandard.SliderLabeled("BioSynth_Diablitech_NumOfImplantsBeforePain".Translate() + (BioSynthDiablitechSettings.numOfImplantsBeforePain).ToString(),
                BioSynthDiablitechSettings.numOfImplantsBeforePain, 1f, 7f, tooltip: "BioSynth_Diablitech_NumOfImplantsBeforePainDesc".Translate())
            );
            listingStandard.Gap();
            listingStandard.GapLine();
            listingStandard.Gap();
            listingStandard.Label("BioSynth_Diablitech_LabelTwo".Translate());
            listingStandard.CheckboxLabeled("BioSynth_Diablitech_DevilHeartLuciferiumAddiction".Translate(), ref BioSynthDiablitechSettings.DevilHeartLuciferiumAddiction, "BioSynth_Diablitech_DevilHeartLuciferiumAddictionDesc".Translate());
            BioSynthDiablitechSettings.LuciferiumAddictionChance = listingStandard.SliderLabeled("BioSynth_Diablitech_LuciferiumAddictionChance".Translate() + (BioSynthDiablitechSettings.LuciferiumAddictionChance * 100f).ToString("F0") + "%",
                BioSynthDiablitechSettings.LuciferiumAddictionChance, 0f, 1f, tooltip: "BioSynth_Diablitech_LuciferiumAddictionChanceDesc".Translate()
            );
            // Get the height of a CheckboxLabeled (same as Text.LineHeight + 2f padding)

            listingStandard.Gap();

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_Diablitech_BottomWarning".Translate());

            listingStandard.End();
            base.DoSettingsWindowContents(inRect);
        }

        /// Override SettingsCategory to show up in the list of settings.
        /// Using .Translate() is optional, but does allow for localization.
        public override string SettingsCategory()
        {
            return "BioSynth_Diablitech_ModName".Translate();
        }

        
    }
}
