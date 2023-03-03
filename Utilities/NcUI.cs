using Tekla.Structures.Model.Operations;

namespace BourneIssueApp.Utilities
{
    public static class NcUI
    {
        public static void Export(string path)
        {
            Operation.CreateNCFilesFromSelected("Bourne NC file settings ", path + @"\");
        }
    }
}