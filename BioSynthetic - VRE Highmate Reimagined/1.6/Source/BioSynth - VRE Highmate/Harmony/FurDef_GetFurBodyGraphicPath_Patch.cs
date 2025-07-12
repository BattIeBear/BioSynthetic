using HarmonyLib;
using RimWorld;
using Verse;

namespace BioSynth_VRE_Highmate
{
    [HarmonyPatch(typeof(FurDef), nameof(FurDef.GetFurBodyGraphicPath))]
    public static class FurDef_GetFurBodyGraphicPath_Patch
    {
        public static void Prefix(FurDef __instance, ref Pawn pawn)
        {
            string malePath = "";
            string femalePath = "";
            string thinPath = "";
            string hulkPath = "";
            string fatPath = "";

            bool bodyTypeFound = false;
            foreach (BodyTypeGraphicData graphicData in __instance.bodyTypeGraphicPaths)
            {
                if(graphicData.bodyType == pawn.story.bodyType)
                {
                    bodyTypeFound = true;
                }

                if (graphicData.bodyType == BodyTypeDefOf.Male)
                {
                    malePath = graphicData.texturePath;
                }
                else if (graphicData.bodyType == BodyTypeDefOf.Female)
                {
                    femalePath = graphicData.texturePath;
                }
                else if (graphicData.bodyType == BodyTypeDefOf.Thin)
                {
                    thinPath = graphicData.texturePath;
                }
                else if (graphicData.bodyType == BodyTypeDefOf.Hulk)
                {
                    hulkPath = graphicData.texturePath;
                }
                else if (graphicData.bodyType == BodyTypeDefOf.Fat)
                {
                    fatPath = graphicData.texturePath;
                }
            }

            if (bodyTypeFound == false)
            {
                BodyTypeGraphicData newGraphicData = new BodyTypeGraphicData();
                newGraphicData.bodyType = pawn.story.bodyType;
                if (pawn.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectMale)
                {
                    newGraphicData.texturePath = malePath;
                }
                else if (pawn.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectFemale)
                {
                    newGraphicData.texturePath = femalePath;
                }
                else if (pawn.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectThin)
                {
                    newGraphicData.texturePath = thinPath;
                }
                else if (pawn.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectHulk)
                {
                    newGraphicData.texturePath = hulkPath;
                }
                else if (pawn.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectFat)
                {
                    newGraphicData.texturePath = fatPath;
                }
                
                if (newGraphicData.texturePath != null)
                {
                    __instance.bodyTypeGraphicPaths.Add(newGraphicData);
                }
            }
        }
    }
}
