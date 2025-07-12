using RimWorld;
using Verse;

namespace BioSynth_VRE_Highmate
{
    public class HediffComp_ChangeGraphic : HediffComp
    {
        public override void CompPostMake()
        {
            if(BioSynthVREHighmateSettings.AestheticShaperUsesPerfectBody == false)
            {
                return;
            }

            Pawn pawn = Pawn;

            if (pawn.IsMutant)
            {
                return;
            }

            if (pawn.story.bodyType == BodyTypeDefOf.Male)
            {
                pawn.story.bodyType = NewBodyTypeDefOf.BattIeBear_PerfectMale;
                pawn.Drawer.renderer.SetAllGraphicsDirty();
            }
            if(pawn.story.bodyType == BodyTypeDefOf.Female)
            {
                pawn.story.bodyType = NewBodyTypeDefOf.BattIeBear_PerfectFemale;
                pawn.Drawer.renderer.SetAllGraphicsDirty();
            }
            if(pawn.story.bodyType == BodyTypeDefOf.Thin)
            {
                pawn.story.bodyType = NewBodyTypeDefOf.BattIeBear_PerfectThin;
                pawn.Drawer.renderer.SetAllGraphicsDirty();
            }
            if(pawn.story.bodyType == BodyTypeDefOf.Hulk)
            {
                pawn.story.bodyType = NewBodyTypeDefOf.BattIeBear_PerfectHulk;
                pawn.Drawer.renderer.SetAllGraphicsDirty();
            }
            if(pawn.story.bodyType == BodyTypeDefOf.Fat)
            {
                pawn.story.bodyType = NewBodyTypeDefOf.BattIeBear_PerfectFat;
                pawn.Drawer.renderer.SetAllGraphicsDirty();
            }
        }

        public override void CompPostPostRemoved()
        {
            Pawn pawn = Pawn;

            if (pawn.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectMale)
            {
                pawn.story.bodyType = BodyTypeDefOf.Male;
                pawn.Drawer.renderer.SetAllGraphicsDirty();
            }
            if (pawn.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectFemale)
            {
                pawn.story.bodyType = BodyTypeDefOf.Female;
                pawn.Drawer.renderer.SetAllGraphicsDirty();
            }
            if (pawn.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectThin)
            {
                pawn.story.bodyType = BodyTypeDefOf.Thin;
                pawn.Drawer.renderer.SetAllGraphicsDirty();
            }
            if (pawn.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectHulk)
            {
                pawn.story.bodyType = BodyTypeDefOf.Hulk;
                pawn.Drawer.renderer.SetAllGraphicsDirty();
            }
            if (pawn.story.bodyType == NewBodyTypeDefOf.BattIeBear_PerfectFat)
            {
                pawn.story.bodyType = BodyTypeDefOf.Fat;
                pawn.Drawer.renderer.SetAllGraphicsDirty();
            }
        }
    }
}