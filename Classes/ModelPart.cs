using Tekla.Structures.Model;

namespace BourneIssueApp.Classes
{
    public class ModelPart
    {
        public Part Part { get; set; }
        public int PhaseNumber { get; set; }
        public bool IsSteel { get; set; }
        public bool IsPlate { get; set; }
        public bool IsProfile { get; set; }

        public ModelPart(Part part)
        {
            var phaseNumber = 0;
            part.GetReportProperty("PHASE", ref phaseNumber);

            var materialType = string.Empty;
            part.GetReportProperty("MATERIAL_TYPE", ref materialType);

            var profileType = string.Empty;
            part.GetReportProperty("PROFILE_TYPE", ref profileType);

            this.Part = part;
            this.PhaseNumber = phaseNumber;

            if (materialType == "STEEL")
            {
                this.IsSteel = true;
            }

            if (this.IsSteel && profileType == "B")
            {
                this.IsPlate = true;
            }

            if (this.IsSteel && profileType != "B")
            {
                this.IsProfile = true;
            }
        }
    }
}