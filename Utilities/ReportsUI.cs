using System;
using System.IO;
using BourneIssueApp.Classes;
using Tekla.Structures.Model.Operations;

namespace BourneIssueApp.Utilities
{
    internal static class ReportsUI
    {
        public static void ExportAssemblyReports(string rev, string reportsFolder, int number)
        {
            ExportReport("-BEL-Assembly-List.xsr", rev, reportsFolder, number);
            ExportReport("-BEL-Strumis-Upload.xls", rev, reportsFolder, number);

            ExportReport("-BP-Assembly-List.xsr", rev, reportsFolder, number);
            ExportReport("-BP-Fitting-List.xsr", rev, reportsFolder, number);
        }

        public static void ExportBoltReports(string rev, string reportsFolder, int number)
        {
            ExportReport("-BEL-Bolt-Summary-Site-List With Comments.xsr", rev, reportsFolder, number);
            ExportReport("-BEL-Bolt-Assembly-List.xsr", rev, reportsFolder, number);

            ExportReport("-BP-Full-Bolt-Summary-List.xsr", rev, reportsFolder, number);
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
            var fileName = Path.Combine(reportsFolder, reportName);
            var tittle1 = "Phase " + number;
            var tittle2 = rev;


            Operation.CreateReportFromSelected(reportType, fileName, tittle1, tittle2, "");
        }
    }
}