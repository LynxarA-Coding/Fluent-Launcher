using System;
using System.IO;
using System.Linq;
using Fluent_Launcher.BackgroundClasses;
using System.Windows.Forms;
using System.Diagnostics;

namespace Fluent_Launcher
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // Close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool _isSteamFolderValid; // true if Steam folder is valid, false if not
        private bool _isPatched; // true if patched, false if not
        private Setup _setup = new Setup(); // Setup class instance
        private string versionName; // Version name of the skin to use in directory path

        // Select Folder button
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
            }
        }

        // These events are used to make the checkboxes work as radio buttons (only 1 can be toggled true)
        // This button toggles Username button option for the installation
        private void cbUsernameButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cbButtonUsername.Checked)
            {
                cbButtonDefault.Checked = !cbButtonUsername.Checked;
            }
        }

        // This button toggles Default button option for the installation
        private void cbDefaultButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cbButtonDefault.Checked)
            {
                cbButtonUsername.Checked = !cbButtonDefault.Checked;
            }
        }

        // These events are used to make the checkboxes work as radio buttons (only 1 can be toggled true)
        // This button toggles Compact layout option for the installation
        private void cbLayoutCompact_CheckedChanged(object sender, EventArgs e)
        {
            // toggle other checkboxes if this one is checked
            if (cbLayoutCompact.Checked)
            {
                cbLayoutEssentials.Checked = !cbLayoutCompact.Checked;
                cbLayoutEssentialsAlt.Checked = !cbLayoutCompact.Checked;
            }
        }

        // This button toggles Essentials layout option for the installation
        private void cbLayoutEssentials_CheckedChanged(object sender, EventArgs e)
        {
            // toggle other checkboxes if this one is checked
            if (cbLayoutEssentials.Checked)
            {
                cbLayoutCompact.Checked = !cbLayoutEssentials.Checked;
                cbLayoutEssentialsAlt.Checked = !cbLayoutEssentials.Checked;
            }
        }

        // This button toggles Essentials Alternative layout option for the installation
        private void cbLayoutEssentialsAlt_CheckedChanged(object sender, EventArgs e)
        {
            // toggle other checkboxes if this one is checked
            if (cbLayoutEssentialsAlt.Checked)
            {
                cbLayoutCompact.Checked = !cbLayoutEssentialsAlt.Checked;
                cbLayoutEssentials.Checked = !cbLayoutEssentialsAlt.Checked;
            }
        }

        // This button toggles Sidebar layout option for the installation
        private void cbLayoutSidebar_CheckedChanged(object sender, EventArgs e)
        {
            // If sidebar is checked
            if (cbLayoutSidebar.Checked && !cbLayoutCompact.Checked)
            {
                // check a compact layout checkbox since sidebar automatically includes compact layout
                cbLayoutCompact.Checked = true;
            }
        }

        // This button toggles Extra Library option for the installation
        private void cbExtraLibrary_CheckedChanged(object sender, EventArgs e)
        {
            if (!_isPatched && cbExtraLibrary.Checked)
            {
                MessageBox.Show("You need to patch the Friend List first! Download an app and press \"Patch\" inside. The link was copied to the clipboard", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clipboard.SetText("https://github.com/PhantomGamers/SFP");
                cbExtraLibrary.Checked = false;
            }
        }

        // This button toggles Extra Friends option for the installation
        private void cbExtraFriends_CheckedChanged(object sender, EventArgs e)
        {
            if (!_isPatched && cbExtraFriends.Checked)
            {
                MessageBox.Show("You need to patch the Friend List first! Download an app and press \"Patch\" inside. The link was copied to the clipboard", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clipboard.SetText("https://github.com/PhantomGamers/SFP");
                cbExtraFriends.Checked = false;
            }
        }

        // This button toggles Patch Confirmation
        private void cbSFPPatched_CheckedChanged(object sender, EventArgs e)
        {
            _isPatched = cbSFPPatched.Checked;
            cbExtraLibrary.Enabled = cbSFPPatched.Checked;
            cbExtraFriends.Enabled = cbSFPPatched.Checked;

            // If SFP is not patched, uncheck the Extra Library and Extra Friends checkboxes
            if (!cbSFPPatched.Checked)
            {
                cbExtraLibrary.Checked = false;
                cbExtraFriends.Checked = false;
            }
        }

        // Click on text event to send user to the website of SFP
        private void lblExtra_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to open the link to the SFP website?", "SFP Website", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Process.Start("https://github.com/PhantomGamers/SFP");
            }
        }

        // Install button event
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

            // Button Option check
            if (cbButtonDefault.Checked)
            {
                // Install default button
                installation.Install($"{mainDir}/Files/Options/Account Button Extra/1", $"{tbFolder.Text}/skins/{versionName}");
            }
            else if (cbButtonUsername.Checked)
            {
                // Install username button
                installation.Install($"{mainDir}/Files/Options/Account Button Extra/2", $"{tbFolder.Text}/skins/{versionName}");
            }

            // Layout option check
            if (cbLayoutCompact.Checked)
            {
                // install Compact
                installation.Install($"{mainDir}/Files/Options/Client Layouts/Compact", $"{tbFolder.Text}/skins/{versionName}");
            }
            else if (cbLayoutEssentials.Checked)
            {
                // install Essentials
                installation.Install($"{mainDir}/Files/Options/Client Layouts/Essentials", $"{tbFolder.Text}/skins/{versionName}");
            }
            else if (cbLayoutEssentialsAlt.Checked)
            {
                // install Essentials Alternative
                installation.Install($"{mainDir}/Files/Options/Client Layouts/Essentials Alternative", $"{tbFolder.Text}/skins/{versionName}");
            }
            if (cbLayoutSidebar.Checked)
            {
                // install Sidebar
                installation.Install($"{mainDir}/Files/Options/Client Layouts/Sidebar", $"{tbFolder.Text}/skins/{versionName}");
            }

            // Overlay option check
            if (cbOverlay.Checked)
            {
                // install Custom Overlay
                installation.Install($"{mainDir}/Files/Options/Overlay Options", $"{tbFolder.Text}/skins/{versionName}");
            }

            // Extra options check
            // Dark Library option
            if (cbExtraLibrary.Checked && cbSFPPatched.Checked)
            {
                // install Extra Library
                installation.Install($"{mainDir}/Files/Options/Extra/Library", $"{tbFolder.Text}/steamui");
            }
            // Dark Friends option
            if (cbExtraFriends.Checked && cbSFPPatched.Checked)
            {
                // install Extra Friends
                installation.Install($"{mainDir}/Files/Options/Extra/Friends", $"{tbFolder.Text}/clientui");
            }

            // Enable install button back
            btnInstall.Text = "INSTALL";
            btnInstall.Enabled = true;

            // Final message depending on the extra installation options
            if (!_isPatched && (cbExtraLibrary.Checked || cbExtraFriends.Checked))
            {
                MessageBox.Show("Fluent For Steam has been installed successfully! However, the Extra options were skipped due to unchecked Patch", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fluent For Steam has been installed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Uninstall button event
        private void btnUninstall_Click(object sender, EventArgs e)
        {
            // If Steam folder is not valid, show error message and stop uninstall process
            if (!_isSteamFolderValid)
            {
                MessageBox.Show("The Steam Folder is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Open Steam button event
        private void btnOpenSteam_Click(object sender, EventArgs e)
        {
            // If Steam folder is not valid, show error message and stop opening Steam
            if (!_isSteamFolderValid)
            {
                MessageBox.Show("The Steam Folder is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if steam is already open
            bool isSteamLaunched = false;
            
            Process[] steam = Process.GetProcessesByName("Steam");
            foreach (Process process in steam)
            {
                isSteamLaunched = true;
                break;
            }

            // launch steam if its not
            if (!isSteamLaunched)
            {
                Process.Start($"{tbFolder.Text}/steam.exe");
            }
        }

        // Copyright text click event
        private void lblCopyright_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to open the link to the LynxarA's Github profile?", "My Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Process.Start("https://github.com/LynxarA-Coding");
            }
        }
    }
}
