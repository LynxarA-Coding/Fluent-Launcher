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
            this.cbLanguage = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblHeaderDiscl = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.elpsMain = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlAbout = new Guna.UI2.WinForms.Guna2Panel();
            this.pbAboutLogo = new System.Windows.Forms.PictureBox();
            this.lblAboutOpurojo = new System.Windows.Forms.Label();
            this.lblAboutLink = new System.Windows.Forms.Label();
            this.btnAboutClose = new System.Windows.Forms.PictureBox();
            this.lblAboutLynxara = new System.Windows.Forms.Label();
            this.lblAboutDesignedby = new System.Windows.Forms.Label();
            this.lblAboutMadeby = new System.Windows.Forms.Label();
            this.pnlPage = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAboutClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            resources.ApplyResources(this.pnlHeader, "pnlHeader");
            this.pnlHeader.Controls.Add(this.cbLanguage);
            this.pnlHeader.Controls.Add(this.pbLogo);
            this.pnlHeader.Controls.Add(this.lblHeaderDiscl);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Parent = this.pnlHeader;
            // 
            // cbLanguage
            // 
            resources.ApplyResources(this.cbLanguage, "cbLanguage");
            this.cbLanguage.BackColor = System.Drawing.Color.Transparent;
            this.cbLanguage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cbLanguage.BorderRadius = 6;
            this.cbLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbLanguage.FocusedColor = System.Drawing.Color.Empty;
            this.cbLanguage.FocusedState.Parent = this.cbLanguage;
            this.cbLanguage.ForeColor = System.Drawing.Color.White;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.HoverState.Parent = this.cbLanguage;
            this.cbLanguage.Items.AddRange(new object[] {
            resources.GetString("cbLanguage.Items"),
            resources.GetString("cbLanguage.Items1"),
            resources.GetString("cbLanguage.Items2")});
            this.cbLanguage.ItemsAppearance.Parent = this.cbLanguage;
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.ShadowDecoration.Parent = this.cbLanguage;
            this.cbLanguage.StartIndex = 0;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // pbLogo
            // 
            resources.ApplyResources(this.pbLogo, "pbLogo");
            this.pbLogo.Image = global::Fluent_Launcher.Properties.Resources.fleuntuserdiscord_circle;
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.TabStop = false;
            // 
            // lblHeaderDiscl
            // 
            resources.ApplyResources(this.lblHeaderDiscl, "lblHeaderDiscl");
            this.lblHeaderDiscl.ForeColor = System.Drawing.Color.White;
            this.lblHeaderDiscl.Name = "lblHeaderDiscl";
            // 
            // lblHeader
            // 
            resources.ApplyResources(this.lblHeader, "lblHeader");
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Name = "lblHeader";
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Image = global::Fluent_Launcher.Properties.Resources.cancel_white;
            this.btnClose.Name = "btnClose";
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.pnlHeader;
            // 
            // elpsMain
            // 
            this.elpsMain.BorderRadius = 45;
            this.elpsMain.TargetControl = this;
            // 
            // lblCopyright
            // 
            resources.ApplyResources(this.lblCopyright, "lblCopyright");
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Click += new System.EventHandler(this.lblCopyright_Click);
            // 
            // pnlAbout
            // 
            resources.ApplyResources(this.pnlAbout, "pnlAbout");
            this.pnlAbout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.pnlAbout.BorderRadius = 15;
            this.pnlAbout.BorderThickness = 2;
            this.pnlAbout.Controls.Add(this.pbAboutLogo);
            this.pnlAbout.Controls.Add(this.lblAboutOpurojo);
            this.pnlAbout.Controls.Add(this.lblAboutLink);
            this.pnlAbout.Controls.Add(this.btnAboutClose);
            this.pnlAbout.Controls.Add(this.lblAboutLynxara);
            this.pnlAbout.Controls.Add(this.lblAboutDesignedby);
            this.pnlAbout.Controls.Add(this.lblAboutMadeby);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.ShadowDecoration.Parent = this.pnlAbout;
            // 
            // pbAboutLogo
            // 
            resources.ApplyResources(this.pbAboutLogo, "pbAboutLogo");
            this.pbAboutLogo.Image = global::Fluent_Launcher.Properties.Resources.fleuntuserdiscord_circle;
            this.pbAboutLogo.Name = "pbAboutLogo";
            this.pbAboutLogo.TabStop = false;
            // 
            // lblAboutOpurojo
            // 
            resources.ApplyResources(this.lblAboutOpurojo, "lblAboutOpurojo");
            this.lblAboutOpurojo.ForeColor = System.Drawing.Color.White;
            this.lblAboutOpurojo.Name = "lblAboutOpurojo";
            // 
            // lblAboutLink
            // 
            resources.ApplyResources(this.lblAboutLink, "lblAboutLink");
            this.lblAboutLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.lblAboutLink.Name = "lblAboutLink";
            this.lblAboutLink.Click += new System.EventHandler(this.lblAboutLink_Click);
            // 
            // btnAboutClose
            // 
            resources.ApplyResources(this.btnAboutClose, "btnAboutClose");
            this.btnAboutClose.Image = global::Fluent_Launcher.Properties.Resources.cancel_white;
            this.btnAboutClose.Name = "btnAboutClose";
            this.btnAboutClose.TabStop = false;
            this.btnAboutClose.Click += new System.EventHandler(this.btnAboutClose_Click);
            // 
            // lblAboutLynxara
            // 
            resources.ApplyResources(this.lblAboutLynxara, "lblAboutLynxara");
            this.lblAboutLynxara.ForeColor = System.Drawing.Color.White;
            this.lblAboutLynxara.Name = "lblAboutLynxara";
            // 
            // lblAboutDesignedby
            // 
            resources.ApplyResources(this.lblAboutDesignedby, "lblAboutDesignedby");
            this.lblAboutDesignedby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblAboutDesignedby.Name = "lblAboutDesignedby";
            // 
            // lblAboutMadeby
            // 
            resources.ApplyResources(this.lblAboutMadeby, "lblAboutMadeby");
            this.lblAboutMadeby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblAboutMadeby.Name = "lblAboutMadeby";
            // 
            // pnlPage
            // 
            resources.ApplyResources(this.pnlPage, "pnlPage");
            this.pnlPage.Name = "pnlPage";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.pnlAbout);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAboutLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAboutClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblHeader;
        private Guna.UI2.WinForms.Guna2Elipse elpsMain;
        private System.Windows.Forms.Label lblHeaderDiscl;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2Panel pnlAbout;
        private System.Windows.Forms.Label lblAboutMadeby;
        private System.Windows.Forms.Label lblAboutLynxara;
        private System.Windows.Forms.PictureBox pbAboutLogo;
        private System.Windows.Forms.Label lblAboutDesignedby;
        private System.Windows.Forms.Label lblAboutOpurojo;
        private System.Windows.Forms.Label lblAboutLink;
        private System.Windows.Forms.PictureBox btnAboutClose;
        private System.Windows.Forms.Panel pnlPage;
        private Guna.UI2.WinForms.Guna2ComboBox cbLanguage;
    }
}

