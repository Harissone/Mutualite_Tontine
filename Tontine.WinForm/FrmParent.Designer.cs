namespace Tontine.WinForm
{
    partial class FrmParent
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSettingMenu = new System.Windows.Forms.Panel();
            this.btnAboutApp = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnAppSetting = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelEventMenu = new System.Windows.Forms.Panel();
            this.btnInfosEvent = new System.Windows.Forms.Button();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.panelMettingMenu = new System.Windows.Forms.Panel();
            this.btnInfoMetting = new System.Windows.Forms.Button();
            this.btnCreateMetting = new System.Windows.Forms.Button();
            this.btnMetting = new System.Windows.Forms.Button();
            this.panelChild = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSettingMenu.SuspendLayout();
            this.panelEventMenu.SuspendLayout();
            this.panelMettingMenu.SuspendLayout();
            this.panelChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.panelSettingMenu);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnHelp);
            this.panelMenu.Controls.Add(this.panelEventMenu);
            this.panelMenu.Controls.Add(this.btnEvent);
            this.panelMenu.Controls.Add(this.panelMettingMenu);
            this.panelMenu.Controls.Add(this.btnMetting);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(233, 643);
            this.panelMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 615);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(216, 34);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Tontine.WinForm.Properties.Resources.logo_tontine_png_png;
            this.pictureBox1.Location = new System.Drawing.Point(0, 398);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelSettingMenu
            // 
            this.panelSettingMenu.BackColor = System.Drawing.Color.DimGray;
            this.panelSettingMenu.Controls.Add(this.btnAboutApp);
            this.panelSettingMenu.Controls.Add(this.btnProfil);
            this.panelSettingMenu.Controls.Add(this.btnAppSetting);
            this.panelSettingMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSettingMenu.Location = new System.Drawing.Point(0, 283);
            this.panelSettingMenu.Name = "panelSettingMenu";
            this.panelSettingMenu.Size = new System.Drawing.Size(216, 115);
            this.panelSettingMenu.TabIndex = 8;
            // 
            // btnAboutApp
            // 
            this.btnAboutApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutApp.FlatAppearance.BorderSize = 0;
            this.btnAboutApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutApp.ForeColor = System.Drawing.Color.White;
            this.btnAboutApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutApp.Location = new System.Drawing.Point(0, 68);
            this.btnAboutApp.Name = "btnAboutApp";
            this.btnAboutApp.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAboutApp.Size = new System.Drawing.Size(216, 34);
            this.btnAboutApp.TabIndex = 3;
            this.btnAboutApp.Text = "About app";
            this.btnAboutApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutApp.UseVisualStyleBackColor = true;
            this.btnAboutApp.Click += new System.EventHandler(this.btnAboutApp_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfil.FlatAppearance.BorderSize = 0;
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.ForeColor = System.Drawing.Color.White;
            this.btnProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.Location = new System.Drawing.Point(0, 34);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProfil.Size = new System.Drawing.Size(216, 34);
            this.btnProfil.TabIndex = 2;
            this.btnProfil.Text = "Profil";
            this.btnProfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnAppSetting
            // 
            this.btnAppSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppSetting.FlatAppearance.BorderSize = 0;
            this.btnAppSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppSetting.ForeColor = System.Drawing.Color.White;
            this.btnAppSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppSetting.Location = new System.Drawing.Point(0, 0);
            this.btnAppSetting.Name = "btnAppSetting";
            this.btnAppSetting.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAppSetting.Size = new System.Drawing.Size(216, 34);
            this.btnAppSetting.TabIndex = 1;
            this.btnAppSetting.Text = "App setting";
            this.btnAppSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppSetting.UseVisualStyleBackColor = true;
            this.btnAppSetting.Click += new System.EventHandler(this.btnAppSetting_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 249);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(216, 34);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(0, 215);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(216, 34);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelEventMenu
            // 
            this.panelEventMenu.BackColor = System.Drawing.Color.DimGray;
            this.panelEventMenu.Controls.Add(this.btnInfosEvent);
            this.panelEventMenu.Controls.Add(this.btnCreateEvent);
            this.panelEventMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEventMenu.Location = new System.Drawing.Point(0, 141);
            this.panelEventMenu.Name = "panelEventMenu";
            this.panelEventMenu.Size = new System.Drawing.Size(216, 74);
            this.panelEventMenu.TabIndex = 5;
            // 
            // btnInfosEvent
            // 
            this.btnInfosEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfosEvent.FlatAppearance.BorderSize = 0;
            this.btnInfosEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfosEvent.ForeColor = System.Drawing.Color.White;
            this.btnInfosEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfosEvent.Location = new System.Drawing.Point(0, 34);
            this.btnInfosEvent.Name = "btnInfosEvent";
            this.btnInfosEvent.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnInfosEvent.Size = new System.Drawing.Size(216, 34);
            this.btnInfosEvent.TabIndex = 2;
            this.btnInfosEvent.Text = "Infos event";
            this.btnInfosEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfosEvent.UseVisualStyleBackColor = true;
            this.btnInfosEvent.Click += new System.EventHandler(this.btnInfosEvent_Click);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateEvent.FlatAppearance.BorderSize = 0;
            this.btnCreateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEvent.ForeColor = System.Drawing.Color.White;
            this.btnCreateEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateEvent.Location = new System.Drawing.Point(0, 0);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCreateEvent.Size = new System.Drawing.Size(216, 34);
            this.btnCreateEvent.TabIndex = 1;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEvent.FlatAppearance.BorderSize = 0;
            this.btnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvent.ForeColor = System.Drawing.Color.White;
            this.btnEvent.Location = new System.Drawing.Point(0, 107);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEvent.Size = new System.Drawing.Size(216, 34);
            this.btnEvent.TabIndex = 4;
            this.btnEvent.Text = "Event";
            this.btnEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // panelMettingMenu
            // 
            this.panelMettingMenu.BackColor = System.Drawing.Color.DimGray;
            this.panelMettingMenu.Controls.Add(this.btnInfoMetting);
            this.panelMettingMenu.Controls.Add(this.btnCreateMetting);
            this.panelMettingMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMettingMenu.Location = new System.Drawing.Point(0, 28);
            this.panelMettingMenu.Name = "panelMettingMenu";
            this.panelMettingMenu.Size = new System.Drawing.Size(216, 79);
            this.panelMettingMenu.TabIndex = 3;
            // 
            // btnInfoMetting
            // 
            this.btnInfoMetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoMetting.FlatAppearance.BorderSize = 0;
            this.btnInfoMetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoMetting.ForeColor = System.Drawing.Color.White;
            this.btnInfoMetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoMetting.Location = new System.Drawing.Point(0, 34);
            this.btnInfoMetting.Name = "btnInfoMetting";
            this.btnInfoMetting.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnInfoMetting.Size = new System.Drawing.Size(216, 34);
            this.btnInfoMetting.TabIndex = 2;
            this.btnInfoMetting.Text = "Infos metting";
            this.btnInfoMetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoMetting.UseVisualStyleBackColor = true;
            this.btnInfoMetting.Click += new System.EventHandler(this.btnInfoMetting_Click);
            // 
            // btnCreateMetting
            // 
            this.btnCreateMetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateMetting.FlatAppearance.BorderSize = 0;
            this.btnCreateMetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMetting.ForeColor = System.Drawing.Color.White;
            this.btnCreateMetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateMetting.Location = new System.Drawing.Point(0, 0);
            this.btnCreateMetting.Name = "btnCreateMetting";
            this.btnCreateMetting.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCreateMetting.Size = new System.Drawing.Size(216, 34);
            this.btnCreateMetting.TabIndex = 1;
            this.btnCreateMetting.Text = "Create metting";
            this.btnCreateMetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateMetting.UseVisualStyleBackColor = true;
            this.btnCreateMetting.Click += new System.EventHandler(this.btnCreateMetting_Click_1);
            // 
            // btnMetting
            // 
            this.btnMetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMetting.FlatAppearance.BorderSize = 0;
            this.btnMetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMetting.ForeColor = System.Drawing.Color.White;
            this.btnMetting.Location = new System.Drawing.Point(0, 0);
            this.btnMetting.Name = "btnMetting";
            this.btnMetting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMetting.Size = new System.Drawing.Size(216, 28);
            this.btnMetting.TabIndex = 1;
            this.btnMetting.Text = "Metting";
            this.btnMetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMetting.UseVisualStyleBackColor = true;
            this.btnMetting.Click += new System.EventHandler(this.btnMetting_Click);
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.DimGray;
            this.panelChild.Controls.Add(this.pictureBox2);
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(233, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(896, 643);
            this.panelChild.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Tontine.WinForm.Properties.Resources.logo_tontine_png_png;
            this.pictureBox2.Location = new System.Drawing.Point(194, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(508, 457);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FrmParent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1129, 643);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelMenu);
            this.Name = "FrmParent";
            this.Text = "FrmParent";
            this.Load += new System.EventHandler(this.FrmParent_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSettingMenu.ResumeLayout(false);
            this.panelEventMenu.ResumeLayout(false);
            this.panelMettingMenu.ResumeLayout(false);
            this.panelChild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelSettingMenu;
        private System.Windows.Forms.Button btnAboutApp;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnAppSetting;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panelEventMenu;
        private System.Windows.Forms.Button btnInfosEvent;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Panel panelMettingMenu;
        private System.Windows.Forms.Button btnInfoMetting;
        private System.Windows.Forms.Button btnCreateMetting;
        private System.Windows.Forms.Button btnMetting;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}