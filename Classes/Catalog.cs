using System.Collections.Generic;
using System.Data;
using System.Linq;
using Tekla.Structures.Model;
using ModelObjectSelector = Tekla.Structures.Model.UI.ModelObjectSelector;

namespace BourneIssueApp.Classes
{
    public static class Catalog
    {
        private static List<ModelPart> ModelParts { get; set; }
        public static List<Phase> Phases { get; set; }
        public static List<Part> Parts { get; set; }

        static Catalog()
        {
            ModelParts = new List<ModelPart>();
            Phases = new List<Phase>();
            Parts = new List<Part>();
        }

        public static void CollectPartsFromTheModel()
        {
            ModelObjectEnumerator.AutoFetch = true;
            var mos = new ModelObjectSelector();
            var moe = mos.GetSelectedObjects();
            while (moe.MoveNext())
            {
                var part = moe.Current as Part;
                if (part == null)
                {
                    continue;
                }

                var modelPart = new ModelPart(part);
                ModelParts.Add(modelPart);
                Parts.Add(part);
            }
        }

        public static void SplitPartsIntoPhases()
        {
            var phaseNumbers = ModelParts.Select(x => x.PhaseNumber).Distinct().OrderBy(x => x).ToList();

            foreach (var phaseNumber in phaseNumbers)
            {
                var phase = new Phase(phaseNumber);

                foreach (var modelPart in ModelParts)
                {
                    if (modelPart.PhaseNumber == phaseNumber)
                    {
                        if (modelPart.IsSteel)
                        {
                            phase.Parts.Add(modelPart.Part);
                        }

                        if (modelPart.IsPlate)
                        {
                            phase.Plates.Add(modelPart.Part);
                            phase.HasPlates = true;
                        }

                        if (modelPart.IsProfile)
                        {
                            phase.Profiles.Add(modelPart.Part);
                            phase.HasProfiles = true;
                        }
                    }
                }

                Phases.Add(phase);
            }
        }
    }
}