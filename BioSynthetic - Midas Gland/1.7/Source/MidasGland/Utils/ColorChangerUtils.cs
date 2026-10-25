using UnityEngine;

namespace BioSynth_MidasGland
{
    public static class ColorChangerUtils
    {
        public static string GetGoldColor
        {
            get
            {
                if (BioSynthMidasGlandSettings.RoyalGold || BioSynthMidasGlandSettings.RoyalGoldGlandOnly)
                {
                    return "DBB40C";
                }
                return "FFEB7A";
            }
        }
        public static string GetSilverColor
        {
            get
            {
                if (BioSynthMidasGlandSettings.GraySilver || BioSynthMidasGlandSettings.GraySilverGlandOnly)
                {
                    return "737373";
                }
                if (BioSynthMidasGlandSettings.ChromeSilver || BioSynthMidasGlandSettings.ChromeSilverGlandOnly)
                {
                    return "E3E7F0";
                }
                return "B4AD96";
            }
        }

        public static Color ConvertToHair(Color input)
        {
            Color.RGBToHSV(input, out float inputH, out float inputS, out float inputV);
            Color output = Color.HSVToRGB(inputH, Mathf.Min(inputS * 1.175f, 1.0f), Mathf.Max(inputV - 0.175f, 0.0f));

            return output;
        }
    }
}