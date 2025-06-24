using System.Xml;
using Verse;

namespace BioSynth_MidasGland
{
    public class GoldColorOptions : PatchOperation
    {
        private PatchOperation Royal;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthMidasGlandSettings.RoyalGold)
            {
                if (Royal != null)
                {
                    return Royal.Apply(xml);
                }
            }

            return true;
        }
    }
    public class SilverColorOptions : PatchOperation
    {
        private PatchOperation Consistent;
        private PatchOperation GraySilver;
        private PatchOperation ChromeSilver;
        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthMidasGlandSettings.ConsistantSilver)
            {
                if (Consistent != null)
                {
                    return Consistent.Apply(xml);
                }
            }
            if (BioSynthMidasGlandSettings.GraySilver)
            {
                if (GraySilver != null)
                {
                    return GraySilver.Apply(xml);
                }
            }
            if (BioSynthMidasGlandSettings.ChromeSilver)
            {
                if (ChromeSilver != null)
                {
                    return ChromeSilver.Apply(xml);
                }
            }

            return true;
        }
    }
}
