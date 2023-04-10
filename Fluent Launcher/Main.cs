using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace Fluent_Launcher
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // Options Dictionary
        private readonly Dictionary<string, string[]> _installOptions = new Dictionary<string, string[]>
        {
            { "AccountButton", new[] { "Default", "Username" } },
            {"Layout", new[] {"Compact", "Essentials", "Essentials Alternative", "Sidebar"}},
            {"CustomOverlay", new[] {"Default", "Bottom", "Left Align", "Left Bar"}},
            {"Extra", new []{"Dark Library", "Dark Friends List"}}
        };

        /*
        [ All Initializers ]
        */
        
        public Dictionary<string, bool> _installOptionsState = new Dictionary<string, bool>(); // State of the options
        public string _installPath = ""; // Path to Steam (saved)
        public bool _isPatched = false; // Is the Steam patched?

        /*
        [ Page Handler ]
        */

        // Page handler
        public void ChangePage(int num)
        {
            // Based on the passed number, change the page
            switch (num)
            {
                default:
                    // Clearing controls (changing the page)
                    pnlPage.Controls.Clear();

                    // New instance of the page
                    PageMain page = new PageMain() {Owner = this};

                    // Page settings to make it appear and work
                    page.TopLevel = false;
                    page.Dock = DockStyle.Fill;

                    // Add the page to the panel
                    pnlPage.Controls.Add(page);
                    page.Show();
                    break;
                case 1:
                    // Clearing controls (changing the page)
                    pnlPage.Controls.Clear();

                    // New instance of the page
                    PageSettings page1 = new PageSettings() { Owner = this};

                    // Page settings to make it appear and work
                    page1.TopLevel = false;
                    page1.Dock = DockStyle.Fill;

                    // Add the page to the panel
                    pnlPage.Controls.Add(page1);
                    page1.Show();
                    break;
            }
        }

        // About menu
        // Copyright text click event
        private void lblCopyright_Click(object sender, EventArgs e)
        {
            // Make the page invisible
            pnlPage.Visible = false;

            // Make the about page visible
            pnlAbout.Enabled = true;
            pnlAbout.Visible = true;

            // Center the panel
            pnlAbout.Location = new Point((this.Width - pnlAbout.Width) / 2, (this.Height - pnlAbout.Height) / 2 + 10);

            // Bring the about page to the front
            pnlAbout.BringToFront();

            // Center the labels and picture box
            foreach (var control in pnlAbout.Controls)
            {
                if (control is Label)
                {
                    // center the label
                    Label label = (Label)control;
                    label.Location = new Point((pnlAbout.Width - label.Width) / 2, label.Location.Y);
                }
                else if (control is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)control;

                    // check if button is logo
                    if (pictureBox.Name == "pbAboutLogo")
                    {
                        // center the logo
                        pictureBox.Location = new Point((pnlAbout.Width - pictureBox.Width) / 2, pictureBox.Location.Y);
                    }
                }
            }
        }
        private void lblAboutLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/LynxarA-Coding/Fluent-Launcher");
        }

        // Close button (about page) click event
        private void btnAboutClose_Click(object sender, EventArgs e)
        {
            // Make the panel invisible
            pnlAbout.Enabled = false;
            pnlAbout.Visible = false;

            // Send the panel to the back
            pnlAbout.SendToBack();

            // Make the page visible
            pnlPage.Visible = true;
        }

        /*
        [ MAIN METHODS ]
        */
        private void Main_Load(object sender, EventArgs e)
        {
            // Initialize the options state
            _installOptionsState = new Dictionary<string, bool>();
            foreach (var group in _installOptions.Keys)
            {
                foreach (var option in _installOptions[group])
                {
                    _installOptionsState.Add($"{group}:{option}", false);
                }
            }

            // Center elements
            lblCopyright.Location = new Point((this.Width - lblCopyright.Width) / 2, lblCopyright.Location.Y);

            ChangePage(0);
        }

        // Close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
