using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace BioSynth_Diablitech
{
    internal class BioSynthDiablitechSettings : ModSettings
    {
        /// Choices for Perfect Body gene graphics
        public static int numOfImplantsBeforePain = 3;
        public static bool DevilHeartLuciferiumAddiction = true;
        public static float LuciferiumAddictionChance = 1f;

        /// The part that writes our settings to file. Note that saving is by ref.
        public override void ExposeData()
        {
            Scribe_Values.Look(ref numOfImplantsBeforePain, "numOfImplantsBeforePain", 3);
            Scribe_Values.Look(ref DevilHeartLuciferiumAddiction, "DevilHeartLuciferiumAddiction");
            Scribe_Values.Look(ref LuciferiumAddictionChance, "LuciferiumAddictionChance", 1f);
            base.ExposeData();
        }
    }
}
