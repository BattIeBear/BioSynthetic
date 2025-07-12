using Verse;

namespace BioSynth_VRE_Highmate
{
    public class BioSynthVREHighmateSettings : ModSettings
    {
        /// allows for extra hair and skin colors
        public static bool AllowExtraHairColors = true;
        public static bool AllowExtraSkinColors = true;
        public static bool AllowCustomSkinColors = true;

        /// choices for the cat genes (if activated in VRE)
        public static bool CatEarsDefaultSprite = true;
        public static bool CatEarsHairColor = true;
        public static bool HalfCatEars = false;
        public static bool HalfCatTails = false;

        /// minor toggleable options
        public static bool OptionalRewriteThoughts = true;
        public static bool OptionalTrimHairSelection = false;


        /// applies lowmate genes to highmate
        public static bool HighmateUsesAdditionalGenes = true;
        public static bool SoftRemoveLowmate = false;
        public static bool FullRemoveLowmate = false;

        /// adds minor gameplay changes
        public static bool AestheticShaperUsesPerfectBody = true;
        public static bool LoveEnhancerUsesPerfectBody = true;
        public static bool LovinDependencyMakesBisexual = true;
        public static bool LovinDeficiencyDoesNotTriggerGiveUp = true;
        public static bool InitiateLovinRespectsSexuality = true;
        public static bool InitiateLovinRespectsConsent = true;



        /// The part that writes our settings to file. Note that saving is by ref.
        public override void ExposeData()
        {
            Scribe_Values.Look(ref AllowExtraHairColors, "AllowExtraHairColors");
            Scribe_Values.Look(ref AllowExtraSkinColors, "AllowExtraSkinColors");
            Scribe_Values.Look(ref AllowCustomSkinColors, "AllowCustomSkinColors");
            Scribe_Values.Look(ref CatEarsDefaultSprite, "CatEarsDefaultSprite");
            Scribe_Values.Look(ref CatEarsHairColor, "CatEarsHairColor");
            Scribe_Values.Look(ref HalfCatEars, "HalfCatEars");
            Scribe_Values.Look(ref HalfCatTails, "HalfCatTails");
            Scribe_Values.Look(ref OptionalRewriteThoughts, "OptionalRewriteThoughts");
            Scribe_Values.Look(ref OptionalTrimHairSelection, "OptionalTrimHairSelection");
            Scribe_Values.Look(ref HighmateUsesAdditionalGenes, "HighmateUsesAdditionalGenes");
            Scribe_Values.Look(ref SoftRemoveLowmate, "SoftRemoveLowmate");
            Scribe_Values.Look(ref FullRemoveLowmate, "FullRemoveLowmate");
            Scribe_Values.Look(ref AestheticShaperUsesPerfectBody, "AestheticShaperUsesPerfectBody");
            Scribe_Values.Look(ref LoveEnhancerUsesPerfectBody, "LoveEnhancerUsesPerfectBody");
            Scribe_Values.Look(ref LovinDependencyMakesBisexual, "LovinDependencyMakesBisexual");
            Scribe_Values.Look(ref LovinDeficiencyDoesNotTriggerGiveUp, "LovinDefficiencyDoesNotTriggerGiveUp");
            Scribe_Values.Look(ref InitiateLovinRespectsSexuality, "InitiateLovinRespectsSexuality");
            Scribe_Values.Look(ref InitiateLovinRespectsConsent, "InitiateLovinRespectsConsent");
            base.ExposeData();
        }
    }
}