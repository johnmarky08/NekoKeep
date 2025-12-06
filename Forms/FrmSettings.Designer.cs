namespace NekoKeep.Forms
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            btnSettingsAccount = new Panel();
            btnSettingsBackup = new Panel();
            btnSettingsAbout = new Panel();
            btnCloseMainContextMenu = new Panel();
            SuspendLayout();
            // 
            // btnSettingsAccount
            // 
            btnSettingsAccount.BackColor = Color.Transparent;
            btnSettingsAccount.BackgroundImage = Properties.Resources.account__selected_;
            btnSettingsAccount.BackgroundImageLayout = ImageLayout.Center;
            btnSettingsAccount.Cursor = Cursors.Hand;
            btnSettingsAccount.Location = new Point(52, 70);
            btnSettingsAccount.Name = "btnSettingsAccount";
            btnSettingsAccount.Size = new Size(419, 133);
            btnSettingsAccount.TabIndex = 0;
            btnSettingsAccount.Click += BtnSettingsAccount_Click;
            // 
            // btnSettingsBackup
            // 
            btnSettingsBackup.BackColor = Color.Transparent;
            btnSettingsBackup.BackgroundImage = Properties.Resources.Backup;
            btnSettingsBackup.BackgroundImageLayout = ImageLayout.Center;
            btnSettingsBackup.Cursor = Cursors.Hand;
            btnSettingsBackup.Location = new Point(52, 203);
            btnSettingsBackup.Name = "btnSettingsBackup";
            btnSettingsBackup.Size = new Size(419, 135);
            btnSettingsBackup.TabIndex = 1;
            btnSettingsBackup.Click += BtnSettingsBackup_Click;
            // 
            // btnSettingsAbout
            // 
            btnSettingsAbout.BackColor = Color.Transparent;
            btnSettingsAbout.BackgroundImage = Properties.Resources.About_Us;
            btnSettingsAbout.BackgroundImageLayout = ImageLayout.Center;
            btnSettingsAbout.Cursor = Cursors.Hand;
            btnSettingsAbout.Location = new Point(52, 338);
            btnSettingsAbout.Name = "btnSettingsAbout";
            btnSettingsAbout.Size = new Size(419, 135);
            btnSettingsAbout.TabIndex = 2;
            btnSettingsAbout.Click += BtnSettingsAbout_Click;
            // 
            // btnCloseMainContextMenu
            // 
            btnCloseMainContextMenu.BackColor = Color.Transparent;
            btnCloseMainContextMenu.Cursor = Cursors.Hand;
            btnCloseMainContextMenu.Location = new Point(1515, 41);
            btnCloseMainContextMenu.Name = "btnCloseMainContextMenu";
            btnCloseMainContextMenu.Size = new Size(62, 61);
            btnCloseMainContextMenu.TabIndex = 3;
            btnCloseMainContextMenu.Click += BtnCloseMainContextMenu_Click;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Settings_Screen;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1600, 941);
            Controls.Add(btnCloseMainContextMenu);
            Controls.Add(btnSettingsAbout);
            Controls.Add(btnSettingsBackup);
            Controls.Add(btnSettingsAccount);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FrmSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NekoKeep";
            ResumeLayout(false);
        }

        #endregion

        private Panel btnSettingsAccount;
        private Panel btnSettingsBackup;
        private Panel btnSettingsAbout;
        private Panel btnCloseMainContextMenu;
    }
}