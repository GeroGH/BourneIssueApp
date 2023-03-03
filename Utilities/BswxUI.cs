using System.IO;
using BourneIssueApp.Classes;
using Tekla.Structures.Model;

namespace BourneIssueApp.Utilities
{
    public static class BswxUI
    {
        public static void SaveBswxSettings(string rev, string tempNcFolder, string tempPdfFolder, int number)
        {
            var revNo = (rev == string.Empty) ? string.Empty : " REV " + rev;
            var fileName = UserInfo.TempBswxExportFolder + @"\" + UserInfo.ModelNumber + " PHASE " + number + revNo;

            TextWriter swFirst = new StreamWriter(UserInfo.ModelFolder + @"\attributes\" + UserInfo.Initials + " Export BIM Phase " + number + ".BIMReview.ExportPluginForm.xml");
            swFirst.WriteLine(@"<?xml version=""1.0"" encoding=""utf-8""?>");
            swFirst.WriteLine(@"<config>");
            swFirst.WriteLine(@"  <output_file_path>" + fileName + @".bswx</output_file_path>");
            swFirst.WriteLine(@"  <export_cam_files>1</export_cam_files>");
            swFirst.WriteLine(@"  <cam_file_folder>" + tempNcFolder + @"</cam_file_folder>");
            swFirst.WriteLine(@"  <export_gantt_charts>0</export_gantt_charts>");
            swFirst.WriteLine(@"  <plates_us_style>0</plates_us_style>");
            swFirst.WriteLine(@"  <plate_prefixes></plate_prefixes>");
            swFirst.WriteLine(@"  <new_prefix></new_prefix>");
            swFirst.WriteLine(@"  <split_bolts>0</split_bolts>");
            swFirst.WriteLine(@"  <replacement_char>0</replacement_char>");
            swFirst.WriteLine(@"  <invalid_chars>0</invalid_chars>");
            swFirst.WriteLine(@"  <exclude_cuts>1</exclude_cuts>");
            swFirst.WriteLine(@"  <exclude_welds>1</exclude_welds>");
            swFirst.WriteLine(@"  <exclude_holes>1</exclude_holes>");
            swFirst.WriteLine(@"  <exclude_bolts>1</exclude_bolts>");
            swFirst.WriteLine(@"  <complete_assemblies>1</complete_assemblies>");
            swFirst.WriteLine(@"  <selected_parts_only>1</selected_parts_only>");
            swFirst.WriteLine(@"  <drawing_file_folder>" + tempPdfFolder + @"</drawing_file_folder>");
            swFirst.WriteLine(@"  <include_gas>0</include_gas>");
            swFirst.WriteLine(@"  <export_drawings>1</export_drawings>");
            swFirst.WriteLine(@"  <include_multi>0</include_multi>");
            swFirst.WriteLine(@"  <drawing_extension>1</drawing_extension>");
            swFirst.WriteLine(@"  <obj_in_assem>0</obj_in_assem>");
            swFirst.WriteLine(@"  <merge_girder>0</merge_girder>");
            swFirst.WriteLine(@"  <modified_weight>1</modified_weight>");
            swFirst.WriteLine(@"</config>");
            swFirst.Close();
        }

        public static void CreateTempBswxFolders(string tempNcFolder, string tempPdfFolder)
        {
            SystemIO.CreateFolder(tempNcFolder);
            SystemIO.CreateFolder(tempPdfFolder);
        }

        public static void CopyTempNcFiles(string tempNcFolder, string ncPlateFolder, string ncProfileFolder)
        {
            SystemIO.CopyFiles(ncPlateFolder, tempNcFolder);
            SystemIO.CopyFiles(ncProfileFolder, tempNcFolder);
        }

        public static void CopyTempPdfFiles(string tempPdfFolder, string plateFolder, string profileFolder, string assemblyFolder)
        {
            SystemIO.CopyFiles(plateFolder, tempPdfFolder);
            SystemIO.CopyFiles(profileFolder, tempPdfFolder);
            SystemIO.CopyFiles(assemblyFolder, tempPdfFolder);
        }

        public static void ExportBswxFile(string rev, string tempNcFolder, string tempPdfFolder, int number)
        {
            var revNo = (rev == string.Empty) ? string.Empty : " REV " + rev;
            var fileName = UserInfo.TempBswxExportFolder + @"\" + UserInfo.ModelNumber + " PHASE " + number + revNo + @".bswx";

            var componentInput = new ComponentInput();
            componentInput.AddOneInputPosition(new Tekla.Structures.Geometry3d.Point(0, 0, 0));
            var component = new Component(componentInput) { Name = "BIMREVIEW Export", Number = BaseComponent.PLUGIN_OBJECT_NUMBER };
            component.SetAttribute("output_file_path", fileName);
            component.SetAttribute("export_cam_files", 1);
            component.SetAttribute("cam_file_folder", tempNcFolder);
            component.SetAttribute("export_gantt_charts", 0);
            component.SetAttribute("plates_us_style", 0);
            component.SetAttribute("plate_prefixes", "");
            component.SetAttribute("new_prefix", "");
            component.SetAttribute("split_bolts", 0);
            component.SetAttribute("replacement_char", 0);
            component.SetAttribute("invalid_chars", 0);
            component.SetAttribute("exclude_cuts", 1);
            component.SetAttribute("exclude_welds", 1);
            component.SetAttribute("exclude_holes", 1);
            component.SetAttribute("exclude_bolts", 1);
            component.SetAttribute("complete_assemblies", 1);
            component.SetAttribute("selected_parts_only", 1);
            component.SetAttribute("drawing_file_folder", tempPdfFolder);
            component.SetAttribute("include_gas", 0);
            component.SetAttribute("export_drawings", 1);
            component.SetAttribute("include_multi", 0);
            component.SetAttribute("drawing_extension", 1);
            component.SetAttribute("obj_in_assem", 0);
            component.SetAttribute("merge_girder", 0);
            component.SetAttribute("modified_weight", 1);
            component.Insert();
        }

        public static void CopyBswxFile(string rev, string bswxFolder, int number)
        {
            var revNo = (rev == string.Empty) ? string.Empty : " REV " + rev;

            var oldBswx = UserInfo.TempBswxExportFolder + @"\" + UserInfo.ModelNumber + " PHASE " + number + revNo + @".bswx";
            var newBswx = bswxFolder + @"\" + UserInfo.ModelNumber + " PHASE " + number + revNo + @".bswx";

            var oldLog = UserInfo.TempBswxExportFolder + @"\" + UserInfo.ModelNumber + " PHASE " + number + revNo + @"_Log.txt";
            var newLog = bswxFolder + @"\" + UserInfo.ModelNumber + " PHASE " + number + revNo + @"_Log.txt";

            File.Copy(oldBswx, newBswx, true);
            File.Copy(oldLog, newLog, true);
        }

        public static void DeleteTempBswxFolders(string tempNcFolder, string tempPdfFolder)
        {
            //SystemIO.DeleteFolder(tempNcFolder);
            //SystemIO.DeleteFolder(tempPdfFolder);
        }
    }
}