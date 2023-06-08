namespace BourneIssueApp
{
    partial class SelectionForm
    {

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.Components != null))
            {
                this.Components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionForm));
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.CheckBoxGA = new System.Windows.Forms.CheckBox();
            this.CheckBoxAssembly = new System.Windows.Forms.CheckBox();
            this.CheckBoxFitings = new System.Windows.Forms.CheckBox();
            this.CheckBoxNC = new System.Windows.Forms.CheckBox();
            this.CheckBoxIFC = new System.Windows.Forms.CheckBox();
            this.CheckBoxBSWX = new System.Windows.Forms.CheckBox();
            this.LabelBswxRev = new System.Windows.Forms.Label();
            this.LabelIfcRev = new System.Windows.Forms.Label();
            this.TextRevisionBswx = new System.Windows.Forms.TextBox();
            this.TextRevisionIfc = new System.Windows.Forms.TextBox();
            this.GroupBoxDrawings = new System.Windows.Forms.GroupBox();
            this.GroupBoxNcFiles = new System.Windows.Forms.GroupBox();
            this.GroupBoxBimFiles = new System.Windows.Forms.GroupBox();
            this.GroupBoxOpenFolder = new System.Windows.Forms.GroupBox();
            this.CheckBoxOpenMainFolder = new System.Windows.Forms.CheckBox();
            this.AppVersion = new System.Windows.Forms.Label();
            this.GroupBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.GroupBoxVersion = new System.Windows.Forms.GroupBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ComboBoxPrinter = new System.Windows.Forms.ComboBox();
            this.TextRevisionAssembly = new System.Windows.Forms.TextBox();
            this.TextRevisionBolts = new System.Windows.Forms.TextBox();
            this.CheckBoxReportsBolts = new System.Windows.Forms.CheckBox();
            this.CheckBoxReportsAssembly = new System.Windows.Forms.CheckBox();
            this.TextRevisionAditionalReport = new System.Windows.Forms.TextBox();
            this.TextAditionalReport = new System.Windows.Forms.TextBox();
            this.GroupBoxToogleSelection = new System.Windows.Forms.GroupBox();
            this.groupBoxPrinter = new System.Windows.Forms.GroupBox();
            this.LabelAssemblyRev = new System.Windows.Forms.Label();
            this.LabelBoltRev = new System.Windows.Forms.Label();
            this.LabelAditionalReportRevision = new System.Windows.Forms.Label();
            this.CheckAdditionalReports = new System.Windows.Forms.CheckBox();
            this.GroupBoxReports = new System.Windows.Forms.GroupBox();
            this.GroupBoxDrawings.SuspendLayout();
            this.GroupBoxNcFiles.SuspendLayout();
            this.GroupBoxBimFiles.SuspendLayout();
            this.GroupBoxOpenFolder.SuspendLayout();
            this.GroupBoxVersion.SuspendLayout();
            this.GroupBoxToogleSelection.SuspendLayout();
            this.groupBoxPrinter.SuspendLayout();
            this.GroupBoxReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonStart.Location = new System.Drawing.Point(8, 432);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(200, 50);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Export";
            this.ToolTip.SetToolTip(this.ButtonStart, "Click here to start the export");
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonCancel.Location = new System.Drawing.Point(219, 432);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(200, 50);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Close";
            this.ToolTip.SetToolTip(this.ButtonCancel, "Click here to close the application");
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // CheckBoxGA
            // 
            this.CheckBoxGA.AutoSize = true;
            this.CheckBoxGA.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CheckBoxGA.Location = new System.Drawing.Point(23, 23);
            this.CheckBoxGA.Name = "CheckBoxGA";
            this.CheckBoxGA.Size = new System.Drawing.Size(138, 17);
            this.CheckBoxGA.TabIndex = 3;
            this.CheckBoxGA.Text = "Create Empty Ga Folder";
            this.ToolTip.SetToolTip(this.CheckBoxGA, "Creates empty folders for the GA\'s");
            this.CheckBoxGA.UseVisualStyleBackColor = true;
            // 
            // CheckBoxAssembly
            // 
            this.CheckBoxAssembly.AutoSize = true;
            this.CheckBoxAssembly.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CheckBoxAssembly.Location = new System.Drawing.Point(23, 54);
            this.CheckBoxAssembly.Name = "CheckBoxAssembly";
            this.CheckBoxAssembly.Size = new System.Drawing.Size(111, 17);
            this.CheckBoxAssembly.TabIndex = 4;
            this.CheckBoxAssembly.Text = "Export Assemblies";
            this.ToolTip.SetToolTip(this.CheckBoxAssembly, "Select to export assembly drawings");
            this.CheckBoxAssembly.UseVisualStyleBackColor = true;
            // 
            // CheckBoxFitings
            // 
            this.CheckBoxFitings.AutoSize = true;
            this.CheckBoxFitings.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CheckBoxFitings.Location = new System.Drawing.Point(23, 85);
            this.CheckBoxFitings.Name = "CheckBoxFitings";
            this.CheckBoxFitings.Size = new System.Drawing.Size(92, 17);
            this.CheckBoxFitings.TabIndex = 5;
            this.CheckBoxFitings.Text = "Export Fittings";
            this.ToolTip.SetToolTip(this.CheckBoxFitings, "Select to export fitting drawings in separated folders:\r\nFitting plates\r\nFitting " +
        "profiles");
            this.CheckBoxFitings.UseVisualStyleBackColor = true;
            // 
            // CheckBoxNC
            // 
            this.CheckBoxNC.AutoSize = true;
            this.CheckBoxNC.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CheckBoxNC.Location = new System.Drawing.Point(23, 19);
            this.CheckBoxNC.Name = "CheckBoxNC";
            this.CheckBoxNC.Size = new System.Drawing.Size(97, 17);
            this.CheckBoxNC.TabIndex = 12;
            this.CheckBoxNC.Text = "Export Nc Files";
            this.ToolTip.SetToolTip(this.CheckBoxNC, "Select to export .nc files in separated folders:\r\nFiles plates\r\nFiles profiles");
            this.CheckBoxNC.UseVisualStyleBackColor = true;
            // 
            // CheckBoxIFC
            // 
            this.CheckBoxIFC.AutoSize = true;
            this.CheckBoxIFC.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CheckBoxIFC.Location = new System.Drawing.Point(23, 20);
            this.CheckBoxIFC.Name = "CheckBoxIFC";
            this.CheckBoxIFC.Size = new System.Drawing.Size(75, 17);
            this.CheckBoxIFC.TabIndex = 13;
            this.CheckBoxIFC.Text = "Export IFC";
            this.ToolTip.SetToolTip(this.CheckBoxIFC, "Select to export .ifc file");
            this.CheckBoxIFC.UseVisualStyleBackColor = true;
            // 
            // CheckBoxBSWX
            // 
            this.CheckBoxBSWX.AutoSize = true;
            this.CheckBoxBSWX.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CheckBoxBSWX.Location = new System.Drawing.Point(23, 44);
            this.CheckBoxBSWX.Name = "CheckBoxBSWX";
            this.CheckBoxBSWX.Size = new System.Drawing.Size(91, 17);
            this.CheckBoxBSWX.TabIndex = 14;
            this.CheckBoxBSWX.Text = "Export BSWX";
            this.ToolTip.SetToolTip(this.CheckBoxBSWX, "Select to export .bswx file");
            this.CheckBoxBSWX.UseVisualStyleBackColor = true;
            // 
            // LabelBswxRev
            // 
            this.LabelBswxRev.AutoSize = true;
            this.LabelBswxRev.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LabelBswxRev.Location = new System.Drawing.Point(303, 45);
            this.LabelBswxRev.Name = "LabelBswxRev";
            this.LabelBswxRev.Size = new System.Drawing.Size(30, 13);
            this.LabelBswxRev.TabIndex = 18;
            this.LabelBswxRev.Text = "Rev:";
            // 
            // LabelIfcRev
            // 
            this.LabelIfcRev.AutoSize = true;
            this.LabelIfcRev.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LabelIfcRev.Location = new System.Drawing.Point(303, 20);
            this.LabelIfcRev.Name = "LabelIfcRev";
            this.LabelIfcRev.Size = new System.Drawing.Size(30, 13);
            this.LabelIfcRev.TabIndex = 17;
            this.LabelIfcRev.Text = "Rev:";
            // 
            // TextRevisionBswx
            // 
            this.TextRevisionBswx.Location = new System.Drawing.Point(339, 42);
            this.TextRevisionBswx.Name = "TextRevisionBswx";
            this.TextRevisionBswx.Size = new System.Drawing.Size(53, 20);
            this.TextRevisionBswx.TabIndex = 16;
            this.ToolTip.SetToolTip(this.TextRevisionBswx, "Add revision letter or number in the box");
            this.TextRevisionBswx.TextChanged += new System.EventHandler(this.TextRevisionBswx_TextChanged);
            // 
            // TextRevisionIfc
            // 
            this.TextRevisionIfc.Location = new System.Drawing.Point(339, 16);
            this.TextRevisionIfc.Name = "TextRevisionIfc";
            this.TextRevisionIfc.Size = new System.Drawing.Size(53, 20);
            this.TextRevisionIfc.TabIndex = 15;
            this.ToolTip.SetToolTip(this.TextRevisionIfc, "Add revision letter or number in the box");
            this.TextRevisionIfc.TextChanged += new System.EventHandler(this.TextRevisionIfc_TextChanged);
            // 
            // GroupBoxDrawings
            // 
            this.GroupBoxDrawings.Controls.Add(this.CheckBoxFitings);
            this.GroupBoxDrawings.Controls.Add(this.CheckBoxAssembly);
            this.GroupBoxDrawings.Controls.Add(this.CheckBoxGA);
            this.GroupBoxDrawings.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.GroupBoxDrawings.Location = new System.Drawing.Point(10, 12);
            this.GroupBoxDrawings.Name = "GroupBoxDrawings";
            this.GroupBoxDrawings.Size = new System.Drawing.Size(200, 114);
            this.GroupBoxDrawings.TabIndex = 20;
            this.GroupBoxDrawings.TabStop = false;
            this.GroupBoxDrawings.Text = "Drawings:";
            // 
            // GroupBoxNcFiles
            // 
            this.GroupBoxNcFiles.Controls.Add(this.CheckBoxNC);
            this.GroupBoxNcFiles.ForeColor = System.Drawing.SystemColors.Highlight;
            this.GroupBoxNcFiles.Location = new System.Drawing.Point(10, 252);
            this.GroupBoxNcFiles.Name = "GroupBoxNcFiles";
            this.GroupBoxNcFiles.Size = new System.Drawing.Size(411, 44);
            this.GroupBoxNcFiles.TabIndex = 28;
            this.GroupBoxNcFiles.TabStop = false;
            this.GroupBoxNcFiles.Text = "Nc Files:";
            // 
            // GroupBoxBimFiles
            // 
            this.GroupBoxBimFiles.Controls.Add(this.LabelBswxRev);
            this.GroupBoxBimFiles.Controls.Add(this.LabelIfcRev);
            this.GroupBoxBimFiles.Controls.Add(this.TextRevisionBswx);
            this.GroupBoxBimFiles.Controls.Add(this.TextRevisionIfc);
            this.GroupBoxBimFiles.Controls.Add(this.CheckBoxBSWX);
            this.GroupBoxBimFiles.Controls.Add(this.CheckBoxIFC);
            this.GroupBoxBimFiles.ForeColor = System.Drawing.SystemColors.Highlight;
            this.GroupBoxBimFiles.Location = new System.Drawing.Point(10, 302);
            this.GroupBoxBimFiles.Name = "GroupBoxBimFiles";
            this.GroupBoxBimFiles.Size = new System.Drawing.Size(411, 72);
            this.GroupBoxBimFiles.TabIndex = 29;
            this.GroupBoxBimFiles.TabStop = false;
            this.GroupBoxBimFiles.Text = "Bim Files:";
            // 
            // GroupBoxOpenFolder
            // 
            this.GroupBoxOpenFolder.Controls.Add(this.CheckBoxOpenMainFolder);
            this.GroupBoxOpenFolder.ForeColor = System.Drawing.SystemColors.Highlight;
            this.GroupBoxOpenFolder.Location = new System.Drawing.Point(8, 378);
            this.GroupBoxOpenFolder.Name = "GroupBoxOpenFolder";
            this.GroupBoxOpenFolder.Size = new System.Drawing.Size(200, 47);
            this.GroupBoxOpenFolder.TabIndex = 30;
            this.GroupBoxOpenFolder.TabStop = false;
            this.GroupBoxOpenFolder.Text = "Open Folder:";
            // 
            // CheckBoxOpenMainFolder
            // 
            this.CheckBoxOpenMainFolder.AutoSize = true;
            this.CheckBoxOpenMainFolder.Checked = true;
            this.CheckBoxOpenMainFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxOpenMainFolder.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CheckBoxOpenMainFolder.Location = new System.Drawing.Point(23, 19);
            this.CheckBoxOpenMainFolder.Name = "CheckBoxOpenMainFolder";
            this.CheckBoxOpenMainFolder.Size = new System.Drawing.Size(142, 17);
            this.CheckBoxOpenMainFolder.TabIndex = 31;
            this.CheckBoxOpenMainFolder.Text = "Open Folder After Export";
            this.ToolTip.SetToolTip(this.CheckBoxOpenMainFolder, "Select this option if you\r\nwant to open the main folder after\r\nthe application co" +
        "mpletes the exports");
            this.CheckBoxOpenMainFolder.UseVisualStyleBackColor = true;
            // 
            // AppVersion
            // 
            this.AppVersion.AutoSize = true;
            this.AppVersion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.AppVersion.Location = new System.Drawing.Point(132, 20);
            this.AppVersion.Name = "AppVersion";
            this.AppVersion.Size = new System.Drawing.Size(43, 13);
            this.AppVersion.TabIndex = 31;
            this.AppVersion.Text = "16.10 a";
            this.ToolTip.SetToolTip(this.AppVersion, "Current version of the application");
            // 
            // GroupBoxSelectAll
            // 
            this.GroupBoxSelectAll.ForeColor = System.Drawing.SystemColors.InfoText;
            this.GroupBoxSelectAll.Location = new System.Drawing.Point(25, 21);
            this.GroupBoxSelectAll.Name = "GroupBoxSelectAll";
            this.GroupBoxSelectAll.Size = new System.Drawing.Size(159, 18);
            this.GroupBoxSelectAll.TabIndex = 6;
            this.GroupBoxSelectAll.Text = "Toggle Common Selections";
            this.ToolTip.SetToolTip(this.GroupBoxSelectAll, "Toggles the selection for the\r\nmost common selections");
            this.GroupBoxSelectAll.UseVisualStyleBackColor = true;
            this.GroupBoxSelectAll.CheckedChanged += new System.EventHandler(this.GroupBoxSelectAll_CheckedChanged);
            // 
            // GroupBoxVersion
            // 
            this.GroupBoxVersion.Controls.Add(this.AppVersion);
            this.GroupBoxVersion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.GroupBoxVersion.Location = new System.Drawing.Point(219, 378);
            this.GroupBoxVersion.Name = "GroupBoxVersion";
            this.GroupBoxVersion.Size = new System.Drawing.Size(200, 47);
            this.GroupBoxVersion.TabIndex = 29;
            this.GroupBoxVersion.TabStop = false;
            this.GroupBoxVersion.Text = "Version:";
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 32000;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.ToolTipTitle = "Tooltip:";
            // 
            // ComboBoxPrinter
            // 
            this.ComboBoxPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxPrinter.FormattingEnabled = true;
            this.ComboBoxPrinter.Location = new System.Drawing.Point(22, 24);
            this.ComboBoxPrinter.Name = "ComboBoxPrinter";
            this.ComboBoxPrinter.Size = new System.Drawing.Size(159, 21);
            this.ComboBoxPrinter.Sorted = true;
            this.ComboBoxPrinter.TabIndex = 7;
            this.ToolTip.SetToolTip(this.ComboBoxPrinter, "Select PDF printer from the list");
            this.ComboBoxPrinter.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPrinter_SelectedIndexChanged);
            // 
            // TextRevisionAssembly
            // 
            this.TextRevisionAssembly.Location = new System.Drawing.Point(339, 17);
            this.TextRevisionAssembly.Name = "TextRevisionAssembly";
            this.TextRevisionAssembly.Size = new System.Drawing.Size(53, 20);
            this.TextRevisionAssembly.TabIndex = 24;
            this.ToolTip.SetToolTip(this.TextRevisionAssembly, "Add revision letter or number in the box");
            this.TextRevisionAssembly.TextChanged += new System.EventHandler(this.TextRevisionAssembly_TextChanged);
            // 
            // TextRevisionBolts
            // 
            this.TextRevisionBolts.Location = new System.Drawing.Point(339, 46);
            this.TextRevisionBolts.Name = "TextRevisionBolts";
            this.TextRevisionBolts.Size = new System.Drawing.Size(53, 20);
            this.TextRevisionBolts.TabIndex = 25;
            this.ToolTip.SetToolTip(this.TextRevisionBolts, "Add revision letter or number in the box");
            this.TextRevisionBolts.TextChanged += new System.EventHandler(this.TextRevisionBolts_TextChanged);
            // 
            // CheckBoxReportsBolts
            // 
            this.CheckBoxReportsBolts.AutoSize = true;
            this.CheckBoxReportsBolts.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CheckBoxReportsBolts.Location = new System.Drawing.Point(23, 50);
            this.CheckBoxReportsBolts.Name = "CheckBoxReportsBolts";
            this.CheckBoxReportsBolts.Size = new System.Drawing.Size(120, 17);
            this.CheckBoxReportsBolts.TabIndex = 23;
            this.CheckBoxReportsBolts.Text = "Export Bolt Reports ";
            this.ToolTip.SetToolTip(this.CheckBoxReportsBolts, "Select to export bolt reports:\r\nBEL-Bolt-Summary-Site-List.xsr\r\nBEL-Bolt-Assembly" +
        "-List.xsr");
            this.CheckBoxReportsBolts.UseVisualStyleBackColor = true;
            // 
            // CheckBoxReportsAssembly
            // 
            this.CheckBoxReportsAssembly.AutoSize = true;
            this.CheckBoxReportsAssembly.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CheckBoxReportsAssembly.Location = new System.Drawing.Point(23, 23);
            this.CheckBoxReportsAssembly.Name = "CheckBoxReportsAssembly";
            this.CheckBoxReportsAssembly.Size = new System.Drawing.Size(143, 17);
            this.CheckBoxReportsAssembly.TabIndex = 22;
            this.CheckBoxReportsAssembly.Text = "Export Assembly Reports";
            this.ToolTip.SetToolTip(this.CheckBoxReportsAssembly, "Select to export assembly reports:\r\nBEL-Assembly-List.xsr\r\nBEL-Strumis-Upload.xls" +
        "");
            this.CheckBoxReportsAssembly.UseVisualStyleBackColor = true;
            // 
            // TextRevisionAditionalReport
            // 
            this.TextRevisionAditionalReport.Location = new System.Drawing.Point(339, 76);
            this.TextRevisionAditionalReport.Name = "TextRevisionAditionalReport";
            this.TextRevisionAditionalReport.Size = new System.Drawing.Size(53, 20);
            this.TextRevisionAditionalReport.TabIndex = 28;
            this.ToolTip.SetToolTip(this.TextRevisionAditionalReport, "Add revision letter or number in the box");
            this.TextRevisionAditionalReport.TextChanged += new System.EventHandler(this.TextRevisionAditionalReport_TextChanged);
            // 
            // TextAditionalReport
            // 
            this.TextAditionalReport.Location = new System.Drawing.Point(43, 76);
            this.TextAditionalReport.Name = "TextAditionalReport";
            this.TextAditionalReport.Size = new System.Drawing.Size(236, 20);
            this.TextAditionalReport.TabIndex = 30;
            this.TextAditionalReport.Text = "Add different type of report here ...";
            this.ToolTip.SetToolTip(this.TextAditionalReport, "Add report name as text in the field\r\nto export different type of report\r\n");
            this.TextAditionalReport.TextChanged += new System.EventHandler(this.TextAditionalReport_TextChanged);
            // 
            // GroupBoxToogleSelection
            // 
            this.GroupBoxToogleSelection.Controls.Add(this.GroupBoxSelectAll);
            this.GroupBoxToogleSelection.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.GroupBoxToogleSelection.Location = new System.Drawing.Point(221, 12);
            this.GroupBoxToogleSelection.Name = "GroupBoxToogleSelection";
            this.GroupBoxToogleSelection.Size = new System.Drawing.Size(200, 49);
            this.GroupBoxToogleSelection.TabIndex = 21;
            this.GroupBoxToogleSelection.TabStop = false;
            this.GroupBoxToogleSelection.Text = "Selection:";
            // 
            // groupBoxPrinter
            // 
            this.groupBoxPrinter.Controls.Add(this.ComboBoxPrinter);
            this.groupBoxPrinter.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxPrinter.Location = new System.Drawing.Point(221, 67);
            this.groupBoxPrinter.Name = "groupBoxPrinter";
            this.groupBoxPrinter.Size = new System.Drawing.Size(200, 59);
            this.groupBoxPrinter.TabIndex = 22;
            this.groupBoxPrinter.TabStop = false;
            this.groupBoxPrinter.Text = "Printer:";
            // 
            // LabelAssemblyRev
            // 
            this.LabelAssemblyRev.AutoSize = true;
            this.LabelAssemblyRev.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LabelAssemblyRev.Location = new System.Drawing.Point(303, 21);
            this.LabelAssemblyRev.Name = "LabelAssemblyRev";
            this.LabelAssemblyRev.Size = new System.Drawing.Size(30, 13);
            this.LabelAssemblyRev.TabIndex = 26;
            this.LabelAssemblyRev.Text = "Rev:";
            // 
            // LabelBoltRev
            // 
            this.LabelBoltRev.AutoSize = true;
            this.LabelBoltRev.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LabelBoltRev.Location = new System.Drawing.Point(303, 50);
            this.LabelBoltRev.Name = "LabelBoltRev";
            this.LabelBoltRev.Size = new System.Drawing.Size(30, 13);
            this.LabelBoltRev.TabIndex = 27;
            this.LabelBoltRev.Text = "Rev:";
            // 
            // LabelAditionalReportRevision
            // 
            this.LabelAditionalReportRevision.AutoSize = true;
            this.LabelAditionalReportRevision.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LabelAditionalReportRevision.Location = new System.Drawing.Point(303, 79);
            this.LabelAditionalReportRevision.Name = "LabelAditionalReportRevision";
            this.LabelAditionalReportRevision.Size = new System.Drawing.Size(30, 13);
            this.LabelAditionalReportRevision.TabIndex = 29;
            this.LabelAditionalReportRevision.Text = "Rev:";
            // 
            // CheckAdditionalReports
            // 
            this.CheckAdditionalReports.AutoSize = true;
            this.CheckAdditionalReports.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CheckAdditionalReports.Location = new System.Drawing.Point(23, 79);
            this.CheckAdditionalReports.Name = "CheckAdditionalReports";
            this.CheckAdditionalReports.Size = new System.Drawing.Size(15, 14);
            this.CheckAdditionalReports.TabIndex = 31;
            this.CheckAdditionalReports.UseVisualStyleBackColor = true;
            // 
            // GroupBoxReports
            // 
            this.GroupBoxReports.Controls.Add(this.CheckAdditionalReports);
            this.GroupBoxReports.Controls.Add(this.TextAditionalReport);
            this.GroupBoxReports.Controls.Add(this.LabelAditionalReportRevision);
            this.GroupBoxReports.Controls.Add(this.TextRevisionAditionalReport);
            this.GroupBoxReports.Controls.Add(this.LabelBoltRev);
            this.GroupBoxReports.Controls.Add(this.CheckBoxReportsAssembly);
            this.GroupBoxReports.Controls.Add(this.LabelAssemblyRev);
            this.GroupBoxReports.Controls.Add(this.CheckBoxReportsBolts);
            this.GroupBoxReports.Controls.Add(this.TextRevisionBolts);
            this.GroupBoxReports.Controls.Add(this.TextRevisionAssembly);
            this.GroupBoxReports.ForeColor = System.Drawing.SystemColors.Highlight;
            this.GroupBoxReports.Location = new System.Drawing.Point(10, 132);
            this.GroupBoxReports.Name = "GroupBoxReports";
            this.GroupBoxReports.Size = new System.Drawing.Size(411, 114);
            this.GroupBoxReports.TabIndex = 21;
            this.GroupBoxReports.TabStop = false;
            this.GroupBoxReports.Text = "Reports:";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(430, 490);
            this.Controls.Add(this.groupBoxPrinter);
            this.Controls.Add(this.GroupBoxToogleSelection);
            this.Controls.Add(this.GroupBoxVersion);
            this.Controls.Add(this.GroupBoxOpenFolder);
            this.Controls.Add(this.GroupBoxBimFiles);
            this.Controls.Add(this.GroupBoxNcFiles);
            this.Controls.Add(this.GroupBoxReports);
            this.Controls.Add(this.GroupBoxDrawings);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonStart);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Export Type:";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.GroupBoxDrawings.ResumeLayout(false);
            this.GroupBoxDrawings.PerformLayout();
            this.GroupBoxNcFiles.ResumeLayout(false);
            this.GroupBoxNcFiles.PerformLayout();
            this.GroupBoxBimFiles.ResumeLayout(false);
            this.GroupBoxBimFiles.PerformLayout();
            this.GroupBoxOpenFolder.ResumeLayout(false);
            this.GroupBoxOpenFolder.PerformLayout();
            this.GroupBoxVersion.ResumeLayout(false);
            this.GroupBoxVersion.PerformLayout();
            this.GroupBoxToogleSelection.ResumeLayout(false);
            this.groupBoxPrinter.ResumeLayout(false);
            this.GroupBoxReports.ResumeLayout(false);
            this.GroupBoxReports.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion Windows Form Designer generated code

        public global::System.Windows.Forms.CheckBox CheckBoxGA;
        public global::System.Windows.Forms.CheckBox CheckBoxAssembly;
        public global::System.Windows.Forms.CheckBox CheckBoxFitings;
        public global::System.Windows.Forms.CheckBox CheckBoxNC;
        public global::System.Windows.Forms.CheckBox CheckBoxIFC;
        public global::System.Windows.Forms.CheckBox CheckBoxBSWX;
        public global::System.Windows.Forms.CheckBox CheckBoxOpenMainFolder;
        public global::System.Windows.Forms.CheckBox GroupBoxSelectAll;
        private global::System.Windows.Forms.TextBox TextRevisionBswx;
        private global::System.Windows.Forms.TextBox TextRevisionIfc;
        public global::System.Windows.Forms.Label LabelBswxRev;
        public global::System.Windows.Forms.Label LabelIfcRev;
        public global::System.Windows.Forms.Label AppVersion;
        public global::System.Windows.Forms.GroupBox GroupBoxNcFiles;
        public global::System.Windows.Forms.GroupBox GroupBoxBimFiles;
        public global::System.Windows.Forms.GroupBox GroupBoxOpenFolder;
        public global::System.Windows.Forms.GroupBox GroupBoxDrawings;
        public global::System.Windows.Forms.GroupBox GroupBoxVersion;
        public global::System.Windows.Forms.Button ButtonStart;
        public global::System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.ComponentModel.IContainer Components;
        private System.Windows.Forms.ComboBox ComboBoxPrinter;
        public System.Windows.Forms.GroupBox GroupBoxToogleSelection;
        public System.Windows.Forms.GroupBox groupBoxPrinter;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.TextBox TextRevisionAssembly;
        private System.Windows.Forms.TextBox TextRevisionBolts;
        public System.Windows.Forms.CheckBox CheckBoxReportsBolts;
        public System.Windows.Forms.Label LabelAssemblyRev;
        public System.Windows.Forms.CheckBox CheckBoxReportsAssembly;
        public System.Windows.Forms.Label LabelBoltRev;
        private System.Windows.Forms.TextBox TextRevisionAditionalReport;
        public System.Windows.Forms.Label LabelAditionalReportRevision;
        private System.Windows.Forms.TextBox TextAditionalReport;
        public System.Windows.Forms.CheckBox CheckAdditionalReports;
        public System.Windows.Forms.GroupBox GroupBoxReports;
    }
}

