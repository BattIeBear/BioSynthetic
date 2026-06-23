using RimWorld;
using System.Collections.Generic;
using UnityEngine;
using Verse;

namespace BioSynth_VREHussarReimagined
{
    public class BioSynthVREHussarSettingsWindow : Mod
    {
        /// A reference to our settings.
        BioSynthVREHussarSettings settings;

        /// A mandatory constructor which resolves the reference to our settings.
        public BioSynthVREHussarSettingsWindow(ModContentPack content) : base(content)
        {
            this.settings = GetSettings<BioSynthVREHussarSettings>();
        }

        /// The (optional) GUI part to set your settings.
        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            listingStandard.Label("BioSynth_VREHussar_TopWarning".Translate());

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_VREHussar_Label1".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_AllowBattleReady".Translate(), ref BioSynthVREHussarSettings.BattleReady, "BioSynth_VREHussar_AllowBattleReadyDesc".Translate());
            if (BioSynthVREHussarSettings.BattleReady)
            {
                BioSynthVREHussarSettings.NoAptitude = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_MinimizeOverlap".Translate(), ref BioSynthVREHussarSettings.MinimizeOverlap, "BioSynth_VREHussar_MinimizeOverlapDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_NoAptitude".Translate(), ref BioSynthVREHussarSettings.NoAptitude, "BioSynth_VREHussar_NoAptitudeDesc".Translate());
            if (BioSynthVREHussarSettings.NoAptitude)
            {
                BioSynthVREHussarSettings.BattleReady = false;
            }

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_VREHussar_Label2".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_EnableDrawbacks".Translate(), ref BioSynthVREHussarSettings.EnableDrawbacks, "BioSynth_VREHussar_EnableDrawbacksDesc".Translate());
            BioSynthVREHussarSettings.DrawbackChance = Mathf.RoundToInt(listingStandard.SliderLabeled("BioSynth_VREHussar_DrawbackChance".Translate() + BioSynthVREHussarSettings.DrawbackChance + "%", BioSynthVREHussarSettings.DrawbackChance, 1, 100, tooltip: "BioSynth_VREHussar_DrawbackChanceDesc".Translate()));
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_DisablePyromania".Translate(), ref BioSynthVREHussarSettings.DisablePyromania, "BioSynth_VREHussar_DisablePyromaniaDesc".Translate());

            listingStandard.GapLine();

            listingStandard.Label("BioSynth_VREHussar_Label3".Translate());
            if(BioSynthVREHussarSettings.Demon)
            {
                BioSynthVREHussarSettings.UhlanName = BioSynthVREHussarSettings.UhlanNames.BioSynth_VREHussar_Demon;
            }
            else if (BioSynthVREHussarSettings.Devil)
            {
                BioSynthVREHussarSettings.UhlanName = BioSynthVREHussarSettings.UhlanNames.BioSynth_VREHussar_Devil;
            }
            else if (BioSynthVREHussarSettings.Fiend)
            {
                BioSynthVREHussarSettings.UhlanName = BioSynthVREHussarSettings.UhlanNames.BioSynth_VREHussar_Fiend;
            }
            else if (BioSynthVREHussarSettings.Bloodletter)
            {
                BioSynthVREHussarSettings.UhlanName = BioSynthVREHussarSettings.UhlanNames.BioSynth_VREHussar_Bloodletter;
            }
            else if (BioSynthVREHussarSettings.Bloodthirster)
            {
                BioSynthVREHussarSettings.UhlanName = BioSynthVREHussarSettings.UhlanNames.BioSynth_VREHussar_Bloodthirster;
            }
            if (listingStandard.ButtonTextLabeled("BioSynth_VREHussar_UhlanNameOptions".Translate(), BioSynthVREHussarSettings.UhlanName.ToString().Translate(),tooltip: "BioSynth_VREHussar_UhlanNameOptionsDesc".Translate()))
            {
                var options = new List<FloatMenuOption>();

                foreach (BioSynthVREHussarSettings.UhlanNames name in System.Enum.GetValues(typeof(BioSynthVREHussarSettings.UhlanNames)))
                {
                    BioSynthVREHussarSettings.UhlanNames newName = name;

                    options.Add(new FloatMenuOption(newName.ToString().Translate(),
                        () =>
                        {
                            BioSynthVREHussarSettings.Demon = false;
                            BioSynthVREHussarSettings.Devil = false;
                            BioSynthVREHussarSettings.Fiend = false;
                            BioSynthVREHussarSettings.Bloodletter = false;
                            BioSynthVREHussarSettings.Bloodthirster = false;
                            BioSynthVREHussarSettings.UhlanName = newName;
                        }
                        ));
                }

                Find.WindowStack.Add(new FloatMenu(options));
            }
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_OptionalHorns".Translate(), ref BioSynthVREHussarSettings.Horns, "BioSynth_VREHussar_OptionalHornsDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_OptionalRidges".Translate(), ref BioSynthVREHussarSettings.Ridges, "BioSynth_VREHussar_OptionalRidgesDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_OptionalGlidewings".Translate(), ref BioSynthVREHussarSettings.Glidewings, "BioSynth_VREHussar_OptionalGlidewingsDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_OptionalGiant".Translate(), ref BioSynthVREHussarSettings.Giant, "BioSynth_VREHussar_OptionalGiantDesc".Translate());
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_OptionalImpid".Translate(), ref BioSynthVREHussarSettings.Impid, "BioSynth_VREHussar_OptionalImpidDesc".Translate());


            listingStandard.GapLine();

            listingStandard.Label("BioSynth_VREHussar_Label4".Translate());
            BioSynthVREHussarSettings.IncludeOld = Mathf.RoundToInt(listingStandard.SliderLabeled("BioSynth_VREHussar_Include".Translate() + BioSynthVREHussarSettings.IncludeOld + "%", BioSynthVREHussarSettings.IncludeOld, 0, 100, tooltip: "BioSynth_VREHussar_IncludeDesc".Translate()));
            if (BioSynthVREHussarSettings.IncludeOld > 0)
            {
                BioSynthVREHussarSettings.ConvertToNew = false;
            }
            listingStandard.CheckboxLabeled("BioSynth_VREHussar_Convert".Translate(), ref BioSynthVREHussarSettings.ConvertToNew, "BioSynth_VREHussar_ConvertDesc".Translate());
            if (BioSynthVREHussarSettings.ConvertToNew == true)
            {
                BioSynthVREHussarSettings.IncludeOld = 0;
            }

            listingStandard.Gap();

            listingStandard.Label("BioSynth_VREHussar_BottomWarning".Translate());
            listingStandard.End();
            base.DoSettingsWindowContents(inRect);
        }

        /// Override SettingsCategory to show up in the list of settings.
        /// Using .Translate() is optional, but does allow for localization.
        public override string SettingsCategory()
        {
            return "BioSynth_VREHussar_ModName".Translate();
        }
    }
}