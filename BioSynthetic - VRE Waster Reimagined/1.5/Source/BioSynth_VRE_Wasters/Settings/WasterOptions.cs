using System.Xml;
using Verse;

namespace BioSynth_VRE_Wasters
{
    public class AddNewHairOptions : PatchOperation
    {
        private PatchOperation AddNewHair;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREWasterSettings.AddNewHairColors)
            {
                if (AddNewHair != null)
                {
                    return AddNewHair.Apply(xml);
                }
            }

            return true;
        }
    }

    public class AddNewSkinOptions : PatchOperation
    {
        private PatchOperation AddNewSkin;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREWasterSettings.AddNewSkinColors)
            {
                if (AddNewSkin != null)
                {
                    return AddNewSkin.Apply(xml);
                }
            }

            return true;
        }
    }

    public class GauntBodyOptions : PatchOperation
    {
        private PatchOperation DisableGaunt;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREWasterSettings.DisableGauntBody)
            {
                if (DisableGaunt != null)
                {
                    return DisableGaunt.Apply(xml);
                }
            }

            return true;
        }
    }

    public class InstabilityOptions : PatchOperation
    {
        private PatchOperation KeepInstability;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREWasterSettings.KeepInstability)
            {
                if (KeepInstability != null)
                {
                    return KeepInstability.Apply(xml);
                }
            }

            return true;
        }
    }
}
