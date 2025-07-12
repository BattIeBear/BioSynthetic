using HarmonyLib;
using RimWorld;
using VanillaRacesExpandedHighmate;
using Verse;

namespace BioSynth_VRE_Highmate
{
    [HarmonyPatch(typeof(CompAbilityEffect_InitiateLovin), nameof(CompAbilityEffect_InitiateLovin.Valid))]
    public static class CompAbilityEffect_InitiateLovin_Valid_Patch
    {
        public static bool Postfix(bool ___result, CompAbilityEffect_InitiateLovin __instance, ref LocalTargetInfo target, ref bool throwMessages)
        {
            if(!___result || (BioSynthVREHighmateSettings.InitiateLovinRespectsSexuality == false && BioSynthVREHighmateSettings.InitiateLovinRespectsConsent == false))
            {
                return ___result;
            }

            Pawn initiator = __instance.parent.pawn;
            Pawn recipient = target.Pawn;

            if (initiator == null)
            {
                return ___result;
            }

            if (recipient == null)
            {
                return ___result;
            }

            if (BioSynthVREHighmateSettings.InitiateLovinRespectsConsent)
            {
                if(recipient.IsSlaveOfColony || recipient.IsPrisonerOfColony)
                {
                    if (throwMessages)
                    {
                        Messages.Message("BioSynth_VREHigmate_NonConsent".Translate(initiator.LabelShortCap, recipient.LabelShortCap), recipient, MessageTypeDefOf.RejectInput, historical: false);
                    }
                    return false;
                }
            }

            if (BioSynthVREHighmateSettings.InitiateLovinRespectsSexuality)
            {
                if (initiator.gender == recipient.gender)
                {
                    if (initiator.story.traits.HasTrait(TraitDefOf.Gay) == false && initiator.story.traits.HasTrait(TraitDefOf.Bisexual) == false)
                    {
                        if (throwMessages)
                        {
                            Messages.Message("BioSynth_VREHigmate_InitiatorNotGay".Translate(initiator.LabelShortCap, recipient.LabelShortCap), recipient, MessageTypeDefOf.RejectInput, historical: false);
                        }
                        return false;
                    }
                    if (recipient.story.traits.HasTrait(TraitDefOf.Gay) == false && recipient.story.traits.HasTrait(TraitDefOf.Bisexual) == false)
                    {
                        if (throwMessages)
                        {
                            Messages.Message("BioSynth_VREHigmate_RecipientNotGay".Translate(initiator.LabelShortCap, recipient.LabelShortCap), recipient, MessageTypeDefOf.RejectInput, historical: false);
                        }
                        return false;
                    }
                }
                else
                {
                    if (initiator.story.traits.HasTrait(TraitDefOf.Gay) == true)
                    {
                        if (throwMessages)
                        {
                            Messages.Message("BioSynth_VREHigmate_InitiatorIsGay".Translate(initiator.LabelShortCap, recipient.LabelShortCap), recipient, MessageTypeDefOf.RejectInput, historical: false);
                        }
                        return false;
                    }
                    if (recipient.story.traits.HasTrait(TraitDefOf.Gay) == true)
                    {
                        if (throwMessages)
                        {
                            Messages.Message("BioSynth_VREHigmate_RecipientIsGay".Translate(initiator.LabelShortCap, recipient.LabelShortCap), recipient, MessageTypeDefOf.RejectInput, historical: false);
                        }
                        return false;
                    }
                }
            }
            return ___result;
        }
    }
}