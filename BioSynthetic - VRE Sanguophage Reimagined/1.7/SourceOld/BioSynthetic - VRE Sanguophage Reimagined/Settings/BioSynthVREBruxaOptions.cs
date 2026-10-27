using System.Xml;
using Verse;

namespace BioSynth_VRE_Sanguophage
{
    public class RemoveBruxaOptions : PatchOperation
    {
        private PatchOperation soft;
        private PatchOperation non;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.RemoveBruxaSoft)
            {
                if (soft != null)
                {
                    return soft.Apply(xml);
                }
            }
            else
            {
                if (non != null)
                {
                    return non.Apply(xml);
                }
            }

            return true;
        }
    }

    public class BruxaBodyOptions : PatchOperation
    {
        private PatchOperation standard;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.BruxaBodyStandard)
            {
                if (standard != null)
                {
                    return standard.Apply(xml);
                }
            }

            return true;
        }
    }

    public class BruxaHairOptions : PatchOperation
    {
        private PatchOperation non;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.BruxaRemoveHair)
            {
                if (non != null)
                {
                    return non.Apply(xml);
                }
            }

            return true;
        }
    }

    public class BruxaPerfectOptions : PatchOperation
    {
        private PatchOperation perfect;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.BruxaPerfectBody)
            {
                if (perfect != null)
                {
                    return perfect.Apply(xml);
                }
            }

            return true;
        }
    }
}