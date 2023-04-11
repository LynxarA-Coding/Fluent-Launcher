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
            this.pnlHeader.Controls.Add(this.pbLogo);
            this.pnlHeader.Controls.Add(this.lblHeaderDiscl);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Parent = this.pnlHeader;
            this.pnlHeader.Size = new System.Drawing.Size(800, 74);
            this.pnlHeader.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Fluent_Launcher.Properties.Resources.fleuntuserdiscord_circle;
            this.pbLogo.Location = new System.Drawing.Point(8, 8);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(60, 60);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // lblHeaderDiscl
            // 
            this.lblHeaderDiscl.AutoSize = true;
            this.lblHeaderDiscl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderDiscl.ForeColor = System.Drawing.Color.White;
            this.lblHeaderDiscl.Location = new System.Drawing.Point(70, 37);
            this.lblHeaderDiscl.Name = "lblHeaderDiscl";
            this.lblHeaderDiscl.Size = new System.Drawing.Size(281, 26);
            this.lblHeaderDiscl.TabIndex = 3;
            this.lblHeaderDiscl.Text = "This program is not an official \"Fluent for Steam\" Launcher. \r\nBe advised, it may" +
    " have critical bugs";
            this.lblHeaderDiscl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(74, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(271, 39);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "FLUENT LAUNCHER";
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
            this.elpsMain.BorderRadius = 45;
            this.elpsMain.TargetControl = this;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.lblCopyright.Location = new System.Drawing.Point(324, 416);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(119, 30);
            this.lblCopyright.TabIndex = 3;
            this.lblCopyright.Text = "v1.1.1\r\nMade by LynxarADev";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCopyright.Click += new System.EventHandler(this.lblCopyright_Click);
            // 
            // pnlAbout
            // 
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
            this.pnlAbout.Enabled = false;
            this.pnlAbout.Location = new System.Drawing.Point(18, 380);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.ShadowDecoration.Parent = this.pnlAbout;
            this.pnlAbout.Size = new System.Drawing.Size(506, 236);
            this.pnlAbout.TabIndex = 15;
            this.pnlAbout.Visible = false;
            // 
            // pbAboutLogo
            // 
            this.pbAboutLogo.Image = global::Fluent_Launcher.Properties.Resources.fleuntuserdiscord_circle;
            this.pbAboutLogo.Location = new System.Drawing.Point(213, 78);
            this.pbAboutLogo.Name = "pbAboutLogo";
            this.pbAboutLogo.Size = new System.Drawing.Size(60, 60);
            this.pbAboutLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAboutLogo.TabIndex = 12;
            this.pbAboutLogo.TabStop = false;
            // 
            // lblAboutOpurojo
            // 
            this.lblAboutOpurojo.AutoSize = true;
            this.lblAboutOpurojo.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutOpurojo.ForeColor = System.Drawing.Color.White;
            this.lblAboutOpurojo.Location = new System.Drawing.Point(153, 165);
            this.lblAboutOpurojo.Name = "lblAboutOpurojo";
            this.lblAboutOpurojo.Size = new System.Drawing.Size(180, 45);
            this.lblAboutOpurojo.TabIndex = 1;
            this.lblAboutOpurojo.Text = "opurojogo";
            // 
            // lblAboutLink
            // 
            this.lblAboutLink.AutoSize = true;
            this.lblAboutLink.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.lblAboutLink.Location = new System.Drawing.Point(103, 212);
            this.lblAboutLink.Name = "lblAboutLink";
            this.lblAboutLink.Size = new System.Drawing.Size(291, 15);
            this.lblAboutLink.TabIndex = 3;
            this.lblAboutLink.Text = "https://github.com/LynxarA-Coding/Fluent-Launcher";
            this.lblAboutLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAboutLink.Click += new System.EventHandler(this.lblAboutLink_Click);
            // 
            // btnAboutClose
            // 
            this.btnAboutClose.Image = global::Fluent_Launcher.Properties.Resources.cancel_white;
            this.btnAboutClose.Location = new System.Drawing.Point(459, 8);
            this.btnAboutClose.Name = "btnAboutClose";
            this.btnAboutClose.Size = new System.Drawing.Size(40, 40);
            this.btnAboutClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAboutClose.TabIndex = 0;
            this.btnAboutClose.TabStop = false;
            this.btnAboutClose.Click += new System.EventHandler(this.btnAboutClose_Click);
            // 
            // lblAboutLynxara
            // 
            this.lblAboutLynxara.AutoSize = true;
            this.lblAboutLynxara.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutLynxara.ForeColor = System.Drawing.Color.White;
            this.lblAboutLynxara.Location = new System.Drawing.Point(142, 35);
            this.lblAboutLynxara.Name = "lblAboutLynxara";
            this.lblAboutLynxara.Size = new System.Drawing.Size(202, 45);
            this.lblAboutLynxara.TabIndex = 1;
            this.lblAboutLynxara.Text = "LynxarADev";
            // 
            // lblAboutDesignedby
            // 
            this.lblAboutDesignedby.AutoSize = true;
            this.lblAboutDesignedby.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutDesignedby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblAboutDesignedby.Location = new System.Drawing.Point(80, 134);
            this.lblAboutDesignedby.Name = "lblAboutDesignedby";
            this.lblAboutDesignedby.Size = new System.Drawing.Size(330, 33);
            this.lblAboutDesignedby.TabIndex = 0;
            this.lblAboutDesignedby.Text = "Fluent for Steam designed by";
            // 
            // lblAboutMadeby
            // 
            this.lblAboutMadeby.AutoSize = true;
            this.lblAboutMadeby.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutMadeby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118)))));
            this.lblAboutMadeby.Location = new System.Drawing.Point(113, 4);
            this.lblAboutMadeby.Name = "lblAboutMadeby";
            this.lblAboutMadeby.Size = new System.Drawing.Size(264, 33);
            this.lblAboutMadeby.TabIndex = 0;
            this.lblAboutMadeby.Text = "This project is made by";
            // 
            // pnlPage
            // 
            this.pnlPage.Location = new System.Drawing.Point(9, 80);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(780, 333);
            this.pnlPage.TabIndex = 17;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlAbout);
            this.Controls.Add(this.pnlPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
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
    }
}

