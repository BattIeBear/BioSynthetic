using System.Xml;
using Verse;

namespace BioSynth_VRE_Sanguophage
{
    public class RemoveStrigoiOptions : PatchOperation
    {
        private PatchOperation soft;
        private PatchOperation non;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.RemoveStrigoiSoft)
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

    public class StrigoiEarOptions : PatchOperation
    {
        private PatchOperation both;
        private PatchOperation neither;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.StrigoiBothBatEars)
            {
                if (both != null)
                {
                    return both.Apply(xml);
                }
            }
            if (BioSynthVRESanguophageSettings.StrigoiRemoveBatEars)
            {
                if (neither != null)
                {
                    return neither.Apply(xml);
                }
            }

            return true;
        }
    }

    public class StrigoiBeardOptions : PatchOperation
    {
        private PatchOperation beardless;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.StrigoiBeardless)
            {
                if (beardless != null)
                {
                    return beardless.Apply(xml);
                }
            }

            return true;
        }
    }

    public class StrigoiNoseOptions : PatchOperation
    {
        private PatchOperation non;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.StrigoiRemoveBatNose)
            {
                if (non != null)
                {
                    return non.Apply(xml);
                }
            }

            return true;
        }
    }

    public class StrigoiHairOptions : PatchOperation
    {
        private PatchOperation non;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.StrigoiRemoveHair)
            {
                if (non != null)
                {
                    return non.Apply(xml);
                }
            }

            return true;
        }
    }

    public class StrigoiBodyOptions : PatchOperation
    {
        private PatchOperation non_skinny;
        private PatchOperation large;
        private PatchOperation hulk;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.StrigoiBodyNonSkinny)
            {
                if (non_skinny != null)
                {
                    return non_skinny.Apply(xml);
                }
            }
            if (BioSynthVRESanguophageSettings.StrigoiBodyLarge)
            {
                if (large != null)
                {
                    return large.Apply(xml);
                }
            }
            if (BioSynthVRESanguophageSettings.StrigoiBodyHulk)
            {
                if (hulk != null)
                {
                    return hulk.Apply(xml);
                }
            }

            return true;
        }
    }
}