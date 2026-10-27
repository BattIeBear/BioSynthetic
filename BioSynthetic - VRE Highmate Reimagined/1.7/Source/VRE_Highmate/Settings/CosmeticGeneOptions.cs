using System.Xml;
using Verse;

namespace BioSynth_VRE_Highmate
{
    public class ExtraHairColorOptions : PatchOperation
    {
        private PatchOperation ExtraHairColor;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHighmateSettings.AllowExtraHairColors)
            {
                if (ExtraHairColor != null)
                {
                    return ExtraHairColor.Apply(xml);
                }
            }

            return true;
        }
    }

    public class ExtraSkinColorOptions : PatchOperation
    {
        private PatchOperation ExtraSkinColor;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHighmateSettings.AllowExtraSkinColors)
            {
                if (ExtraSkinColor != null)
                {
                    return ExtraSkinColor.Apply(xml);
                }
            }

            return true;
        }
    }

    public class CustomSkinColorOptions : PatchOperation
    {
        private PatchOperation CustomSkinColor;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHighmateSettings.AllowCustomSkinColors)
            {
                if (CustomSkinColor != null)
                {
                    return CustomSkinColor.Apply(xml);
                }
            }

            return true;
        }
    }

    public class RewriteThoughtsOptions : PatchOperation
    {
        private PatchOperation RewriteThoughts;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHighmateSettings.AllowCustomSkinColors)
            {
                if (RewriteThoughts != null)
                {
                    return RewriteThoughts.Apply(xml);
                }
            }

            return true;
        }
    }

    public class RemoveHairOptions : PatchOperation
    {
        private PatchOperation RemoveHair;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHighmateSettings.AllowCustomSkinColors)
            {
                if (RemoveHair != null)
                {
                    return RemoveHair.Apply(xml);
                }
            }

            return true;
        }
    }
}
