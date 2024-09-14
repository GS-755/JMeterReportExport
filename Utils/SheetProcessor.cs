namespace JMeterReportExport.Utils
{
    using System;
    using System.IO;
    using CsvHelper;
    using System.Globalization;
    using System.Windows.Forms;
    using CsvHelper.Configuration;
    using JMeterReportExport.Models;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using Excel = Microsoft.Office.Interop.Excel;

    public class SheetProcessor
    {
        private static List<string> csvFiles = new List<string>();
        private static List<string> convertedFiles = new List<string>();
        private static HashSet<List<ReportNode>> reportNodes = new HashSet<List<ReportNode>>();

        public static HashSet<List<ReportNode>> ReportNodes 
        { 
            get => reportNodes; 
            set => reportNodes = value; 
        }
        public static List<string> ConvertedFiles 
        { 
            get => convertedFiles;
        }
        public static List<string> CsvFiles 
        { 
            get => csvFiles; 
        }

        public static void ReadAllCsvFiles(string[] filePaths) 
        {
            foreach (string filePath in filePaths)
            {
                ReportNodes.Add(ReadSingleCsvFile(filePath.Trim()));
            }
        }

        private static List<ReportNode> ReadSingleCsvFile(string filePath)
        {
            try
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true,
                }))
                {
                    // Read the header row
                    csv.Read();
                    csv.ReadHeader();

                    var records = new List<ReportNode>();
                    while (csv.Read())
                    {
                        var record = new ReportNode
                        {
                            Label = csv.GetField<string>(0).Trim(),
                            Samples = csv.GetField<int>(1),
                            Average = csv.GetField<double>(2),
                            Min = csv.GetField<double>(3),
                            Max = csv.GetField<double>(4),
                            StdDev = csv.GetField<double>(5),
                            ErrorPercentage = StrProcessor.ParsePercentage(csv.GetField(6)),
                            Throughput = csv.GetField<double>(7),
                            ReceivedKBPerSec = csv.GetField<double>(8),
                            SentKBPerSec = csv.GetField<double>(9),
                            AvgBytes = csv.GetField<double>(10)
                        };

                        records.Add(record);
                    }

                    return records;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<ReportNode>();
            }
        }
        public static string ExportToExcel(string templatePath, string outputPath)
        {
            string fileName = string.Empty;
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Open(templatePath.Trim());

                int sheetIndex = 1;
                foreach (var recordList in ReportNodes)
                {
                    if (sheetIndex > 1)
                    {
                        // Copy the first sheet as a template for additional sheets
                        worksheet = workbook.Worksheets[1];
                        worksheet.Copy(After: workbook.Worksheets[workbook.Worksheets.Count]);
                        worksheet = workbook.Worksheets[workbook.Worksheets.Count];
                        worksheet.Name = Path.GetFileNameWithoutExtension(
                            csvFiles[sheetIndex - 1].Trim()
                        );
                    }
                    else
                    {
                        worksheet = workbook.Worksheets[1];
                        worksheet.Name = Path.GetFileNameWithoutExtension(
                            csvFiles[sheetIndex - 1].Trim()
                        );
                    }

                    // Start from row 2 (assuming row 1 has headers)
                    int row = 2;

                    foreach (var record in recordList)
                    {
                        worksheet.Cells[row, 1] = record.Label;
                        worksheet.Cells[row, 2] = record.Samples;
                        worksheet.Cells[row, 3] = record.Average;
                        worksheet.Cells[row, 4] = record.Min;
                        worksheet.Cells[row, 5] = record.Max;
                        worksheet.Cells[row, 6] = record.StdDev;
                        worksheet.Cells[row, 7] = record.ErrorPercentage;
                        worksheet.Cells[row, 8] = record.Throughput;
                        worksheet.Cells[row, 9] = record.ReceivedKBPerSec;
                        worksheet.Cells[row, 10] = record.SentKBPerSec;
                        worksheet.Cells[row, 11] = record.AvgBytes;

                        row++;
                    }

                    sheetIndex++;
                }

                // Save the workbook
                fileName = $"{outputPath.Trim()}\\Report_{DateTime.Now.ToString("yyyyMMdd_hhmmss")}.xlsx";
                workbook.SaveAs(fileName);

                MessageBox.Show(
                    "Export completed successfully!", 
                    "Success", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred during export: {ex.Message}", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                // Clean up
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);
                if (workbook != null)
                {
                    workbook.Close();
                    Marshal.ReleaseComObject(workbook);
                }
                if (excelApp != null)
                {
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
            }

            return fileName;
        }
    }
}
