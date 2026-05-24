using System.Xml;
using Verse;

namespace BioSynth_VRE_Sanguophage
{
    public class RemoveEkkimianOptions : PatchOperation
    {
        private PatchOperation soft;
        private PatchOperation non;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.RemoveEkkimianSoft)
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

    public class EkkimianEarOptions : PatchOperation
    {
        private PatchOperation both;
        private PatchOperation neither;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.EkkimianBothBatEars)
            {
                if (both != null)
                {
                    return both.Apply(xml);
                }
            }
            if (BioSynthVRESanguophageSettings.EkkimianRemoveBatEars)
            {
                if (neither != null)
                {
                    return neither.Apply(xml);
                }
            }

            return true;
        }
    }

    public class EkkimianBeardOptions : PatchOperation
    {
        private PatchOperation beardless;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.EkkimianBeardless)
            {
                if (beardless != null)
                {
                    return beardless.Apply(xml);
                }
            }

            return true;
        }
    }

    public class EkkimianBodyOptions : PatchOperation
    {
        private PatchOperation hulk;
        private PatchOperation any;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.EkkimianBodyPlusHulk)
            {
                if (hulk != null)
                {
                    return hulk.Apply(xml);
                }
            }
            if (BioSynthVRESanguophageSettings.EkkimianBodyAny)
            {
                if (any != null)
                {
                    return any.Apply(xml);
                }
            }

            return true;
        }
    }

    public class EkkimianWasterOptions : PatchOperation
    {
        private PatchOperation gaunt;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVRESanguophageSettings.EkkimianGauntBody)
            {
                if (gaunt != null)
                {
                    return gaunt.Apply(xml);
                }
            }

            return true;
        }
    }
}
