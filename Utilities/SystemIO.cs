using System.IO;

namespace BourneIssueApp.Utilities
{
    public static class SystemIO
    {
        public static void CreateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public static void DeleteFolder(string path)
        {
            if (Directory.Exists(path))
            {
                var files = Directory.GetFiles(path);

                foreach (var file in files)
                {
                    File.SetAttributes(file, FileAttributes.Normal);
                    File.Delete(file);
                }

                Directory.Delete(path, false);
            }
        }

        public static void DeleteFolderIfEmpty(string path)
        {
            if (Directory.Exists(path))
            {
                var files = Directory.GetFiles(path);

                if (files.Length == 0)
                {
                    Directory.Delete(path, false);
                }
            }
        }

        public static void CopyFiles(string source, string destination)
        {
            if (!Directory.Exists(source))
            {
                return;
            }

            var directoryInfo = new DirectoryInfo(source);
            var files = directoryInfo.GetFiles();

            foreach (var file in files)
            {
                file.CopyTo(Path.Combine(destination, file.Name), true);
            }
        }

        public static void CreateFolderSuperseded(string path)
        {
            if (!Directory.Exists(path))
            {
                return;
            }

            var files = Directory.GetFiles(path);
            if (files.Length == 0)
            {
                return;
            }

            var FileRevisionExists = false;
            foreach (var file in files)
            {
                if (file.Contains("_") || file.ToUpper().Contains(" REV ") && !file.ToUpper().Contains("LOG.TXT"))
                {
                    if (file.ToUpper().Contains("LOG.TXT"))
                    {
                        continue;
                    }

                    FileRevisionExists = true;
                }
            }

            var supersededFolderPath = Path.Combine(path, "Superseded");
            if (FileRevisionExists)
            {
                CreateFolder(supersededFolderPath);
            }
        }
    }
}