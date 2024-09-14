namespace JMeterReportExport
{
    partial class IndexForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mnMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.openCsvDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCsvFiles = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnOpenExplorer = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.listBoxXlsxFiles = new System.Windows.Forms.ListBox();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnMain,
            this.mnAbout});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(731, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mnMain
            // 
            this.mnMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOpenCsv,
            this.mnExit});
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(60, 24);
            this.mnMain.Text = "Menu";
            // 
            // mnOpenCsv
            // 
            this.mnOpenCsv.Name = "mnOpenCsv";
            this.mnOpenCsv.Size = new System.Drawing.Size(199, 26);
            this.mnOpenCsv.Text = "Open CSV file(s)";
            this.mnOpenCsv.Click += new System.EventHandler(this.mnOpenCsv_Click);
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(199, 26);
            this.mnExit.Text = "Exit";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // mnAbout
            // 
            this.mnAbout.Name = "mnAbout";
            this.mnAbout.Size = new System.Drawing.Size(64, 24);
            this.mnAbout.Text = "About";
            this.mnAbout.Click += new System.EventHandler(this.mnAbout_Click);
            // 
            // openCsvDialog
            // 
            this.openCsvDialog.DefaultExt = "csv";
            this.openCsvDialog.FileName = "openCsvDialog";
            this.openCsvDialog.Filter = "CSV Files (*.csv)|*.csv";
            this.openCsvDialog.InitialDirectory = "%userprofile%\\\\Documents";
            this.openCsvDialog.Multiselect = true;
            this.openCsvDialog.ReadOnlyChecked = true;
            this.openCsvDialog.SupportMultiDottedExtensions = true;
            this.openCsvDialog.Title = "Select CSV file(s) to open";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imported CSV file(s)";
            // 
            // listBoxCsvFiles
            // 
            this.listBoxCsvFiles.FormattingEnabled = true;
            this.listBoxCsvFiles.HorizontalScrollbar = true;
            this.listBoxCsvFiles.ItemHeight = 16;
            this.listBoxCsvFiles.Location = new System.Drawing.Point(29, 112);
            this.listBoxCsvFiles.Name = "listBoxCsvFiles";
            this.listBoxCsvFiles.ScrollAlwaysVisible = true;
            this.listBoxCsvFiles.Size = new System.Drawing.Size(325, 420);
            this.listBoxCsvFiles.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Exported XLSX file(s)";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(171, 50);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(128, 40);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert to XLSX";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnOpenExplorer
            // 
            this.btnOpenExplorer.Location = new System.Drawing.Point(522, 50);
            this.btnOpenExplorer.Name = "btnOpenExplorer";
            this.btnOpenExplorer.Size = new System.Drawing.Size(128, 40);
            this.btnOpenExplorer.TabIndex = 9;
            this.btnOpenExplorer.Text = "Open location";
            this.btnOpenExplorer.UseVisualStyleBackColor = true;
            this.btnOpenExplorer.Click += new System.EventHandler(this.btnOpenExplorer_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(574, 554);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // listBoxXlsxFiles
            // 
            this.listBoxXlsxFiles.FormattingEnabled = true;
            this.listBoxXlsxFiles.HorizontalScrollbar = true;
            this.listBoxXlsxFiles.ItemHeight = 16;
            this.listBoxXlsxFiles.Location = new System.Drawing.Point(377, 112);
            this.listBoxXlsxFiles.Name = "listBoxXlsxFiles";
            this.listBoxXlsxFiles.ScrollAlwaysVisible = true;
            this.listBoxXlsxFiles.Size = new System.Drawing.Size(325, 420);
            this.listBoxXlsxFiles.TabIndex = 12;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 611);
            this.Controls.Add(this.listBoxXlsxFiles);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOpenExplorer);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxCsvFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "IndexForm";
            this.Text = "JMeter Export Report";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnMain;
        private System.Windows.Forms.ToolStripMenuItem mnOpenCsv;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem mnAbout;
        private System.Windows.Forms.OpenFileDialog openCsvDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCsvFiles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnOpenExplorer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox listBoxXlsxFiles;
    }
}

