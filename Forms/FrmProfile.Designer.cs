namespace NekoKeep.Forms
{
    partial class FrmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfile));
            btnCloseMainContextMenu_Profile = new Panel();
            txtSettingsProfile_DisplayName = new TextBox();
            picSettingsProfile_CatTheme = new PictureBox();
            btnSettingsProfile_Back = new Panel();
            btnSettingsProfile_Next = new Panel();
            btnSettingsProfile_Update = new Panel();
            ((System.ComponentModel.ISupportInitialize)picSettingsProfile_CatTheme).BeginInit();
            SuspendLayout();
            // 
            // btnCloseMainContextMenu_Profile
            // 
            btnCloseMainContextMenu_Profile.BackColor = Color.Transparent;
            btnCloseMainContextMenu_Profile.Cursor = Cursors.Hand;
            btnCloseMainContextMenu_Profile.Location = new Point(1516, 40);
            btnCloseMainContextMenu_Profile.Name = "btnCloseMainContextMenu_Profile";
            btnCloseMainContextMenu_Profile.Size = new Size(61, 61);
            btnCloseMainContextMenu_Profile.TabIndex = 0;
            btnCloseMainContextMenu_Profile.Click += BtnCloseMainContextMenu_Profile_Click;
            // 
            // txtSettingsProfile_DisplayName
            // 
            txtSettingsProfile_DisplayName.BackColor = Color.FromArgb(255, 180, 143);
            txtSettingsProfile_DisplayName.BorderStyle = BorderStyle.None;
            txtSettingsProfile_DisplayName.Font = new Font("Comic Sans MS", 25F);
            txtSettingsProfile_DisplayName.Location = new Point(88, 236);
            txtSettingsProfile_DisplayName.Name = "txtSettingsProfile_DisplayName";
            txtSettingsProfile_DisplayName.Size = new Size(348, 47);
            txtSettingsProfile_DisplayName.TabIndex = 0;
            txtSettingsProfile_DisplayName.TabStop = false;
            txtSettingsProfile_DisplayName.TextAlign = HorizontalAlignment.Center;
            // 
            // picSettingsProfile_CatTheme
            // 
            picSettingsProfile_CatTheme.BackColor = Color.Transparent;
            picSettingsProfile_CatTheme.Image = Properties.Resources.NekoKeep_Bluey_Cat1;
            picSettingsProfile_CatTheme.Location = new Point(802, 261);
            picSettingsProfile_CatTheme.Name = "picSettingsProfile_CatTheme";
            picSettingsProfile_CatTheme.Size = new Size(394, 505);
            picSettingsProfile_CatTheme.SizeMode = PictureBoxSizeMode.Zoom;
            picSettingsProfile_CatTheme.TabIndex = 1;
            picSettingsProfile_CatTheme.TabStop = false;
            // 
            // btnSettingsProfile_Back
            // 
            btnSettingsProfile_Back.BackColor = Color.Transparent;
            btnSettingsProfile_Back.Cursor = Cursors.Hand;
            btnSettingsProfile_Back.Location = new Point(481, 483);
            btnSettingsProfile_Back.Name = "btnSettingsProfile_Back";
            btnSettingsProfile_Back.Size = new Size(198, 135);
            btnSettingsProfile_Back.TabIndex = 2;
            btnSettingsProfile_Back.Click += BtnSettingsProfile_Back_Click;
            // 
            // btnSettingsProfile_Next
            // 
            btnSettingsProfile_Next.BackColor = Color.Transparent;
            btnSettingsProfile_Next.Cursor = Cursors.Hand;
            btnSettingsProfile_Next.Location = new Point(1322, 483);
            btnSettingsProfile_Next.Name = "btnSettingsProfile_Next";
            btnSettingsProfile_Next.Size = new Size(198, 135);
            btnSettingsProfile_Next.TabIndex = 3;
            btnSettingsProfile_Next.Click += BtnSettingsProfile_Next_Click;
            // 
            // btnSettingsProfile_Update
            // 
            btnSettingsProfile_Update.BackColor = Color.Transparent;
            btnSettingsProfile_Update.Cursor = Cursors.Hand;
            btnSettingsProfile_Update.Location = new Point(921, 799);
            btnSettingsProfile_Update.Name = "btnSettingsProfile_Update";
            btnSettingsProfile_Update.Size = new Size(158, 50);
            btnSettingsProfile_Update.TabIndex = 4;
            btnSettingsProfile_Update.Click += BtnSettingsProfile_Update_Click;
            // 
            // FrmProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Profile_Screen__Change_Cat_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1600, 941);
            Controls.Add(btnSettingsProfile_Update);
            Controls.Add(btnSettingsProfile_Next);
            Controls.Add(btnSettingsProfile_Back);
            Controls.Add(picSettingsProfile_CatTheme);
            Controls.Add(txtSettingsProfile_DisplayName);
            Controls.Add(btnCloseMainContextMenu_Profile);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FrmProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NekoKeep";
            ((System.ComponentModel.ISupportInitialize)picSettingsProfile_CatTheme).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel btnCloseMainContextMenu_Profile;
        private TextBox txtSettingsProfile_DisplayName;
        private PictureBox picSettingsProfile_CatTheme;
        private Panel btnSettingsProfile_Back;
        private Panel btnSettingsProfile_Next;
        private Panel btnSettingsProfile_Update;
    }
}