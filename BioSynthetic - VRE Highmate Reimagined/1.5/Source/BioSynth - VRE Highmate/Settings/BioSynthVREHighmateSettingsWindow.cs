using UnityEngine;
using Verse;

namespace BioSynth_VRE_Highmate
{
    public class BioSynthVREHighmateSettingsWindow : Mod
    {
        /// A reference to our settings.
        BioSynthVREHighmateSettings settings;

        /// A mandatory constructor which resolves the reference to our settings.
        public BioSynthVREHighmateSettingsWindow(ModContentPack content) : base(content)
        {
            this.settings = GetSettings<BioSynthVREHighmateSettings>();
        }

        /// The (optional) GUI part to set your settings.
        public override void DoSettingsWindowContents(Rect inRect)
        {
            Rect lRect = new Rect(inRect.x, inRect.y, (inRect.width / 2f) - 15f, inRect.height);
            Rect rRect = new Rect((inRect.x + inRect.width / 2f) + 15f, inRect.y, (inRect.width / 2f) - 15f, inRect.height);
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            listingStandard.Label("BioSynth_VREHigmate_TopWarning".Translate());

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

            listingStandard.Label("BioSynth_VREHigmate_BottomWarning".Translate());

            listingStandard.End();



            listingStandard.Begin(lRect);

            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();

            listingStandard.Label("BioSynth_VREHigmate_Label1".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_AllowExtraHairColors".Translate(), ref BioSynthVREHighmateSettings.AllowExtraHairColors, "BioSynth_VREHigmate_AllowExtraHairColorsDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_AllowExtraSkinColors".Translate(), ref BioSynthVREHighmateSettings.AllowExtraSkinColors, "BioSynth_VREHigmate_AllowExtraSkinColorsDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_AllowCustomSkinColors".Translate(), ref BioSynthVREHighmateSettings.AllowCustomSkinColors, "BioSynth_VREHigmate_AllowCustomSkinColorsDesc".Translate());

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_VREHigmate_Label2".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_CatEarsDefaultSprite".Translate(), ref BioSynthVREHighmateSettings.CatEarsDefaultSprite, "BioSynth_VREHigmate_CatEarsDefaultSpriteDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_CatEarsHairColor".Translate(), ref BioSynthVREHighmateSettings.CatEarsHairColor, "BioSynth_VREHigmate_CatEarsHairColorDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_HalfCatEars".Translate(), ref BioSynthVREHighmateSettings.HalfCatEars, "BioSynth_VREHigmate_HalfCatEarsDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_HalfCatTails".Translate(), ref BioSynthVREHighmateSettings.HalfCatTails, "BioSynth_VREHigmate_HalfCatTailsDesc".Translate());

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_VREHigmate_Label3".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_OptionalRewriteThoughts".Translate(), ref BioSynthVREHighmateSettings.OptionalRewriteThoughts, "BioSynth_VREHigmate_OptionalRewriteThoughtsDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_OptionalTrimHairSelection".Translate(), ref BioSynthVREHighmateSettings.OptionalTrimHairSelection, "BioSynth_VREHigmate_OptionalTrimHairSelectionDesc".Translate());

            listingStandard.End();



            listingStandard.Begin(rRect);

            listingStandard.Gap();
            listingStandard.Gap();
            listingStandard.Gap();

            listingStandard.Label("BioSynth_VREHigmate_Label4".Translate());
            listingStandard.Label("BioSynth_VREHigmate_Label5".Translate());
            listingStandard.Label("BioSynth_VREHigmate_Label6".Translate());
            listingStandard.Label("BioSynth_VREHigmate_Label7".Translate());
            listingStandard.Label("BioSynth_VREHigmate_Label8".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_HighmateUsesAdditionalGenes".Translate(), ref BioSynthVREHighmateSettings.HighmateUsesAdditionalGenes, "BioSynth_VREHigmate_HighmateUsesAdditionalGenesDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_SoftRemoveLowmate".Translate(), ref BioSynthVREHighmateSettings.SoftRemoveLowmate, "BioSynth_VREHigmate_SoftRemoveLowmateDesc".Translate());
            if (BioSynthVREHighmateSettings.SoftRemoveLowmate == true)
            {
                BioSynthVREHighmateSettings.FullRemoveLowmate = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_FullRemoveLowmate".Translate(), ref BioSynthVREHighmateSettings.FullRemoveLowmate, "BioSynth_VREHigmate_FullRemoveLowmateDesc".Translate());
            if (BioSynthVREHighmateSettings.FullRemoveLowmate == true)
            {
                BioSynthVREHighmateSettings.SoftRemoveLowmate = false;
            }

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_VREHigmate_Label9".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_AestheticShaperUsesPerfectBody".Translate(), ref BioSynthVREHighmateSettings.AestheticShaperUsesPerfectBody, "BioSynth_VREHigmate_AestheticShaperUsesPerfectBodyDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_LoveEnhancerUsesPerfectBody".Translate(), ref BioSynthVREHighmateSettings.LoveEnhancerUsesPerfectBody, "BioSynth_VREHigmate_LoveEnhancerUsesPerfectBodyDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_LovinDependencyMakesBisexual".Translate(), ref BioSynthVREHighmateSettings.LovinDependencyMakesBisexual, "BioSynth_VREHigmate_LovinDependencyMakesBisexualDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_LovinDeficiencyDoesNotTriggerGiveUp".Translate(), ref BioSynthVREHighmateSettings.LovinDeficiencyDoesNotTriggerGiveUp, "BioSynth_VREHigmate_LovinDeficiencyDoesNotTriggerGiveUpDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_InitiateLovinRespectsSexuality".Translate(), ref BioSynthVREHighmateSettings.InitiateLovinRespectsSexuality, "BioSynth_VREHigmate_InitiateLovinRespectsSexualityDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHigmate_InitiateLovinRespectsConsent".Translate(), ref BioSynthVREHighmateSettings.InitiateLovinRespectsConsent, "BioSynth_VREHigmate_InitiateLovinRespectsConsentDesc".Translate());

            listingStandard.End();
            base.DoSettingsWindowContents(inRect);
        }

        /// Override SettingsCategory to show up in the list of settings.
        /// Using .Translate() is optional, but does allow for localization.
        public override string SettingsCategory()
        {
            return "BioSynth_VREHigmate_ModName".Translate();
        }
    }
}