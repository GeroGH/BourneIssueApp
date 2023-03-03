using Tekla.Structures;

namespace BourneIssueApp.Utilities
{
    public static class DrawingsUI
    {
        public static void SelectDrawings(DrawingType drawingType)
        {
            var oldString = string.Empty;
            var newString = string.Empty;

            if (drawingType == DrawingType.Assembly)
            {
                oldString = "11";
                newString = "albl_Assembly_drawings";
            }

            if (drawingType == DrawingType.Fitting)
            {
                oldString = "10";
                newString = "albl_single_part_drawings";
            }

            var oldStyleDrawingList = MacroBuilderCompatibilityHelper.IsOldDrawingListInUse();

            if (oldStyleDrawingList)
            {
                var macroBuilder = new MacroBuilder();
                macroBuilder.Callback("gdr_menu_select_active_draw", "", "main_frame");
                macroBuilder.ValueChange("Drawing_selection", "diaSavedSearchOptionMenu", oldString);
                macroBuilder.PushButton("dia_draw_filter_by_parts", "Drawing_selection");
                macroBuilder.Run();
                MacroBuilder.WaitForMacroToRun();
                TeklaStructures.ExecuteScript("akit.PopupCallback(\"diaSelectAllCB\", \"\", \"Drawing_selection\", \"dia_draw_select_list\");");
            }

            if (!oldStyleDrawingList)
            {
                var IsWpfSupported = false;
                var builder = new MacroBuilder();
                var helper = new MacroBuilderCompatibilityHelper(builder);

                if (MacroBuilderCompatibilityHelper.CreateMacroCodeForDocumentManager())
                {
                    IsWpfSupported = true;
                }

                if (helper.IsSupportedPushWpfButtonMethod())
                {
                    IsWpfSupported = true;
                }

                if (helper.IsSupportedSelectWpfListViewItemsByNameMethod())
                {
                    IsWpfSupported = true;
                }

                if (helper.IsSupportedSelectWpfDataGridRowsMethod())
                {
                    IsWpfSupported = true;
                }

                if (IsWpfSupported)
                {
                    builder.WpfCommandRepositoryCommand("Drawing.DrawingList");
                    helper.InvokePushWpfButtonMethod("DocumentManager.MainWindow", new[] { "AID_DOCMAN_ShowAllDocuments" });
                    helper.InvokePushWpfButtonMethod("DocumentManager.MainWindow", new[] { "AID_DOCMAN_ButtonSelectDrawings" });
                    helper.InvokeSelectWpfListViewItemsByNameMethod("DocumentManager.MainWindow", new[] { "AID_DOCMAN_CategoryList" }, new[] { newString });
                    builder.Run();
                    MacroBuilder.WaitForMacroToRun();
                }
            }
        }
    }
}