using System;
using System.IO;

namespace CSharp_lab4_Shcherbatiuk.Tools
{
    internal static class FileFolderHelper
    {
        private static readonly string AppDataPath =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        internal static readonly string AppFolderPath =
            Path.Combine(AppDataPath, "Shcherbatiuk04");

        internal static readonly string StorageFilePath =
            Path.Combine(AppFolderPath, "ListShcherbatiuk.cskma");

        internal static bool CreateFolderAndCheckFileExistance(string filePath)
        {
            var file = new FileInfo(filePath);
            return file.CreateFolderAndCheckFileExistance();
        }

        internal static bool CreateFolderAndCheckFileExistance(this FileInfo file)
        {
            if (file.Directory != null && !file.Directory.Exists)
            {
                file.Directory.Create();
            }
            return file.Exists;
        }
    }
}