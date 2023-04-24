using System;
using System.Diagnostics;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.ComponentModel;
using System.Globalization;
using System.Threading;

namespace Fluent_Launcher
{
    public partial class PageSettings : Form
    {
        public PageSettings()
        {
            InitializeComponent();
        }

        /*
        [ MAIN METHOD ]
        */
        private void PageSettings_Load(object sender, EventArgs e)
        {
            // UI Updater
            UpdateUI();
            pnlPatch.Location = new Point((this.Width - pnlPatch.Width) / 2, pnlPatch.Location.Y);
            cbSFP.Location = new Point((pnlPatch.Width - cbSFP.Width) / 2, cbSFP.Location.Y);
            LoadSettings();
        }

        /*
        [ Language Setters ]
        */

        // UI Updater
        public void UpdateUI()
        {
            // Initializing component and resources
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PageSettings));

            // Getting culture info
            Main main = (Main)this.Owner;
            CultureInfo culture = main._currentCulture;

            // Changing the language
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            resources.ApplyResources(this, "$this", culture);

            // Updating the UI
            lblPageTitle.Text = resources.GetString("lblPageTitle.Text");
            btnBack.Text = resources.GetString("btnBack.Text");
            lblButtonsTitle.Text = resources.GetString("lblButtonsTitle.Text");
            lblLayoutTitle.Text = resources.GetString("lblLayoutTitle.Text");
            lblOverlayTitle.Text = resources.GetString("lblOverlayTitle.Text");
            lblExtraTitle.Text = resources.GetString("lblExtraTitle.Text");
            cbSFP.Text = resources.GetString("cbSFP.Text");
            cbSFP.Location = new Point((pnlPatch.Width - cbSFP.Width) / 2, cbSFP.Location.Y);
            rbButtonDefault.Text = resources.GetString("rbButtonDefault.Text");
            rbButtonUsername.Text = resources.GetString("rbButtonUsername.Text");
            cbLayoutSidebar.Text = resources.GetString("cbLayoutSidebar.Text");
            cbLayoutSidebarText.Text = resources.GetString("cbLayoutSidebarText.Text");
            object LayoutSidebarLocation = resources.GetObject("cbLayoutSidebarText.Location");
            cbLayoutSidebarText.Location = (Point)LayoutSidebarLocation;
            rbLayoutCompact.Text = resources.GetString("rbLayoutCompact.Text");
            rbLayoutEssentials.Text = resources.GetString("rbLayoutEssentials.Text");
            rbLayoutEssentialsAlt.Text = resources.GetString("rbLayoutEssentialsAlt.Text");
            rbOverlayTop.Text = resources.GetString("rbOverlayTop.Text");
            rbOverlayBottom.Text = resources.GetString("rbOverlayBottom.Text");
            rbOverlayLeftAlign.Text = resources.GetString("rbOverlayLeftAlign.Text");
            rbOverlayLeftBar.Text = resources.GetString("rbOverlayLeftBar.Text");
            cbExtraLibrary.Text = resources.GetString("cbExtraLibrary.Text");
            cbExtraFriends.Text = resources.GetString("cbExtraFriends.Text");
        }

        /*
        [ Options Events ]
        */

        // Setting the Options states
        private void LoadSettings()
        {
            // Copying the instance of the main form
            Main main = (Main)Owner;

            // Load settings
            // Layout restore
            cbLayoutSidebar.Checked = main._installOptionsState["Layout:Sidebar"];
            cbLayoutSidebarText.Checked = main._installOptionsState["Layout:Sidebar Text"];
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
            Main main = (Main)Owner;
            CultureInfo culture = main._currentCulture;
            // Initializing component and resources
            ComponentResourceManager resources = new ComponentResourceManager(typeof(PageSettings));
            resources.ApplyResources(this, "$this", culture);

            DialogResult result = DialogResult.None;
            result = MessageBox.Show(resources.GetString("PatchSteamError", culture),
                resources.GetString("PatchSteamTitle", culture), MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Path to the SFP Patcher
                string sfpPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Files\\SFP\\SFP_UI.exe";

                // Check if SFP is launched already
                if (Process.GetProcessesByName("SFP_UI").Length == 0)
                {
                    // Make a prompt with explanation
                    MessageBox.Show(resources.GetString("PatchSteamGuide", culture), resources.GetString("PatchSteamGuideTitle", culture), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Launch SFP
                    Process.Start(sfpPath);
                }
                else
                {
                    // SFP is already launched error
                    MessageBox.Show(resources.GetString("SFPLaunched", culture),
                        resources.GetString("ErrorTitle", culture), MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Change Sidebar style
                if (name == "cbLayoutSidebar" && cb.Checked)
                {
                    cbLayoutSidebarText.Checked = false;
                    main._installOptionsState["Layout:Sidebar"] = cbLayoutSidebar.Checked;
                }
                else if (name == "cbLayoutSidebarText" && cb.Checked)
                {
                    cbLayoutSidebar.Checked = false;
                    main._installOptionsState["Layout:Sidebar Text"] = cbLayoutSidebarText.Checked;
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
                if (name == "rbOverlayTop")
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

        /*
        [ UI Events ]
        */

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
            // Copying the instance of the main form to access the _isPatched variable
            Main main = (Main)Owner;
            main._isPatched = cbSFP.Checked;
        }
    }
}
