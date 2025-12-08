using NekoKeep.Backend;
using NekoKeep.Backend.Databases;
using NekoKeep.Backend.Interfaces;
using System.Reflection;

namespace NekoKeep.Forms
{
    public partial class FrmOnboarding : Form
    {
        private readonly AppContext ctx;
        public FrmOnboarding(AppContext ctx)
        {
            InitializeComponent();
            this.ctx = ctx;

            EnableDoubleBuffer(this);
            EnableDoubleBuffer(mainTabControl);
            foreach (TabPage tabPage in mainTabControl.TabPages)
                EnableDoubleBuffer(tabPage);
        }

        private static void EnableDoubleBuffer(Control control)
        {
            var prop = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            prop?.SetValue(control, true, null);
        }

        private void ClearLoginFields()
        {
            txtLoginEmail.Clear();
            txtLoginPassword.Clear();
        }

        private void BtnRedirectRegister_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = tabRegisterPage;
            ClearLoginFields();
        }

        private void BtnRedirectLogin_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = tabLoginPage;
            ClearLoginFields();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            int user = UsersDB.AuthenticateUser(txtLoginEmail.Text, txtLoginPassword.Text);

            if (user == 1)
            {
                var mainForm = new FrmMain(ctx);
                ctx.SwitchTo(mainForm);
            }
            else if (user == -1)
            {
                Utils.ThrowError("User not found. Please check your email.");
            }
            else if (user == 0)
            {
                Utils.ThrowError("Incorrect password. Please try again.");
            }

