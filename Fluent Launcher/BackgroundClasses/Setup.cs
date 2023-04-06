﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_Launcher.BackgroundClasses
{
    public class Setup
    {
        public bool IsSteamFolderValid(string folderUrl)
        {
            // if there is no steam.exe in the selected folder, return false
            if (!File.Exists($"{folderUrl}/steam.exe"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private readonly string[] _hierarchyFolders = { "Account Button Extra", "Client Layouts", "Extra", "Overlay Options" };

        public bool PrequisitesCheck()
        {
            // checking if folder exists
            if (!Directory.Exists("Files/Main"))
            {
                return false;
            }

            // check if all folders exist
            foreach (string folder in _hierarchyFolders)
            {
                if (!Directory.Exists($"Files/Options/{folder}"))
                {
                    return false;
                }
            } 

            // check if folder has directories in it
            if (Directory.GetDirectories("Files").Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
