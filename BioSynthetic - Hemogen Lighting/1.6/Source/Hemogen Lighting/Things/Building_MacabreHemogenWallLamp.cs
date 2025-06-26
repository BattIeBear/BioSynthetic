using RimWorld;
using Verse;

namespace BioSynth_HemogenLighting
{
    [StaticConstructorOnStartup]
    public class Building_MacabreHemogenWallLamp : Building
    {
        private CompFlickable flickableComp;

        private CompPowerTrader powerTraderComp;

        private Graphic offGraphic;
        public override Graphic Graphic
        {
            get
            {
                if (flickableComp.SwitchIsOn && powerTraderComp.PowerOn)
                {
                    return DefaultGraphic;
                }

                if (offGraphic == null)
                {                                   //Type graphicClass, Texture2D texture, Shader shader, Vector2 drawSize, Color color, Color colorTwo, GraphicData data, List<ShaderParameter> shaderParameters, string maskPath = null
                    offGraphic = GraphicDatabase.Get(def.graphicData.graphicClass, def.graphicData.texPath + "_Off", def.graphicData.shaderType.Shader, def.graphicData.drawSize, DrawColor, DrawColorTwo, def.graphicData, def.graphicData.shaderParameters, def.graphic.maskPath);
                }

                return offGraphic;
            }
        }

        public override void SpawnSetup(Map map, bool respawningAfterLoad)
        {
            base.SpawnSetup(map, respawningAfterLoad);
            flickableComp = GetComp<CompFlickable>();
            powerTraderComp = GetComp<CompPowerTrader>();
        }
        public override void PostMake()
        {
            base.PostMake();
            flickableComp = GetComp<CompFlickable>();
            powerTraderComp = GetComp<CompPowerTrader>();
        }
    }
}
