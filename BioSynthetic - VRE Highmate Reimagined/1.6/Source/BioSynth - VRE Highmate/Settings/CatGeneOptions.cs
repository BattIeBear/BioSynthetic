using System.Xml;
using Verse;

namespace BioSynth_VRE_Highmate
{
    //public class CatEarSpriteOptions : PatchOperation
    //{
    //    private PatchOperation VanillaSprite;

    //    protected override bool ApplyWorker(XmlDocument xml)
    //    {
    //        if (BioSynthVREHighmateSettings.CatEarsDefaultSprite)
    //        {
    //            if (VanillaSprite != null)
    //            {
    //                return VanillaSprite.Apply(xml);
    //            }
    //        }

    //        return true;
    //    }
    //}

    public class CatEarColorOptions : PatchOperation
    {
        private PatchOperation HairColor;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHighmateSettings.CatEarsHairColor)
            {
                if (HairColor != null)
                {
                    return HairColor.Apply(xml);
                }
            }

            return true;
        }
    }

    public class FelineEarColorOptions : PatchOperation
    {
        private PatchOperation HairColor;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHighmateSettings.FelineEarsHairColor)
            {
                if (HairColor != null)
                {
                    return HairColor.Apply(xml);
                }
            }

            return true;
        }
    }

    public class CatEarGenerationOptions : PatchOperation
    {
        private PatchOperation FelineHuman;
        private PatchOperation CatHuman;
        private PatchOperation CatFeline;
        private PatchOperation CatFelineHuman;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHighmateSettings.FelineHumanEars)
            {
                if (FelineHuman != null)
                {
                    return FelineHuman.Apply(xml);
                }
            }
            else if (BioSynthVREHighmateSettings.CatHumanEars)
            {
                if (CatHuman != null)
                {
                    return CatHuman.Apply(xml);
                }
            }
            else if (BioSynthVREHighmateSettings.CatFelineEars)
            {
                if (CatFeline != null)
                {
                    return CatFeline.Apply(xml);
                }
            }
            else if (BioSynthVREHighmateSettings.CatFelineHumanEars)
            {
                if (CatFelineHuman != null)
                {
                    return CatFelineHuman.Apply(xml);
                }
            }

            return true;
        }
    }

    public class CatTailGenerationOptions : PatchOperation
    {
        private PatchOperation HalfOnly;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHighmateSettings.HalfCatTails)
            {
                if (HalfOnly != null)
                {
                    return HalfOnly.Apply(xml);
                }
            }

            return true;
        }
    }
}