            ClearLoginFields();
        }

        private static void ShowOrHidePassword(TextBox textBox, Panel panelButton)
        {
            if (textBox.UseSystemPasswordChar)
            {
                textBox.UseSystemPasswordChar = false;
                panelButton.BackgroundImage = Properties.Resources.Hide_Icon;
            }
            else
            {
                textBox.UseSystemPasswordChar = true;
                panelButton.BackgroundImage = Properties.Resources.Show_Icon;
            }
        }

        private void BtnLoginPassShow_Click(object sender, EventArgs e) => ShowOrHidePassword(txtLoginPassword, btnLoginPassShow);

        private void BtnRegisterPassShow_Click(object sender, EventArgs e) => ShowOrHidePassword(txtRegisterPassword, btnRegisterPassShow);

        private void ClearRegisterFields()
        {
            txtRegisterDisplayName.Clear();
            txtRegisterEmail.Clear();
            txtRegisterPassword.Clear();
            mpin = "";
            UpdateMpinDisplay();
            selectedCatPresetId = 1;
            UpdateCatDisplay();
        }

        private void BtnRegisterContinue_Click(object sender, EventArgs e)
        {
            bool success = true;
            if (string.IsNullOrEmpty(txtRegisterDisplayName.Text) || string.IsNullOrEmpty(txtRegisterEmail.Text) || string.IsNullOrEmpty(txtRegisterPassword.Text))
            {
                Utils.ThrowError("Please fill in all fields.");
                success = false;
            }
            else if (!Utils.ValidateEmail(txtRegisterEmail.Text))
            {
                Utils.ThrowError("Please enter a valid email address.");
                success = false;
            }
            else if (UsersDB.CheckUserEmail(txtRegisterEmail.Text))
            {
                Utils.ThrowError("This email is already registered. Please use a different email.");
                success = false;
            }
            else if (!Utils.ValidatePassword(txtRegisterPassword.Text))
            {
                Utils.ThrowError("Your password must be at least 8 characters and include uppercase and lowercase letters, a number, and a special character.");
                success = false;
            }

            if (!success) ClearRegisterFields();
            else mainTabControl.SelectedTab = tabRegisterMpinPage;
        }

        private string mpin = "";
        private string mpin2 = "";

        private void PnlRegisterMpinHolder_KeyDown(object? sender, KeyEventArgs e)
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

        private void MainTabControl_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (mainTabControl.SelectedTab == tabRegisterMpinPage)
            {
                pnlRegisterMpinHolder.Focus();
            }
            else if (mainTabControl.SelectedTab == tabLoginForgotPassOtp)
            {
                pnlLoginForgotPassOtpHolder.Focus();
            }
        }

        private void UpdateMpinDisplay()
        {
            for (int i = 1; i <= 6; i++)
            {
                var results = tabRegisterMpinPage.Controls.Find("registerMpin_" + i, true);
                if (results.Length > 0 && results[0] is Panel panel)
                {
                    panel.BackgroundImage = i <= mpin.Length
                        ? Properties.Resources.ResourceManager.GetObject("MPIN_" + mpin[i - 1]) as Bitmap
                        : Properties.Resources.MPIN_Blank;

                    panel.Invalidate();
                    panel.Update();
                }
            }
        }

        private bool IsMpinCompleted = false;
        private void BtnRegisterContinue2_Click(object sender, EventArgs e)
        {
            if (!IsMpinCompleted && mpin.Length == 6)
            {
                mpin2 = mpin;
                mpin = "";
                UpdateMpinDisplay();
                IsMpinCompleted = true;
                registerMpinText.BackgroundImage = Properties.Resources.Re_enter_your_MPIN;
            }
            else if (Utils.ValidateMpin(mpin) && mpin2.Equals(mpin) && mpin.Length == 6)
            {
                mainTabControl.SelectedTab = tabRegisterCatSelection;
            }
            else
            {
                bool hasMpin2 = string.IsNullOrWhiteSpace(mpin2) && mpin.Length == 6;
                Utils.ThrowError(hasMpin2
                    ? "Please enter a six-digit MPIN."
                    : "The MPIN entries do not match. Please verify and try again.");

                mpin = "";
                mpin2 = "";
                IsMpinCompleted = false;
                registerMpinText.BackgroundImage = Properties.Resources.Enter_your_MPIN_Text;
                UpdateMpinDisplay();
            }
        }

        private int selectedCatPresetId = 1;
        private void UpdateCatDisplay()
        {
            if (selectedCatPresetId < 1) selectedCatPresetId = 4;
            else if (selectedCatPresetId > 4) selectedCatPresetId = 1;

            registerCatGif.Image = selectedCatPresetId switch
            {
                1 => Properties.Resources.NekoKeep_Night_Cat1,
                2 => Properties.Resources.NekoKeep_Bluey_Cat1,
                3 => Properties.Resources.NekoKeep_Gray_Cat1,
                4 => Properties.Resources.NekoKeep_Orange_Cat1,
                _ => Properties.Resources.NekoKeep_Night_Cat1,
            };
        }

        private void BtnRegisterCatSelectionBackward_Click(object sender, EventArgs e)
        {
            selectedCatPresetId--;
            UpdateCatDisplay();
        }

        private void BtnRegisterCatSelectionForward_Click(object sender, EventArgs e)
        {
            selectedCatPresetId++;
            UpdateCatDisplay();
        }

        private void BtnRegisterContinue3_Click(object sender, EventArgs e)
        {
            string encryptedPassword = Utils.BCryptEncrypt(txtRegisterPassword.Text);
            string encryptedMpin = Utils.BCryptEncrypt(mpin);

            IUser user = new UserDto()
            {
                DisplayName = txtRegisterDisplayName.Text,
                Email = txtRegisterEmail.Text,
                CatPresetId = selectedCatPresetId,
            };

            UsersDB.CreateUser(user, encryptedPassword, encryptedMpin);
            Utils.ThrowSuccess("Registration successful! You can now proceed to log in.");
            ClearRegisterFields();
            mainTabControl.SelectedTab = tabLoginPage;
        }

        private void BtnLoginForgotPass_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = tabLoginForgotPassEmail;
            ClearLoginFields();
        }

        private void ClearOtpFields()
        {
            txtLoginForgotPassEmail.Clear();
            otp = "";
            UpdateOtpDisplay();
            txtLoginChangePass1.Clear();
            txtLoginChangePass2.Clear();
            generatedOtp = null;
        }

        private void BtnLoginGoBack_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = tabLoginPage;
            ClearOtpFields();
        }

        private string otp = "";
        private void PnlLoginForgotPassOtpHolder_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (otp.Length > 0)
                    otp = otp[..^1];
                e.Handled = true;
            }
            else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                if (otp.Length < 6)
                {
                    char digit = (char)('0' + (e.KeyCode - Keys.D0));
                    otp += digit;
                }
                e.Handled = true;
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                if (otp.Length < 6)
                {
                    char digit = (char)('0' + (e.KeyCode - Keys.NumPad0));
                    otp += digit;
                }
                e.Handled = true;
            }

            UpdateOtpDisplay();
        }

        private void UpdateOtpDisplay()
        {
            for (int i = 1; i <= 6; i++)
            {
                var results = tabLoginForgotPassOtp.Controls.Find("loginForgotPassOtp_" + i, true);
                if (results.Length > 0 && results[0] is Panel panel)
                {
                    panel.BackgroundImage = i <= otp.Length
                        ? Properties.Resources.ResourceManager.GetObject("MPIN_" + otp[i - 1]) as Bitmap
                        : Properties.Resources.MPIN_Blank;

                    panel.Invalidate();
                    panel.Update();
                }
            }
        }

        private string? generatedOtp;
        private async void BtnLoginForgotPassNext_Click(object sender, EventArgs e)
        {
            if (!Utils.ValidateEmail(txtLoginForgotPassEmail.Text)) Utils.ThrowError("Please enter a valid email address.");
            else if (!UsersDB.CheckUserEmail(txtLoginForgotPassEmail.Text)) Utils.ThrowError("This email is not registered. Please check and try again.");
            else
            {
                generatedOtp = await Utils.SendOtp(txtLoginForgotPassEmail.Text);
                if (string.IsNullOrEmpty(generatedOtp)) return;

                mainTabControl.SelectedTab = tabLoginForgotPassOtp;
                return;
            }

            ClearOtpFields();
        }

        private void BtnLoginForgotPassLastNext_Click(object sender, EventArgs e)
        {
            if (!otp.Equals(generatedOtp))
            {
                Utils.ThrowError("The OTP you entered is incorrect. Please try again.");
                otp = "";
                UpdateOtpDisplay();
            }
            else mainTabControl.SelectedTab = tabLoginChangePass;
        }

        private void BtnLoginForgotPassChangePass_Click(object sender, EventArgs e)
        {
            if (!Utils.ValidatePassword(txtLoginChangePass1.Text)) Utils.ThrowError("Your password must be at least 8 characters and include uppercase and lowercase letters, a number, and a special character.");
            else if (!txtLoginChangePass1.Text.Equals(txtLoginChangePass2.Text)) Utils.ThrowError("The password confirmation does not match.");
            else
            {
                UsersDB.UpdateUserPassword(txtLoginForgotPassEmail.Text, txtLoginChangePass1.Text);
                Utils.ThrowSuccess("Password reset successfully.");
                ClearOtpFields();
                mainTabControl.SelectedTab = tabLoginPage;
            }
        }

        private void BtnLoginShowChangePass1_Click(object sender, EventArgs e) => ShowOrHidePassword(txtLoginChangePass1, btnLoginShowChangePass1);

        private void BtnLoginShowChangePass2_Click(object sender, EventArgs e) => ShowOrHidePassword(txtLoginChangePass2, btnLoginShowChangePass2);
    }
}

