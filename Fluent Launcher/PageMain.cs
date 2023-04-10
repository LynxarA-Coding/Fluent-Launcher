using Fluent_Launcher.BackgroundClasses;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Fluent_Launcher
{
    public partial class PageMain : Form
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private bool _isSteamFolderValid; // true if Steam folder is valid, false if not
        private string versionName; // Version name of the skin to use in directory path
        private Setup _setup = new Setup(); // Setup class instance

        // Perform action when the form is loaded
        private void PageMain_Load(object sender, EventArgs e)
        {
            // Copying the instance of the main form
            Main main = (Main)this.Owner;

            string path = main._installPath; // Path to Steam (saved)

            if (path != "")
            {
                tbFolder.Text = path; // Set the path to the textbox
                _isSteamFolderValid = true ; // Set the Steam folder as valid
            }
        }

        // Select button click event
        private void btnFolderSelect_Click(object sender, EventArgs e)
        {
            // open folder browser dialog
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();

            string url = folderBrowserDialog.SelectedPath;
            // set the selected path to the textbox
            tbFolder.Text = url;

            // check if the selected folder is valid
            if (!_setup.IsSteamFolderValid(url))
            {
                // if not, do not allow installation
                tbFolder.Text = string.Empty;
                _isSteamFolderValid = false;
            }
            else
            {
                // if yes, allow installation
                _isSteamFolderValid = true;

                // Save the path to the Main form
                Main main = (Main)this.Owner;
                main._installPath = url;
            }
        }

        // Install button click event
        private void btnInstall_Click(object sender, EventArgs e)
        {
            // If Steam folder is not valid, show error message and stop installation
            if (!_isSteamFolderValid)
            {
                MessageBox.Show("The Steam Folder is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If prequisites are not met, show error message and stop installation
            if (!_setup.PrequisitesCheck())
            {
                MessageBox.Show("There are no files for the Fluent installation. Please, download the program again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // get version name
            string mainDir = Path.GetDirectoryName(Application.ExecutablePath);
            versionName = Directory.GetDirectories($"{mainDir}/Files/Main")[0].Split('\\').Last();

            // kill Steam app if it's running
            Process[] steam = Process.GetProcessesByName("Steam");
            foreach (Process process in steam)
            {
                process.Kill();
            }

            // Disable install button
            btnInstall.Enabled = false;
            btnInstall.Text = "INSTALLING";

            // Start installation
            Installation installation = new Installation();

            // Copy main files
            installation.Main($"{mainDir}/Files/Main/{versionName}", $"{tbFolder.Text}/skins", versionName);

            // Initializing main for settings check
            Main main = (Main)this.Owner;
            // Button Option check
            if (main._installOptionsState["AccountButton:Default"])
            {
                // Install default button
                installation.Install($"{mainDir}/Files/Options/Account Button Extra/1", $"{tbFolder.Text}/skins/{versionName}");
            }
            else if (main._installOptionsState["AccountButton:Username"])
            {
                // Install username button
                installation.Install($"{mainDir}/Files/Options/Account Button Extra/2", $"{tbFolder.Text}/skins/{versionName}");
            }

            // Layout option check
            if (main._installOptionsState["Layout:Compact"])
            {
                // install Compact
                installation.Install($"{mainDir}/Files/Options/Client Layouts/Compact", $"{tbFolder.Text}/skins/{versionName}");
            }
            else if (main._installOptionsState["Layout:Essentials"])
            {
                // install Essentials
                installation.Install($"{mainDir}/Files/Options/Client Layouts/Essentials", $"{tbFolder.Text}/skins/{versionName}");
            }
            else if (main._installOptionsState["Layout:Essentials Alternative"])
            {
                // install Essentials Alternative
                installation.Install($"{mainDir}/Files/Options/Client Layouts/Essentials Alternative", $"{tbFolder.Text}/skins/{versionName}");
            }
            if (main._installOptionsState["Layout:Sidebar"])
            {
                // install Sidebar
                installation.Install($"{mainDir}/Files/Options/Client Layouts/Sidebar", $"{tbFolder.Text}/skins/{versionName}");
            }

            // Overlay option check
            if (main._installOptionsState["CustomOverlay:Default"])
            {
                // install Default Overlay
                installation.Install($"{mainDir}/Files/Options/Overlay Options/Default", $"{tbFolder.Text}/skins/{versionName}");
            }
            else if (main._installOptionsState["CustomOverlay:Bottom"])
            {
                // install Bottom Overlay
                installation.Install($"{mainDir}/Files/Options/Overlay Options/Bottom", $"{tbFolder.Text}/skins/{versionName}");
            }
            else if (main._installOptionsState["CustomOverlay:Left Align"])
            {
                // install Left Align Overlay
                installation.Install($"{mainDir}/Files/Options/Overlay Options/Left Align", $"{tbFolder.Text}/skins/{versionName}");
            }
            else if (main._installOptionsState["CustomOverlay:Left Bar"])
            {
                // install Left Bar Overlay
                installation.Install($"{mainDir}/Files/Options/Overlay Options/Left Bar", $"{tbFolder.Text}/skins/{versionName}");
            }

            // Extra options check
            // Dark Library option
            if (main._installOptionsState["Extra:Dark Library"])
            {
                // install Extra Library
                installation.Install($"{mainDir}/Files/Options/Extra/Library", $"{tbFolder.Text}/steamui");
            }
            // Dark Friends option
            if (main._installOptionsState["Extra:Dark Friends List"])
            {
                // install Extra Friends
                installation.Install($"{mainDir}/Files/Options/Extra/Friends", $"{tbFolder.Text}/clientui");
            }

            // Enable install button back
            btnInstall.Text = "INSTALL";
            btnInstall.Enabled = true;

            // Show success message
            MessageBox.Show("Fluent for Steam was installed successfully!", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Uninstall button click event
        private void btnUninstall_Click(object sender, EventArgs e)
        {
            // If Steam folder is not valid, show error message and stop uninstall process
            if (!_isSteamFolderValid)
            {
                MessageBox.Show("The Steam Folder is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Do the prompt and exit if the answer is no
            if (!isUninstalling())
            {
                return;
            }

            // kill Steam app
            Process[] steam = Process.GetProcessesByName("Steam");
            foreach (Process process in steam)
            {
                process.Kill();
            }

            // get version name
            string mainDir = Path.GetDirectoryName(Application.ExecutablePath);
            versionName = Directory.GetDirectories($"{mainDir}/Files/Main")[0].Split('\\').Last();

            // uninstall everything from the skin folder
            Installation installation = new Installation();
            installation.Uninstall($"{tbFolder.Text}/skins/{versionName}");

            MessageBox.Show("Fluent For Steam has been uninstalled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool isUninstalling()
        {
            if (!pnlUninstallPrompt.Enabled)
            {
                // Make the page invisible
                pnlButtons.Visible = false;

                // Make the prompt visible
                pnlUninstallPrompt.Enabled = true;
                pnlUninstallPrompt.Visible = true;

                // Center the prompt
                pnlUninstallPrompt.Location = new Point((this.Width - pnlUninstallPrompt.Width) / 2, (this.Height - pnlUninstallPrompt.Height) / 2);

                // Bring prompt to front
                pnlUninstallPrompt.BringToFront();
            }

            // Do stuff while prompt is working
            while (uninstallingPromptResult == "NONE")
            {
                Application.DoEvents();
            }

            // Make the panel invisible
            pnlUninstallPrompt.Enabled = false;
            pnlUninstallPrompt.Visible = false;

            // Send the panel to the back
            pnlUninstallPrompt.SendToBack();

            // Make the page visible
            pnlButtons.Visible = true;

            // Handle the positive result
            if (uninstallingPromptResult == "YES")
            {
                // reset the result
                uninstallingPromptResult = "NONE";

                return true;
            }

            // reset the result
            uninstallingPromptResult = "NONE";

            return false;
        }

        private string uninstallingPromptResult = "NONE"; // Prompt result, none if no result yet

        // Prompt buttons click events
        private void btnUninstallYes_Click(object sender, EventArgs e)
        {
            uninstallingPromptResult = "YES";
        }

        private void btnUninstallNo_Click(object sender, EventArgs e)
        {
            uninstallingPromptResult = "NO";
        }

        // Settings button click event
        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Copying instance of the Main
            Main main = (Main)this.Owner;
            main.ChangePage(1);
        }
    }
}
