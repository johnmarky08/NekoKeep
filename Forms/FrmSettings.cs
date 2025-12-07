using NekoKeep.Backend;
using NekoKeep.Backend.Classes;
using NekoKeep.Backend.Databases;
using System.Reflection;
using System.Text.RegularExpressions;

namespace NekoKeep.Forms
{
    public partial class FrmSettings : Form
    {
        private readonly AppContext ctx;
        [GeneratedRegex(@"^(.)([^@]+)")]
        private static partial Regex EmailRegex();

        public FrmSettings(AppContext ctx)
        {
            InitializeComponent();
            EnableDoubleBuffer(this);
            EnableDoubleBuffer(pnlSettingsAccount);
            EnableDoubleBuffer(pnlSettingsChange);
            EnableDoubleBuffer(pnlSettingsBackup);
            EnableDoubleBuffer(pnlSettingsBackupMpinHolder);
            EnableDoubleBuffer(pnlSettingsAbout);

            this.ctx = ctx;
            lblEmail.Text = EmailRegex().Replace(User.Session!.Email, static m => m.Groups[1].Value + new string('-', m.Groups[2].Value.Length));
            ChangeSettingsTab(true, false, false);
        }

        private static void EnableDoubleBuffer(Control control)
        {
            var prop = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            prop?.SetValue(control, true, null);
        }

        private void ChangeSettingsTab(bool account, bool backup, bool about)
        {
            lblBackupImportFilename.Text = "Load a file";
            btnBackupStartImport.Enabled = false;
            btnBackupStartImport.Cursor = Cursors.No;
            btnBackupStartImport.BackgroundImage = Properties.Resources.import_btn_disable;
            type = null;

            btnSettingsAccount.BackgroundImage = account ? Properties.Resources.account__selected_ : Properties.Resources.Account;
            btnSettingsBackup.BackgroundImage = backup ? Properties.Resources.backup__selected_ : Properties.Resources.Backup;
            btnSettingsAbout.BackgroundImage = about ? Properties.Resources.About_us__selected_ : Properties.Resources.About_Us;
            pnlSettingsChange.Visible = false;
            pnlSettingsBackupMpinHolder.Visible = false;
            pnlSettingsAccount.Visible = account;
            pnlSettingsBackup.Visible = backup;
            pnlSettingsAbout.Visible = about;
            Invalidate();
            Update();
        }

        private void BtnSettingsAccount_Click(object sender, EventArgs e) => ChangeSettingsTab(true, false, false);

        private void BtnSettingsBackup_Click(object sender, EventArgs e) => ChangeSettingsTab(false, true, false);

        private void BtnSettingsAbout_Click(object sender, EventArgs e) => ChangeSettingsTab(false, false, true);

        private void BtnCloseMainContextMenu_Click(object sender, EventArgs e)
        {
            var mainForm = new FrmMain(ctx);
            ctx.SwitchTo(mainForm);
        }

        private string? type = null;

        private void ShowSettingsChange(Image bgImage, string newType)
        {
            type = newType;
            pnlSettingsAccount.Visible = false;
            pnlSettingsChange.Visible = true;
            pnlSettingsChange.BackgroundImage = bgImage;

            string[] hiddedTypes = ["password", "mpin"];
            if (hiddedTypes.Contains(type))
            {
                btnShowPass1.Visible = true;
                btnShowPass2.Visible = true;
                btnShowPass3.Visible = true;
                txtSettingsChangeOld.Size = new Size(366, 38);
                txtSettingsChangeNew.Size = new Size(366, 38);
                txtSettingsChangeNew2.Size = new Size(366, 38);
                txtSettingsChangeOld.UseSystemPasswordChar = true;
                txtSettingsChangeNew.UseSystemPasswordChar = true;
                txtSettingsChangeNew2.UseSystemPasswordChar = true;
            }
            else
            {
                btnShowPass1.Visible = false;
                btnShowPass2.Visible = false;
                btnShowPass3.Visible = false;
                txtSettingsChangeOld.Size = new Size(447, 38);
                txtSettingsChangeNew.Size = new Size(447, 38);
                txtSettingsChangeNew2.Size = new Size(447, 38);
                txtSettingsChangeOld.UseSystemPasswordChar = false;
                txtSettingsChangeNew.UseSystemPasswordChar = false;
                txtSettingsChangeNew2.UseSystemPasswordChar = false;
            }

            ClearSettingsChangeFields();
            pnlSettingsChange.Invalidate();
            pnlSettingsChange.Update();
        }

