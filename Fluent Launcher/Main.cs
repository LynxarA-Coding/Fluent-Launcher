using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using static Guna.UI2.HtmlRenderer.Adapters.RGraphicsPath;
using System.Net;
using System.Xml.Linq;
using Fluent_Launcher.BackgroundClasses;
using System.Threading;
using System.Globalization;
using System.ComponentModel;
using Fluent_Launcher.Properties;

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
            {"Layout", new[] {"Compact", "Essentials", "Essentials Alternative", "Sidebar", "Sidebar Text"}},
            {"CustomOverlay", new[] {"Default", "Bottom", "Left Align", "Left Bar"}},
            {"Extra", new []{"Dark Library", "Dark Friends List"}}
        };

        /*
        [ MAIN METHOD ]
        */

        private readonly string appVersion = "v1.1.4"; // Current App version
        private void Main_Load(object sender, EventArgs e)
        {
            if (!_setup.VersionCheck(appVersion))
            {
                pnlPage.Enabled = false;
                pnlPage.Visible = false;
                return;
            }

            // Restore settings
            string language = Settings.Default["Language"].ToString();
            _currentCulture = new CultureInfo(language);
            if (language == "fr-FR")
            {
                cbLanguage.SelectedIndex = 2;
            }
            else if (language == "ru-RU")
            {
                cbLanguage.SelectedIndex = 1;
            }
            else if (language == "en-EN")
            {
                cbLanguage.SelectedIndex = 0;
            }

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

        /*
        [ All Initializers ]
        */

        private Setup _setup = new Setup(); // Setup class
        public Dictionary<string, bool> _installOptionsState = new Dictionary<string, bool>(); // State of the options
        public string _installPath = ""; // Path to Steam (saved)
        public bool _isPatched = false; // Is the Steam patched?

        /*
        [ Language Setters ]
        */

        public CultureInfo _currentCulture = Thread.CurrentThread.CurrentCulture; // Current language
        // Language update method
        private void UpdateUI(string lang)
        {
            // Initializing component and resources
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Main));

            // Changing the language
            _currentCulture = new CultureInfo(lang);
            Thread.CurrentThread.CurrentCulture = _currentCulture;
            Thread.CurrentThread.CurrentUICulture = _currentCulture;
            resources.ApplyResources(this, "$this", _currentCulture);

            // Updating the UI
            lblHeaderDiscl.Text = resources.GetString("lblHeaderDiscl.Text");
            lblAboutMadeby.Text = resources.GetString("lblAboutMadeby.Text");
            lblAboutMadeby.Location = new Point((pnlAbout.Width - lblAboutMadeby.Width) / 2, lblAboutMadeby.Location.Y);
            lblAboutDesignedby.Text = resources.GetString("lblAboutDesignedby.Text");
            lblAboutDesignedby.Location = new Point((pnlAbout.Width - lblAboutDesignedby.Width) / 2, lblAboutDesignedby.Location.Y);
            lblCopyright.Text = resources.GetString("lblCopyright.Text");
            lblCopyright.Location = new Point((this.Width - lblCopyright.Width) / 2, lblCopyright.Location.Y);

            // Update UI of all pages
            foreach (var control in pnlPage.Controls)
            {
                if (control is PageMain)
                {
                    PageMain page = (PageMain)control;
                    page.UpdateUI();
                }
                else if (control is PageSettings)
                {
                    PageSettings page = (PageSettings)control;
                    page.UpdateUI();
                }
            }
        }

        // Language changed event
        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change the language
            if (cbLanguage.SelectedIndex == 0)
            {
                Settings.Default["Language"] = "en-EN";
                Settings.Default.Save();
                UpdateUI("en-EN");
            }
            else if (cbLanguage.SelectedIndex == 1)
            {
                Settings.Default["Language"] = "ru-RU";
                Settings.Default.Save();
                UpdateUI("ru-RU");
            }
            else if (cbLanguage.SelectedIndex == 2)
            {
                Settings.Default["Language"] = "fr-FR";
                Settings.Default.Save();
                UpdateUI("fr-FR");
            }
        }

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
                    PageMain page = new PageMain() { Owner = this };

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
                    PageSettings page1 = new PageSettings() { Owner = this };

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

        // Close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
