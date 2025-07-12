using System.Xml;
using Verse;

namespace BioSynth_VRE_Highmate
{
    public class CatEarSpriteOptions : PatchOperation
    {
        private PatchOperation VanillaSprite;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHighmateSettings.CatEarsDefaultSprite)
            {
                if (VanillaSprite != null)
                {
                    return VanillaSprite.Apply(xml);
                }
            }

            return true;
        }
    }

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

    public class CatEarGenerationOptions : PatchOperation
    {
        private PatchOperation HalfOnly;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHighmateSettings.HalfCatEars)
            {
                if (HalfOnly != null)
                {
                    return HalfOnly.Apply(xml);
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
