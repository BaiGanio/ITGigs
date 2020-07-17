using System;
using System.IO;
using System.Linq;

namespace RemoveFilesAndFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Path of the root folder to start the search from */
            string rootPath = @"E:\TeamKepler\BGAPI";// Console.ReadLine();

            Console.Write("Enter folder names separated by a space ' ' which you would like to be removed: ");
            string[] folderNamesToDelete = new string[] { "bin", "obj" };// Console.ReadLine().Split(' ');

            RecursiveDelete(rootPath, folderNamesToDelete, false);
            Console.WriteLine("Done!");
        }
        private static void RecursiveDelete(string folderName, string[] folderNamesToDelete, bool deleteAll)
        {
            DirectoryInfo rootFolderInstance = new DirectoryInfo(folderName);
            var subFolders = rootFolderInstance.GetDirectories();
            if (deleteAll)
            {
                var allFiles = rootFolderInstance.GetFiles();
                foreach (var file in allFiles)
                {
                    File.SetAttributes(file.FullName, FileAttributes.Normal);
                    file.Delete();
                }

                foreach (var folder in subFolders)
                {
                    RecursiveDelete(folder.FullName, folderNamesToDelete, true);
                }

                rootFolderInstance.Delete();
            }
            else
            {
                foreach (var folder in subFolders)
                {
                    RecursiveDelete(folder.FullName, folderNamesToDelete, false);
                }

                if (folderNamesToDelete.Any(n => n.ToLower() == rootFolderInstance.Name))
                {
                    rootFolderInstance.Attributes = FileAttributes.Normal;
                    RecursiveDelete(rootFolderInstance.FullName, folderNamesToDelete, true);
                }
            }
        }
    }
}