        private static void ShowHidePass(TextBox textBox, Panel btn)
        {
            if (textBox.UseSystemPasswordChar)
            {
                textBox.UseSystemPasswordChar = false;
                btn.BackgroundImage = Properties.Resources.Hide_Icon;
            }
            else
            {
                textBox.UseSystemPasswordChar = true;
                btn.BackgroundImage = Properties.Resources.Show_Icon;
            }
        }

        private void BtnSettingsChangeEmail_Click(object sender, EventArgs e) => ShowSettingsChange(Properties.Resources.Account__Change_Email__Screen, "email");

        private void BtnSettingsChangePassword_Click(object sender, EventArgs e) => ShowSettingsChange(Properties.Resources.Account__Change_Password__Screen, "password");

        private void BtnSettingsChangeMpin_Click(object sender, EventArgs e) => ShowSettingsChange(Properties.Resources.Account__Change_MPIN__Screen, "mpin");


        private void BtnSettingsAccountSave_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "email":
                    {
                        if (!User.Session!.Email.Equals(txtSettingsChangeOld.Text)) Utils.ThrowError("The old email you entered is incorrect.");
                        else if (!Utils.ValidateEmail(txtSettingsChangeNew.Text)) Utils.ThrowError("The new email you entered is not valid.");
                        else if (!txtSettingsChangeNew.Text.Equals(txtSettingsChangeNew2.Text)) Utils.ThrowError("The new email confirmation does not match.");
                        else if (User.Session.Email.Equals(txtSettingsChangeNew.Text)) Utils.ThrowError("The new email you entered is the same as the current one.");
                        else
                        {
                            UsersDB.UpdateUserEmail(User.Session.Id, txtSettingsChangeNew.Text);
                            lblEmail.Text = EmailRegex().Replace(txtSettingsChangeNew.Text, static m => m.Groups[1].Value + new string('-', m.Groups[2].Value.Length));
                            Utils.ThrowSuccess("Email updated successfully.");
                        }
                        break;
                    }
                case "password":
                    {
                        if (!User.VerifyPassword(txtSettingsChangeOld.Text)) Utils.ThrowError("The old password you entered is incorrect.");
                        else if (!Utils.ValidatePassword(txtSettingsChangeNew.Text)) Utils.ThrowError("The new password you entered is not valid.");
                        else if (!txtSettingsChangeNew.Text.Equals(txtSettingsChangeNew2.Text)) Utils.ThrowError("The new password confirmation does not match.");
                        else if (txtSettingsChangeOld.Text.Equals(txtSettingsChangeNew.Text)) Utils.ThrowError("The new password you entered is the same as the current one.");
                        else
                        {
                            UsersDB.UpdateUserPassword(User.Session!.Id, txtSettingsChangeNew.Text);
                            Utils.ThrowSuccess("Password updated successfully.");
                        }
                        break;
                    }
                case "mpin":
                    {
                        if (!User.VerifyMpin(txtSettingsChangeOld.Text)) Utils.ThrowError("The old MPIN you entered is incorrect.");
                        else if (!Utils.ValidateMpin(txtSettingsChangeNew.Text)) Utils.ThrowError("The new MPIN you entered is not valid.");
                        else if (!txtSettingsChangeNew.Text.Equals(txtSettingsChangeNew2.Text)) Utils.ThrowError("The new MPIN confirmation does not match.");
                        else if (txtSettingsChangeOld.Text.Equals(txtSettingsChangeNew.Text)) Utils.ThrowError("The new MPIN you entered is the same as the current one.");
                        else
                        {
                            UsersDB.UpdateUserMpin(User.Session!.Id, txtSettingsChangeNew.Text);
                            Utils.ThrowSuccess("MPIN updated successfully.");
                        }
                        break;
                    }
            }

