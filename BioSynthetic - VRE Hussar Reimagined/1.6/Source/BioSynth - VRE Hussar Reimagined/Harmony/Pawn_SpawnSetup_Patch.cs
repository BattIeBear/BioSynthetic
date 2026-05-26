using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using Verse;

namespace BioSynth_VREHussarReimagined
{
    [HarmonyPatch(typeof(Pawn), nameof(Pawn.SpawnSetup))]
    public static class Pawn_SpawnSetup_Patch
    {
        public static List<GeneDef> genes = new List<GeneDef>();
        public static void Prefix(Pawn __instance)
        {
            if (BioSynthVREHussarSettings.ConvertToNew)
            {
                if (__instance.RaceProps.Humanlike == false)
                {
                    return;
                }
                if (genes.Count == 0)
                {
                    genes = DefDatabase<GeneDef>.AllDefs.Where((GeneDef x) => ((Def)x).defName.Contains("VREHT_") && ((Def)x).defName != "VREHT_Conversion").ToList();
                }
                foreach (GeneDef gene in genes)
                {
                    if (__instance.genes.HasActiveGene(gene))
                    {
                        Log.Message(gene.defName + " found in " + __instance.Name);
                        Gene oldGene = __instance.genes.GetGene(gene);
                        bool xeno = __instance.genes.IsXenogene(oldGene);
                        __instance.genes.RemoveGene(oldGene);
                        __instance.genes.AddGene(DefDatabase<GeneDef>.GetNamed("BattIeBear_BattleReady_Randomizer"), xeno);
                    }
                }
            }
        }
    }
}
