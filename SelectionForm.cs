using System;
using System.Diagnostics;
using System.Windows.Forms;
using BourneIssueApp.Classes;
using BourneIssueApp.Utilities;
using Tekla.Structures;

namespace BourneIssueApp
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            this.InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            this.Hide();

            var excutionForm = new ExecutionForm(this.CheckBoxBSWX.Checked);
            excutionForm.Show();

            excutionForm.UpdateLabel("Creating Main Folder");
            SystemIO.CreateFolder(UserInfo.MainFolder);

            excutionForm.UpdateLabel("Adding Model Parts To Catalogue");
            Catalog.CollectPartsFromTheModel();

            excutionForm.UpdateLabel("Adding Model Parts To Catalogue");
            Catalog.SplitPartsIntoPhases();

            if (this.CheckBoxGA.Checked)
            {
                foreach (var phase in Catalog.Phases)
                {
                    SystemIO.CreateFolder(phase.GasFolder);
                }
            }

            if (this.CheckBoxAssembly.Checked)
            {
                foreach (var phase in Catalog.Phases)
                {
                    excutionForm.UpdateLabel("Selecting Assembly Drawings", phase.Number);
                    ModelUI.SelectParts(phase.Parts);
                    DrawingsUI.SelectDrawings(DrawingType.Assembly);
                    PrinterUI.Print(phase.AssembliesFolder, this.ComboBoxPrinter.Text, excutionForm, phase.Number);
                }
            }

            if (this.CheckBoxFitings.Checked)
            {
                foreach (var phase in Catalog.Phases)
                {
                    if (phase.HasPlates)
                    {
                        excutionForm.UpdateLabel("Selecting Plate Drawings", phase.Number);
                        ModelUI.SelectParts(phase.Plates);
                        DrawingsUI.SelectDrawings(DrawingType.Fitting);
                        PrinterUI.Print(phase.PlatesFolder, this.ComboBoxPrinter.Text, excutionForm, phase.Number);
                    }
                }
            }

            if (this.CheckBoxFitings.Checked)
            {
                foreach (var phase in Catalog.Phases)
                {
                    if (phase.HasProfiles)
                    {
                        excutionForm.UpdateLabel("Selecting Profile Drawings", phase.Number);
                        ModelUI.SelectParts(phase.Profiles);
                        DrawingsUI.SelectDrawings(DrawingType.Fitting);
                        PrinterUI.Print(phase.ProfilesFolder, this.ComboBoxPrinter.Text, excutionForm, phase.Number);
                    }
                }
            }

            if (this.CheckBoxReportsAssembly.Checked)
            {
                foreach (var phase in Catalog.Phases)
                {
                    excutionForm.UpdateLabel("Exporting Assembly Reports", phase.Number);
                    ModelUI.SelectParts(phase.Parts);
                    SystemIO.CreateFolder(phase.ReportsFolder);
                    ReportsUI.ExportAssemblyReports(this.TextRevisionAssembly.Text, phase.ReportsFolder, phase.Number);
                }
            }

            if (this.CheckBoxReportsBolts.Checked)
            {
                foreach (var phase in Catalog.Phases)
                {
                    excutionForm.UpdateLabel("Exporting Bolt Reports", phase.Number);
                    ModelUI.SelectParts(phase.Parts);
                    SystemIO.CreateFolder(phase.ReportsFolder);
                    ReportsUI.ExportBoltReports(this.TextRevisionBolts.Text, phase.ReportsFolder, phase.Number);
                }
            }

            if (this.TextAditionalReport.Text != "Add different type of report here ...")
            {
                foreach (var phase in Catalog.Phases)
                {
                    excutionForm.UpdateLabel("Exporting Aditional Reports", phase.Number);
                    ModelUI.SelectParts(phase.Parts);
                    SystemIO.CreateFolder(phase.ReportsFolder);
                    ReportsUI.ExportAdditionalReport(this.TextAditionalReport.Text, this.TextRevisionAditionalReport.Text, phase.ReportsFolder, phase.Number);
                }
            }

            if (this.CheckBoxNC.Checked)
            {
                foreach (var phase in Catalog.Phases)
                {
                    excutionForm.UpdateLabel("Exporting Plate Nc Files", phase.Number);
                    ModelUI.SelectParts(phase.Plates);
                    SystemIO.CreateFolder(phase.NcPlatesFolder);
                    NcUI.Export(phase.NcPlatesFolder, NCFileType.Plates);
                }
            }

            if (this.CheckBoxNC.Checked)
            {
                foreach (var phase in Catalog.Phases)
                {
                    excutionForm.UpdateLabel("Exporting Profile Nc Files", phase.Number);
                    ModelUI.SelectParts(phase.Profiles);
                    SystemIO.CreateFolder(phase.NcProfilesFolder);
                    NcUI.Export(phase.NcProfilesFolder, NCFileType.Profiles);
                }
            }

            if (this.CheckBoxIFC.Checked)
            {
                foreach (var phase in Catalog.Phases)
                {
                    excutionForm.UpdateLabel("Exporting .ifc File", phase.Number);
                    SystemIO.CreateFolder(UserInfo.TempIfcExportFolder);
                    SystemIO.CreateFolder(phase.IfcFolder);
                    ModelUI.SelectParts(phase.Parts);
                    IfcUI.ExportIfcModel(this.TextRevisionIfc.Text, phase.Number);
                    IfcUI.CopyIfcFile(this.TextRevisionIfc.Text, phase.IfcFolder, phase.Number);
                }
            }

            if (this.CheckBoxBSWX.Checked)
            {
                foreach (var phase in Catalog.Phases)
                {
                    excutionForm.UpdateLabel("Exporting .bswx File", phase.Number);
                    SystemIO.CreateFolder(UserInfo.TempBswxExportFolder);
                    SystemIO.CreateFolder(phase.BswxFolder);
                    ModelUI.SelectParts(phase.Parts);
                    BswxUI.SaveBswxSettings(this.TextRevisionBswx.Text, phase.TempNcFilesFolder, phase.TempPdfFilesFolder, phase.Number);
                    BswxUI.CreateTempBswxFolders(phase.TempNcFilesFolder, phase.TempPdfFilesFolder);
                    BswxUI.CopyTempNcFiles(phase.TempNcFilesFolder, phase.NcPlatesFolder, phase.NcProfilesFolder);
                    BswxUI.CopyTempPdfFiles(phase.TempPdfFilesFolder, phase.PlatesFolder, phase.ProfilesFolder, phase.AssembliesFolder);
                    BswxUI.ExportBswxFile(this.TextRevisionBswx.Text, phase.TempNcFilesFolder, phase.TempPdfFilesFolder, phase.Number);
                    BswxUI.CopyBswxFile(this.TextRevisionBswx.Text, phase.BswxFolder, phase.Number);
                    BswxUI.DeleteTempBswxFolders(phase.TempNcFilesFolder, phase.TempPdfFilesFolder);
                }
            }

            excutionForm.UpdateLabel("Selecting All Parts From The Model");
            ModelUI.SelectParts(Catalog.Parts);

            foreach (var phase in Catalog.Phases)
            {
                excutionForm.UpdateLabel("Creating Folders Superseded");
                SystemIO.CreateFolderSuperseded(phase.GasFolder);
                SystemIO.CreateFolderSuperseded(phase.AssembliesFolder);
                SystemIO.CreateFolderSuperseded(phase.PlatesFolder);
                SystemIO.CreateFolderSuperseded(phase.ProfilesFolder);
                SystemIO.CreateFolderSuperseded(phase.ReportsFolder);
                SystemIO.CreateFolderSuperseded(phase.IfcFolder);
                SystemIO.CreateFolderSuperseded(phase.BswxFolder);
            }

            if (this.CheckBoxOpenMainFolder.Checked)
            {
                excutionForm.UpdateLabel("Opening The Main Folder");
                Process.Start(UserInfo.MainFolder);
            }

            this.Close();

            stopWatch.Stop();

            excutionForm.UpdateLabel("Export Completed ..." + stopWatch.Elapsed.ToString());
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.GroupBoxSelectAll.CheckState == CheckState.Checked)
            {
                this.CheckBoxGA.CheckState = CheckState.Checked;
                this.CheckBoxAssembly.CheckState = CheckState.Checked;
                this.CheckBoxFitings.CheckState = CheckState.Checked;
                this.CheckBoxReportsAssembly.CheckState = CheckState.Checked;
                this.CheckBoxReportsBolts.CheckState = CheckState.Checked;
                this.CheckBoxNC.CheckState = CheckState.Checked;
                this.CheckBoxIFC.CheckState = CheckState.Checked;
            }

            if (this.GroupBoxSelectAll.CheckState == CheckState.Unchecked)
            {
                this.CheckBoxGA.CheckState = CheckState.Unchecked;
                this.CheckBoxAssembly.CheckState = CheckState.Unchecked;
                this.CheckBoxFitings.CheckState = CheckState.Unchecked;
                this.CheckBoxReportsAssembly.CheckState = CheckState.Unchecked;
                this.CheckBoxReportsBolts.CheckState = CheckState.Unchecked;
                this.CheckBoxNC.CheckState = CheckState.Unchecked;
                this.CheckBoxIFC.CheckState = CheckState.Unchecked;
            }
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                if (printer.Contains("PDF"))
                {
                    this.ComboBoxPrinter.Items.Add(printer);
                }
            }

            this.ComboBoxPrinter.SelectedIndex = 0;

            if (!TeklaStructures.Connect())
            {
                MessageBox.Show("Model connection not found ...", "Model Connection ...");
                return;
            }
        }

        private void TextAditionalReport_TextChanged(object sender, EventArgs e)
        {
            this.CheckAdditionalReports.CheckState = CheckState.Checked;
        }

        private void TextRevisionAssembly_TextChanged(object sender, EventArgs e)
        {
            this.CheckBoxReportsAssembly.CheckState = CheckState.Checked;
        }

        private void TextRevisionBolts_TextChanged(object sender, EventArgs e)
        {
            this.CheckBoxReportsBolts.CheckState = CheckState.Checked;
        }

        private void TextRevisionAditionalReport_TextChanged(object sender, EventArgs e)
        {
            this.CheckAdditionalReports.CheckState = CheckState.Checked;
        }

        private void TextRevisionIfc_TextChanged(object sender, EventArgs e)
        {
            this.CheckBoxIFC.CheckState = CheckState.Checked;
        }

        private void TextRevisionBswx_TextChanged(object sender, EventArgs e)
        {
            this.CheckBoxBSWX.CheckState = CheckState.Checked;
        }

        private void ComboBoxPrinter_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ComboBoxPrinter.Text = this.ComboBoxPrinter.SelectedItem.ToString();
        }
    }
}