namespace Fluent_Launcher
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeaderDiscl = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.elpsMain = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tbFolder = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFolderSelect = new Guna.UI2.WinForms.Guna2Button();
            this.cbButtonDefault = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbButtonUsername = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblButton = new System.Windows.Forms.Label();
            this.lblLayout = new System.Windows.Forms.Label();
            this.cbLayoutCompact = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbLayoutEssentials = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbLayoutEssentialsAlt = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbLayoutSidebar = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnInstall = new Guna.UI2.WinForms.Guna2TileButton();
            this.cbOverlay = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblOverlay = new System.Windows.Forms.Label();
            this.btnUninstall = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnOpenSteam = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblExtra = new System.Windows.Forms.Label();
            this.cbExtraLibrary = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbSFPPatched = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbExtraFriends = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeaderDiscl);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.pbLogo);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Parent = this.pnlHeader;
            this.pnlHeader.Size = new System.Drawing.Size(800, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderDiscl
            // 
            this.lblHeaderDiscl.AutoSize = true;
            this.lblHeaderDiscl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderDiscl.ForeColor = System.Drawing.Color.White;
            this.lblHeaderDiscl.Location = new System.Drawing.Point(66, 34);
            this.lblHeaderDiscl.Name = "lblHeaderDiscl";
            this.lblHeaderDiscl.Size = new System.Drawing.Size(532, 15);
            this.lblHeaderDiscl.TabIndex = 3;
            this.lblHeaderDiscl.Text = "This program is not an official \"Fluent for Steam\" Launcher. Be advised, it may h" +
    "ave critical bugs";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(62, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(151, 26);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Fluent Launcher";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Fluent_Launcher.Properties.Resources.fleuntuserdiscord;
            this.pbLogo.Location = new System.Drawing.Point(9, 5);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(50, 50);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Fluent_Launcher.Properties.Resources.cancel_white;
            this.btnClose.Location = new System.Drawing.Point(750, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.pnlHeader;
            // 
            // elpsMain
            // 
            this.elpsMain.BorderRadius = 15;
            this.elpsMain.TargetControl = this;
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
            this.tbFolder.Location = new System.Drawing.Point(9, 76);
            this.tbFolder.Name = "tbFolder";
            this.tbFolder.PasswordChar = '\0';
            this.tbFolder.PlaceholderText = "Steam Folder";
            this.tbFolder.ReadOnly = true;
            this.tbFolder.SelectedText = "";
            this.tbFolder.ShadowDecoration.Parent = this.tbFolder;
            this.tbFolder.Size = new System.Drawing.Size(636, 36);
            this.tbFolder.TabIndex = 1;
            // 
            // btnFolderSelect
            // 
            this.btnFolderSelect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnFolderSelect.BorderRadius = 6;
            this.btnFolderSelect.BorderThickness = 1;
            this.btnFolderSelect.CheckedState.Parent = this.btnFolderSelect;
            this.btnFolderSelect.CustomImages.Parent = this.btnFolderSelect;
            this.btnFolderSelect.FillColor = System.Drawing.Color.White;
            this.btnFolderSelect.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolderSelect.ForeColor = System.Drawing.Color.Black;
            this.btnFolderSelect.HoverState.Parent = this.btnFolderSelect;
            this.btnFolderSelect.Location = new System.Drawing.Point(650, 76);
            this.btnFolderSelect.Name = "btnFolderSelect";
            this.btnFolderSelect.ShadowDecoration.Parent = this.btnFolderSelect;
            this.btnFolderSelect.Size = new System.Drawing.Size(140, 36);
            this.btnFolderSelect.TabIndex = 2;
            this.btnFolderSelect.Text = "SELECT";
            this.btnFolderSelect.Click += new System.EventHandler(this.btnFolderSelect_Click);
            // 
            // cbButtonDefault
            // 
            this.cbButtonDefault.AutoSize = true;
            this.cbButtonDefault.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbButtonDefault.CheckedState.BorderRadius = 2;
            this.cbButtonDefault.CheckedState.BorderThickness = 0;
            this.cbButtonDefault.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbButtonDefault.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbButtonDefault.ForeColor = System.Drawing.Color.White;
            this.cbButtonDefault.Location = new System.Drawing.Point(9, 169);
            this.cbButtonDefault.Name = "cbButtonDefault";
            this.cbButtonDefault.Size = new System.Drawing.Size(168, 30);
            this.cbButtonDefault.TabIndex = 3;
            this.cbButtonDefault.Text = "Default Account";
            this.cbButtonDefault.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbButtonDefault.UncheckedState.BorderRadius = 2;
            this.cbButtonDefault.UncheckedState.BorderThickness = 0;
            this.cbButtonDefault.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbButtonDefault.UseVisualStyleBackColor = true;
            this.cbButtonDefault.CheckedChanged += new System.EventHandler(this.cbDefaultButton_CheckedChanged);
            // 
            // cbButtonUsername
            // 
            this.cbButtonUsername.AutoSize = true;
            this.cbButtonUsername.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbButtonUsername.CheckedState.BorderRadius = 2;
            this.cbButtonUsername.CheckedState.BorderThickness = 0;
            this.cbButtonUsername.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbButtonUsername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbButtonUsername.ForeColor = System.Drawing.Color.White;
            this.cbButtonUsername.Location = new System.Drawing.Point(9, 205);
            this.cbButtonUsername.Name = "cbButtonUsername";
            this.cbButtonUsername.Size = new System.Drawing.Size(197, 30);
            this.cbButtonUsername.TabIndex = 4;
            this.cbButtonUsername.Text = "Username + Money";
            this.cbButtonUsername.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbButtonUsername.UncheckedState.BorderRadius = 2;
            this.cbButtonUsername.UncheckedState.BorderThickness = 0;
            this.cbButtonUsername.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbButtonUsername.UseVisualStyleBackColor = true;
            this.cbButtonUsername.CheckedChanged += new System.EventHandler(this.cbUsernameButton_CheckedChanged);
            // 
            // lblButton
            // 
            this.lblButton.AutoSize = true;
            this.lblButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButton.ForeColor = System.Drawing.Color.White;
            this.lblButton.Location = new System.Drawing.Point(3, 124);
            this.lblButton.Name = "lblButton";
            this.lblButton.Size = new System.Drawing.Size(187, 33);
            this.lblButton.TabIndex = 5;
            this.lblButton.Text = "Account Button";
            // 
            // lblLayout
            // 
            this.lblLayout.AutoSize = true;
            this.lblLayout.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLayout.ForeColor = System.Drawing.Color.White;
            this.lblLayout.Location = new System.Drawing.Point(3, 242);
            this.lblLayout.Name = "lblLayout";
            this.lblLayout.Size = new System.Drawing.Size(90, 33);
            this.lblLayout.TabIndex = 5;
            this.lblLayout.Text = "Layout";
            // 
            // cbLayoutCompact
            // 
            this.cbLayoutCompact.AutoSize = true;
            this.cbLayoutCompact.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbLayoutCompact.CheckedState.BorderRadius = 2;
            this.cbLayoutCompact.CheckedState.BorderThickness = 0;
            this.cbLayoutCompact.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbLayoutCompact.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLayoutCompact.ForeColor = System.Drawing.Color.White;
            this.cbLayoutCompact.Location = new System.Drawing.Point(9, 287);
            this.cbLayoutCompact.Name = "cbLayoutCompact";
            this.cbLayoutCompact.Size = new System.Drawing.Size(107, 30);
            this.cbLayoutCompact.TabIndex = 5;
            this.cbLayoutCompact.Text = "Compact";
            this.cbLayoutCompact.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbLayoutCompact.UncheckedState.BorderRadius = 2;
            this.cbLayoutCompact.UncheckedState.BorderThickness = 0;
            this.cbLayoutCompact.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbLayoutCompact.UseVisualStyleBackColor = true;
            this.cbLayoutCompact.CheckedChanged += new System.EventHandler(this.cbLayoutCompact_CheckedChanged);
            // 
            // cbLayoutEssentials
            // 
            this.cbLayoutEssentials.AutoSize = true;
            this.cbLayoutEssentials.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbLayoutEssentials.CheckedState.BorderRadius = 2;
            this.cbLayoutEssentials.CheckedState.BorderThickness = 0;
            this.cbLayoutEssentials.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbLayoutEssentials.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLayoutEssentials.ForeColor = System.Drawing.Color.White;
            this.cbLayoutEssentials.Location = new System.Drawing.Point(9, 323);
            this.cbLayoutEssentials.Name = "cbLayoutEssentials";
            this.cbLayoutEssentials.Size = new System.Drawing.Size(113, 30);
            this.cbLayoutEssentials.TabIndex = 6;
            this.cbLayoutEssentials.Text = "Essentials";
            this.cbLayoutEssentials.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbLayoutEssentials.UncheckedState.BorderRadius = 2;
            this.cbLayoutEssentials.UncheckedState.BorderThickness = 0;
            this.cbLayoutEssentials.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbLayoutEssentials.UseVisualStyleBackColor = true;
            this.cbLayoutEssentials.CheckedChanged += new System.EventHandler(this.cbLayoutEssentials_CheckedChanged);
            // 
            // cbLayoutEssentialsAlt
            // 
            this.cbLayoutEssentialsAlt.AutoSize = true;
            this.cbLayoutEssentialsAlt.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbLayoutEssentialsAlt.CheckedState.BorderRadius = 2;
            this.cbLayoutEssentialsAlt.CheckedState.BorderThickness = 0;
            this.cbLayoutEssentialsAlt.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbLayoutEssentialsAlt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLayoutEssentialsAlt.ForeColor = System.Drawing.Color.White;
            this.cbLayoutEssentialsAlt.Location = new System.Drawing.Point(9, 359);
            this.cbLayoutEssentialsAlt.Name = "cbLayoutEssentialsAlt";
            this.cbLayoutEssentialsAlt.Size = new System.Drawing.Size(211, 30);
            this.cbLayoutEssentialsAlt.TabIndex = 7;
            this.cbLayoutEssentialsAlt.Text = "Essentials Alternative";
            this.cbLayoutEssentialsAlt.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbLayoutEssentialsAlt.UncheckedState.BorderRadius = 2;
            this.cbLayoutEssentialsAlt.UncheckedState.BorderThickness = 0;
            this.cbLayoutEssentialsAlt.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbLayoutEssentialsAlt.UseVisualStyleBackColor = true;
            this.cbLayoutEssentialsAlt.CheckedChanged += new System.EventHandler(this.cbLayoutEssentialsAlt_CheckedChanged);
            // 
            // cbLayoutSidebar
            // 
            this.cbLayoutSidebar.AutoSize = true;
            this.cbLayoutSidebar.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbLayoutSidebar.CheckedState.BorderRadius = 2;
            this.cbLayoutSidebar.CheckedState.BorderThickness = 0;
            this.cbLayoutSidebar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbLayoutSidebar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLayoutSidebar.ForeColor = System.Drawing.Color.White;
            this.cbLayoutSidebar.Location = new System.Drawing.Point(9, 395);
            this.cbLayoutSidebar.Name = "cbLayoutSidebar";
            this.cbLayoutSidebar.Size = new System.Drawing.Size(95, 30);
            this.cbLayoutSidebar.TabIndex = 8;
            this.cbLayoutSidebar.Text = "Sidebar";
            this.cbLayoutSidebar.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbLayoutSidebar.UncheckedState.BorderRadius = 2;
            this.cbLayoutSidebar.UncheckedState.BorderThickness = 0;
            this.cbLayoutSidebar.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbLayoutSidebar.UseVisualStyleBackColor = true;
            this.cbLayoutSidebar.CheckedChanged += new System.EventHandler(this.cbLayoutSidebar_CheckedChanged);
            // 
            // btnInstall
            // 
            this.btnInstall.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnInstall.BorderRadius = 15;
            this.btnInstall.CheckedState.Parent = this.btnInstall;
            this.btnInstall.CustomImages.Parent = this.btnInstall;
            this.btnInstall.FillColor = System.Drawing.Color.White;
            this.btnInstall.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstall.ForeColor = System.Drawing.Color.Black;
            this.btnInstall.HoverState.Parent = this.btnInstall;
            this.btnInstall.Location = new System.Drawing.Point(650, 298);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.ShadowDecoration.Parent = this.btnInstall;
            this.btnInstall.Size = new System.Drawing.Size(140, 140);
            this.btnInstall.TabIndex = 10;
            this.btnInstall.Text = "INSTALL";
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // cbOverlay
            // 
            this.cbOverlay.AutoSize = true;
            this.cbOverlay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbOverlay.CheckedState.BorderRadius = 2;
            this.cbOverlay.CheckedState.BorderThickness = 0;
            this.cbOverlay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbOverlay.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOverlay.ForeColor = System.Drawing.Color.White;
            this.cbOverlay.Location = new System.Drawing.Point(273, 169);
            this.cbOverlay.Name = "cbOverlay";
            this.cbOverlay.Size = new System.Drawing.Size(96, 30);
            this.cbOverlay.TabIndex = 9;
            this.cbOverlay.Text = "Overlay";
            this.cbOverlay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbOverlay.UncheckedState.BorderRadius = 2;
            this.cbOverlay.UncheckedState.BorderThickness = 0;
            this.cbOverlay.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbOverlay.UseVisualStyleBackColor = true;
            // 
            // lblOverlay
            // 
            this.lblOverlay.AutoSize = true;
            this.lblOverlay.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverlay.ForeColor = System.Drawing.Color.White;
            this.lblOverlay.Location = new System.Drawing.Point(267, 124);
            this.lblOverlay.Name = "lblOverlay";
            this.lblOverlay.Size = new System.Drawing.Size(194, 33);
            this.lblOverlay.TabIndex = 10;
            this.lblOverlay.Text = "Custom Overlay";
            // 
            // btnUninstall
            // 
            this.btnUninstall.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnUninstall.BorderRadius = 15;
            this.btnUninstall.CheckedState.Parent = this.btnUninstall;
            this.btnUninstall.CustomImages.Parent = this.btnUninstall;
            this.btnUninstall.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.btnUninstall.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUninstall.ForeColor = System.Drawing.Color.Black;
            this.btnUninstall.HoverState.Parent = this.btnUninstall;
            this.btnUninstall.Location = new System.Drawing.Point(505, 298);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.ShadowDecoration.Parent = this.btnUninstall;
            this.btnUninstall.Size = new System.Drawing.Size(140, 140);
            this.btnUninstall.TabIndex = 11;
            this.btnUninstall.Text = "UNINSTALL";
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnOpenSteam
            // 
            this.btnOpenSteam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.btnOpenSteam.BorderRadius = 15;
            this.btnOpenSteam.CheckedState.Parent = this.btnOpenSteam;
            this.btnOpenSteam.CustomImages.Parent = this.btnOpenSteam;
            this.btnOpenSteam.FillColor = System.Drawing.Color.White;
            this.btnOpenSteam.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSteam.ForeColor = System.Drawing.Color.Black;
            this.btnOpenSteam.HoverState.Parent = this.btnOpenSteam;
            this.btnOpenSteam.Location = new System.Drawing.Point(505, 169);
            this.btnOpenSteam.Name = "btnOpenSteam";
            this.btnOpenSteam.ShadowDecoration.Parent = this.btnOpenSteam;
            this.btnOpenSteam.Size = new System.Drawing.Size(283, 121);
            this.btnOpenSteam.TabIndex = 12;
            this.btnOpenSteam.Text = "OPEN STEAM";
            this.btnOpenSteam.Click += new System.EventHandler(this.btnOpenSteam_Click);
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtra.ForeColor = System.Drawing.Color.White;
            this.lblExtra.Location = new System.Drawing.Point(267, 242);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(232, 33);
            this.lblExtra.TabIndex = 5;
            this.lblExtra.Text = "Extra (requires SFP)";
            this.lblExtra.Click += new System.EventHandler(this.lblExtra_Click);
            // 
            // cbExtraLibrary
            // 
            this.cbExtraLibrary.AutoSize = true;
            this.cbExtraLibrary.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbExtraLibrary.CheckedState.BorderRadius = 2;
            this.cbExtraLibrary.CheckedState.BorderThickness = 0;
            this.cbExtraLibrary.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbExtraLibrary.Enabled = false;
            this.cbExtraLibrary.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtraLibrary.ForeColor = System.Drawing.Color.White;
            this.cbExtraLibrary.Location = new System.Drawing.Point(273, 287);
            this.cbExtraLibrary.Name = "cbExtraLibrary";
            this.cbExtraLibrary.Size = new System.Drawing.Size(135, 30);
            this.cbExtraLibrary.TabIndex = 9;
            this.cbExtraLibrary.Text = "Dark Library";
            this.cbExtraLibrary.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbExtraLibrary.UncheckedState.BorderRadius = 2;
            this.cbExtraLibrary.UncheckedState.BorderThickness = 0;
            this.cbExtraLibrary.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbExtraLibrary.UseVisualStyleBackColor = true;
            this.cbExtraLibrary.CheckedChanged += new System.EventHandler(this.cbExtraLibrary_CheckedChanged);
            // 
            // cbSFPPatched
            // 
            this.cbSFPPatched.AutoSize = true;
            this.cbSFPPatched.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbSFPPatched.CheckedState.BorderRadius = 2;
            this.cbSFPPatched.CheckedState.BorderThickness = 0;
            this.cbSFPPatched.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbSFPPatched.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSFPPatched.ForeColor = System.Drawing.Color.White;
            this.cbSFPPatched.Location = new System.Drawing.Point(505, 129);
            this.cbSFPPatched.Name = "cbSFPPatched";
            this.cbSFPPatched.Size = new System.Drawing.Size(238, 30);
            this.cbSFPPatched.TabIndex = 9;
            this.cbSFPPatched.Text = "I\'ve already patched SFP";
            this.cbSFPPatched.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbSFPPatched.UncheckedState.BorderRadius = 2;
            this.cbSFPPatched.UncheckedState.BorderThickness = 0;
            this.cbSFPPatched.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbSFPPatched.UseVisualStyleBackColor = true;
            this.cbSFPPatched.CheckedChanged += new System.EventHandler(this.cbSFPPatched_CheckedChanged);
            // 
            // cbExtraFriends
            // 
            this.cbExtraFriends.AutoSize = true;
            this.cbExtraFriends.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbExtraFriends.CheckedState.BorderRadius = 2;
            this.cbExtraFriends.CheckedState.BorderThickness = 0;
            this.cbExtraFriends.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbExtraFriends.Enabled = false;
            this.cbExtraFriends.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtraFriends.ForeColor = System.Drawing.Color.White;
            this.cbExtraFriends.Location = new System.Drawing.Point(273, 323);
            this.cbExtraFriends.Name = "cbExtraFriends";
            this.cbExtraFriends.Size = new System.Drawing.Size(164, 30);
            this.cbExtraFriends.TabIndex = 9;
            this.cbExtraFriends.Text = "Dark Friend List";
            this.cbExtraFriends.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbExtraFriends.UncheckedState.BorderRadius = 2;
            this.cbExtraFriends.UncheckedState.BorderThickness = 0;
            this.cbExtraFriends.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbExtraFriends.UseVisualStyleBackColor = true;
            this.cbExtraFriends.CheckedChanged += new System.EventHandler(this.cbExtraFriends_CheckedChanged);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.lblCopyright.Location = new System.Drawing.Point(6, 426);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(357, 15);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "v1.0.0 Made by LynxarADev (https://github.com/LynxarA-Coding)";
            this.lblCopyright.Click += new System.EventHandler(this.lblCopyright_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.cbSFPPatched);
            this.Controls.Add(this.cbExtraFriends);
            this.Controls.Add(this.cbExtraLibrary);
            this.Controls.Add(this.cbOverlay);
            this.Controls.Add(this.lblOverlay);
            this.Controls.Add(this.btnUninstall);
            this.Controls.Add(this.btnOpenSteam);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.cbLayoutSidebar);
            this.Controls.Add(this.cbLayoutEssentialsAlt);
            this.Controls.Add(this.cbLayoutEssentials);
            this.Controls.Add(this.cbLayoutCompact);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.lblLayout);
            this.Controls.Add(this.lblButton);
            this.Controls.Add(this.cbButtonUsername);
            this.Controls.Add(this.cbButtonDefault);
            this.Controls.Add(this.btnFolderSelect);
            this.Controls.Add(this.tbFolder);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblHeader;
        private Guna.UI2.WinForms.Guna2Elipse elpsMain;
        private Guna.UI2.WinForms.Guna2TextBox tbFolder;
        private Guna.UI2.WinForms.Guna2Button btnFolderSelect;
        private Guna.UI2.WinForms.Guna2CheckBox cbButtonDefault;
        private Guna.UI2.WinForms.Guna2CheckBox cbButtonUsername;
        private System.Windows.Forms.Label lblButton;
        private System.Windows.Forms.Label lblLayout;
        private Guna.UI2.WinForms.Guna2CheckBox cbLayoutCompact;
        private Guna.UI2.WinForms.Guna2CheckBox cbLayoutEssentials;
        private Guna.UI2.WinForms.Guna2CheckBox cbLayoutEssentialsAlt;
        private Guna.UI2.WinForms.Guna2CheckBox cbLayoutSidebar;
        private Guna.UI2.WinForms.Guna2TileButton btnInstall;
        private Guna.UI2.WinForms.Guna2CheckBox cbOverlay;
        private System.Windows.Forms.Label lblOverlay;
        private Guna.UI2.WinForms.Guna2TileButton btnUninstall;
        private Guna.UI2.WinForms.Guna2TileButton btnOpenSteam;
        private System.Windows.Forms.Label lblHeaderDiscl;
        private System.Windows.Forms.Label lblExtra;
        private Guna.UI2.WinForms.Guna2CheckBox cbExtraLibrary;
        private Guna.UI2.WinForms.Guna2CheckBox cbSFPPatched;
        private Guna.UI2.WinForms.Guna2CheckBox cbExtraFriends;
        private System.Windows.Forms.Label lblCopyright;
    }
}

