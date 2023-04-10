namespace Fluent_Launcher
{
    partial class PageSettings
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
            this.btnBack = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblButtonsTitle = new System.Windows.Forms.Label();
            this.lblOverlayTitle = new System.Windows.Forms.Label();
            this.rbOverlayTop = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbOverlayBottom = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbOverlayLeftAlign = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbOverlayLeftBar = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblLayoutTitle = new System.Windows.Forms.Label();
            this.cbLayoutSidebar = new Guna.UI2.WinForms.Guna2CheckBox();
            this.rbLayoutCompact = new Guna.UI2.WinForms.Guna2RadioButton();
            this.pnlOverlay = new System.Windows.Forms.Panel();
            this.pnlLayout = new System.Windows.Forms.Panel();
            this.rbLayoutEssentials = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbLayoutEssentialsAlt = new Guna.UI2.WinForms.Guna2RadioButton();
            this.pnlExtra = new System.Windows.Forms.Panel();
            this.lblExtraTitle = new System.Windows.Forms.Label();
            this.cbExtraLibrary = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbExtraFriends = new Guna.UI2.WinForms.Guna2CheckBox();
            this.rbButtonDefault = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbButtonUsername = new Guna.UI2.WinForms.Guna2RadioButton();
            this.pnlPatch = new Guna.UI2.WinForms.Guna2Panel();
            this.cbSFP = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlOverlay.SuspendLayout();
            this.pnlLayout.SuspendLayout();
            this.pnlExtra.SuspendLayout();
            this.pnlPatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 15;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.btnBack.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Location = new System.Drawing.Point(561, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(213, 40);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "GO BACK (SAVE)";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblButtonsTitle
            // 
            this.lblButtonsTitle.AutoSize = true;
            this.lblButtonsTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButtonsTitle.ForeColor = System.Drawing.Color.White;
            this.lblButtonsTitle.Location = new System.Drawing.Point(20, 59);
            this.lblButtonsTitle.Name = "lblButtonsTitle";
            this.lblButtonsTitle.Size = new System.Drawing.Size(203, 29);
            this.lblButtonsTitle.TabIndex = 12;
            this.lblButtonsTitle.Text = "ACCOUNT BUTTON";
            // 
            // lblOverlayTitle
            // 
            this.lblOverlayTitle.AutoSize = true;
            this.lblOverlayTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverlayTitle.ForeColor = System.Drawing.Color.White;
            this.lblOverlayTitle.Location = new System.Drawing.Point(3, 4);
            this.lblOverlayTitle.Name = "lblOverlayTitle";
            this.lblOverlayTitle.Size = new System.Drawing.Size(197, 29);
            this.lblOverlayTitle.TabIndex = 12;
            this.lblOverlayTitle.Text = "CUSTOM OVERLAY";
            // 
            // rbOverlayTop
            // 
            this.rbOverlayTop.AutoSize = true;
            this.rbOverlayTop.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbOverlayTop.CheckedState.BorderThickness = 0;
            this.rbOverlayTop.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbOverlayTop.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbOverlayTop.CheckedState.InnerOffset = -4;
            this.rbOverlayTop.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOverlayTop.ForeColor = System.Drawing.Color.White;
            this.rbOverlayTop.Location = new System.Drawing.Point(8, 36);
            this.rbOverlayTop.Name = "rbOverlayTop";
            this.rbOverlayTop.Size = new System.Drawing.Size(157, 27);
            this.rbOverlayTop.TabIndex = 14;
            this.rbOverlayTop.TabStop = true;
            this.rbOverlayTop.Text = "Default (Top Bar)";
            this.rbOverlayTop.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.rbOverlayTop.UncheckedState.BorderThickness = 2;
            this.rbOverlayTop.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbOverlayTop.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbOverlayTop.UseVisualStyleBackColor = true;
            this.rbOverlayTop.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            this.rbOverlayTop.Click += new System.EventHandler(this.rbCheckChanged);
            // 
            // rbOverlayBottom
            // 
            this.rbOverlayBottom.AutoSize = true;
            this.rbOverlayBottom.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbOverlayBottom.CheckedState.BorderThickness = 0;
            this.rbOverlayBottom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbOverlayBottom.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbOverlayBottom.CheckedState.InnerOffset = -4;
            this.rbOverlayBottom.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOverlayBottom.ForeColor = System.Drawing.Color.White;
            this.rbOverlayBottom.Location = new System.Drawing.Point(8, 65);
            this.rbOverlayBottom.Name = "rbOverlayBottom";
            this.rbOverlayBottom.Size = new System.Drawing.Size(85, 27);
            this.rbOverlayBottom.TabIndex = 14;
            this.rbOverlayBottom.TabStop = true;
            this.rbOverlayBottom.Text = "Bottom";
            this.rbOverlayBottom.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.rbOverlayBottom.UncheckedState.BorderThickness = 2;
            this.rbOverlayBottom.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbOverlayBottom.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbOverlayBottom.UseVisualStyleBackColor = true;
            this.rbOverlayBottom.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            this.rbOverlayBottom.Click += new System.EventHandler(this.rbCheckChanged);
            // 
            // rbOverlayLeftAlign
            // 
            this.rbOverlayLeftAlign.AutoSize = true;
            this.rbOverlayLeftAlign.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbOverlayLeftAlign.CheckedState.BorderThickness = 0;
            this.rbOverlayLeftAlign.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbOverlayLeftAlign.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbOverlayLeftAlign.CheckedState.InnerOffset = -4;
            this.rbOverlayLeftAlign.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOverlayLeftAlign.ForeColor = System.Drawing.Color.White;
            this.rbOverlayLeftAlign.Location = new System.Drawing.Point(8, 94);
            this.rbOverlayLeftAlign.Name = "rbOverlayLeftAlign";
            this.rbOverlayLeftAlign.Size = new System.Drawing.Size(99, 27);
            this.rbOverlayLeftAlign.TabIndex = 14;
            this.rbOverlayLeftAlign.TabStop = true;
            this.rbOverlayLeftAlign.Text = "Left Align";
            this.rbOverlayLeftAlign.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.rbOverlayLeftAlign.UncheckedState.BorderThickness = 2;
            this.rbOverlayLeftAlign.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbOverlayLeftAlign.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbOverlayLeftAlign.UseVisualStyleBackColor = true;
            this.rbOverlayLeftAlign.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            this.rbOverlayLeftAlign.Click += new System.EventHandler(this.rbCheckChanged);
            // 
            // rbOverlayLeftBar
            // 
            this.rbOverlayLeftBar.AutoSize = true;
            this.rbOverlayLeftBar.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbOverlayLeftBar.CheckedState.BorderThickness = 0;
            this.rbOverlayLeftBar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbOverlayLeftBar.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbOverlayLeftBar.CheckedState.InnerOffset = -4;
            this.rbOverlayLeftBar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOverlayLeftBar.ForeColor = System.Drawing.Color.White;
            this.rbOverlayLeftBar.Location = new System.Drawing.Point(8, 123);
            this.rbOverlayLeftBar.Name = "rbOverlayLeftBar";
            this.rbOverlayLeftBar.Size = new System.Drawing.Size(87, 27);
            this.rbOverlayLeftBar.TabIndex = 14;
            this.rbOverlayLeftBar.TabStop = true;
            this.rbOverlayLeftBar.Text = "Left Bar";
            this.rbOverlayLeftBar.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.rbOverlayLeftBar.UncheckedState.BorderThickness = 2;
            this.rbOverlayLeftBar.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbOverlayLeftBar.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbOverlayLeftBar.UseVisualStyleBackColor = true;
            this.rbOverlayLeftBar.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            this.rbOverlayLeftBar.Click += new System.EventHandler(this.rbCheckChanged);
            // 
            // lblLayoutTitle
            // 
            this.lblLayoutTitle.AutoSize = true;
            this.lblLayoutTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLayoutTitle.ForeColor = System.Drawing.Color.White;
            this.lblLayoutTitle.Location = new System.Drawing.Point(7, 4);
            this.lblLayoutTitle.Name = "lblLayoutTitle";
            this.lblLayoutTitle.Size = new System.Drawing.Size(91, 29);
            this.lblLayoutTitle.TabIndex = 12;
            this.lblLayoutTitle.Text = "LAYOUT";
            // 
            // cbLayoutSidebar
            // 
            this.cbLayoutSidebar.AutoSize = true;
            this.cbLayoutSidebar.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbLayoutSidebar.CheckedState.BorderRadius = 2;
            this.cbLayoutSidebar.CheckedState.BorderThickness = 0;
            this.cbLayoutSidebar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbLayoutSidebar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLayoutSidebar.ForeColor = System.Drawing.Color.White;
            this.cbLayoutSidebar.Location = new System.Drawing.Point(11, 41);
            this.cbLayoutSidebar.Name = "cbLayoutSidebar";
            this.cbLayoutSidebar.Size = new System.Drawing.Size(87, 27);
            this.cbLayoutSidebar.TabIndex = 13;
            this.cbLayoutSidebar.Text = "Sidebar";
            this.cbLayoutSidebar.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cbLayoutSidebar.UncheckedState.BorderRadius = 2;
            this.cbLayoutSidebar.UncheckedState.BorderThickness = 0;
            this.cbLayoutSidebar.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cbLayoutSidebar.UseVisualStyleBackColor = true;
            this.cbLayoutSidebar.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            // 
            // rbLayoutCompact
            // 
            this.rbLayoutCompact.AutoSize = true;
            this.rbLayoutCompact.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbLayoutCompact.CheckedState.BorderThickness = 0;
            this.rbLayoutCompact.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbLayoutCompact.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbLayoutCompact.CheckedState.InnerOffset = -4;
            this.rbLayoutCompact.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLayoutCompact.ForeColor = System.Drawing.Color.White;
            this.rbLayoutCompact.Location = new System.Drawing.Point(11, 67);
            this.rbLayoutCompact.Name = "rbLayoutCompact";
            this.rbLayoutCompact.Size = new System.Drawing.Size(96, 27);
            this.rbLayoutCompact.TabIndex = 15;
            this.rbLayoutCompact.TabStop = true;
            this.rbLayoutCompact.Text = "Compact";
            this.rbLayoutCompact.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.rbLayoutCompact.UncheckedState.BorderThickness = 2;
            this.rbLayoutCompact.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbLayoutCompact.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbLayoutCompact.UseVisualStyleBackColor = true;
            this.rbLayoutCompact.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            this.rbLayoutCompact.Click += new System.EventHandler(this.rbCheckChanged);
            // 
            // pnlOverlay
            // 
            this.pnlOverlay.Controls.Add(this.rbOverlayTop);
            this.pnlOverlay.Controls.Add(this.rbOverlayLeftBar);
            this.pnlOverlay.Controls.Add(this.rbOverlayBottom);
            this.pnlOverlay.Controls.Add(this.rbOverlayLeftAlign);
            this.pnlOverlay.Controls.Add(this.lblOverlayTitle);
            this.pnlOverlay.Location = new System.Drawing.Point(17, 150);
            this.pnlOverlay.Name = "pnlOverlay";
            this.pnlOverlay.Size = new System.Drawing.Size(304, 170);
            this.pnlOverlay.TabIndex = 16;
            // 
            // pnlLayout
            // 
            this.pnlLayout.Controls.Add(this.lblLayoutTitle);
            this.pnlLayout.Controls.Add(this.cbLayoutSidebar);
            this.pnlLayout.Controls.Add(this.rbLayoutEssentials);
            this.pnlLayout.Controls.Add(this.rbLayoutEssentialsAlt);
            this.pnlLayout.Controls.Add(this.rbLayoutCompact);
            this.pnlLayout.Location = new System.Drawing.Point(442, 55);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.Size = new System.Drawing.Size(326, 128);
            this.pnlLayout.TabIndex = 17;
            // 
            // rbLayoutEssentials
            // 
            this.rbLayoutEssentials.AutoSize = true;
            this.rbLayoutEssentials.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbLayoutEssentials.CheckedState.BorderThickness = 0;
            this.rbLayoutEssentials.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbLayoutEssentials.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbLayoutEssentials.CheckedState.InnerOffset = -4;
            this.rbLayoutEssentials.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLayoutEssentials.ForeColor = System.Drawing.Color.White;
            this.rbLayoutEssentials.Location = new System.Drawing.Point(11, 90);
            this.rbLayoutEssentials.Name = "rbLayoutEssentials";
            this.rbLayoutEssentials.Size = new System.Drawing.Size(104, 27);
            this.rbLayoutEssentials.TabIndex = 15;
            this.rbLayoutEssentials.TabStop = true;
            this.rbLayoutEssentials.Text = "Essentials";
            this.rbLayoutEssentials.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.rbLayoutEssentials.UncheckedState.BorderThickness = 2;
            this.rbLayoutEssentials.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbLayoutEssentials.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbLayoutEssentials.UseVisualStyleBackColor = true;
            this.rbLayoutEssentials.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            this.rbLayoutEssentials.Click += new System.EventHandler(this.rbCheckChanged);
            // 
            // rbLayoutEssentialsAlt
            // 
            this.rbLayoutEssentialsAlt.AutoSize = true;
            this.rbLayoutEssentialsAlt.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbLayoutEssentialsAlt.CheckedState.BorderThickness = 0;
            this.rbLayoutEssentialsAlt.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbLayoutEssentialsAlt.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbLayoutEssentialsAlt.CheckedState.InnerOffset = -4;
            this.rbLayoutEssentialsAlt.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLayoutEssentialsAlt.ForeColor = System.Drawing.Color.White;
            this.rbLayoutEssentialsAlt.Location = new System.Drawing.Point(121, 90);
            this.rbLayoutEssentialsAlt.Name = "rbLayoutEssentialsAlt";
            this.rbLayoutEssentialsAlt.Size = new System.Drawing.Size(193, 27);
            this.rbLayoutEssentialsAlt.TabIndex = 15;
            this.rbLayoutEssentialsAlt.TabStop = true;
            this.rbLayoutEssentialsAlt.Text = "Essentials Alternative";
            this.rbLayoutEssentialsAlt.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.rbLayoutEssentialsAlt.UncheckedState.BorderThickness = 2;
            this.rbLayoutEssentialsAlt.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbLayoutEssentialsAlt.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbLayoutEssentialsAlt.UseVisualStyleBackColor = true;
            this.rbLayoutEssentialsAlt.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            this.rbLayoutEssentialsAlt.Click += new System.EventHandler(this.rbCheckChanged);
            // 
            // pnlExtra
            // 
            this.pnlExtra.Controls.Add(this.lblExtraTitle);
            this.pnlExtra.Controls.Add(this.cbExtraFriends);
            this.pnlExtra.Controls.Add(this.cbExtraLibrary);
            this.pnlExtra.Location = new System.Drawing.Point(442, 189);
            this.pnlExtra.Name = "pnlExtra";
            this.pnlExtra.Size = new System.Drawing.Size(281, 111);
            this.pnlExtra.TabIndex = 18;
            // 
            // lblExtraTitle
            // 
            this.lblExtraTitle.AutoSize = true;
            this.lblExtraTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraTitle.ForeColor = System.Drawing.Color.White;
            this.lblExtraTitle.Location = new System.Drawing.Point(7, 4);
            this.lblExtraTitle.Name = "lblExtraTitle";
            this.lblExtraTitle.Size = new System.Drawing.Size(243, 29);
            this.lblExtraTitle.TabIndex = 12;
            this.lblExtraTitle.Text = "EXTRA (SFP REQUIRED)";
            // 
            // cbExtraLibrary
            // 
            this.cbExtraLibrary.AutoSize = true;
            this.cbExtraLibrary.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbExtraLibrary.CheckedState.BorderRadius = 2;
            this.cbExtraLibrary.CheckedState.BorderThickness = 0;
            this.cbExtraLibrary.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbExtraLibrary.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtraLibrary.ForeColor = System.Drawing.Color.White;
            this.cbExtraLibrary.Location = new System.Drawing.Point(12, 36);
            this.cbExtraLibrary.Name = "cbExtraLibrary";
            this.cbExtraLibrary.Size = new System.Drawing.Size(124, 27);
            this.cbExtraLibrary.TabIndex = 13;
            this.cbExtraLibrary.Text = "Dark Library";
            this.cbExtraLibrary.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cbExtraLibrary.UncheckedState.BorderRadius = 2;
            this.cbExtraLibrary.UncheckedState.BorderThickness = 0;
            this.cbExtraLibrary.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cbExtraLibrary.UseVisualStyleBackColor = true;
            this.cbExtraLibrary.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            // 
            // cbExtraFriends
            // 
            this.cbExtraFriends.AutoSize = true;
            this.cbExtraFriends.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbExtraFriends.CheckedState.BorderRadius = 2;
            this.cbExtraFriends.CheckedState.BorderThickness = 0;
            this.cbExtraFriends.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbExtraFriends.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtraFriends.ForeColor = System.Drawing.Color.White;
            this.cbExtraFriends.Location = new System.Drawing.Point(12, 61);
            this.cbExtraFriends.Name = "cbExtraFriends";
            this.cbExtraFriends.Size = new System.Drawing.Size(157, 27);
            this.cbExtraFriends.TabIndex = 13;
            this.cbExtraFriends.Text = "Dark Friends List";
            this.cbExtraFriends.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cbExtraFriends.UncheckedState.BorderRadius = 2;
            this.cbExtraFriends.UncheckedState.BorderThickness = 0;
            this.cbExtraFriends.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cbExtraFriends.UseVisualStyleBackColor = true;
            this.cbExtraFriends.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            // 
            // rbButtonDefault
            // 
            this.rbButtonDefault.AutoSize = true;
            this.rbButtonDefault.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbButtonDefault.CheckedState.BorderThickness = 0;
            this.rbButtonDefault.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbButtonDefault.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbButtonDefault.CheckedState.InnerOffset = -4;
            this.rbButtonDefault.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbButtonDefault.ForeColor = System.Drawing.Color.White;
            this.rbButtonDefault.Location = new System.Drawing.Point(25, 92);
            this.rbButtonDefault.Name = "rbButtonDefault";
            this.rbButtonDefault.Size = new System.Drawing.Size(147, 27);
            this.rbButtonDefault.TabIndex = 14;
            this.rbButtonDefault.TabStop = true;
            this.rbButtonDefault.Text = "Only Username";
            this.rbButtonDefault.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.rbButtonDefault.UncheckedState.BorderThickness = 2;
            this.rbButtonDefault.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbButtonDefault.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbButtonDefault.UseVisualStyleBackColor = true;
            this.rbButtonDefault.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            this.rbButtonDefault.Click += new System.EventHandler(this.rbCheckChanged);
            // 
            // rbButtonUsername
            // 
            this.rbButtonUsername.AutoSize = true;
            this.rbButtonUsername.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbButtonUsername.CheckedState.BorderThickness = 0;
            this.rbButtonUsername.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.rbButtonUsername.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbButtonUsername.CheckedState.InnerOffset = -4;
            this.rbButtonUsername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbButtonUsername.ForeColor = System.Drawing.Color.White;
            this.rbButtonUsername.Location = new System.Drawing.Point(25, 117);
            this.rbButtonUsername.Name = "rbButtonUsername";
            this.rbButtonUsername.Size = new System.Drawing.Size(178, 27);
            this.rbButtonUsername.TabIndex = 14;
            this.rbButtonUsername.TabStop = true;
            this.rbButtonUsername.Text = "Username + Money";
            this.rbButtonUsername.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.rbButtonUsername.UncheckedState.BorderThickness = 2;
            this.rbButtonUsername.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbButtonUsername.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbButtonUsername.UseVisualStyleBackColor = true;
            this.rbButtonUsername.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            this.rbButtonUsername.Click += new System.EventHandler(this.rbCheckChanged);
            // 
            // pnlPatch
            // 
            this.pnlPatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlPatch.BorderRadius = 6;
            this.pnlPatch.BorderThickness = 1;
            this.pnlPatch.Controls.Add(this.cbSFP);
            this.pnlPatch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.pnlPatch.Location = new System.Drawing.Point(327, 285);
            this.pnlPatch.Name = "pnlPatch";
            this.pnlPatch.ShadowDecoration.Parent = this.pnlPatch;
            this.pnlPatch.Size = new System.Drawing.Size(299, 36);
            this.pnlPatch.TabIndex = 19;
            // 
            // cbSFP
            // 
            this.cbSFP.AutoSize = true;
            this.cbSFP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cbSFP.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbSFP.CheckedState.BorderRadius = 2;
            this.cbSFP.CheckedState.BorderThickness = 0;
            this.cbSFP.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(93)))), ((int)(((byte)(241)))));
            this.cbSFP.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSFP.ForeColor = System.Drawing.Color.White;
            this.cbSFP.Location = new System.Drawing.Point(9, 5);
            this.cbSFP.Name = "cbSFP";
            this.cbSFP.Size = new System.Drawing.Size(216, 27);
            this.cbSFP.TabIndex = 13;
            this.cbSFP.Text = "I\'ve already patched SFP";
            this.cbSFP.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbSFP.UncheckedState.BorderRadius = 2;
            this.cbSFP.UncheckedState.BorderThickness = 0;
            this.cbSFP.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbSFP.UseVisualStyleBackColor = false;
            this.cbSFP.CheckedChanged += new System.EventHandler(this.cbSFP_CheckedChanged);
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(18, 5);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(157, 42);
            this.lblPageTitle.TabIndex = 12;
            this.lblPageTitle.Text = "SETTINGS";
            // 
            // PageSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(780, 333);
            this.Controls.Add(this.pnlPatch);
            this.Controls.Add(this.rbButtonUsername);
            this.Controls.Add(this.rbButtonDefault);
            this.Controls.Add(this.pnlExtra);
            this.Controls.Add(this.pnlLayout);
            this.Controls.Add(this.pnlOverlay);
            this.Controls.Add(this.lblPageTitle);
            this.Controls.Add(this.lblButtonsTitle);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageSettings";
            this.Text = "PageSettings";
            this.Load += new System.EventHandler(this.PageSettings_Load);
            this.pnlOverlay.ResumeLayout(false);
            this.pnlOverlay.PerformLayout();
            this.pnlLayout.ResumeLayout(false);
            this.pnlLayout.PerformLayout();
            this.pnlExtra.ResumeLayout(false);
            this.pnlExtra.PerformLayout();
            this.pnlPatch.ResumeLayout(false);
            this.pnlPatch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton btnBack;
        private System.Windows.Forms.Label lblButtonsTitle;
        private System.Windows.Forms.Label lblOverlayTitle;
        private Guna.UI2.WinForms.Guna2RadioButton rbOverlayTop;
        private Guna.UI2.WinForms.Guna2RadioButton rbOverlayBottom;
        private Guna.UI2.WinForms.Guna2RadioButton rbOverlayLeftAlign;
        private Guna.UI2.WinForms.Guna2RadioButton rbOverlayLeftBar;
        private System.Windows.Forms.Label lblLayoutTitle;
        private Guna.UI2.WinForms.Guna2CheckBox cbLayoutSidebar;
        private Guna.UI2.WinForms.Guna2RadioButton rbLayoutCompact;
        private System.Windows.Forms.Panel pnlOverlay;
        private System.Windows.Forms.Panel pnlLayout;
        private Guna.UI2.WinForms.Guna2RadioButton rbLayoutEssentials;
        private Guna.UI2.WinForms.Guna2RadioButton rbLayoutEssentialsAlt;
        private System.Windows.Forms.Panel pnlExtra;
        private System.Windows.Forms.Label lblExtraTitle;
        private Guna.UI2.WinForms.Guna2CheckBox cbExtraLibrary;
        private Guna.UI2.WinForms.Guna2CheckBox cbExtraFriends;
        private Guna.UI2.WinForms.Guna2RadioButton rbButtonDefault;
        private Guna.UI2.WinForms.Guna2RadioButton rbButtonUsername;
        private Guna.UI2.WinForms.Guna2Panel pnlPatch;
        private Guna.UI2.WinForms.Guna2CheckBox cbSFP;
        private System.Windows.Forms.Label lblPageTitle;
    }
}