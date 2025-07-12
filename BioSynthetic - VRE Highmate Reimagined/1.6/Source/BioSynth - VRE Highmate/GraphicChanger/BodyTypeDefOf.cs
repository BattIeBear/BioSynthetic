using RimWorld;

namespace BioSynth_VRE_Highmate
{
    [DefOf]
    public static class NewBodyTypeDefOf
    {
        public static BodyTypeDef BattIeBear_PerfectMale;

        public static BodyTypeDef BattIeBear_PerfectFemale;

        public static BodyTypeDef BattIeBear_PerfectThin;

        public static BodyTypeDef BattIeBear_PerfectHulk;

        public static BodyTypeDef BattIeBear_PerfectFat;

        static NewBodyTypeDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(BodyTypeDefOf));
        }
    }
}
