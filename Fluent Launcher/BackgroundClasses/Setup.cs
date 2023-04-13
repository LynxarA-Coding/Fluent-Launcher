using Newtonsoft.Json.Linq;
using System;
using System.IO;
using static Guna.UI2.HtmlRenderer.Adapters.RGraphicsPath;
using System.Net.NetworkInformation;
using System.Net;
using System.Windows.Forms;
using System.Xml.Schema;

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

            // check if SFP exists
            if (!Directory.Exists($"Files/SFP"))
            {
                return false;
            }

            // check if folder has directories in it
            if (Directory.GetDirectories("Files").Length == 0)
            {
                return false;
            }

            return true;
        }

        public bool VersionCheck(string version)
        {
            // Check if internet is on
            try
            {
                using (var ping = new Ping())
                {
                    var reply = ping.Send("google.com");
                }
            }
            catch (Exception)
            {
                // Internet is off, show error message
                MessageBox.Show("Internet is off. Please turn it on to check for updates.", "Internet is off", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                // Get the latest version from Github
                var apiUrl = $"https://api.github.com/repos/LynxarA-CodinG/Fluent-Launcher/releases/latest";
                var request = WebRequest.Create(apiUrl) as HttpWebRequest; // Create a request
                request.UserAgent = "Mozilla/5.0"; // Required by Github API

                // Get the response
                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    // Check if the response is OK
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        MessageBox.Show("There was an error while checking for updates. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    using (var stream = response.GetResponseStream())
                    {
                        // Get the latest version from Github
                        var json = JObject.Parse(new StreamReader(stream).ReadToEnd());
                        string tag = json["tag_name"].ToString();

                        // Compare the versions
                        if (tag != version && tag[tag.Length - 1] > version[version.Length - 1])
                        {
                            MessageBox.Show($"There is a new version available: {tag}. Please download it from the Github page.", "New version available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }

                        return true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error while checking for updates. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
