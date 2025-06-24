using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace BioSynth_MidasGland
{
    [HarmonyPatch(typeof(PawnRenderNode), nameof(PawnRenderNode.ColorFor))]
    public static class PawnRenderNode_ColorFor_Patch
    {
        public static void Prefix(ref PawnRenderNode __instance, ref Pawn pawn)
        {
            if (__instance.Props.colorType == PawnRenderNodeProperties.AttachmentColorType.Hair || __instance.Props.colorType == PawnRenderNodeProperties.AttachmentColorType.Skin)
            {
                foreach (Hediff hediff in pawn.health.hediffSet.hediffs)
                {
                    /// if it has Midas Gland
                    if (hediff.def.defName == "biosynth_MidasGland")
                    {
                        Color implantColor = GenColor.FromHex(ColorChangerUtils.GetGoldColor);

                        if (HediffComp_ChangeGraphic.PawnIDtoSkinOverride.ContainsKey(pawn.GetUniqueLoadID()) == false)
                        {
                            Log.Error(pawn.NameShortColored + "'s original skin color was not saved properly! (Midas Gland)");
                            return;
                        }

                        pawn.story.skinColorOverride = implantColor;

                        if (HediffComp_ChangeGraphic.PawnIDtoHairOverride.ContainsKey(pawn.GetUniqueLoadID()) == false)
                        {
                            Log.Error(pawn.NameShortColored + "'s original hair color was not saved properly! (Midas Gland)");
                            return;
                        }
                        pawn.story.HairColor = ColorChangerUtils.ConvertToHair(implantColor);

                        foreach (Gene gene in pawn.genes.GenesListForReading)
                        {
                            if (gene.def.skinIsHairColor)
                            {
                                pawn.story.skinColorOverride = pawn.story.HairColor;
                            }
                        }
                        return;
                    }

                    /// if it has Mercury Gland
                    if (hediff.def.defName == "biosynth_MercuryGland")
                    {
                        Color implantColor = GenColor.FromHex(ColorChangerUtils.GetSilverColor);

                        if (HediffComp_ChangeGraphic.PawnIDtoSkinOverride.ContainsKey(pawn.GetUniqueLoadID()) == false)
                        {
                            Log.Error(pawn.NameShortColored + "'s original skin color was not saved properly! (Mercury Gland)");
                            return;
                        }

                        pawn.story.skinColorOverride = implantColor;

                        if (HediffComp_ChangeGraphic.PawnIDtoHairOverride.ContainsKey(pawn.GetUniqueLoadID()) == false)
                        {
                            Log.Error(pawn.NameShortColored + "'s original hair color was not saved properly! (Mercury Gland)");
                            return;
                        }
                        pawn.story.HairColor = ColorChangerUtils.ConvertToHair(implantColor);

                        foreach (Gene gene in pawn.genes.GenesListForReading)
                        {
                            if (gene.def.skinIsHairColor)
                            {
                                pawn.story.skinColorOverride = pawn.story.HairColor;
                            }
                        }
                        return;
                    }
                }
            }
        }
    }
}