using UnityEngine;
using Verse;

namespace BioSynth_VanillaImpidReimagined
{
    internal class BioSynthVanillaImpidReimaginedSettingsWindow : Mod
    {
        /// A reference to our settings.
        BioSynthVanillaImpidReimaginedSettings settings;

        /// A mandatory constructor which resolves the reference to our settings.
        public BioSynthVanillaImpidReimaginedSettingsWindow(ModContentPack content) : base(content)
        {
            this.settings = GetSettings<BioSynthVanillaImpidReimaginedSettings>();
        }

        /// The (optional) GUI part to set your settings.
        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);

            listingStandard.Label("BioSynth_VanillaImpidReimagined_TopWarning".Translate());

            listingStandard.GapLine();

            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();

            listingStandard.Label("BioSynth_VanillaImpidReimagined_LabelOne".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VanillaImpidReimagined_AddNewHairOptions".Translate(), ref BioSynthVanillaImpidReimaginedSettings.AddNewHairOptions, "BioSynth_VanillaImpidReimagined_AddNewHairOptionsDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VanillaImpidReimagined_AddNewSkinColorY".Translate(), ref BioSynthVanillaImpidReimaginedSettings.AddNewSkinOptionsYellow, "BioSynth_VanillaImpidReimagined_AddNewSkinColorYDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VanillaImpidReimagined_AddNewSkinColorR".Translate(), ref BioSynthVanillaImpidReimaginedSettings.AddNewSkinOptionsRed, "BioSynth_VanillaImpidReimagined_AddNewSkinColorRDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VanillaImpidReimagined_LimitBodyOptions".Translate(), ref BioSynthVanillaImpidReimaginedSettings.AddBodyOptions, "BioSynth_VanillaImpidReimagined_LimitBodyOptionsDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VanillaImpidReimagined_UpdateGenes".Translate(), ref BioSynthVanillaImpidReimaginedSettings.UseNewGenes, "BioSynth_VanillaImpidReimagined_UpdateGenesDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VanillaImpidReimagined_NakedSpeedOptions".Translate(), ref BioSynthVanillaImpidReimaginedSettings.NakedSpeedOptions, "BioSynth_VanillaImpidReimagined_NakedSpeedOptionsDesc".Translate());

            listingStandard.GapLine();

            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();

            listingStandard.Label("BioSynth_VanillaImpidReimagined_LabelTwo".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VanillaImpidReimagined_UpdateFactionOptions".Translate(), ref BioSynthVanillaImpidReimaginedSettings.ModifyFaction, "BioSynth_VanillaImpidReimagined_UpdateFactionOptionsDesc".Translate());


            listingStandard.Gap();

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_VanillaImpidReimagined_BottomWarning".Translate());

            listingStandard.End();
            base.DoSettingsWindowContents(inRect);
        }

        /// Override SettingsCategory to show up in the list of settings.
        /// Using .Translate() is optional, but does allow for localisation.
        public override string SettingsCategory()
        {
            return "BioSynth_VanillaImpidReimagined_ModName".Translate();
        }
    }
}