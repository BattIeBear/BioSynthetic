using Verse;

namespace BioSynth_Diablitech
{
    class HediffCompProperties_AddictionOnDamagePart : HediffCompProperties
    {
        public bool anyDamageToPart;

        public HediffDef createdHigh;

        public HediffDef createdAddiction;

        public HediffCompProperties_AddictionOnDamagePart()
        {
            compClass = typeof(HediffComp_AddictionOnDamagePart);
        }
    }
}
