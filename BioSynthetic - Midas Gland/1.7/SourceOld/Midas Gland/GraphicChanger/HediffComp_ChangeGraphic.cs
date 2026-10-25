using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Verse;

namespace BioSynth_MidasGland
{
    public class HediffComp_ChangeGraphic : HediffComp
    {
        public static Dictionary<string, Color?> PawnIDtoHairOverride = new Dictionary<string, Color?>();
        public static Dictionary<string, Color?> PawnIDtoSkinOverride = new Dictionary<string, Color?>();

        public override void CompPostMake()
        {
            Pawn pawn = Pawn;
            string ID = pawn.GetUniqueLoadID();

            Color implantColor;
            switch (Def.defName)
            {
                case "biosynth_MidasGland":
                    implantColor = GenColor.FromHex(ColorChangerUtils.GetGoldColor);
                    break;
                case "biosynth_MercuryGland":
                    implantColor = GenColor.FromHex(ColorChangerUtils.GetSilverColor);
                    break;
                default:
                    Log.Error("Error: Tried to Run HediffComp_ChangeGraphic.CompPostMake with Def named: " + Def.defName);
                    implantColor = Color.magenta;
                    break;
            }

            //Hair
            //if no reference
            if (PawnIDtoHairOverride.ContainsKey(ID) == false)
            {
                //add reference
                PawnIDtoHairOverride.Add(ID, pawn.story.HairColor);
            }
            pawn.story.HairColor = ColorChangerUtils.ConvertToHair(implantColor);
            //end Hair

            //if override
            //and no reference
            if (PawnIDtoSkinOverride.ContainsKey(ID) == false)
            {
                //add reference
                PawnIDtoSkinOverride.Add(ID, pawn.story.skinColorOverride);
            }

            pawn.story.skinColorOverride = implantColor;
            foreach (Gene gene in pawn.genes.GenesListForReading)
            {
                if (gene.def.skinIsHairColor)
                {
                    pawn.story.skinColorOverride = pawn.story.HairColor;
                }
            }
            pawn.Drawer.renderer.SetAllGraphicsDirty();
            //end Body
        }

        public override void CompPostPostRemoved()
        {
            Pawn pawn = Pawn;
            if (PawnIDtoHairOverride.ContainsKey(pawn.GetUniqueLoadID()))
            {
                //set override to reference
                pawn.story.HairColor = (Color)PawnIDtoHairOverride[pawn.GetUniqueLoadID()];
                PawnIDtoHairOverride.Remove(pawn.GetUniqueLoadID());
            }
            
            //if reference exists
            if (PawnIDtoSkinOverride.ContainsKey(pawn.GetUniqueLoadID()))
            {
                //set override to reference
                pawn.story.skinColorOverride = PawnIDtoSkinOverride[pawn.GetUniqueLoadID()];
                PawnIDtoSkinOverride.Remove(pawn.GetUniqueLoadID());
            }
            else
            {
                //otherwise
                Log.Error("SkinColor Override Not Saved Properly");
            }

            foreach (Gene gene in pawn.genes.GenesListForReading)
            {
                if (gene.def.skinIsHairColor)
                {
                    pawn.story.skinColorOverride = pawn.story.HairColor;
                }
            }
            pawn.Drawer.renderer.SetAllGraphicsDirty();
        }


        public override void CompExposeData()
        {
            if (PawnIDtoHairOverride == null)
            {
                PawnIDtoHairOverride = new Dictionary<string, Color?>();
            }
            List<string> hairKeyList = PawnIDtoHairOverride.Keys.ToList();
            List<Color?> hairValueList = PawnIDtoHairOverride.Values.ToList();

            if (PawnIDtoSkinOverride == null)
            {
                PawnIDtoSkinOverride = new Dictionary<string, Color?>();
            }
            List<string> skinKeyList = PawnIDtoSkinOverride.Keys.ToList();
            List<Color?> skinValueList = PawnIDtoSkinOverride.Values.ToList();

            Scribe_Collections.Look(ref PawnIDtoSkinOverride, "PawnIDtoSkinOverride", LookMode.Value, LookMode.Value, ref skinKeyList, ref skinValueList);
            Scribe_Collections.Look(ref PawnIDtoHairOverride, "PawnIDtoHairOverride", LookMode.Value, LookMode.Value, ref hairKeyList, ref hairValueList);
        }
    }
}