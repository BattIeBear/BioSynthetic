using System.Xml;
using Verse;

namespace BioSynth_HemogenLighting
{
    public class MemeOptions : PatchOperation
    {
        private PatchOperation Meme;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthHemogenLightingSettings.RequiresBloodfeedingMeme)
            {
                if (Meme != null)
                {
                    return Meme.Apply(xml);
                }
            }

            return true;
        }
    }
    public class ResearchOptions : PatchOperation
    {
        private PatchOperation Research;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthHemogenLightingSettings.RequiresAdvancedLightsResearch)
            {
                if (Research != null)
                {
                    return Research.Apply(xml);
                }
            }

            return true;
        }
    }
}
