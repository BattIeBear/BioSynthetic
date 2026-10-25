using RimWorld;
using Verse;

namespace BioSynth_Diablitech
{
    class CompProperties_AbilityFireSpit : CompProperties_AbilityEffect
    {
        public float range;

        public float lineWidthEnd;

        public ThingDef filthDef;

        public int damAmount = -1;

        public EffecterDef effecterDef;

        public bool canHitFilledCells;

        public CompProperties_AbilityFireSpit()
        {
            compClass = typeof(CompAbilityEffect_FireSpit);
        }
    }
}