using System.Xml;
using Verse;

namespace BioSynth_VREHussarReimagined
{
    public class UhlanNameOptions : PatchOperation
    {
        private PatchOperation Demon;
        private PatchOperation Devil;
        private PatchOperation Fiend;
        private PatchOperation Bloodletter;
        private PatchOperation Bloodthirster;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHussarSettings.Demon)
            {
                Demon.Apply(xml);
            }
            else if (BioSynthVREHussarSettings.Devil)
            {
                Devil.Apply(xml);
            }
            else if (BioSynthVREHussarSettings.Fiend)
            {
                Fiend.Apply(xml);
            }
            else if (BioSynthVREHussarSettings.Bloodletter)
            {
                Bloodletter.Apply(xml);
            }
            else if (BioSynthVREHussarSettings.Bloodthirster)
            {
                Bloodthirster.Apply(xml);
            }
            return true;
        }
    }
    public class UhlanHornOptions : PatchOperation
    {
        private PatchOperation Horns;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHussarSettings.Horns)
            {
                Horns.Apply(xml);
            }
            return true;
        }
    }
}