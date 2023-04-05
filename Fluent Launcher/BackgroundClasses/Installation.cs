using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Launcher.BackgroundClasses
{
    public class Installation
    {
        // Recursive function to copy a directory and all its contents
        private static void CopyDirectory(string sourceDir, string destinationDir, bool overwrite)
        {
            // Get the subdirectories for the specified directory
            DirectoryInfo sourceDirectory = new DirectoryInfo(sourceDir);
            if (!Directory.Exists(destinationDir))
            {
                Directory.CreateDirectory(destinationDir);
            }

            // Copy each file into the new directory
            foreach (FileInfo file in sourceDirectory.GetFiles())
            {
                string destinationFile = Path.Combine(destinationDir, file.Name);
                file.CopyTo(destinationFile, overwrite);
            }

            // Copy each subdirectory using recursion
            foreach (DirectoryInfo subDir in sourceDirectory.GetDirectories())
            {
                string destinationSubDir = Path.Combine(destinationDir, subDir.Name);
                CopyDirectory(subDir.FullName, destinationSubDir, overwrite);
            }
        }

        // Recursive function to delete a directory and all its contents
        private static void DeleteDirectory(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                // If there are subdirectories
                foreach (string subDirPath in Directory.GetDirectories(directoryPath))
                {
                    // Recursively call this function to delete files within the subdirectories
                    DeleteDirectory(subDirPath);
                }

                // Delete all files in the directory
                foreach (string filePath in Directory.GetFiles(directoryPath))
                {
                    File.Delete(filePath);
                }

                // Delete the directory itself
                Directory.Delete(directoryPath, true);
            }
        }

        // Main installation function for the skin
        public void Main(string urlFrom, string urlTo, string skinName)
        {
            // if there is no skins folder inside Steam, create one
            if (!Directory.Exists(urlTo))
            {
                Directory.CreateDirectory(urlTo);
            }

            // delete files inside directory
            foreach (string file in Directory.GetFiles(urlTo))
            {
                File.Delete(file);
            }

            // Copy main files
            urlTo = urlTo + $"/{skinName}";
            CopyDirectory(urlFrom, urlTo, true);
        }

        // Universal installation of any module
        public void Install(string urlFrom, string urlTo)
        {
            CopyDirectory(urlFrom, urlTo, true);
        }

        // Universal uninstallation of any module (folder)
        public void Uninstall(string urlFrom)
        {
            DeleteDirectory(urlFrom);
        }
    }
}
