using RimWorld;
using System.Collections.Generic;
using System.Linq;
using Verse;

namespace BioSynth_VREHussarReimagined
{
    public class Gene_BattleReadyRandomizer : Gene
    {

        public static List<GeneDef> genes = new List<GeneDef>();

        public void GenerateGenes()
        {
            genes = DefDatabase<GeneDef>.AllDefs.Where((GeneDef x) => x.defName.Contains("BattleReady") && x.defName != this.def.defName).ToList();
            GeneDef toughnessGene = DefDatabase<GeneDef>.GetNamed("VREH_Toughness", false);
            if (toughnessGene != null)
            {
                genes.Add(toughnessGene);
            }
        }
        public override void PostAdd()
        {
            if (genes.Count == 0)
            {
                GenerateGenes();
            }

            base.PostAdd();

            if (Rand.Range(1, 100) > BioSynthVREHussarSettings.IncludeOld)
            {
                pawn.genes.AddGene(ValidateAndRandomize(), pawn.genes.IsXenogene(this));
                if (BioSynthVREHussarSettings.EnableDrawbacks && Rand.Range(0, 100) < BioSynthVREHussarSettings.DrawbackChance)
                {
                    pawn.genes.AddGene(ValidateAndRandomizeDrawback(), pawn.genes.IsXenogene(this));
                }
                pawn.genes.RemoveGene(this);
            }
            else if (BioSynthVREHussarSettings.ConvertToNew == false)
            {
                pawn.genes.AddGene(DefDatabase<GeneDef>.GetNamed("VREHT_WeaponAptitude_Randomizer", false), pawn.genes.IsXenogene(this));
                pawn.genes.RemoveGene(this);
            }
        }

        public GeneDef ValidateAndRandomize()
        {
            List<GeneDef> validatedGenes = new List<GeneDef>();
            List<TraitDef> traits = pawn.story.traits.allTraits.Select((Trait x) => x.def).ToList();

            foreach (GeneDef gene in genes)
            {
                if (gene.forcedTraits == null)
                {
                    validatedGenes.Add(gene);
                }
                else
                {
                    bool valid = true;
                    for (int i = 0; i < gene.forcedTraits.Count; i++)
                    {
                        if (traits.Contains(gene.forcedTraits[i].def))
                        {
                            valid = false;
                            break;
                        }

                        if (BioSynthVREHussarSettings.MinimizeOverlap)
                        {
                            if (gene.forcedTraits[i].def.defName == "Brawler" || gene.forcedTraits[i].def.defName == "ShootingAccuracy")
                            {
                                foreach (TraitDef trait in traits)
                                {
                                    if (trait.defName == "Brawler" || trait.defName == "ShootingAccuracy")
                                    {
                                        valid = false;
                                        break;
                                    }
                                }
                            }

                            if (!valid)
                            {
                                break;
                            }
                        }
                    }

                    if (valid)
                    {
                        validatedGenes.Add(gene);
                    }
                }
            }

            return validatedGenes.RandomElement();
        }

        public GeneDef ValidateAndRandomizeDrawback()
        {
            List<GeneDef> genes = DefDatabase<GeneDef>.AllDefs.Where((GeneDef x) => x.defName.Contains("BattleDrawback")).ToList();
            List<GeneDef> validatedGenes = new List<GeneDef>();
            List<TraitDef> traits = pawn.story.traits.allTraits.Select((Trait x) => x.def).ToList();

            if (BioSynthVREHussarSettings.DisablePyromania)
            {
                genes.Remove(DefDatabase<GeneDef>.GetNamed("BattIeBear_BattleDrawback_Pyromaniac", false));
            }

            foreach (GeneDef gene in genes)
            {
                if (gene.forcedTraits != null)
                {
                    bool valid = true;
                    for (int i = 0; i < gene.forcedTraits.Count; i++)
                    {
                        if (traits.Contains(gene.forcedTraits[i].def))
                        {
                            valid = false;
                            break;
                        }
                    }

                    if (valid)
                    {
                        validatedGenes.Add(gene);
                    }
                }
            }

            return validatedGenes.RandomElement();
        }
    }
}
