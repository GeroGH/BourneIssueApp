using System.Collections.Generic;
using System.IO;
using Tekla.Structures.Model;

namespace BourneIssueApp.Classes
{
    public class Phase
    {
        public int Number { get; set; }
        public string Fabricator { get; set; }
        public bool HasPlates { get; set; }
        public bool HasProfiles { get; set; }
        public List<Part> Profiles { get; set; }
        public List<Part> Plates { get; set; }
        public List<Part> Parts { get; set; }
        public string PhaseFolder { get; set; }
        public string GasFolder { get; set; }
        public string AssembliesFolder { get; set; }
        public string PlatesFolder { get; set; }
        public string ProfilesFolder { get; set; }
        public string ReportsFolder { get; set; }
        public string NcPlatesFolder { get; set; }
        public string NcProfilesFolder { get; set; }
        public string IfcFolder { get; set; }
        public string BswxFolder { get; set; }
        public string TempNcFilesFolder { get; set; }
        public string TempPdfFilesFolder { get; set; }

        public Phase(int phaseNumber)
        {
            this.Number = phaseNumber;

            this.HasPlates = false;
            this.HasProfiles = false;

            this.Profiles = new List<Part>();
            this.Plates = new List<Part>();
            this.Parts = new List<Part>();

            this.PhaseFolder = Path.Combine(UserInfo.MainFolder, "PHASE" + " " + this.Number + " Fabricator");
            this.GasFolder = Path.Combine(this.PhaseFolder, "01 GA DRG'S");
            this.AssembliesFolder = Path.Combine(this.PhaseFolder, "02 ASSEMBLY DRG'S");
            this.PlatesFolder = Path.Combine(this.PhaseFolder, "03 PLATES FITTINGS DRG'S");
            this.ProfilesFolder = Path.Combine(this.PhaseFolder, "04 PROFILES FITTINGS DRG'S");
            this.ReportsFolder = Path.Combine(this.PhaseFolder, "05 LISTS");
            this.NcPlatesFolder = Path.Combine(this.PhaseFolder, "06 PLATES NC FILES");
            this.NcProfilesFolder = Path.Combine(this.PhaseFolder, "07 PROFILES NC FILES");
            this.IfcFolder = Path.Combine(this.PhaseFolder, "08 BIM FILES");
            this.BswxFolder = Path.Combine(this.PhaseFolder, "09 BSWX FILES");
            this.TempNcFilesFolder = Path.Combine(this.PhaseFolder, this.BswxFolder, "01 NC'S FILES (Temp Folder, Do Not Use)");
            this.TempPdfFilesFolder = Path.Combine(this.PhaseFolder, this.BswxFolder, "02 PDF'S FILES (Temp Folder, Do Not Use)");
        }
    }
}