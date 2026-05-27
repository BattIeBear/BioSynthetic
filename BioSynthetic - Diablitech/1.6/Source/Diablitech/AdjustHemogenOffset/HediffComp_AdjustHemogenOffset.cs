using RimWorld;
using Verse;

namespace BioSynth_Diablitech
{
    internal class HediffComp_AdjustHemogenOffset : HediffComp
    {
        public override void CompPostMake()
        {
            Pawn pawn = Pawn;
            
            Gene_Hemogen gene_Hemogen = pawn.genes?.GetFirstGeneOfType<Gene_Hemogen>();
            gene_Hemogen?.SetMax(gene_Hemogen.Max + .25f);
        }

        public override void CompPostPostRemoved()
        {
            Pawn pawn = Pawn;

            Gene_Hemogen gene_Hemogen = pawn.genes?.GetFirstGeneOfType<Gene_Hemogen>();
            gene_Hemogen?.SetMax(gene_Hemogen.Max - .25f);
        }
    }
}