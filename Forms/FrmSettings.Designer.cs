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
            pnlSettingsAccount = new Panel();
            lblSettingsMpin = new Label();
            lblSettingsPassword = new Label();
            lblEmail = new Label();
            btnSettingsChangeMpin = new Panel();
            btnSettingsChangePassword = new Panel();
            btnSettingsChangeEmail = new Panel();
            pnlSettingsChange = new Panel();
            btnShowPass1 = new Panel();
            btnShowPass3 = new Panel();
            btnShowPass2 = new Panel();
            txtSettingsChangeNew2 = new TextBox();
            txtSettingsChangeNew = new TextBox();
            txtSettingsChangeOld = new TextBox();
            btnSettingsAccountSave = new Panel();
            pnlSettingsBackup = new Panel();
            cbxBackupDescending = new CheckBox();
            cbxBackupSortLastUpdated = new CheckBox();
            lblBackupImportFilename = new Label();
            btnBackupStartImport = new Panel();
            btnBackupExport = new Panel();
            btnBackupImport = new Panel();
            pnlSettingsBackupMpinHolder = new Panel();
            btnBackupStartExport = new Panel();
            backupMpin_6 = new Panel();
            backupMpin_5 = new Panel();
            backupMpin_4 = new Panel();
            backupMpin_3 = new Panel();
            backupMpin_2 = new Panel();
            backupMpin_1 = new Panel();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            pnlSettingsAbout = new Panel();
            pnlSettingsAccount.SuspendLayout();
            pnlSettingsChange.SuspendLayout();
            pnlSettingsBackup.SuspendLayout();
            pnlSettingsBackupMpinHolder.SuspendLayout();
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
            // pnlSettingsAccount
            // 
            pnlSettingsAccount.BackColor = Color.Transparent;
            pnlSettingsAccount.BackgroundImage = Properties.Resources.Settings_Account;
            pnlSettingsAccount.BackgroundImageLayout = ImageLayout.None;
            pnlSettingsAccount.Controls.Add(lblSettingsMpin);
            pnlSettingsAccount.Controls.Add(lblSettingsPassword);
            pnlSettingsAccount.Controls.Add(lblEmail);
            pnlSettingsAccount.Controls.Add(btnSettingsChangeMpin);
            pnlSettingsAccount.Controls.Add(btnSettingsChangePassword);
            pnlSettingsAccount.Controls.Add(btnSettingsChangeEmail);
            pnlSettingsAccount.Location = new Point(0, 0);
            pnlSettingsAccount.Name = "pnlSettingsAccount";
            pnlSettingsAccount.Size = new Size(1600, 960);
            pnlSettingsAccount.TabIndex = 4;
            // 
            // lblSettingsMpin
            // 
            lblSettingsMpin.Font = new Font("Comic Sans MS", 22F);
            lblSettingsMpin.Location = new Point(603, 304);
            lblSettingsMpin.Name = "lblSettingsMpin";
            lblSettingsMpin.Size = new Size(447, 37);
            lblSettingsMpin.TabIndex = 6;
            lblSettingsMpin.Text = "O O O O O O";
            lblSettingsMpin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSettingsPassword
            // 
            lblSettingsPassword.Font = new Font("Comic Sans MS", 22F);
            lblSettingsPassword.Location = new Point(603, 223);
            lblSettingsPassword.Name = "lblSettingsPassword";
            lblSettingsPassword.Size = new Size(447, 37);
            lblSettingsPassword.TabIndex = 5;
            lblSettingsPassword.Text = "* * * * * * * * * * * *";
            lblSettingsPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Comic Sans MS", 22F);
            lblEmail.Location = new Point(603, 136);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(447, 37);
            lblEmail.TabIndex = 3;
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSettingsChangeMpin
            // 
            btnSettingsChangeMpin.Cursor = Cursors.Hand;
            btnSettingsChangeMpin.Location = new Point(1132, 308);
            btnSettingsChangeMpin.Name = "btnSettingsChangeMpin";
            btnSettingsChangeMpin.Size = new Size(250, 44);
            btnSettingsChangeMpin.TabIndex = 2;
            btnSettingsChangeMpin.Click += BtnSettingsChangeMpin_Click;
            // 
            // btnSettingsChangePassword
            // 
            btnSettingsChangePassword.Cursor = Cursors.Hand;
            btnSettingsChangePassword.Location = new Point(1132, 223);
            btnSettingsChangePassword.Name = "btnSettingsChangePassword";
            btnSettingsChangePassword.Size = new Size(250, 44);
            btnSettingsChangePassword.TabIndex = 1;
            btnSettingsChangePassword.Click += BtnSettingsChangePassword_Click;
            // 
            // btnSettingsChangeEmail
            // 
            btnSettingsChangeEmail.Cursor = Cursors.Hand;
            btnSettingsChangeEmail.Location = new Point(1132, 136);
            btnSettingsChangeEmail.Name = "btnSettingsChangeEmail";
            btnSettingsChangeEmail.Size = new Size(250, 44);
            btnSettingsChangeEmail.TabIndex = 0;
            btnSettingsChangeEmail.Click += BtnSettingsChangeEmail_Click;
            // 
            // pnlSettingsChange
            // 
            pnlSettingsChange.BackColor = Color.Transparent;
            pnlSettingsChange.BackgroundImage = Properties.Resources.Account__Change_Email__Screen;
            pnlSettingsChange.BackgroundImageLayout = ImageLayout.None;
            pnlSettingsChange.Controls.Add(btnShowPass1);
            pnlSettingsChange.Controls.Add(btnShowPass3);
            pnlSettingsChange.Controls.Add(btnShowPass2);
            pnlSettingsChange.Controls.Add(txtSettingsChangeNew2);
            pnlSettingsChange.Controls.Add(txtSettingsChangeNew);
            pnlSettingsChange.Controls.Add(txtSettingsChangeOld);
            pnlSettingsChange.Controls.Add(btnSettingsAccountSave);
            pnlSettingsChange.Location = new Point(0, 0);
            pnlSettingsChange.Name = "pnlSettingsChange";
            pnlSettingsChange.Size = new Size(1600, 960);
            pnlSettingsChange.TabIndex = 7;
            // 
            // btnShowPass1
            // 
            btnShowPass1.BackgroundImage = Properties.Resources.Show_Icon;
            btnShowPass1.BackgroundImageLayout = ImageLayout.Center;
            btnShowPass1.Cursor = Cursors.Hand;
            btnShowPass1.Location = new Point(1380, 201);
            btnShowPass1.Name = "btnShowPass1";
            btnShowPass1.Size = new Size(80, 58);
            btnShowPass1.TabIndex = 5;
            btnShowPass1.Visible = false;
            btnShowPass1.Click += BtnShowPass1_Click;
            // 
            // btnShowPass3
            // 
            btnShowPass3.BackgroundImage = Properties.Resources.Show_Icon;
            btnShowPass3.BackgroundImageLayout = ImageLayout.Center;
            btnShowPass3.Cursor = Cursors.Hand;
            btnShowPass3.Location = new Point(1380, 384);
            btnShowPass3.Name = "btnShowPass3";
            btnShowPass3.Size = new Size(80, 56);
            btnShowPass3.TabIndex = 5;
            btnShowPass3.Visible = false;
            btnShowPass3.Click += BtnShowPass3_Click;
            // 
            // btnShowPass2
            // 
            btnShowPass2.BackgroundImage = Properties.Resources.Show_Icon;
            btnShowPass2.BackgroundImageLayout = ImageLayout.Center;
            btnShowPass2.Cursor = Cursors.Hand;
            btnShowPass2.Location = new Point(1380, 295);
            btnShowPass2.Name = "btnShowPass2";
            btnShowPass2.Size = new Size(80, 60);
            btnShowPass2.TabIndex = 4;
            btnShowPass2.Visible = false;
            btnShowPass2.Click += BtnShowPass2_Click;
            // 
            // txtSettingsChangeNew2
            // 
            txtSettingsChangeNew2.BackColor = Color.FromArgb(194, 194, 194);
            txtSettingsChangeNew2.BorderStyle = BorderStyle.None;
            txtSettingsChangeNew2.Font = new Font("Comic Sans MS", 20F);
            txtSettingsChangeNew2.Location = new Point(1013, 402);
            txtSettingsChangeNew2.Name = "txtSettingsChangeNew2";
            txtSettingsChangeNew2.Size = new Size(366, 38);
            txtSettingsChangeNew2.TabIndex = 3;
            txtSettingsChangeNew2.KeyPress += HandleKeyPress;
            // 
            // txtSettingsChangeNew
            // 
            txtSettingsChangeNew.BackColor = Color.FromArgb(194, 194, 194);
            txtSettingsChangeNew.BorderStyle = BorderStyle.None;
            txtSettingsChangeNew.Font = new Font("Comic Sans MS", 20F);
            txtSettingsChangeNew.Location = new Point(1013, 314);
            txtSettingsChangeNew.Name = "txtSettingsChangeNew";
            txtSettingsChangeNew.Size = new Size(366, 38);
            txtSettingsChangeNew.TabIndex = 2;
            txtSettingsChangeNew.KeyPress += HandleKeyPress;
            // 
            // txtSettingsChangeOld
            // 
            txtSettingsChangeOld.BackColor = Color.FromArgb(194, 194, 194);
            txtSettingsChangeOld.BorderStyle = BorderStyle.None;
            txtSettingsChangeOld.Font = new Font("Comic Sans MS", 20F);
            txtSettingsChangeOld.Location = new Point(1013, 221);
            txtSettingsChangeOld.Name = "txtSettingsChangeOld";
            txtSettingsChangeOld.Size = new Size(366, 38);
            txtSettingsChangeOld.TabIndex = 1;
            txtSettingsChangeOld.KeyPress += HandleKeyPress;
            // 
            // btnSettingsAccountSave
            // 
            btnSettingsAccountSave.Cursor = Cursors.Hand;
            btnSettingsAccountSave.Location = new Point(935, 523);
            btnSettingsAccountSave.Name = "btnSettingsAccountSave";
            btnSettingsAccountSave.Size = new Size(155, 50);
            btnSettingsAccountSave.TabIndex = 0;
            btnSettingsAccountSave.Click += BtnSettingsAccountSave_Click;
            // 
            // pnlSettingsBackup
            // 
            pnlSettingsBackup.BackColor = Color.Transparent;
            pnlSettingsBackup.BackgroundImage = Properties.Resources.Settings_Screen__Backup_;
            pnlSettingsBackup.BackgroundImageLayout = ImageLayout.None;
            pnlSettingsBackup.Controls.Add(cbxBackupDescending);
            pnlSettingsBackup.Controls.Add(cbxBackupSortLastUpdated);
            pnlSettingsBackup.Controls.Add(lblBackupImportFilename);
            pnlSettingsBackup.Controls.Add(btnBackupStartImport);
            pnlSettingsBackup.Controls.Add(btnBackupExport);
            pnlSettingsBackup.Controls.Add(btnBackupImport);
            pnlSettingsBackup.Location = new Point(0, 0);
            pnlSettingsBackup.Name = "pnlSettingsBackup";
            pnlSettingsBackup.Size = new Size(1600, 960);
            pnlSettingsBackup.TabIndex = 0;
            // 
            // cbxBackupDescending
            // 
            cbxBackupDescending.AutoSize = true;
            cbxBackupDescending.Cursor = Cursors.Hand;
            cbxBackupDescending.Font = new Font("Comic Sans MS", 15F);
            cbxBackupDescending.Location = new Point(960, 589);
            cbxBackupDescending.Name = "cbxBackupDescending";
            cbxBackupDescending.Size = new Size(136, 32);
            cbxBackupDescending.TabIndex = 4;
            cbxBackupDescending.Text = "Descending";
            cbxBackupDescending.UseVisualStyleBackColor = true;
            // 
            // cbxBackupSortLastUpdated
            // 
            cbxBackupSortLastUpdated.AutoSize = true;
            cbxBackupSortLastUpdated.Cursor = Cursors.Hand;
            cbxBackupSortLastUpdated.Font = new Font("Comic Sans MS", 15F);
            cbxBackupSortLastUpdated.Location = new Point(788, 589);
            cbxBackupSortLastUpdated.Name = "cbxBackupSortLastUpdated";
            cbxBackupSortLastUpdated.Size = new Size(155, 32);
            cbxBackupSortLastUpdated.TabIndex = 3;
            cbxBackupSortLastUpdated.Text = "Last Updated";
            cbxBackupSortLastUpdated.UseVisualStyleBackColor = true;
            // 
            // lblBackupImportFilename
            // 
            lblBackupImportFilename.AutoSize = true;
            lblBackupImportFilename.Font = new Font("Comic Sans MS", 20F);
            lblBackupImportFilename.Location = new Point(825, 329);
            lblBackupImportFilename.Name = "lblBackupImportFilename";
            lblBackupImportFilename.Size = new Size(149, 38);
            lblBackupImportFilename.TabIndex = 2;
            lblBackupImportFilename.Text = "Load a file";
            // 
            // btnBackupStartImport
            // 
            btnBackupStartImport.BackgroundImage = Properties.Resources.import_btn_disable;
            btnBackupStartImport.BackgroundImageLayout = ImageLayout.Center;
            btnBackupStartImport.Cursor = Cursors.No;
            btnBackupStartImport.Enabled = false;
            btnBackupStartImport.Location = new Point(653, 384);
            btnBackupStartImport.Name = "btnBackupStartImport";
            btnBackupStartImport.Size = new Size(156, 48);
            btnBackupStartImport.TabIndex = 1;
            btnBackupStartImport.Click += BtnBackupStartImport_Click;
            // 
            // btnBackupExport
            // 
            btnBackupExport.Cursor = Cursors.Hand;
            btnBackupExport.Location = new Point(653, 644);
            btnBackupExport.Name = "btnBackupExport";
            btnBackupExport.Size = new Size(156, 44);
            btnBackupExport.TabIndex = 1;
            btnBackupExport.Click += BtnBackupExport_Click;
            // 
            // btnBackupImport
            // 
            btnBackupImport.Cursor = Cursors.Hand;
            btnBackupImport.Location = new Point(653, 324);
            btnBackupImport.Name = "btnBackupImport";
            btnBackupImport.Size = new Size(156, 44);
            btnBackupImport.TabIndex = 0;
            btnBackupImport.Click += BtnBackupImport_Click;
            // 
            // pnlSettingsBackupMpinHolder
            // 
            pnlSettingsBackupMpinHolder.BackColor = Color.Transparent;
            pnlSettingsBackupMpinHolder.BackgroundImage = Properties.Resources.Settings_SCreen__Backup_MPIN_;
            pnlSettingsBackupMpinHolder.BackgroundImageLayout = ImageLayout.Center;
            pnlSettingsBackupMpinHolder.Controls.Add(btnBackupStartExport);
            pnlSettingsBackupMpinHolder.Controls.Add(backupMpin_6);
            pnlSettingsBackupMpinHolder.Controls.Add(backupMpin_5);
            pnlSettingsBackupMpinHolder.Controls.Add(backupMpin_4);
            pnlSettingsBackupMpinHolder.Controls.Add(backupMpin_3);
            pnlSettingsBackupMpinHolder.Controls.Add(backupMpin_2);
            pnlSettingsBackupMpinHolder.Controls.Add(backupMpin_1);
            pnlSettingsBackupMpinHolder.Location = new Point(0, 0);
            pnlSettingsBackupMpinHolder.Name = "pnlSettingsBackupMpinHolder";
            pnlSettingsBackupMpinHolder.Size = new Size(1600, 980);
            pnlSettingsBackupMpinHolder.TabIndex = 5;
            pnlSettingsBackupMpinHolder.KeyDown += PnlBackupMpinHolder_KeyDown;
            // 
            // btnBackupStartExport
            // 
            btnBackupStartExport.Cursor = Cursors.Hand;
            btnBackupStartExport.Location = new Point(929, 701);
            btnBackupStartExport.Name = "btnBackupStartExport";
            btnBackupStartExport.Size = new Size(156, 47);
            btnBackupStartExport.TabIndex = 7;
            btnBackupStartExport.Click += BtnBackupStartExport_Click;
            // 
            // backupMpin_6
            // 
            backupMpin_6.BackgroundImage = Properties.Resources.MPIN_Blank__Backup_;
            backupMpin_6.BackgroundImageLayout = ImageLayout.Center;
            backupMpin_6.Cursor = Cursors.IBeam;
            backupMpin_6.Location = new Point(1372, 411);
            backupMpin_6.Name = "backupMpin_6";
            backupMpin_6.Size = new Size(146, 143);
            backupMpin_6.TabIndex = 5;
            // 
            // backupMpin_5
            // 
            backupMpin_5.BackgroundImage = Properties.Resources.MPIN_Blank__Backup_;
            backupMpin_5.BackgroundImageLayout = ImageLayout.Center;
            backupMpin_5.Cursor = Cursors.IBeam;
            backupMpin_5.Location = new Point(1198, 411);
            backupMpin_5.Name = "backupMpin_5";
            backupMpin_5.Size = new Size(146, 143);
            backupMpin_5.TabIndex = 4;
            // 
            // backupMpin_4
            // 
            backupMpin_4.BackgroundImage = Properties.Resources.MPIN_Blank__Backup_;
            backupMpin_4.BackgroundImageLayout = ImageLayout.Center;
            backupMpin_4.Cursor = Cursors.IBeam;
            backupMpin_4.Location = new Point(1024, 411);
            backupMpin_4.Name = "backupMpin_4";
            backupMpin_4.Size = new Size(146, 143);
            backupMpin_4.TabIndex = 3;
            // 
            // backupMpin_3
            // 
            backupMpin_3.BackgroundImage = Properties.Resources.MPIN_Blank__Backup_;
            backupMpin_3.BackgroundImageLayout = ImageLayout.Center;
            backupMpin_3.Cursor = Cursors.IBeam;
            backupMpin_3.Location = new Point(850, 411);
            backupMpin_3.Name = "backupMpin_3";
            backupMpin_3.Size = new Size(146, 143);
            backupMpin_3.TabIndex = 2;
            // 
            // backupMpin_2
            // 
            backupMpin_2.BackgroundImage = Properties.Resources.MPIN_Blank__Backup_;
            backupMpin_2.BackgroundImageLayout = ImageLayout.Center;
            backupMpin_2.Cursor = Cursors.IBeam;
            backupMpin_2.Location = new Point(676, 411);
            backupMpin_2.Name = "backupMpin_2";
            backupMpin_2.Size = new Size(146, 143);
            backupMpin_2.TabIndex = 1;
            // 
            // backupMpin_1
            // 
            backupMpin_1.BackgroundImage = Properties.Resources.MPIN_Blank__Backup_;
            backupMpin_1.BackgroundImageLayout = ImageLayout.Center;
            backupMpin_1.Cursor = Cursors.IBeam;
            backupMpin_1.Location = new Point(502, 411);
            backupMpin_1.Name = "backupMpin_1";
            backupMpin_1.Size = new Size(146, 143);
            backupMpin_1.TabIndex = 0;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Excel File (*.xlsx)|*.xlsx";
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.FileName = "neko_keep_accounts.xlsx";
            saveFileDialog.Filter = "*.xlsx|*.csv";
            // 
            // pnlSettingsAbout
            // 
            pnlSettingsAbout.BackColor = Color.Transparent;
            pnlSettingsAbout.Location = new Point(0, 0);
            pnlSettingsAbout.Name = "pnlSettingsAbout";
            pnlSettingsAbout.Size = new Size(1600, 980);
            pnlSettingsAbout.TabIndex = 8;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Settings_Screen;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1600, 941);
            Controls.Add(btnCloseMainContextMenu);
            Controls.Add(btnSettingsAccount);
            Controls.Add(btnSettingsBackup);
            Controls.Add(btnSettingsAbout);
            Controls.Add(pnlSettingsAbout);
            Controls.Add(pnlSettingsBackupMpinHolder);
            Controls.Add(pnlSettingsBackup);
            Controls.Add(pnlSettingsChange);
            Controls.Add(pnlSettingsAccount);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FrmSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NekoKeep";
            pnlSettingsAccount.ResumeLayout(false);
            pnlSettingsChange.ResumeLayout(false);
            pnlSettingsChange.PerformLayout();
            pnlSettingsBackup.ResumeLayout(false);
            pnlSettingsBackup.PerformLayout();
            pnlSettingsBackupMpinHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel btnSettingsAccount;
        private Panel btnSettingsBackup;
        private Panel btnSettingsAbout;
        private Panel btnCloseMainContextMenu;
        private Panel pnlSettingsAccount;
        private Panel btnSettingsChangeEmail;
        private Panel btnSettingsChangeMpin;
        private Panel btnSettingsChangePassword;
        private Label lblEmail;
        private Label lblSettingsPassword;
        private Label lblSettingsMpin;
        private Panel pnlSettingsChange;
        private Panel btnSettingsAccountSave;
        private TextBox txtSettingsChangeNew;
        private TextBox txtSettingsChangeOld;
        private TextBox txtSettingsChangeNew2;
        private Panel btnShowPass2;
        private Panel btnShowPass3;
        private Panel btnShowPass1;
        private Panel pnlSettingsBackup;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Panel btnBackupExport;
        private Panel btnBackupImport;
        private Panel btnBackupStartImport;
        private Label lblBackupImportFilename;
        private CheckBox cbxBackupSortLastUpdated;
        private CheckBox cbxBackupDescending;
        private Panel pnlSettingsBackupMpinHolder;
        private Panel backupMpin_1;
        private Panel backupMpin_2;
        private Panel backupMpin_6;
        private Panel backupMpin_5;
        private Panel backupMpin_4;
        private Panel backupMpin_3;
        private Panel btnBackupStartExport;
        private Panel pnlSettingsAbout;
    }
}