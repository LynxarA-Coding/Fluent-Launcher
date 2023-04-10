using System;
using System.Diagnostics;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Drawing;

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
                    // If not patched, uncheck the checkbox
                    if (cbExtraLibrary.Checked && !main._isPatched)
                    {
                        cbExtraLibrary.Checked = false;
                        DialogResult result = MessageBox.Show("You need to patch Steam to use this feature. Do you want to patch Steam now?", "Patch Steam", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            Process.Start("https://github.com/PhantomGamers/SFP");
                        }
                    }
                    else if (cbExtraLibrary.Checked && main._isPatched)
                    {
                        main._installOptionsState["Extra:Dark Library"] = cbExtraLibrary.Checked;
                    }
                }
                else if (name == "cbExtraFriends")
                {
                    // If not patched, uncheck the checkbox
                    if (cbExtraFriends.Checked && !main._isPatched)
                    {
                        cbExtraFriends.Checked = false;
                        DialogResult result = MessageBox.Show("You need to patch Steam to use this feature. Do you want to patch Steam now?", "Patch Steam", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            Process.Start("https://github.com/PhantomGamers/SFP");
                        }
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
