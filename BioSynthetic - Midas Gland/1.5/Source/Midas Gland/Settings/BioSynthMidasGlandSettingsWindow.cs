using UnityEngine;
using Verse;

namespace BioSynth_MidasGland
{
    internal class BioSynthMidasGlandSettingsWindow : Mod
    {
        /// A reference to our settings.
        BioSynthMidasGlandSettings settings;

        /// A mandatory constructor which resolves the reference to our settings.
        public BioSynthMidasGlandSettingsWindow(ModContentPack content) : base(content)
        {
            this.settings = GetSettings<BioSynthMidasGlandSettings>();
        }

        /// The (optional) GUI part to set your settings.
        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);

            listingStandard.Label("BioSynth_MidasGland_TopWarning".Translate());

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_MidasGland_LabelOne".Translate());
            listingStandard.CheckboxLabeled("BioSynth_MidasGland_RoyalGoldGlandOnly".Translate(), ref BioSynthMidasGlandSettings.RoyalGoldGlandOnly, "BioSynth_MidasGland_RoyalGoldGlandOnly_Desc".Translate());
            if (BioSynthMidasGlandSettings.RoyalGoldGlandOnly == true)
            {
                BioSynthMidasGlandSettings.RoyalGold = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_MidasGland_RoyalGold".Translate(), ref BioSynthMidasGlandSettings.RoyalGold, "BioSynth_MidasGland_RoyalGold_Desc".Translate());
            if (BioSynthMidasGlandSettings.RoyalGold == true)
            {
                BioSynthMidasGlandSettings.RoyalGoldGlandOnly = false;
            }
            listingStandard.GapLine();

            listingStandard.Label("BioSynth_MidasGland_LabelTwo".Translate());
            listingStandard.CheckboxLabeled("BioSynth_MidasGland_ConsistantSilver".Translate(), ref BioSynthMidasGlandSettings.ConsistantSilver, "BioSynth_MidasGland_ConsistantSilver_Desc".Translate());
            if (BioSynthMidasGlandSettings.ConsistantSilver == true)
            {
                BioSynthMidasGlandSettings.GraySilverGlandOnly = false;
                BioSynthMidasGlandSettings.GraySilver = false;
                BioSynthMidasGlandSettings.ChromeSilver = false;
                BioSynthMidasGlandSettings.ChromeSilverGlandOnly = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_MidasGland_GraySilverGlandOnly".Translate(), ref BioSynthMidasGlandSettings.GraySilverGlandOnly, "BioSynth_MidasGland_GraySilverGlandOnly_Desc".Translate());
            if (BioSynthMidasGlandSettings.GraySilverGlandOnly == true)
            {
                BioSynthMidasGlandSettings.ConsistantSilver = false;
                BioSynthMidasGlandSettings.GraySilver = false;
                BioSynthMidasGlandSettings.ChromeSilver = false;
                BioSynthMidasGlandSettings.ChromeSilverGlandOnly = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_MidasGland_GraySilver".Translate(), ref BioSynthMidasGlandSettings.GraySilver, "BioSynth_MidasGland_GraySilver_Desc".Translate());
            if (BioSynthMidasGlandSettings.GraySilver == true)
            {
                BioSynthMidasGlandSettings.ConsistantSilver = false;
                BioSynthMidasGlandSettings.GraySilverGlandOnly = false;
                BioSynthMidasGlandSettings.ChromeSilver = false;
                BioSynthMidasGlandSettings.ChromeSilverGlandOnly = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_MidasGland_ChromeSilverGlandOnly".Translate(), ref BioSynthMidasGlandSettings.ChromeSilverGlandOnly, "BioSynth_MidasGland_ChromeSilverGlandOnly_Desc".Translate());
            if (BioSynthMidasGlandSettings.ChromeSilverGlandOnly == true)
            {
                BioSynthMidasGlandSettings.ConsistantSilver = false;
                BioSynthMidasGlandSettings.GraySilverGlandOnly = false;
                BioSynthMidasGlandSettings.GraySilver = false;
                BioSynthMidasGlandSettings.ChromeSilver = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_MidasGland_ChromeSilver".Translate(), ref BioSynthMidasGlandSettings.ChromeSilver, "BioSynth_MidasGland_ChromeSilver_Desc".Translate());
            if (BioSynthMidasGlandSettings.ChromeSilver == true)
            {
                BioSynthMidasGlandSettings.ConsistantSilver = false;
                BioSynthMidasGlandSettings.GraySilverGlandOnly = false;
                BioSynthMidasGlandSettings.GraySilver = false;
                BioSynthMidasGlandSettings.ChromeSilverGlandOnly = false;
            }
            listingStandard.GapLine();

            listingStandard.Label("BioSynth_MidasGland_BottomWarning".Translate());

            listingStandard.End();

            

            base.DoSettingsWindowContents(inRect);
        }

        /// Override SettingsCategory to show up in the list of settings.
        /// Using .Translate() is optional, but does allow for localisation.
        public override string SettingsCategory()
        {
            return "BioSynth_MidasGland_ModName".Translate();
        }
    }
}