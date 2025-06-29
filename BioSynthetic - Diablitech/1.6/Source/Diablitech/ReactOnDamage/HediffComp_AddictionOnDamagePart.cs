using Verse;

namespace BioSynth_Diablitech
{
    class HediffComp_AddictionOnDamagePart : HediffComp
    {
        public HediffCompProperties_AddictionOnDamagePart Props => (HediffCompProperties_AddictionOnDamagePart)props;

        public override void Notify_PawnPostApplyDamage(DamageInfo dinfo, float totalDamageDealt)
        {
            if (Props.anyDamageToPart == true && BioSynthDiablitechSettings.DevilHeartLuciferiumAddiction)
            {
                Hediff hediff = GetMostRecentHediff();
                if (hediff.Part == parent.Part)
                {
                    if (Rand.Value <= BioSynthDiablitechSettings.LuciferiumAddictionChance)
                    {
                        React();
                    }
                }
            }
        }

        private void React()
        {
            if (Props.createdHigh != null)
            {
                parent.pawn.health.AddHediff(Props.createdHigh);
            }
            if (Props.createdAddiction != null)
            {
                parent.pawn.health.AddHediff(Props.createdAddiction);
            }
        }

        private Hediff GetMostRecentHediff()
        {
            Hediff hediff = null;
            for (int i = 0; i < parent.pawn.health.hediffSet.hediffs.Count; i++)
            {
                if (hediff == null || parent.pawn.health.hediffSet.hediffs[i].ageTicks < hediff.ageTicks)
                {
                    hediff = parent.pawn.health.hediffSet.hediffs[i];
                }
            }

            return hediff;
        }
    }
}
