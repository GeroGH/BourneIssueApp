
namespace BourneIssueApp.Utilities
{
    using System.IO;
    using Tekla.Structures.Drawing;
    using Tekla.Structures.Model.Operations;
    public static class PrinterUI
    {
        public static void Print(string path, string printerName, ExecutionForm excutionForm, int phase)
        {
            var suffix = ".pdf";

            var printAttributes = new DPMPrinterAttributes();
            printAttributes.PrinterName = printerName;

            printAttributes.OutputType = DotPrintOutputType.PDF;
            printAttributes.ColorMode = DotPrintColor.BlackAndWhite;
            printAttributes.OpenFileWhenFinished = false;

            var handler = new DrawingHandler();
            var drawings = handler.GetDrawingSelector().GetSelected();

            if (drawings.GetSize() > 0)
            {
                SystemIO.CreateFolder(path);
            }

            drawings.SelectInstances = false;
            foreach (Drawing drawing in drawings)
            {
                var name = drawing.GetPlotFileNameExt(IncludeRevisionMarkEnum.ByFormatString);

                excutionForm.UpdateLabel($"Exporting Phase {phase}, Drawing {name} ");
                Operation.DisplayPrompt($"Exporting Phase {phase}, Drawing {name} ...");

                name += suffix;
                var fileName = Path.Combine(path, name);
                handler.PrintDrawing(drawing, printAttributes, fileName);
                handler.CloseActiveDrawing();
            }
        }
    }
}