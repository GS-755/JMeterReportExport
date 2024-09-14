namespace JMeterReportExport
{
    using System;
    using System.IO;
    using System.Diagnostics;
    using System.Windows.Forms;
    using JMeterReportExport.Utils;
    using JMeterReportExport.Forms.Dialogs;

    public partial class IndexForm : Form
    {
        // Private attribute 
        private string EXPORT_PATH = 
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        // Constructor 
        public IndexForm()
        {
            InitializeComponent(); 
        }

        /* Menu strip action Start */
        // Open CSV file(s) dialog 
        private void mnOpenCsv_Click(object sender, EventArgs e)
        {
            if (openCsvDialog.ShowDialog() == DialogResult.OK)
            {   
                string[] filePath = openCsvDialog.FileNames;
                // Append opened file for decorating purpose :D
                foreach (string fileName in filePath)
                {
                    SheetProcessor.CsvFiles.Add(fileName);  
                    listBoxCsvFiles.Items.Add(Path.GetFileName(fileName));
                }
                // Process reading CSV files
                SheetProcessor.ReadAllCsvFiles(filePath);   
            }
        }
        // Open About dialog
        private void mnAbout_Click(object sender, EventArgs e)
        {
            var aboutBox = new MainAboutBox();
            aboutBox.Show();
        }
        // Exit event
        private void mnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        /* Menu strip action End */

        /* Button event Start */
        // Convert to XSLX task
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (listBoxCsvFiles.Items != null && listBoxCsvFiles.Items.Count != 0)
            {
                // Process exporting data to Excel 
                string exportedFileName = SheetProcessor.ExportToExcel(
                    GlobalConstants.EXCEL_TEMPLATE,
                    EXPORT_PATH
                );
                // Write converted filename to output listbox 
                if (exportedFileName != string.Empty || exportedFileName != null)
                {
                    listBoxXlsxFiles.Items.Add(exportedFileName);
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select CSV file(s)!\n(Menu => Open CSV File(s)",
                    "Can not process CSV conversion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
        // Clear input & data task 
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the displayed CSV file(s) 
            listBoxCsvFiles.Items.Clear();
            // Clear the data structures of the SheetProcessor
            SheetProcessor.CsvFiles.Clear();
            SheetProcessor.ReportNodes.Clear(); 
        }
        // Task: Open Default "Documents" folder  
        private void btnOpenExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", EXPORT_PATH);
        }
        /* Button event End */
    }
}
