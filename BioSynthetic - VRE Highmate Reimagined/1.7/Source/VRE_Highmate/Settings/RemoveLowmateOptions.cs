using System.Xml;
using Verse;

namespace BioSynth_VRE_Highmate
{
    public class RemoveLowmateOptions : PatchOperation
    {
        private PatchOperation Soft;
        private PatchOperation Full;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHighmateSettings.FullRemoveLowmate)
            {
                if (Full != null)
                {
                    return Full.Apply(xml);
                }
            }
            else if (BioSynthVREHighmateSettings.SoftRemoveLowmate)
            {
                if (Soft != null)
                {
                    return Soft.Apply(xml);
                }
            }

            return true;
        }
    }
}