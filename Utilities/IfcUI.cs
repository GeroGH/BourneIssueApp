using System.IO;
using BourneIssueApp.Classes;
using Tekla.Structures.Model;

namespace BourneIssueApp.Utilities
{
    public static class IfcUI
    {
        public static void ExportIfcModel(string IfcFolderPath, string rev, int number)
        {
            var revNo = (rev == string.Empty) ? string.Empty : " REV " + rev;

            var fileName = Path.Combine(IfcFolderPath, UserInfo.ModelNumber + " PHASE " + number + revNo);

            var componentInput = new ComponentInput();
            componentInput.AddOneInputPosition(new Tekla.Structures.Geometry3d.Point(0, 0, 0));
            var component = new Component(componentInput) { Name = "ExportIFC", Number = BaseComponent.PLUGIN_OBJECT_NUMBER };
            component.SetAttribute("OutputFile", fileName);
            component.SetAttribute("Format", 0);
            component.SetAttribute("ExportType", 1);
            component.SetAttribute("AdditionalPSets", "IfcPropertySetConfigurations_SG");
            component.SetAttribute("CreateAll", 0);
            component.SetAttribute("Assemblies", 1);
            component.SetAttribute("Bolts", 1);
            component.SetAttribute("Welds", 0);
            component.SetAttribute("SurfaceTreatments", 1);
            component.SetAttribute("BaseQuantities", 1);
            component.SetAttribute("GridExport", 1);
            component.SetAttribute("ViewColors", 1);
            component.SetAttribute("LayersNameAsPart", 1);
            component.Insert();
        }
    }
}