using HarmonyLib;
using RimWorld;
using Verse;

namespace BioSynth_Diablitech
{
    [HarmonyPatch(typeof(Gene_Deathrest), nameof(Gene_Deathrest.Wake))]
    class Gene_Deathrest_Wake_Patch
    {
        public static void Postfix(Gene_Deathrest __instance)
        {
            Pawn p = __instance.pawn;

            if (p == null || p.health == null || p.health.hediffSet == null)
            {
                return;
            }

            p.health.hediffSet.TryGetHediff(HeddifDefOf.biosynth_HemonexusSpine, out Hediff hemonexus_spine);
            if (hemonexus_spine == null)
            {
                return;
            }

            Gene_Hemogen gene_Hemogen = p.genes?.GetFirstGeneOfType<Gene_Hemogen>();
            gene_Hemogen?.SetMax(gene_Hemogen.Max + .25f);
        }
    }
}
