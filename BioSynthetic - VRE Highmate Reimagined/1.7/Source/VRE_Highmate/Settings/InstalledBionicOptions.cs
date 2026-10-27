using System.Xml;
using Verse;

namespace BioSynth_VRE_Highmate
{
    public class AestheticShaperPerfectBodyOptions : PatchOperation
    {
        private PatchOperation Uses;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHighmateSettings.AestheticShaperUsesPerfectBody)
            {
                if (Uses != null)
                {
                    return Uses.Apply(xml);
                }
            }

            return true;
        }
    }
}
