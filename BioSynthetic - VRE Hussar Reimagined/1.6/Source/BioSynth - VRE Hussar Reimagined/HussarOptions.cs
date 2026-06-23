using System.Xml;
using Verse;

namespace BioSynth_VREHussarReimagined
{
    public class AllowBattleReady : PatchOperation
    {
        private PatchOperation BattleReady;
        private PatchOperation NoAptitude;
        
        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHussarSettings.BattleReady)
            {
                BattleReady.Apply(xml);
            }
            if (BioSynthVREHussarSettings.NoAptitude)
            {
                NoAptitude.Apply(xml);
            }
            return true;
        }
    }
    public class UhlanNameOptions : PatchOperation
    {
        private PatchOperation Demon;
        private PatchOperation Devil;
        private PatchOperation Fiend;
        private PatchOperation Bloodletter;
        private PatchOperation Bloodthirster;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            switch(BioSynthVREHussarSettings.UhlanName)
            {
                case BioSynthVREHussarSettings.UhlanNames.BioSynth_VREHussar_Uhlan:
                    break;
                case BioSynthVREHussarSettings.UhlanNames.BioSynth_VREHussar_Demon:
                    Demon.Apply(xml);
                    break;
                case BioSynthVREHussarSettings.UhlanNames.BioSynth_VREHussar_Devil:
                    Devil.Apply(xml);
                    break;
                case BioSynthVREHussarSettings.UhlanNames.BioSynth_VREHussar_Fiend:
                    Fiend.Apply(xml);
                    break;
                case BioSynthVREHussarSettings.UhlanNames.BioSynth_VREHussar_Bloodletter:
                    Bloodletter.Apply(xml);
                    break;
                case BioSynthVREHussarSettings.UhlanNames.BioSynth_VREHussar_Bloodthirster:
                    Bloodthirster.Apply(xml);
                    break;
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
    public class UhlanRidgeOptions : PatchOperation
    {
        private PatchOperation Ridges;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHussarSettings.Ridges)
            {
                Ridges.Apply(xml);
            }
            return true;
        }
    }
    public class UhlanGlidewingsOptions : PatchOperation
    {
        private PatchOperation Remove;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHussarSettings.Glidewings == false)
            {
                Remove.Apply(xml);
            }
            return true;
        }
    }
    public class UhlanGiantOptions : PatchOperation
    {
        private PatchOperation Remove;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHussarSettings.Giant == false)
            {
                Remove.Apply(xml);
            }
            return true;
        }
    }
    public class UhlanImpidOptions : PatchOperation
    {
        private PatchOperation Impid;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            if (BioSynthVREHussarSettings.Impid)
            {
                Impid.Apply(xml);
            }
            return true;
        }
    }
}