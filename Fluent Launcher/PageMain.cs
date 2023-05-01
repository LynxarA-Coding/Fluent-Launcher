using Fluent_Launcher.BackgroundClasses;
using Fluent_Launcher.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
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
        private Localization _localization = new Localization(); // Localization class instance

        /*
        [ MAIN METHOD ]
        */

        // Perform action when the form is loaded
        private void PageMain_Load(object sender, EventArgs e)
        {
            UpdateUI();
            // Copying the instance of the main form
            Main main = (Main)this.Owner;

            string path = main._installPath; // Path to Steam (saved)

            if (path != "")
            {
                tbFolder.Text = path; // Set the path to the textbox
                _isSteamFolderValid = true; // Set the Steam folder as valid
            }

            pnlButtons.Location = new Point((this.Width - pnlButtons.Width) / 2, pnlButtons.Location.Y); // Center the buttons panel
            lblUninstallDisclaimer.Location = new Point((this.Width - lblUninstallDisclaimer.Width) / 2, lblUninstallDisclaimer.Location.Y); // Center the uninstall disclaimer label
        }

        /*
        [ Language Setters ]
        */

        // UI Updater
        public void UpdateUI()
        {
            // Initializing component and resources
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PageMain));

            // Getting culture info
            Main main = (Main)this.Owner;
            CultureInfo culture = main._currentCulture;

            // Changing the language
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            resources.ApplyResources(this, "$this", culture);

            // Updating the UI
            btnFolderSelect.Text = resources.GetString("btnFolderSelect.Text", culture);
            btnInstall.Text = resources.GetString("btnInstall.Text", culture);
            btnInstall.Font = resources.GetObject("btnInstall.Font", culture) as Font;
            btnUninstall.Text = resources.GetString("btnUninstall.Text", culture);
            lblUninstallDisclaimer.Text = resources.GetString("lblUninstallDisclaimer.Text", culture);
            lblUninstallDisclaimer.Location = new Point((this.Width - lblUninstallDisclaimer.Width) / 2, lblUninstallDisclaimer.Location.Y);
            lblUninstallPrompt.Text = resources.GetString("lblUninstallPrompt.Text", culture);
            lblUninstallPrompt.Location = new Point((pnlUninstallPrompt.Width - lblUninstallPrompt.Width) / 2, lblUninstallPrompt.Location.Y);
            btnUninstallYes.Text = resources.GetString("btnUninstallYes.Text", culture);
            btnUninstallNo.Text = resources.GetString("btnUninstallNo.Text", culture);
            cbShadow.Location = new Point((this.Width - cbShadow.Width) / 2, cbShadow.Location.Y);
        }

        /*
        [ UI Events ]
        */

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
            Main main = (Main)this.Owner;
            CultureInfo culture = main._currentCulture;

            // If Steam folder is not valid, show error message and stop installation
            if (!_isSteamFolderValid)
            {
                // Show localized error
                MessageBox.Show(_localization.Localized["FolderNotValid"][culture.ToString()], _localization.Localized["ErrorTitle"][culture.ToString()], MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // If prequisites are not met, show error message and stop installation
            if (!_setup.PrequisitesCheck())
            {
                MessageBox.Show(_localization.Localized["NotEnoughFiles"][culture.ToString()], _localization.Localized["ErrorTitle"][culture.ToString()], MessageBoxButtons.OK, MessageBoxIcon.Error);

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

            // Start installation
            Installation installation = new Installation();

            // If Shadow patch is selected
            if (cbShadow.Checked)
            {
                // Copy patch files
                installation.Install($"{mainDir}/Files/Shadow", $"{tbFolder.Text}/");
            }
            else
            {
                // Copy main files
                installation.Main($"{mainDir}/Files/Main/{versionName}", $"{tbFolder.Text}/skins", versionName);

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
                else if (main._installOptionsState["Layout:Sidebar Text"])
                {
                    // Install Sidebar + Text
                    installation.Install($"{mainDir}/Files/Options/Client Layouts/Sidebar Text", $"{tbFolder.Text}/skins/{versionName}");
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
            }

            // Enable install button back
            btnInstall.Enabled = true;

            // Show success message
            MessageBox.Show(_localization.Localized["SuccessInstalled"][culture.ToString()], _localization.Localized["SuccessTitle"][culture.ToString()], MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Uninstall button click event
        private void btnUninstall_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.Owner;
            CultureInfo culture = main._currentCulture;

            // If Steam folder is not valid, show error message and stop uninstall process
            if (!_isSteamFolderValid)
            {
                // Show localized error
                MessageBox.Show(_localization.Localized["FolderNotValid"][culture.ToString()], _localization.Localized["ErrorTitle"][culture.ToString()], MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            Installation installation = new Installation();

            if (cbShadow.Checked)
            {
                // uninstall Shadow Patch
                installation.Uninstall($"{tbFolder.Text}/steamui");
                installation.UninstallFile($"{tbFolder.Text}/", "libcrypto-3.dll");
                installation.UninstallFile($"{tbFolder.Text}/", "libcurl.dll");
                installation.UninstallFile($"{tbFolder.Text}/", "User32.dll");
                installation.UninstallFile($"{tbFolder.Text}/", "User32.dll");
                installation.UninstallFile($"{tbFolder.Text}/", "zlib1.dll");
            }
            else
            {
                // uninstall everything from the skin folder
                installation.Uninstall($"{tbFolder.Text}/skins/{versionName}");

                // If SFP is installed, uninstalling dark friends list and library
                if (main._isPatched)
                {
                    // Uninstall dark library if exist
                    installation.Uninstall($"{tbFolder.Text}/steamui");

                    // Uninstall dark friends list if exist
                    installation.UninstallFile($"{tbFolder.Text}/clientui/", "friends.custom.css");
                    installation.UninstallFile($"{tbFolder.Text}/clientui/", "ofriends.custom.css");

                    // Notify the user that skin is uninstalled
                    MessageBox.Show(_localization.Localized["SuccessDeletedSFP"][culture.ToString()], _localization.Localized["SuccessTitle"][culture.ToString()],
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (!main._isPatched)
            {
                // Notify the user that skin is uninstalled
                MessageBox.Show(_localization.Localized["SuccessDeleted"][culture.ToString()], _localization.Localized["SuccessTitle"][culture.ToString()],
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        /*
        [ Prompt Events ]
        */
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

        // Uninstall disclaimer label click event
        private void lblUninstallDisclaimer_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.Owner;
            // Show localized message
            CultureInfo culture = main._currentCulture;

            MessageBox.Show(_localization.Localized["UninstallPrompt"][culture.ToString()], lblUninstallDisclaimer.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbShadow_CheckedChanged(object sender, EventArgs e)
        {
            Main main = (Main)this.Owner;
            // Show localized message
            CultureInfo culture = main._currentCulture;

            // If checked, show prompt
            if (cbShadow.Checked)
            {
                DialogResult result = MessageBox.Show(_localization.Localized["ShadowPrompt"][culture.ToString()], "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No)
                {
                    cbShadow.Checked = false;
                }
                else
                {
                    // Show File Selection
                    FileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "*.exe|*.exe";
                    openFileDialog.Title = "Select Steam Shortcut";
                    openFileDialog.ShowDialog();

                    if (openFileDialog.FileName != "")
                    {
                        // Get the path to the selected file.
                        string exePath = openFileDialog.FileName;

                        // Create a WshShell object.
                        IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();

                        // Get the shortcut file path.
                        string shortcutPath = Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                            Path.GetFileNameWithoutExtension(exePath) + ".lnk");

                        // Get the shortcut object.
                        IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutPath);

                        // Modify the launch arguments for the shortcut.
                        shortcut.Arguments = "-cef-enable-debugging";

                        // Save the changes to the shortcut file.
                        shortcut.Save();
                    }
                }
            }
        }
    }
}
