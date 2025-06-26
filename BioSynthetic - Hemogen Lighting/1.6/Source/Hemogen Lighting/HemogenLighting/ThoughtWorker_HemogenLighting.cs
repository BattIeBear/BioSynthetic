using RimWorld;
using Verse.AI;
using Verse;

namespace BioSynth_HemogenLighting
{
    class ThoughtWorker_HemogenLighting : ThoughtWorker
    {
        private const float MaxDist = 8f;

        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            if (!ModsConfig.BiotechActive)
            {
                return false;
            }
            if (p.Suspended)
            {
                return false;
            }

            Room pawnRoom = p.GetRoom();

            if (GenClosest.ClosestThingReachable(p.Position, p.Map, ThingRequest.ForDef(ThingDefOf.biosynth_HemogenLamp), PathEndMode.ClosestTouch, TraverseParms.For(p), 8f, delegate (Thing b)
            {
                Room room = b.GetRoom();
                return (room == null || room == pawnRoom) && (b.TryGetComp<CompGlower>()?.Glows ?? false);
            }) == null
            && GenClosest.ClosestThingReachable(p.Position, p.Map, ThingRequest.ForDef(ThingDefOf.biosynth_MacabreHemogenWallLamp), PathEndMode.ClosestTouch, TraverseParms.For(p), 8f, delegate (Thing b)
            {
                Room room = b.GetRoom();
                return (room == null || room == pawnRoom) && (b.TryGetComp<CompGlower>()?.Glows ?? false);
            }) == null
            && GenClosest.ClosestThingReachable(p.Position, p.Map, ThingRequest.ForDef(ThingDefOf.biosynth_HemogenWallLamp), PathEndMode.ClosestTouch, TraverseParms.For(p), 8f, delegate (Thing b)
            {
                Room room = b.GetRoom();
                return (room == null || room == pawnRoom) && (b.TryGetComp<CompGlower>()?.Glows ?? false);
            }) == null)
            {
                return false;
            }
            return ThoughtState.ActiveAtStage(0);
        }
    }
}
