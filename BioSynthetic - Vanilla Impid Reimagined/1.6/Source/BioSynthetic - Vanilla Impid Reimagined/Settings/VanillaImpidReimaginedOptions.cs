using System.Xml;
using Verse;


namespace BioSynth_VanillaImpidReimagined
{
    public class AddNewHairOptions : PatchOperation
    {
        private PatchOperation hair;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVanillaImpidReimaginedSettings.NakedSpeedOptions)
            {
                if (hair != null)
                {
                    return hair.Apply(xml);
                }
            }

            return true;
        }
    }
    public class AddNewSkinOptions : PatchOperation
    {
        private PatchOperation both;
        private PatchOperation yellow;
        private PatchOperation red;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVanillaImpidReimaginedSettings.AddNewSkinOptionsYellow && BioSynthVanillaImpidReimaginedSettings.AddNewSkinOptionsRed)
            {
                if (both != null)
                {
                    return both.Apply(xml);
                }
            }
            else if (BioSynthVanillaImpidReimaginedSettings.AddNewSkinOptionsYellow)
            {
                if (yellow != null)
                {
                    return yellow.Apply(xml);
                }
            }
            else if (BioSynthVanillaImpidReimaginedSettings.AddNewSkinOptionsRed)
            {
                if (red != null)
                {
                    return red.Apply(xml);
                }
            }

            return true;
        }
    }
    public class AddBodyOptions : PatchOperation
    {
        private PatchOperation body;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVanillaImpidReimaginedSettings.AddBodyOptions)
            {
                if (body != null)
                {
                    return body.Apply(xml);
                }
            }

            return true;
        }
    }
    public class UseNewGenes : PatchOperation
    {
        private PatchOperation update;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVanillaImpidReimaginedSettings.UseNewGenes)
            {
                if (update != null)
                {
                    return update.Apply(xml);
                }
            }

            return true;
        }
    }
    public class NakedSpeedOptions : PatchOperation
    {
        private PatchOperation use;
        private PatchOperation nonuse;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVanillaImpidReimaginedSettings.NakedSpeedOptions)
            {
                if (use != null)
                {
                    return use.Apply(xml);
                }
            }
            else if (nonuse != null)
            {
                return nonuse.Apply(xml);
            }

            return true;
        }
    }
    public class ModifyFaction : PatchOperation
    {
        private PatchOperation use;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVanillaImpidReimaginedSettings.ModifyFaction)
            {
                if (use != null)
                {
                    return use.Apply(xml);
                }
            }

            return true;
        }
    }
}
