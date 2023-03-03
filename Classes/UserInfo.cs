using System;
using System.IO;
using Tekla.Structures.Model;

namespace BourneIssueApp.Classes
{
    public static class UserInfo
    {
        public static string Initials { get; set; }
        public static string MainFolder { get; set; }
        public static string TempIfcExportFolder { get; set; }
        public static string TempBswxExportFolder { get; set; }
        public static string ModelFolder { get; set; }
        public static string ModelNumber { get; set; }

        static UserInfo()
        {
            Initials = GetUserInitials();

            MainFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Drawings");

            TempIfcExportFolder = Path.Combine(@"C:\Exports Tekla " + Initials, "IFC Files");
            TempBswxExportFolder = Path.Combine(@"C:\Exports Tekla " + Initials, "BSWX Files");

            var model = new Model();
            ModelFolder = model.GetInfo().ModelPath;
            ModelNumber = model.GetInfo().ModelName.Substring(0, 4);
        }

        public static string GetUserInitials()
        {
            var userName = Environment.UserName;
            var firstName = userName.Split('.')[0];
            var secondName = userName.Split('.')[1];
            var initials = char.ToUpper(firstName[0]).ToString() + char.ToUpper(secondName[0]).ToString();
            return initials;
        }
    }
}