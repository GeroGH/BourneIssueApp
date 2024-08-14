using System;
using System.IO;
using System.Text.RegularExpressions;
using Tekla.Structures.Model;

namespace BourneIssueApp.Classes
{
    public static class UserInfo
    {
        public static string Initials { get; set; }
        public static string MainFolder { get; set; }
        public static string ModelFolder { get; set; }
        public static string ModelNumber { get; set; }

        static UserInfo()
        {
            Initials = GetUserInitials();

            var model = new Model();
            ModelFolder = model.GetInfo().ModelPath;

            ModelNumber = model.GetInfo().ModelName.Replace(".db1", "");
            var patern = @"[a-zA-Z]?\d{4,8}\s{0,1}?-?\d*";
            var match = Regex.Match(ModelNumber, patern).ToString();

            if (match != string.Empty)
            {
                ModelNumber = match;
            }

            MainFolder = Path.Combine(@"C:\Exports Tekla " + Initials, "Model " + ModelNumber);
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