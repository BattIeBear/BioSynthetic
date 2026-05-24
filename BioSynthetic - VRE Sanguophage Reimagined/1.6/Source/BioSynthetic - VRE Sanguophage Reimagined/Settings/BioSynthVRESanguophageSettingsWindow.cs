using UnityEngine;
using Verse;

namespace BioSynth_VRE_Sanguophage
{
    public class BioSynthVRESanguophageSettingsWindow : Mod
    {
        /// A reference to our settings.
        BioSynthVRESanguophageSettings settings;

        /// A mandatory constructor which resolves the reference to our settings.
        public BioSynthVRESanguophageSettingsWindow(ModContentPack content) : base(content)
        {
            this.settings = GetSettings<BioSynthVRESanguophageSettings>();
        }

        /// The (optional) GUI part to set your settings.
        public override void DoSettingsWindowContents(Rect inRect)
        {
            Rect lRect = new Rect(inRect.x, inRect.y, (inRect.width / 2f) - 15f, inRect.height);
            Rect rRect = new Rect((inRect.x + inRect.width / 2f) + 15f, inRect.y, (inRect.width / 2f) - 15f, inRect.height);
            Listing_Standard listingStandard = new Listing_Standard();


            listingStandard.Begin(inRect);
            listingStandard.Label("BioSynth_VRESanguophage_TopWarning".Translate());

            listingStandard.GapLine();

            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_VRESanguophage_BottomWarning".Translate());

            listingStandard.End();



            listingStandard.Begin(lRect);

            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();

            listingStandard.Label("BioSynth_VRESanguophage_Label1".Translate());
            listingStandard.Gap();
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_RemoveBruxaSoft".Translate(), ref BioSynthVRESanguophageSettings.RemoveBruxaSoft, "BioSynth_VRESanguophage_RemoveBruxaSoftDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_BruxaBodyStandard".Translate(), ref BioSynthVRESanguophageSettings.BruxaBodyStandard, "BioSynth_VRESanguophage_BruxaBodyStandardDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_BruxaRemoveHair".Translate(), ref BioSynthVRESanguophageSettings.BruxaRemoveHair, "BioSynth_VRESanguophage_BruxaRemoveHairDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_BruxaPerfectBody".Translate(), ref BioSynthVRESanguophageSettings.BruxaPerfectBody, "BioSynth_VRESanguophage_BruxaPerfectBodyDesc".Translate());

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_VRESanguophage_Label2".Translate());
            listingStandard.Gap();
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_RemoveEkkimianSoft".Translate(), ref BioSynthVRESanguophageSettings.RemoveEkkimianSoft, "BioSynth_VRESanguophage_RemoveEkkimianSoftDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_EkkimianBothBatEars".Translate(), ref BioSynthVRESanguophageSettings.EkkimianBothBatEars, "BioSynth_VRESanguophage_EkkimianBothBatEarsDesc".Translate());
            if (BioSynthVRESanguophageSettings.EkkimianBothBatEars == true)
            {
                BioSynthVRESanguophageSettings.EkkimianRemoveBatEars = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_EkkimianRemoveBatEars".Translate(), ref BioSynthVRESanguophageSettings.EkkimianRemoveBatEars, "BioSynth_VRESanguophage_EkkimianRemoveBatEarsDesc".Translate());
            if (BioSynthVRESanguophageSettings.EkkimianRemoveBatEars == true)
            {
                BioSynthVRESanguophageSettings.EkkimianBothBatEars = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_EkkimianBeardless".Translate(), ref BioSynthVRESanguophageSettings.EkkimianBeardless, "BioSynth_VRESanguophage_EkkimianBeardlessDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_EkkimianBodyPlusHulk".Translate(), ref BioSynthVRESanguophageSettings.EkkimianBodyPlusHulk, "BioSynth_VRESanguophage_EkkimianBodyPlusHulkDesc".Translate());
            if (BioSynthVRESanguophageSettings.EkkimianBodyPlusHulk == true)
            {
                BioSynthVRESanguophageSettings.EkkimianBodyAny = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_EkkimianBodyAny".Translate(), ref BioSynthVRESanguophageSettings.EkkimianBodyAny, "BioSynth_VRESanguophage_EkkimianBodyAnyDesc".Translate());
            if (BioSynthVRESanguophageSettings.EkkimianBodyAny == true)
            {
                BioSynthVRESanguophageSettings.EkkimianBodyPlusHulk = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_EkkimianGauntBody".Translate(), ref BioSynthVRESanguophageSettings.EkkimianGauntBody, "BioSynth_VRESanguophage_EkkimianGauntBodyDesc".Translate());

            listingStandard.End();



            listingStandard.Begin(rRect);

            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();

            listingStandard.Label("BioSynth_VRESanguophage_Label3".Translate());
            listingStandard.Gap();
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_RemoveStrigoiSoft".Translate(), ref BioSynthVRESanguophageSettings.RemoveStrigoiSoft, "BioSynth_VRESanguophage_RemoveStrigoiSoftDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_StrigoiBothBatEars".Translate(), ref BioSynthVRESanguophageSettings.StrigoiBothBatEars, "BioSynth_VRESanguophage_StrigoiBothBatEarsDesc".Translate());
            if (BioSynthVRESanguophageSettings.StrigoiBothBatEars == true)
            {
                BioSynthVRESanguophageSettings.StrigoiRemoveBatEars = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_StrigoiRemoveBatEars".Translate(), ref BioSynthVRESanguophageSettings.StrigoiRemoveBatEars, "BioSynth_VRESanguophage_StrigoiRemoveBatEarsDesc".Translate());
            if (BioSynthVRESanguophageSettings.StrigoiRemoveBatEars == true)
            {
                BioSynthVRESanguophageSettings.StrigoiBothBatEars = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_StrigoiRemoveBatNose".Translate(), ref BioSynthVRESanguophageSettings.StrigoiRemoveBatNose, "BioSynth_VRESanguophage_StrigoiRemoveBatNoseDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_StrigoiRemoveHair".Translate(), ref BioSynthVRESanguophageSettings.StrigoiRemoveHair, "BioSynth_VRESanguophage_StrigoiRemoveHairDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_StrigoiBeardless".Translate(), ref BioSynthVRESanguophageSettings.StrigoiBeardless, "BioSynth_VRESanguophage_StrigoiBeardlessDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_StrigoiNonSkinny".Translate(), ref BioSynthVRESanguophageSettings.StrigoiBodyNonSkinny, "BioSynth_VRESanguophage_StrigoiNonSkinnyDesc".Translate());
            if (BioSynthVRESanguophageSettings.StrigoiBodyNonSkinny == true)
            {
                BioSynthVRESanguophageSettings.StrigoiBodyLarge = false;
                BioSynthVRESanguophageSettings.StrigoiBodyHulk = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_StrigoiLargeBody".Translate(), ref BioSynthVRESanguophageSettings.StrigoiBodyLarge, "BioSynth_VRESanguophage_StrigoiLargeBodyDesc".Translate());
            if (BioSynthVRESanguophageSettings.StrigoiBodyLarge == true)
            {
                BioSynthVRESanguophageSettings.StrigoiBodyNonSkinny = false;
                BioSynthVRESanguophageSettings.StrigoiBodyHulk = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_StrigoiHulkBody".Translate(), ref BioSynthVRESanguophageSettings.StrigoiBodyHulk, "BioSynth_VRESanguophage_StrigoiHulkBodyDesc".Translate());
            if (BioSynthVRESanguophageSettings.StrigoiBodyHulk == true)
            {
                BioSynthVRESanguophageSettings.StrigoiBodyNonSkinny = false;
                BioSynthVRESanguophageSettings.StrigoiBodyLarge = false;
            }

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_VRESanguophage_Label4".Translate());
            listingStandard.Gap();
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_RemoveBloodmoon".Translate(), ref BioSynthVRESanguophageSettings.RemoveBloodmoon, "BioSynth_VRESanguophage_RemoveBloodmoonDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_HemogenicHalfHunger".Translate(), ref BioSynthVRESanguophageSettings.HemogenicHalfHunger, "BioSynth_VRESanguophage_HemogenicHalfHungerDesc".Translate());
            if (BioSynthVRESanguophageSettings.HemogenicHalfHunger == true)
            {
                BioSynthVRESanguophageSettings.HemogenicNoHunger = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_HemogenicNoHunger".Translate(), ref BioSynthVRESanguophageSettings.HemogenicNoHunger, "BioSynth_VRESanguophage_HemogenicNoHungerDesc".Translate());
            if (BioSynthVRESanguophageSettings.HemogenicNoHunger == true)
            {
                BioSynthVRESanguophageSettings.HemogenicHalfHunger = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_HemogenicHideHediff".Translate(), ref BioSynthVRESanguophageSettings.HemogenicHideHediff, "BioSynth_VRESanguophage_HemogenicHideHediffDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_GenesRegrowOneYear".Translate(), ref BioSynthVRESanguophageSettings.GenesRegrowOneYear, "BioSynth_VRESanguophage_GenesRegrowOneYearDesc".Translate());
            if (BioSynthVRESanguophageSettings.GenesRegrowOneYear == true)
            {
                BioSynthVRESanguophageSettings.GenesRegrowHalfYear = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_GenesRegrowHalfYear".Translate(), ref BioSynthVRESanguophageSettings.GenesRegrowHalfYear, "BioSynth_VRESanguophage_GenesRegrowHalfYearDesc".Translate());
            if (BioSynthVRESanguophageSettings.GenesRegrowHalfYear == true)
            {
                BioSynthVRESanguophageSettings.GenesRegrowOneYear = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VRESanguophage_BaselinerForced".Translate(), ref BioSynthVRESanguophageSettings.BaselinerForced, "BioSynth_VRESanguophage_BaselinerForcedDesc".Translate());
            listingStandard.End();
            base.DoSettingsWindowContents(inRect);
        }

        /// Override SettingsCategory to show up in the list of settings.
        /// Using .Translate() is optional, but does allow for localization.
        public override string SettingsCategory()
        {
            return "BioSynth_VRESanguophage_ModName".Translate();
        }
    }
}