            ClearSettingsChangeFields();
            type = null;
            pnlSettingsAccount.Visible = true;
            pnlSettingsChange.Visible = false;
        }

        private void ClearSettingsChangeFields()
        {
            txtSettingsChangeOld.Text = string.Empty;
            txtSettingsChangeNew.Text = string.Empty;
            txtSettingsChangeNew2.Text = string.Empty;
        }

        private void BtnShowPass1_Click(object sender, EventArgs e) => ShowHidePass(txtSettingsChangeOld, btnShowPass1);

        private void BtnShowPass2_Click(object sender, EventArgs e) => ShowHidePass(txtSettingsChangeNew, btnShowPass2);

        private void BtnShowPass3_Click(object sender, EventArgs e) => ShowHidePass(txtSettingsChangeNew2, btnShowPass3);

        private void BtnBackupImport_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Import Backup File";
            openFileDialog.Filter = "Excel File (*.xlsx)|*.xlsx";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblBackupImportFilename.Text = openFileDialog.SafeFileName;
                btnBackupStartImport.Enabled = true;
                btnBackupStartImport.Cursor = Cursors.Hand;
                btnBackupStartImport.BackgroundImage = Properties.Resources.import_btn;
            }
        }

        private void BtnBackupStartImport_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                try
                {
                    Backup.Import(openFileDialog.FileName);
                    Utils.ThrowSuccess("Backup imported successfully.");
                    lblBackupImportFilename.Text = "Load a file";
                    btnBackupStartImport.Enabled = false;
                    btnBackupStartImport.Cursor = Cursors.No;
                    btnBackupStartImport.BackgroundImage = Properties.Resources.import_btn_disable;
                }
                catch (Exception ex)
                {
                    Utils.ThrowError("An error occurred while importing the backup: " + ex.Message);
                }
            }
        }

        private void BtnBackupExport_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "Export Backup File";
            saveFileDialog.Filter = "Excel File (*.xlsx)|*.xlsx";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.FileName = "neko_keep_backup.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pnlSettingsBackupMpinHolder.Visible = true;
                pnlSettingsBackup.Visible = false;
                pnlSettingsBackupMpinHolder.Focus();
            }
        }

        private string mpin = "";

        private void PnlBackupMpinHolder_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (mpin.Length > 0)
                    mpin = mpin[..^1];
                e.Handled = true;
            }
            else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                if (mpin.Length < 6)
                {
                    char digit = (char)('0' + (e.KeyCode - Keys.D0));
                    mpin += digit;
                }
                e.Handled = true;
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                if (mpin.Length < 6)
                {
                    char digit = (char)('0' + (e.KeyCode - Keys.NumPad0));
                    mpin += digit;
                }
                e.Handled = true;
            }

            UpdateMpinDisplay();
        }

        private void UpdateMpinDisplay()
        {
            for (int i = 1; i <= 6; i++)
            {
                var results = pnlSettingsBackupMpinHolder.Controls.Find("backupMpin_" + i, true);
                if (results.Length > 0 && results[0] is Panel panel)
                {
                    panel.BackgroundImage = i <= mpin.Length
                        ? Properties.Resources.MPIN_Asterisk__Backup_
                        : Properties.Resources.MPIN_Blank__Backup_;

                    panel.Invalidate();
                    panel.Update();
                }
            }
        }

        private void ClearMpinDisplay()
        {
            mpin = "";
            UpdateMpinDisplay();
        }

        private void BtnBackupStartExport_Click(object sender, EventArgs e)
        {
            if (!Utils.ValidateMpin(mpin))
            {
                Utils.ThrowError("The MPIN you entered is not valid.");
                ClearMpinDisplay();
                return;
            }
            else if (!User.VerifyMpin(mpin))
            {
                Utils.ThrowError("The MPIN you entered is incorrect.");
                ClearMpinDisplay();
                return;
            }

            try
            {
                Backup.Export(saveFileDialog.FileName, cbxBackupSortLastUpdated.Checked, cbxBackupDescending.Checked, mpin);
                Utils.ThrowSuccess("Backup exported successfully.");
                ClearMpinDisplay();
                pnlSettingsBackupMpinHolder.Visible = false;
                pnlSettingsBackup.Visible = true;
                pnlSettingsBackup.Focus();
            }
            catch (Exception ex)
            {
                Utils.ThrowError("An error occurred while exporting the backup: " + ex.Message);
            }
        }

        private void HandleKeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = type != null
                && type.Equals("mpin")
                && ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    || (sender is TextBox tb && tb.Text.Length >= 6 && !char.IsControl(e.KeyChar)));
    }
}
