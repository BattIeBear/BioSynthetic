using System.Xml;
using Verse;

namespace BioSynth_VRE_Highmate
{
    public class AdditionalGeneOptions : PatchOperation
    {
        private PatchOperation UseAdditionalGenes;
        private PatchOperation UseDefaultGenes;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHighmateSettings.HighmateUsesAdditionalGenes)
            {
                if (UseAdditionalGenes != null)
                {
                    return UseAdditionalGenes.Apply(xml);
                }
            }
            else if (UseDefaultGenes != null)
            {
                return UseDefaultGenes.Apply(xml);
            }

            return true;
        }
    }

    public class LovinDependencyBisexualOptions : PatchOperation
    {
        private PatchOperation Bisexual;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHighmateSettings.LovinDependencyMakesBisexual)
            {
                if (Bisexual != null)
                {
                    return Bisexual.Apply(xml);
                }
            }

            return true;
        }
    }

    public class LovinDeficiencyDoesNotTriggerGiveUpOptions : PatchOperation
    {
        private PatchOperation HideAway;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHighmateSettings.LovinDeficiencyDoesNotTriggerGiveUp)
            {
                if (HideAway != null)
                {
                    return HideAway.Apply(xml);
                }
            }

            return true;
        }
    }
}
