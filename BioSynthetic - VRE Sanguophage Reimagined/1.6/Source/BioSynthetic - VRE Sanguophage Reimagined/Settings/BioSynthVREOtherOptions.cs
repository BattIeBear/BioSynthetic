using System.Xml;
using Verse;

namespace BioSynth_VRE_Sanguophage
{
    public class HemogenHungerOptions : PatchOperation
    {
        private PatchOperation show;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.HemogenicHideHediff == false)
            {
                if (show != null)
                {
                    return show.Apply(xml);
                }
            }

            return true;
        }
    }
    public class GeneRegrowthOptions : PatchOperation
    {
        private PatchOperation year;
        private PatchOperation half;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.GenesRegrowOneYear)
            {
                if (year != null)
                {
                    return year.Apply(xml);
                }
            }
            if (BioSynthVRESanguophageSettings.GenesRegrowHalfYear)
            {
                if (half != null)
                {
                    return half.Apply(xml);
                }
            }

            return true;
        }
    }
    public class SanguophageEndotypeOptions : PatchOperation
    {
        private PatchOperation baseliner;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.BaselinerForced)
            {
                if (baseliner != null)
                {
                    return baseliner.Apply(xml);
                }
            }

            return true;
        }
    }
}
