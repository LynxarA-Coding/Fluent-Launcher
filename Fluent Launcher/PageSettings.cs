using System;
using System.Diagnostics;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Fluent_Launcher
{
    public partial class PageSettings : Form
    {
        public PageSettings()
        {
            InitializeComponent();
        }

        private void PageSettings_Load(object sender, EventArgs e)
        {
            pnlPatch.Location = new Point((this.Width - pnlPatch.Width) / 2, pnlPatch.Location.Y);
            cbSFP.Location = new Point((pnlPatch.Width - cbSFP.Width) / 2, cbSFP.Location.Y);
            LoadSettings();
        }

        private void LoadSettings()
        {
            // Copying the instance of the main form
            Main main = (Main)Owner;

            // Load settings
            // Layout restore
            cbLayoutSidebar.Checked = main._installOptionsState["Layout:Sidebar"];
            rbLayoutCompact.Checked = main._installOptionsState["Layout:Compact"];
            rbLayoutEssentials.Checked = main._installOptionsState["Layout:Essentials"];
            rbLayoutEssentialsAlt.Checked = main._installOptionsState["Layout:Essentials Alternative"];

            // Extras restore
            cbExtraLibrary.Checked = main._installOptionsState["Extra:Dark Library"];
            cbExtraFriends.Checked = main._installOptionsState["Extra:Dark Friends List"];

            // Buttons restore
            rbButtonDefault.Checked = main._installOptionsState["AccountButton:Default"];
            rbButtonUsername.Checked = main._installOptionsState["AccountButton:Username"];

            // Overlay restore
            rbOverlayTop.Checked = main._installOptionsState["CustomOverlay:Default"];
            rbOverlayBottom.Checked = main._installOptionsState["CustomOverlay:Bottom"];
            rbOverlayLeftAlign.Checked = main._installOptionsState["CustomOverlay:Left Align"];
            rbOverlayLeftBar.Checked = main._installOptionsState["CustomOverlay:Left Bar"];

            // SFP restore
            cbSFP.Checked = main._isPatched;
        }

        // SFP Launch and guide
        private void LaunchSFP()
        {
            DialogResult result = MessageBox.Show("You need to patch Steam to use this feature. Do you want to patch Steam now? (This action will start SFP app)", "Patch Steam", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Path to the SFP Patcher
                string sfpPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Files\\SFP\\SFP_UI.exe";

                // Check if SFP is launched already
                if (Process.GetProcessesByName("SFP_UI").Length == 0)
                {
                    // Make a prompt with explanation
                    MessageBox.Show("1. When app is loaded, click \"Patch\"\n2. Wait for the patch to end\n3. Close Steam if it was opened\n\nClick \"OK\" in this prompt to launch SFP", "SFP Patch Guide", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Launch SFP
                    Process.Start(sfpPath);
                }
                else
                {
                    // SFP is already launched error
                    MessageBox.Show("SFP is already launched. Please patch Steam or close SFP and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Fired when a checkbox or radiobutton is checked or unchecked
        private void cbCheckedChanged(object sender, EventArgs e)
        {
            // Check if sender is a checkbox or radiobutton
            if (sender is Guna2CheckBox cb)
            {
                Main main = (Main)Owner;
                string name = cb.Name;

                // Layout handler
                if (name == "cbLayoutSidebar")
                {
                    main._installOptionsState["Layout:Sidebar"] = cb.Checked;

                    // Check if the checkbox of Compact layout is checked, if not, check it and uncheck the other two
                    if (cb.Checked)
                    {
                        rbLayoutCompact.Checked = cb.Checked;
                        main._installOptionsState["Layout:Compact"] = cb.Checked;
                        main._installOptionsState["Layout:Essentials"] = !cb.Checked;
                        main._installOptionsState["Layout:Essentials Alternative"] = !cb.Checked;
                    }

                    return;
                }

                if (name == "cbExtraLibrary")
                {
                    // If not patched, uncheck the checkbox + launch SFP prompt
                    if (cbExtraLibrary.Checked && !main._isPatched)
                    {
                        cbExtraLibrary.Checked = false;
                        
                        // Launch SFP prompt
                        LaunchSFP();
                    }
                    else if (cbExtraLibrary.Checked && main._isPatched)
                    {
                        main._installOptionsState["Extra:Dark Library"] = cbExtraLibrary.Checked;
                    }
                }
                else if (name == "cbExtraFriends")
                {
                    // If not patched, uncheck the checkbox + launch SFP prompt
                    if (cbExtraFriends.Checked && !main._isPatched)
                    {
                        cbExtraFriends.Checked = false;

                        // Launch SFP prompt
                        LaunchSFP();
                        
                    }
                    else if (cbExtraFriends.Checked && main._isPatched)
                    {
                        main._installOptionsState["Extra:Dark Friends List"] = cbExtraFriends.Checked;
                    }
                }
            }
            else if (sender is Guna2RadioButton rb)
            {
                Main main = (Main)Owner;
                string name = rb.Name;

                // Button settings handler
                if (name == "rbButtonDefault")
                {
                    main._installOptionsState["AccountButton:Default"] = rb.Checked;
                    main._installOptionsState["AccountButton:Username"] = !rb.Checked;
                }
                else if (name == "rbButtonUsername")
                {
                    main._installOptionsState["AccountButton:Username"] = rb.Checked;
                    main._installOptionsState["AccountButton:Default"] = !rb.Checked;
                }

                // Overlay settings handler
                if (name == "rbOverlayDefault")
                {
                    main._installOptionsState["CustomOverlay:Default"] = rb.Checked;
                    main._installOptionsState["CustomOverlay:Bottom"] = !rb.Checked;
                    main._installOptionsState["CustomOverlay:Left Align"] = !rb.Checked;
                    main._installOptionsState["CustomOverlay:Left Bar"] = !rb.Checked;
                }
                else if (name == "rbOverlayBottom")
                {
                    main._installOptionsState["CustomOverlay:Bottom"] = rb.Checked;
                    main._installOptionsState["CustomOverlay:Default"] = !rb.Checked;
                    main._installOptionsState["CustomOverlay:Left Align"] = !rb.Checked;
                    main._installOptionsState["CustomOverlay:Left Bar"] = !rb.Checked;
                }
                else if (name == "rbOverlayLeftAlign")
                {
                    main._installOptionsState["CustomOverlay:Left Align"] = rb.Checked;
                    main._installOptionsState["CustomOverlay:Default"] = !rb.Checked;
                    main._installOptionsState["CustomOverlay:Bottom"] = !rb.Checked;
                    main._installOptionsState["CustomOverlay:Left Bar"] = !rb.Checked;
                }
                else if (name == "rbOverlayLeftBar")
                {
                    main._installOptionsState["CustomOverlay:Left Bar"] = rb.Checked;
                    main._installOptionsState["CustomOverlay:Default"] = !rb.Checked;
                    main._installOptionsState["CustomOverlay:Bottom"] = !rb.Checked;
                    main._installOptionsState["CustomOverlay:Left Align"] = !rb.Checked;
                }

                // Layout settings handler
                if (name == "rbLayoutCompact")
                {
                    main._installOptionsState["Layout:Compact"] = rb.Checked;
                    main._installOptionsState["Layout:Essentials"] = !rb.Checked;
                    main._installOptionsState["Layout:Essentials Alternative"] = !rb.Checked;
                }
                else if (name == "rbLayoutEssentials")
                {
                    main._installOptionsState["Layout:Essentials"] = rb.Checked;
                    main._installOptionsState["Layout:Compact"] = !rb.Checked;
                    main._installOptionsState["Layout:Essentials Alternative"] = !rb.Checked;
                }
                else if (name == "rbLayoutEssentialsAlt")
                {
                    main._installOptionsState["Layout:Essentials Alternative"] = rb.Checked;
                    main._installOptionsState["Layout:Compact"] = !rb.Checked;
                    main._installOptionsState["Layout:Essentials"] = !rb.Checked;
                }
            }
        }

        // Back button click event
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Copying the instance of the main form
            Main main = (Main)Owner;
            main.ChangePage(0);
        }

        private void rbCheckChanged(object sender, EventArgs e)
        {
            // Check if checked is true
            Guna2RadioButton rb = (Guna2RadioButton)sender;

            if (rb.Checked)
            {
                rb.Checked = false;
            }
        }

        private void cbSFP_CheckedChanged(object sender, EventArgs e)
        {
            Main main = (Main)Owner;
            main._isPatched = cbSFP.Checked;
        }
    }
}
