using Tekla.Structures.Model.Operations;

namespace BourneIssueApp.Utilities
{
    public static class NcUI
    {
        public static void Export(string path, NCFileType nCFileType)
        {
            if (nCFileType == NCFileType.Plates)
            {
                Operation.CreateNCFilesFromSelected("Bourne NC file settings - Fittings", path + @"\");
            }

            if (nCFileType == NCFileType.Profiles)
            {
                Operation.CreateNCFilesFromSelected("Bourne NC file settings - Profiles", path + @"\");
            }
        }
    }
}