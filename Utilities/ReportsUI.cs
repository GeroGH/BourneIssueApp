using System;
using System.IO;
using BourneIssueApp.Classes;
using Tekla.Structures.Model.Operations;
using Word = Microsoft.Office.Interop.Word;

namespace BourneIssueApp.Utilities
{
    internal static class ReportsUI
    {
        public static void ExportAssemblyReports(string rev, string reportsFolder, int number)
        {
            ExportReport("-BEL-Assembly-List.xsr", rev, reportsFolder, number);
        }

        public static void ExportBoltReports(string rev, string reportsFolder, int number)
        {
            ExportReport("-BEL-Bolt-Summary-Site-List With Comments.xsr", rev, reportsFolder, number);
            ExportReport("-BEL-Bolt-Assembly-List.xsr", rev, reportsFolder, number);
        }

        public static void ExportAdditionalReport(string name, string rev, string reportsFolder, int number)
        {
            ExportReport(name, rev, reportsFolder, number);
        }

        private static void ExportReport(string reportType, string rev, string reportsFolder, int number)
        {
            var reportFormat = string.Empty;

            if (reportType.Contains(".xls"))
            {
                reportFormat = ".xls";
            }

            if (reportType.Contains(".xsr"))
            {
                reportType = reportType.Replace(".xsr", "");
                reportFormat = ".doc";
            }

            var date = DateTime.Now.ToString("dd.MM.yy");
            var revNo = (rev == string.Empty) ? string.Empty : " REV " + rev;
            var reportName = UserInfo.ModelNumber + "-Phase " + number + reportType + revNo + " " + date + reportFormat;

            if (reportName.Contains(".xls"))
            {
                var leftPart = reportName.Substring(0, reportName.IndexOf(".xls"));
                var rightPart = reportName.Substring(reportName.IndexOf(".xls") + ".xls".Length);
                reportName = leftPart + rightPart;
            }

            reportName = reportName.Substring(0, reportName.IndexOf(reportFormat)) + reportFormat;

            var fileName = Path.Combine(reportsFolder, reportName);
            var tittle1 = "Phase " + number;
            var tittle2 = rev;

            Operation.CreateReportFromSelected(reportType, fileName, tittle1, tittle2, "");

            if (fileName.EndsWith(".doc"))
            {
                SaveDocFileAsPdf(fileName);
            }
        }
        private static void SaveDocFileAsPdf(string fileName)
        {
            var wordApp = new Word.Application();

            var docFile = wordApp.Documents.Open(fileName);
            docFile.Activate();

            docFile.PageSetup.TopMargin = wordApp.InchesToPoints(0.5f);
            docFile.PageSetup.BottomMargin = wordApp.InchesToPoints(0.5f);
            docFile.PageSetup.LeftMargin = wordApp.InchesToPoints(0.5f);
            docFile.PageSetup.RightMargin = wordApp.InchesToPoints(0.5f);

            var pdfPath = fileName.Replace(".doc", ".pdf");
            object misValue = System.Reflection.Missing.Value;

            docFile.SaveAs2(pdfPath, Word.WdSaveFormat.wdFormatPDF, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);

            docFile.Close();
            wordApp.Quit();
        }
    }
}