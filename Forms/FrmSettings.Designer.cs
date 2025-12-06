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
            SuspendLayout();
            // 
            // btnSettingsAccount
            // 
            btnSettingsAccount.BackColor = Color.Transparent;
            btnSettingsAccount.BackgroundImageLayout = ImageLayout.Center;
            btnSettingsAccount.Location = new Point(52, 70);
            btnSettingsAccount.Name = "btnSettingsAccount";
            btnSettingsAccount.Size = new Size(419, 133);
            btnSettingsAccount.TabIndex = 0;
            // 
            // btnSettingsBackup
            // 
            btnSettingsBackup.BackColor = Color.Transparent;
            btnSettingsBackup.BackgroundImage = Properties.Resources.Backup;
            btnSettingsBackup.BackgroundImageLayout = ImageLayout.Center;
            btnSettingsBackup.Location = new Point(52, 203);
            btnSettingsBackup.Name = "btnSettingsBackup";
            btnSettingsBackup.Size = new Size(419, 135);
            btnSettingsBackup.TabIndex = 1;
            // 
            // btnSettingsAbout
            // 
            btnSettingsAbout.BackColor = Color.Transparent;
            btnSettingsAbout.BackgroundImage = Properties.Resources.About_Us;
            btnSettingsAbout.BackgroundImageLayout = ImageLayout.Center;
            btnSettingsAbout.Location = new Point(52, 338);
            btnSettingsAbout.Name = "btnSettingsAbout";
            btnSettingsAbout.Size = new Size(419, 135);
            btnSettingsAbout.TabIndex = 2;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Settings_Screen;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1600, 941);
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
    }
}