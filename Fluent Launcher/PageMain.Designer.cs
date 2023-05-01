namespace Fluent_Launcher
{
    partial class PageMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageMain));
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnInstall = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnUninstall = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnFolderSelect = new Guna.UI2.WinForms.Guna2Button();
            this.tbFolder = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlUninstallPrompt = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUninstallNo = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnUninstallYes = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblUninstallPrompt = new System.Windows.Forms.Label();
            this.lblUninstallDisclaimer = new System.Windows.Forms.Label();
            this.cbShadow = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pnlButtons.SuspendLayout();
            this.pnlUninstallPrompt.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnInstall);
            this.pnlButtons.Controls.Add(this.btnSettings);
            this.pnlButtons.Controls.Add(this.btnUninstall);
            resources.ApplyResources(this.pnlButtons, "pnlButtons");
            this.pnlButtons.Name = "pnlButtons";
            // 
            // btnInstall
            // 
            this.btnInstall.BorderRadius = 15;
            this.btnInstall.CheckedState.Parent = this.btnInstall;
            this.btnInstall.CustomImages.Parent = this.btnInstall;
            this.btnInstall.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            resources.ApplyResources(this.btnInstall, "btnInstall");
            this.btnInstall.ForeColor = System.Drawing.Color.White;
            this.btnInstall.HoverState.Parent = this.btnInstall;
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.ShadowDecoration.Parent = this.btnInstall;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BorderRadius = 15;
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = global::Fluent_Launcher.Properties.Resources.fluent_settings;
            this.btnSettings.ImageSize = new System.Drawing.Size(80, 40);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.BorderRadius = 15;
            this.btnUninstall.CheckedState.Parent = this.btnUninstall;
            this.btnUninstall.CustomImages.Parent = this.btnUninstall;
            this.btnUninstall.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this.btnUninstall, "btnUninstall");
            this.btnUninstall.ForeColor = System.Drawing.Color.White;
            this.btnUninstall.HoverState.Parent = this.btnUninstall;
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.ShadowDecoration.Parent = this.btnUninstall;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnFolderSelect
            // 
            this.btnFolderSelect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnFolderSelect.BorderRadius = 6;
            this.btnFolderSelect.BorderThickness = 1;
            this.btnFolderSelect.CheckedState.Parent = this.btnFolderSelect;
            this.btnFolderSelect.CustomImages.Parent = this.btnFolderSelect;
            this.btnFolderSelect.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnFolderSelect, "btnFolderSelect");
            this.btnFolderSelect.ForeColor = System.Drawing.Color.Black;
            this.btnFolderSelect.HoverState.Parent = this.btnFolderSelect;
            this.btnFolderSelect.Name = "btnFolderSelect";
            this.btnFolderSelect.ShadowDecoration.Parent = this.btnFolderSelect;
            this.btnFolderSelect.Click += new System.EventHandler(this.btnFolderSelect_Click);
            // 
            // tbFolder
            // 
            this.tbFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.tbFolder.BorderRadius = 6;
            this.tbFolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFolder.DefaultText = "";
            this.tbFolder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFolder.DisabledState.Parent = this.tbFolder;
            this.tbFolder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFolder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFolder.FocusedState.Parent = this.tbFolder;
            this.tbFolder.ForeColor = System.Drawing.Color.Black;
            this.tbFolder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbFolder.HoverState.Parent = this.tbFolder;
            resources.ApplyResources(this.tbFolder, "tbFolder");
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.PasswordChar = '\0';
            this.tbFolder.PlaceholderText = "STEAM FOLDER";
            this.tbFolder.ReadOnly = true;
            this.tbFolder.SelectedText = "";
            this.tbFolder.ShadowDecoration.Parent = this.tbFolder;
            // 
            // pnlUninstallPrompt
            // 
            this.pnlUninstallPrompt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.pnlUninstallPrompt.BorderRadius = 15;
            this.pnlUninstallPrompt.BorderThickness = 2;
            this.pnlUninstallPrompt.Controls.Add(this.btnUninstallNo);
            this.pnlUninstallPrompt.Controls.Add(this.btnUninstallYes);
            this.pnlUninstallPrompt.Controls.Add(this.lblUninstallPrompt);
            resources.ApplyResources(this.pnlUninstallPrompt, "pnlUninstallPrompt");
            this.pnlUninstallPrompt.Name = "pnlUninstallPrompt";
            this.pnlUninstallPrompt.ShadowDecoration.Parent = this.pnlUninstallPrompt;
            // 
            // btnUninstallNo
            // 
            this.btnUninstallNo.BorderRadius = 15;
            this.btnUninstallNo.CheckedState.Parent = this.btnUninstallNo;
            this.btnUninstallNo.CustomImages.Parent = this.btnUninstallNo;
            this.btnUninstallNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this.btnUninstallNo, "btnUninstallNo");
            this.btnUninstallNo.ForeColor = System.Drawing.Color.White;
            this.btnUninstallNo.HoverState.Parent = this.btnUninstallNo;
            this.btnUninstallNo.Name = "btnUninstallNo";
            this.btnUninstallNo.ShadowDecoration.Parent = this.btnUninstallNo;
            this.btnUninstallNo.Click += new System.EventHandler(this.btnUninstallNo_Click);
            // 
            // btnUninstallYes
            // 
            this.btnUninstallYes.BorderRadius = 15;
            this.btnUninstallYes.CheckedState.Parent = this.btnUninstallYes;
            this.btnUninstallYes.CustomImages.Parent = this.btnUninstallYes;
            this.btnUninstallYes.FillColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.btnUninstallYes, "btnUninstallYes");
            this.btnUninstallYes.ForeColor = System.Drawing.Color.White;
            this.btnUninstallYes.HoverState.Parent = this.btnUninstallYes;
            this.btnUninstallYes.Name = "btnUninstallYes";
            this.btnUninstallYes.ShadowDecoration.Parent = this.btnUninstallYes;
            this.btnUninstallYes.Click += new System.EventHandler(this.btnUninstallYes_Click);
            // 
            // lblUninstallPrompt
            // 
            resources.ApplyResources(this.lblUninstallPrompt, "lblUninstallPrompt");
            this.lblUninstallPrompt.ForeColor = System.Drawing.Color.White;
            this.lblUninstallPrompt.Name = "lblUninstallPrompt";
            // 
            // lblUninstallDisclaimer
            // 
            resources.ApplyResources(this.lblUninstallDisclaimer, "lblUninstallDisclaimer");
            this.lblUninstallDisclaimer.ForeColor = System.Drawing.Color.White;
            this.lblUninstallDisclaimer.Name = "lblUninstallDisclaimer";
            this.lblUninstallDisclaimer.Click += new System.EventHandler(this.lblUninstallDisclaimer_Click);
            // 
            // cbShadow
            // 
            resources.ApplyResources(this.cbShadow, "cbShadow");
            this.cbShadow.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbShadow.CheckedState.BorderRadius = 2;
            this.cbShadow.CheckedState.BorderThickness = 0;
            this.cbShadow.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbShadow.ForeColor = System.Drawing.Color.White;
            this.cbShadow.Name = "cbShadow";
            this.cbShadow.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cbShadow.UncheckedState.BorderRadius = 2;
            this.cbShadow.UncheckedState.BorderThickness = 0;
            this.cbShadow.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cbShadow.UseVisualStyleBackColor = true;
            this.cbShadow.CheckedChanged += new System.EventHandler(this.cbShadow_CheckedChanged);
            // 
            // PageMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.cbShadow);
            this.Controls.Add(this.lblUninstallDisclaimer);
            this.Controls.Add(this.pnlUninstallPrompt);
            this.Controls.Add(this.btnFolderSelect);
            this.Controls.Add(this.tbFolder);
            this.Controls.Add(this.pnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageMain";
            this.Load += new System.EventHandler(this.PageMain_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlUninstallPrompt.ResumeLayout(false);
            this.pnlUninstallPrompt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private Guna.UI2.WinForms.Guna2TileButton btnInstall;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2TileButton btnUninstall;
        private Guna.UI2.WinForms.Guna2Button btnFolderSelect;
        private Guna.UI2.WinForms.Guna2TextBox tbFolder;
        private Guna.UI2.WinForms.Guna2Panel pnlUninstallPrompt;
        private Guna.UI2.WinForms.Guna2TileButton btnUninstallNo;
        private Guna.UI2.WinForms.Guna2TileButton btnUninstallYes;
        private System.Windows.Forms.Label lblUninstallPrompt;
        private System.Windows.Forms.Label lblUninstallDisclaimer;
        private Guna.UI2.WinForms.Guna2CheckBox cbShadow;
    }
}