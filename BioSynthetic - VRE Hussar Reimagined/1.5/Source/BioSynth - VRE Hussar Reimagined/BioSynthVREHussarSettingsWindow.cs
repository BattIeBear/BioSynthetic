using UnityEngine;
using Verse;

namespace BioSynth_VREHussarReimagined
{
    public class BioSynthVREHussarSettingsWindow : Mod
    {
        /// A reference to our settings.
        BioSynthVREHussarSettings settings;

        /// A mandatory constructor which resolves the reference to our settings.
        public BioSynthVREHussarSettingsWindow(ModContentPack content) : base(content)
        {
            this.settings = GetSettings<BioSynthVREHussarSettings>();
        }

        /// The (optional) GUI part to set your settings.
        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            listingStandard.Label("BioSynth_VREHussar_TopWarning".Translate());

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_VREHussar_Label1".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_MinimizeOverlap".Translate(), ref BioSynthVREHussarSettings.MinimizeOverlap, "BioSynth_VREHussar_MinimizeOverlapDesc".Translate());

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_VREHussar_Label2".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_EnableDrawbacks".Translate(), ref BioSynthVREHussarSettings.EnableDrawbacks, "BioSynth_VREHussar_EnableDrawbacksDesc".Translate());
            BioSynthVREHussarSettings.DrawbackChance = Mathf.RoundToInt(listingStandard.SliderLabeled("BioSynth_VREHussar_DrawbackChance".Translate() + BioSynthVREHussarSettings.DrawbackChance + "%", BioSynthVREHussarSettings.DrawbackChance, 1, 100, tooltip: "BioSynth_VREHussar_DrawbackChanceDesc".Translate()));
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_DisablePyromania".Translate(), ref BioSynthVREHussarSettings.DisablePyromania, "BioSynth_VREHussar_DisablePyromaniaDesc".Translate());

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_VREHussar_Label3".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_Demon".Translate(), ref BioSynthVREHussarSettings.Demon, "BioSynth_VREHussar_DemonDesc".Translate());
            if(BioSynthVREHussarSettings.Demon)
            {
                BioSynthVREHussarSettings.Devil = false;
                BioSynthVREHussarSettings.Fiend = false;
                BioSynthVREHussarSettings.Bloodletter = false;
                BioSynthVREHussarSettings.Bloodthirster = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_Devil".Translate(), ref BioSynthVREHussarSettings.Devil, "BioSynth_VREHussar_DevilDesc".Translate());
            if (BioSynthVREHussarSettings.Devil)
            {
                BioSynthVREHussarSettings.Demon = false;
                BioSynthVREHussarSettings.Fiend = false;
                BioSynthVREHussarSettings.Bloodletter = false;
                BioSynthVREHussarSettings.Bloodthirster = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_Fiend".Translate(), ref BioSynthVREHussarSettings.Fiend, "BioSynth_VREHussar_FiendDesc".Translate());
            if (BioSynthVREHussarSettings.Fiend)
            {
                BioSynthVREHussarSettings.Demon = false;
                BioSynthVREHussarSettings.Devil = false;
                BioSynthVREHussarSettings.Bloodletter = false;
                BioSynthVREHussarSettings.Bloodthirster = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_Bloodletter".Translate(), ref BioSynthVREHussarSettings.Bloodletter, "BioSynth_VREHussar_BloodletterDesc".Translate());
            if (BioSynthVREHussarSettings.Bloodletter)
            {
                BioSynthVREHussarSettings.Demon = false;
                BioSynthVREHussarSettings.Devil = false;
                BioSynthVREHussarSettings.Fiend = false;
                BioSynthVREHussarSettings.Bloodthirster = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_Bloodthirster".Translate(), ref BioSynthVREHussarSettings.Bloodthirster, "BioSynth_VREHussar_BloodthirsterDesc".Translate());
            if (BioSynthVREHussarSettings.Bloodthirster)
            {
                BioSynthVREHussarSettings.Demon = false;
                BioSynthVREHussarSettings.Devil = false;
                BioSynthVREHussarSettings.Fiend = false;
                BioSynthVREHussarSettings.Bloodletter = false;
            }

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_VREHussar_Label4".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_OptionalHorns".Translate(), ref BioSynthVREHussarSettings.Horns, "BioSynth_VREHussar_OptionalHornsDesc".Translate());

            listingStandard.Gap();

            listingStandard.Label("BioSynth_VREHussar_TopWarning".Translate());
            listingStandard.End();
            base.DoSettingsWindowContents(inRect);
        }

        /// Override SettingsCategory to show up in the list of settings.
        /// Using .Translate() is optional, but does allow for localization.
        public override string SettingsCategory()
        {
            return "BioSynth_VREHussar_ModName".Translate();
        }
    }
}