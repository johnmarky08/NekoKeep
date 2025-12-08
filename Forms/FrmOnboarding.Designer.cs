namespace NekoKeep.Forms
{
    partial class FrmOnboarding
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOnboarding));
            mainTabControl = new TabControl();
            tabLoginPage = new TabPage();
            btnLoginForgotPass = new Panel();
            btnLoginPassShow = new Panel();
            btnRedirectRegister = new Panel();
            btnLogin = new Panel();
            txtLoginPassword = new TextBox();
            txtLoginEmail = new TextBox();
            tabRegisterPage = new TabPage();
            btnRegisterPassShow = new Panel();
            btnRedirectLogin = new Panel();
            btnRegisterContinue = new Panel();
            txtRegisterPassword = new TextBox();
            txtRegisterEmail = new TextBox();
            txtRegisterDisplayName = new TextBox();
            tabRegisterMpinPage = new TabPage();
            btnRegisterContinue2 = new Panel();
            registerMpinText = new Panel();
            pnlRegisterMpinHolder = new Panel();
            registerMpin_6 = new Panel();
            registerMpin_5 = new Panel();
            registerMpin_4 = new Panel();
            registerMpin_3 = new Panel();
            registerMpin_2 = new Panel();
            registerMpin_1 = new Panel();
            tabRegisterCatSelection = new TabPage();
            btnRegisterContinue3 = new Panel();
            btnRegisterCatSelectionBackward = new Panel();
            btnRegisterCatSelectionForward = new Panel();
            registerCatGif = new PictureBox();
            tabLoginForgotPassEmail = new TabPage();
            btnLoginGoBack = new Panel();
            btnLoginForgotPassNext = new Panel();
            txtLoginForgotPassEmail = new TextBox();
            tabLoginForgotPassOtp = new TabPage();
            btnLoginForgotPassLastNext = new Panel();
            pnlLoginForgotPassOtpHolder = new Panel();
            loginForgotPassOtp_6 = new Panel();
            loginForgotPassOtp_5 = new Panel();
            loginForgotPassOtp_4 = new Panel();
            loginForgotPassOtp_3 = new Panel();
            loginForgotPassOtp_2 = new Panel();
            loginForgotPassOtp_1 = new Panel();
            tabLoginChangePass = new TabPage();
            btnLoginShowChangePass2 = new Panel();
            btnLoginShowChangePass1 = new Panel();
            btnLoginForgotPassChangePass = new Panel();
            txtLoginChangePass2 = new TextBox();
            txtLoginChangePass1 = new TextBox();
            mainTabControl.SuspendLayout();
            tabLoginPage.SuspendLayout();
            tabRegisterPage.SuspendLayout();
            tabRegisterMpinPage.SuspendLayout();
            pnlRegisterMpinHolder.SuspendLayout();
            tabRegisterCatSelection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)registerCatGif).BeginInit();
            tabLoginForgotPassEmail.SuspendLayout();
            tabLoginForgotPassOtp.SuspendLayout();
            pnlLoginForgotPassOtpHolder.SuspendLayout();
            tabLoginChangePass.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(tabLoginPage);
            mainTabControl.Controls.Add(tabRegisterPage);
            mainTabControl.Controls.Add(tabRegisterMpinPage);
            mainTabControl.Controls.Add(tabRegisterCatSelection);
            mainTabControl.Controls.Add(tabLoginForgotPassEmail);
            mainTabControl.Controls.Add(tabLoginForgotPassOtp);
            mainTabControl.Controls.Add(tabLoginChangePass);
            mainTabControl.Location = new Point(-4, -24);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(1608, 968);
            mainTabControl.TabIndex = 0;
            mainTabControl.TabStop = false;
            mainTabControl.SelectedIndexChanged += MainTabControl_SelectedIndexChanged;
            // 
            // tabLoginPage
            // 
            tabLoginPage.BackgroundImage = Properties.Resources.Login_Form;
            tabLoginPage.Controls.Add(btnLoginForgotPass);
            tabLoginPage.Controls.Add(btnLoginPassShow);
            tabLoginPage.Controls.Add(btnRedirectRegister);
            tabLoginPage.Controls.Add(btnLogin);
            tabLoginPage.Controls.Add(txtLoginPassword);
            tabLoginPage.Controls.Add(txtLoginEmail);
            tabLoginPage.Location = new Point(4, 24);
            tabLoginPage.Name = "tabLoginPage";
            tabLoginPage.Size = new Size(1600, 940);
            tabLoginPage.TabIndex = 3;
            tabLoginPage.Text = "tabLoginPage";
            tabLoginPage.UseVisualStyleBackColor = true;
            // 
            // btnLoginForgotPass
            // 
            btnLoginForgotPass.Cursor = Cursors.Hand;
            btnLoginForgotPass.Location = new Point(838, 728);
            btnLoginForgotPass.Name = "btnLoginForgotPass";
            btnLoginForgotPass.Size = new Size(172, 33);
            btnLoginForgotPass.TabIndex = 6;
            btnLoginForgotPass.Click += BtnLoginForgotPass_Click;
            // 
            // btnLoginPassShow
            // 
            btnLoginPassShow.BackgroundImage = Properties.Resources.Show_Icon;
            btnLoginPassShow.BackgroundImageLayout = ImageLayout.Stretch;
            btnLoginPassShow.Cursor = Cursors.Hand;
            btnLoginPassShow.Location = new Point(949, 662);
            btnLoginPassShow.Name = "btnLoginPassShow";
            btnLoginPassShow.Size = new Size(60, 60);
            btnLoginPassShow.TabIndex = 6;
            btnLoginPassShow.Click += BtnLoginPassShow_Click;
            // 
            // btnRedirectRegister
            // 
            btnRedirectRegister.Cursor = Cursors.Hand;
            btnRedirectRegister.Location = new Point(870, 836);
            btnRedirectRegister.Name = "btnRedirectRegister";
            btnRedirectRegister.Size = new Size(73, 25);
            btnRedirectRegister.TabIndex = 5;
            btnRedirectRegister.Click += BtnRedirectRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Location = new Point(750, 782);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(99, 42);
            btnLogin.TabIndex = 4;
            btnLogin.Click += BtnLogin_Click;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.BorderStyle = BorderStyle.None;
            txtLoginPassword.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLoginPassword.Location = new Point(591, 677);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PlaceholderText = "Password";
            txtLoginPassword.Size = new Size(361, 28);
            txtLoginPassword.TabIndex = 3;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginEmail
            // 
            txtLoginEmail.BorderStyle = BorderStyle.None;
            txtLoginEmail.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLoginEmail.Location = new Point(591, 606);
            txtLoginEmail.Name = "txtLoginEmail";
            txtLoginEmail.PlaceholderText = "Email";
            txtLoginEmail.Size = new Size(400, 28);
            txtLoginEmail.TabIndex = 2;
            // 
            // tabRegisterPage
            // 
            tabRegisterPage.BackgroundImage = Properties.Resources.Register_Form;
            tabRegisterPage.BackgroundImageLayout = ImageLayout.Center;
            tabRegisterPage.Controls.Add(btnRegisterPassShow);
            tabRegisterPage.Controls.Add(btnRedirectLogin);
            tabRegisterPage.Controls.Add(btnRegisterContinue);
            tabRegisterPage.Controls.Add(txtRegisterPassword);
            tabRegisterPage.Controls.Add(txtRegisterEmail);
            tabRegisterPage.Controls.Add(txtRegisterDisplayName);
            tabRegisterPage.Location = new Point(4, 24);
            tabRegisterPage.Name = "tabRegisterPage";
            tabRegisterPage.Padding = new Padding(3);
            tabRegisterPage.Size = new Size(1600, 940);
            tabRegisterPage.TabIndex = 0;
            tabRegisterPage.Text = "tabRagisterPage";
            tabRegisterPage.UseVisualStyleBackColor = true;
            // 
            // btnRegisterPassShow
            // 
            btnRegisterPassShow.BackgroundImage = Properties.Resources.Show_Icon;
            btnRegisterPassShow.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegisterPassShow.Cursor = Cursors.Hand;
            btnRegisterPassShow.Location = new Point(958, 534);
            btnRegisterPassShow.Name = "btnRegisterPassShow";
            btnRegisterPassShow.Size = new Size(60, 60);
            btnRegisterPassShow.TabIndex = 7;
            btnRegisterPassShow.Click += BtnRegisterPassShow_Click;
            // 
            // btnRedirectLogin
            // 
            btnRedirectLogin.Cursor = Cursors.Hand;
            btnRedirectLogin.Location = new Point(893, 718);
            btnRedirectLogin.Name = "btnRedirectLogin";
            btnRedirectLogin.Size = new Size(65, 28);
            btnRedirectLogin.TabIndex = 4;
            btnRedirectLogin.Click += BtnRedirectLogin_Click;
            // 
            // btnRegisterContinue
            // 
            btnRegisterContinue.Cursor = Cursors.Hand;
            btnRegisterContinue.Location = new Point(741, 639);
            btnRegisterContinue.Name = "btnRegisterContinue";
            btnRegisterContinue.Size = new Size(116, 35);
            btnRegisterContinue.TabIndex = 3;
            btnRegisterContinue.Click += BtnRegisterContinue_Click;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.BorderStyle = BorderStyle.None;
            txtRegisterPassword.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegisterPassword.Location = new Point(600, 549);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.PlaceholderText = "Password";
            txtRegisterPassword.Size = new Size(361, 28);
            txtRegisterPassword.TabIndex = 2;
            txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // txtRegisterEmail
            // 
            txtRegisterEmail.BorderStyle = BorderStyle.None;
            txtRegisterEmail.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegisterEmail.Location = new Point(600, 465);
            txtRegisterEmail.Name = "txtRegisterEmail";
            txtRegisterEmail.PlaceholderText = "Email";
            txtRegisterEmail.Size = new Size(400, 28);
            txtRegisterEmail.TabIndex = 1;
            // 
            // txtRegisterDisplayName
            // 
            txtRegisterDisplayName.BorderStyle = BorderStyle.None;
            txtRegisterDisplayName.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegisterDisplayName.Location = new Point(600, 379);
            txtRegisterDisplayName.Name = "txtRegisterDisplayName";
            txtRegisterDisplayName.PlaceholderText = "Display Name";
            txtRegisterDisplayName.Size = new Size(400, 28);
            txtRegisterDisplayName.TabIndex = 0;
            // 
            // tabRegisterMpinPage
            // 
            tabRegisterMpinPage.BackgroundImage = Properties.Resources.MPIN_Form;
            tabRegisterMpinPage.Controls.Add(btnRegisterContinue2);
            tabRegisterMpinPage.Controls.Add(registerMpinText);
            tabRegisterMpinPage.Controls.Add(pnlRegisterMpinHolder);
            tabRegisterMpinPage.Location = new Point(4, 24);
            tabRegisterMpinPage.Name = "tabRegisterMpinPage";
            tabRegisterMpinPage.Size = new Size(1600, 940);
            tabRegisterMpinPage.TabIndex = 1;
            tabRegisterMpinPage.Text = "tabRegisterMpinPage";
            tabRegisterMpinPage.UseVisualStyleBackColor = true;
            // 
            // btnRegisterContinue2
            // 
            btnRegisterContinue2.Cursor = Cursors.Hand;
            btnRegisterContinue2.Location = new Point(722, 654);
            btnRegisterContinue2.Name = "btnRegisterContinue2";
            btnRegisterContinue2.Size = new Size(153, 45);
            btnRegisterContinue2.TabIndex = 3;
            btnRegisterContinue2.Click += BtnRegisterContinue2_Click;
            // 
            // registerMpinText
            // 
            registerMpinText.BackgroundImage = Properties.Resources.Enter_your_MPIN_Text;
            registerMpinText.BackgroundImageLayout = ImageLayout.Center;
            registerMpinText.Location = new Point(593, 562);
            registerMpinText.Name = "registerMpinText";
            registerMpinText.Size = new Size(419, 32);
            registerMpinText.TabIndex = 2;
            // 
            // pnlRegisterMpinHolder
            // 
            pnlRegisterMpinHolder.Controls.Add(registerMpin_6);
            pnlRegisterMpinHolder.Controls.Add(registerMpin_5);
            pnlRegisterMpinHolder.Controls.Add(registerMpin_4);
            pnlRegisterMpinHolder.Controls.Add(registerMpin_3);
            pnlRegisterMpinHolder.Controls.Add(registerMpin_2);
            pnlRegisterMpinHolder.Controls.Add(registerMpin_1);
            pnlRegisterMpinHolder.Location = new Point(258, 326);
            pnlRegisterMpinHolder.Name = "pnlRegisterMpinHolder";
            pnlRegisterMpinHolder.Size = new Size(1081, 236);
            pnlRegisterMpinHolder.TabIndex = 1;
            pnlRegisterMpinHolder.TabStop = true;
            pnlRegisterMpinHolder.KeyDown += PnlRegisterMpinHolder_KeyDown;
            // 
            // registerMpin_6
            // 
            registerMpin_6.BackgroundImage = Properties.Resources.MPIN_Blank;
            registerMpin_6.BackgroundImageLayout = ImageLayout.Center;
            registerMpin_6.Cursor = Cursors.IBeam;
            registerMpin_6.Location = new Point(904, 54);
            registerMpin_6.Name = "registerMpin_6";
            registerMpin_6.Size = new Size(146, 143);
            registerMpin_6.TabIndex = 3;
            // 
            // registerMpin_5
            // 
            registerMpin_5.BackgroundImage = Properties.Resources.MPIN_Blank;
            registerMpin_5.BackgroundImageLayout = ImageLayout.Center;
            registerMpin_5.Cursor = Cursors.IBeam;
            registerMpin_5.Location = new Point(730, 54);
            registerMpin_5.Name = "registerMpin_5";
            registerMpin_5.Size = new Size(146, 143);
            registerMpin_5.TabIndex = 3;
            // 
            // registerMpin_4
            // 
            registerMpin_4.BackgroundImage = Properties.Resources.MPIN_Blank;
            registerMpin_4.BackgroundImageLayout = ImageLayout.Center;
            registerMpin_4.Cursor = Cursors.IBeam;
            registerMpin_4.Location = new Point(556, 54);
            registerMpin_4.Name = "registerMpin_4";
            registerMpin_4.Size = new Size(146, 143);
            registerMpin_4.TabIndex = 3;
            // 
            // registerMpin_3
            // 
            registerMpin_3.BackgroundImage = Properties.Resources.MPIN_Blank;
            registerMpin_3.BackgroundImageLayout = ImageLayout.Center;
            registerMpin_3.Cursor = Cursors.IBeam;
            registerMpin_3.Location = new Point(382, 54);
            registerMpin_3.Name = "registerMpin_3";
            registerMpin_3.Size = new Size(146, 143);
            registerMpin_3.TabIndex = 2;
            // 
            // registerMpin_2
            // 
            registerMpin_2.BackgroundImage = Properties.Resources.MPIN_Blank;
            registerMpin_2.BackgroundImageLayout = ImageLayout.Center;
            registerMpin_2.Cursor = Cursors.IBeam;
            registerMpin_2.Location = new Point(208, 54);
            registerMpin_2.Name = "registerMpin_2";
            registerMpin_2.Size = new Size(146, 143);
            registerMpin_2.TabIndex = 1;
            // 
            // registerMpin_1
            // 
            registerMpin_1.BackgroundImage = Properties.Resources.MPIN_Blank;
            registerMpin_1.BackgroundImageLayout = ImageLayout.Center;
            registerMpin_1.Cursor = Cursors.IBeam;
            registerMpin_1.Location = new Point(34, 54);
            registerMpin_1.Name = "registerMpin_1";
            registerMpin_1.Size = new Size(146, 143);
            registerMpin_1.TabIndex = 0;
            // 
            // tabRegisterCatSelection
            // 
            tabRegisterCatSelection.BackgroundImage = Properties.Resources.Cat_Atelier_Form;
            tabRegisterCatSelection.Controls.Add(btnRegisterContinue3);
            tabRegisterCatSelection.Controls.Add(btnRegisterCatSelectionBackward);
            tabRegisterCatSelection.Controls.Add(btnRegisterCatSelectionForward);
            tabRegisterCatSelection.Controls.Add(registerCatGif);
            tabRegisterCatSelection.Location = new Point(4, 24);
            tabRegisterCatSelection.Name = "tabRegisterCatSelection";
            tabRegisterCatSelection.Size = new Size(1600, 940);
            tabRegisterCatSelection.TabIndex = 2;
            tabRegisterCatSelection.Text = "tabRegisterCatSelection";
            tabRegisterCatSelection.UseVisualStyleBackColor = true;
            // 
            // btnRegisterContinue3
            // 
            btnRegisterContinue3.Cursor = Cursors.Hand;
            btnRegisterContinue3.Location = new Point(724, 858);
            btnRegisterContinue3.Name = "btnRegisterContinue3";
            btnRegisterContinue3.Size = new Size(156, 46);
            btnRegisterContinue3.TabIndex = 3;
            btnRegisterContinue3.Click += BtnRegisterContinue3_Click;
            // 
            // btnRegisterCatSelectionBackward
            // 
            btnRegisterCatSelectionBackward.Cursor = Cursors.Hand;
            btnRegisterCatSelectionBackward.Location = new Point(132, 441);
            btnRegisterCatSelectionBackward.Name = "btnRegisterCatSelectionBackward";
            btnRegisterCatSelectionBackward.Size = new Size(253, 177);
            btnRegisterCatSelectionBackward.TabIndex = 2;
            btnRegisterCatSelectionBackward.Click += BtnRegisterCatSelectionBackward_Click;
            // 
            // btnRegisterCatSelectionForward
            // 
            btnRegisterCatSelectionForward.Cursor = Cursors.Hand;
            btnRegisterCatSelectionForward.Location = new Point(1233, 441);
            btnRegisterCatSelectionForward.Name = "btnRegisterCatSelectionForward";
            btnRegisterCatSelectionForward.Size = new Size(253, 177);
            btnRegisterCatSelectionForward.TabIndex = 1;
            btnRegisterCatSelectionForward.Click += BtnRegisterCatSelectionForward_Click;
            // 
            // registerCatGif
            // 
            registerCatGif.BackgroundImageLayout = ImageLayout.Zoom;
            registerCatGif.Image = Properties.Resources.NekoKeep_Night_Cat1;
            registerCatGif.Location = new Point(604, 144);
            registerCatGif.Name = "registerCatGif";
            registerCatGif.Size = new Size(420, 673);
            registerCatGif.SizeMode = PictureBoxSizeMode.Zoom;
            registerCatGif.TabIndex = 0;
            registerCatGif.TabStop = false;
            // 
            // tabLoginForgotPassEmail
            // 
            tabLoginForgotPassEmail.BackgroundImage = Properties.Resources.Login___Forgot_Pass;
            tabLoginForgotPassEmail.Controls.Add(btnLoginGoBack);
            tabLoginForgotPassEmail.Controls.Add(btnLoginForgotPassNext);
            tabLoginForgotPassEmail.Controls.Add(txtLoginForgotPassEmail);
            tabLoginForgotPassEmail.Location = new Point(4, 24);
            tabLoginForgotPassEmail.Name = "tabLoginForgotPassEmail";
            tabLoginForgotPassEmail.Size = new Size(1600, 940);
            tabLoginForgotPassEmail.TabIndex = 4;
            tabLoginForgotPassEmail.Text = "Login - Forgot Pass";
            tabLoginForgotPassEmail.UseVisualStyleBackColor = true;
            // 
            // btnLoginGoBack
            // 
            btnLoginGoBack.Cursor = Cursors.Hand;
            btnLoginGoBack.Location = new Point(764, 784);
            btnLoginGoBack.Name = "btnLoginGoBack";
            btnLoginGoBack.Size = new Size(80, 21);
            btnLoginGoBack.TabIndex = 2;
            btnLoginGoBack.Click += BtnLoginGoBack_Click;
            // 
            // btnLoginForgotPassNext
            // 
            btnLoginForgotPassNext.Cursor = Cursors.Hand;
            btnLoginForgotPassNext.Location = new Point(745, 730);
            btnLoginForgotPassNext.Name = "btnLoginForgotPassNext";
            btnLoginForgotPassNext.Size = new Size(115, 36);
            btnLoginForgotPassNext.TabIndex = 1;
            btnLoginForgotPassNext.Click += BtnLoginForgotPassNext_Click;
            // 
            // txtLoginForgotPassEmail
            // 
            txtLoginForgotPassEmail.BorderStyle = BorderStyle.None;
            txtLoginForgotPassEmail.Font = new Font("Comic Sans MS", 15F);
            txtLoginForgotPassEmail.Location = new Point(589, 661);
            txtLoginForgotPassEmail.Name = "txtLoginForgotPassEmail";
            txtLoginForgotPassEmail.PlaceholderText = "Email";
            txtLoginForgotPassEmail.Size = new Size(403, 28);
            txtLoginForgotPassEmail.TabIndex = 0;
            // 
            // tabLoginForgotPassOtp
            // 
            tabLoginForgotPassOtp.BackgroundImage = Properties.Resources.OTP_Screen;
            tabLoginForgotPassOtp.BackgroundImageLayout = ImageLayout.Center;
            tabLoginForgotPassOtp.Controls.Add(btnLoginForgotPassLastNext);
            tabLoginForgotPassOtp.Controls.Add(pnlLoginForgotPassOtpHolder);
            tabLoginForgotPassOtp.Location = new Point(4, 24);
            tabLoginForgotPassOtp.Name = "tabLoginForgotPassOtp";
            tabLoginForgotPassOtp.Size = new Size(1600, 940);
            tabLoginForgotPassOtp.TabIndex = 5;
            tabLoginForgotPassOtp.Text = "tabLoginForgotPassMpin";
            tabLoginForgotPassOtp.UseVisualStyleBackColor = true;
            // 
            // btnLoginForgotPassLastNext
            // 
            btnLoginForgotPassLastNext.Cursor = Cursors.Hand;
            btnLoginForgotPassLastNext.Location = new Point(719, 653);
            btnLoginForgotPassLastNext.Name = "btnLoginForgotPassLastNext";
            btnLoginForgotPassLastNext.Size = new Size(158, 49);
            btnLoginForgotPassLastNext.TabIndex = 2;
            btnLoginForgotPassLastNext.Click += BtnLoginForgotPassLastNext_Click;
            // 
            // pnlLoginForgotPassOtpHolder
            // 
            pnlLoginForgotPassOtpHolder.Controls.Add(loginForgotPassOtp_6);
            pnlLoginForgotPassOtpHolder.Controls.Add(loginForgotPassOtp_5);
            pnlLoginForgotPassOtpHolder.Controls.Add(loginForgotPassOtp_4);
            pnlLoginForgotPassOtpHolder.Controls.Add(loginForgotPassOtp_3);
            pnlLoginForgotPassOtpHolder.Controls.Add(loginForgotPassOtp_2);
            pnlLoginForgotPassOtpHolder.Controls.Add(loginForgotPassOtp_1);
            pnlLoginForgotPassOtpHolder.Location = new Point(258, 326);
            pnlLoginForgotPassOtpHolder.Name = "pnlLoginForgotPassOtpHolder";
            pnlLoginForgotPassOtpHolder.Size = new Size(1081, 236);
            pnlLoginForgotPassOtpHolder.TabIndex = 1;
            pnlLoginForgotPassOtpHolder.TabStop = true;
            pnlLoginForgotPassOtpHolder.KeyDown += PnlLoginForgotPassOtpHolder_KeyDown;
            // 
            // loginForgotPassOtp_6
            // 
            loginForgotPassOtp_6.BackgroundImage = Properties.Resources.MPIN_Blank;
            loginForgotPassOtp_6.BackgroundImageLayout = ImageLayout.Center;
            loginForgotPassOtp_6.Cursor = Cursors.IBeam;
            loginForgotPassOtp_6.Location = new Point(904, 54);
            loginForgotPassOtp_6.Name = "loginForgotPassOtp_6";
            loginForgotPassOtp_6.Size = new Size(146, 143);
            loginForgotPassOtp_6.TabIndex = 3;
            // 
            // loginForgotPassOtp_5
            // 
            loginForgotPassOtp_5.BackgroundImage = Properties.Resources.MPIN_Blank;
            loginForgotPassOtp_5.BackgroundImageLayout = ImageLayout.Center;
            loginForgotPassOtp_5.Cursor = Cursors.IBeam;
            loginForgotPassOtp_5.Location = new Point(730, 54);
            loginForgotPassOtp_5.Name = "loginForgotPassOtp_5";
            loginForgotPassOtp_5.Size = new Size(146, 143);
            loginForgotPassOtp_5.TabIndex = 3;
            // 
            // loginForgotPassOtp_4
            // 
            loginForgotPassOtp_4.BackgroundImage = Properties.Resources.MPIN_Blank;
            loginForgotPassOtp_4.BackgroundImageLayout = ImageLayout.Center;
            loginForgotPassOtp_4.Cursor = Cursors.IBeam;
            loginForgotPassOtp_4.Location = new Point(556, 54);
            loginForgotPassOtp_4.Name = "loginForgotPassOtp_4";
            loginForgotPassOtp_4.Size = new Size(146, 143);
            loginForgotPassOtp_4.TabIndex = 3;
            // 
            // loginForgotPassOtp_3
            // 
            loginForgotPassOtp_3.BackgroundImage = Properties.Resources.MPIN_Blank;
            loginForgotPassOtp_3.BackgroundImageLayout = ImageLayout.Center;
            loginForgotPassOtp_3.Cursor = Cursors.IBeam;
            loginForgotPassOtp_3.Location = new Point(382, 54);
            loginForgotPassOtp_3.Name = "loginForgotPassOtp_3";
            loginForgotPassOtp_3.Size = new Size(146, 143);
            loginForgotPassOtp_3.TabIndex = 2;
            // 
            // loginForgotPassOtp_2
            // 
            loginForgotPassOtp_2.BackgroundImage = Properties.Resources.MPIN_Blank;
            loginForgotPassOtp_2.BackgroundImageLayout = ImageLayout.Center;
            loginForgotPassOtp_2.Cursor = Cursors.IBeam;
            loginForgotPassOtp_2.Location = new Point(208, 54);
            loginForgotPassOtp_2.Name = "loginForgotPassOtp_2";
            loginForgotPassOtp_2.Size = new Size(146, 143);
            loginForgotPassOtp_2.TabIndex = 1;
            // 
            // loginForgotPassOtp_1
            // 
            loginForgotPassOtp_1.BackgroundImage = Properties.Resources.MPIN_Blank;
            loginForgotPassOtp_1.BackgroundImageLayout = ImageLayout.Center;
            loginForgotPassOtp_1.Cursor = Cursors.IBeam;
            loginForgotPassOtp_1.Location = new Point(34, 54);
            loginForgotPassOtp_1.Name = "loginForgotPassOtp_1";
            loginForgotPassOtp_1.Size = new Size(146, 143);
            loginForgotPassOtp_1.TabIndex = 0;
            // 
            // tabLoginChangePass
            // 
            tabLoginChangePass.BackgroundImage = Properties.Resources.Login___Change_Pass;
            tabLoginChangePass.Controls.Add(btnLoginShowChangePass2);
            tabLoginChangePass.Controls.Add(btnLoginShowChangePass1);
            tabLoginChangePass.Controls.Add(btnLoginForgotPassChangePass);
            tabLoginChangePass.Controls.Add(txtLoginChangePass2);
            tabLoginChangePass.Controls.Add(txtLoginChangePass1);
            tabLoginChangePass.Location = new Point(4, 24);
            tabLoginChangePass.Name = "tabLoginChangePass";
            tabLoginChangePass.Size = new Size(1600, 940);
            tabLoginChangePass.TabIndex = 6;
            tabLoginChangePass.Text = "tabLoginChangePass";
            tabLoginChangePass.UseVisualStyleBackColor = true;
            // 
            // btnLoginShowChangePass2
            // 
            btnLoginShowChangePass2.BackgroundImage = Properties.Resources.Show_Icon;
            btnLoginShowChangePass2.BackgroundImageLayout = ImageLayout.Stretch;
            btnLoginShowChangePass2.Cursor = Cursors.Hand;
            btnLoginShowChangePass2.Location = new Point(956, 610);
            btnLoginShowChangePass2.Name = "btnLoginShowChangePass2";
            btnLoginShowChangePass2.Size = new Size(60, 60);
            btnLoginShowChangePass2.TabIndex = 4;
            btnLoginShowChangePass2.Click += BtnLoginShowChangePass2_Click;
            // 
            // btnLoginShowChangePass1
            // 
            btnLoginShowChangePass1.BackgroundImage = Properties.Resources.Show_Icon;
            btnLoginShowChangePass1.BackgroundImageLayout = ImageLayout.Stretch;
            btnLoginShowChangePass1.Cursor = Cursors.Hand;
            btnLoginShowChangePass1.Location = new Point(958, 526);
            btnLoginShowChangePass1.Name = "btnLoginShowChangePass1";
            btnLoginShowChangePass1.Size = new Size(60, 60);
            btnLoginShowChangePass1.TabIndex = 3;
            btnLoginShowChangePass1.Click += BtnLoginShowChangePass1_Click;
            // 
            // btnLoginForgotPassChangePass
            // 
            btnLoginForgotPassChangePass.Cursor = Cursors.Hand;
            btnLoginForgotPassChangePass.Location = new Point(742, 716);
            btnLoginForgotPassChangePass.Name = "btnLoginForgotPassChangePass";
            btnLoginForgotPassChangePass.Size = new Size(113, 36);
            btnLoginForgotPassChangePass.TabIndex = 2;
            btnLoginForgotPassChangePass.Click += BtnLoginForgotPassChangePass_Click;
            // 
            // txtLoginChangePass2
            // 
            txtLoginChangePass2.BorderStyle = BorderStyle.None;
            txtLoginChangePass2.Font = new Font("Comic Sans MS", 15F);
            txtLoginChangePass2.Location = new Point(598, 626);
            txtLoginChangePass2.Name = "txtLoginChangePass2";
            txtLoginChangePass2.PlaceholderText = "Confirm Password";
            txtLoginChangePass2.Size = new Size(364, 28);
            txtLoginChangePass2.TabIndex = 1;
            txtLoginChangePass2.UseSystemPasswordChar = true;
            // 
            // txtLoginChangePass1
            // 
            txtLoginChangePass1.BorderStyle = BorderStyle.None;
            txtLoginChangePass1.Font = new Font("Comic Sans MS", 15F);
            txtLoginChangePass1.Location = new Point(598, 541);
            txtLoginChangePass1.Name = "txtLoginChangePass1";
            txtLoginChangePass1.PlaceholderText = "Password";
            txtLoginChangePass1.Size = new Size(364, 28);
            txtLoginChangePass1.TabIndex = 0;
            txtLoginChangePass1.UseSystemPasswordChar = true;
            // 
            // FrmOnboarding
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1600, 941);
            Controls.Add(mainTabControl);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FrmOnboarding";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NekoKeep";
            mainTabControl.ResumeLayout(false);
            tabLoginPage.ResumeLayout(false);
            tabLoginPage.PerformLayout();
            tabRegisterPage.ResumeLayout(false);
            tabRegisterPage.PerformLayout();
            tabRegisterMpinPage.ResumeLayout(false);
            pnlRegisterMpinHolder.ResumeLayout(false);
            tabRegisterCatSelection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)registerCatGif).EndInit();
            tabLoginForgotPassEmail.ResumeLayout(false);
            tabLoginForgotPassEmail.PerformLayout();
            tabLoginForgotPassOtp.ResumeLayout(false);
            pnlLoginForgotPassOtpHolder.ResumeLayout(false);
            tabLoginChangePass.ResumeLayout(false);
            tabLoginChangePass.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected TabControl mainTabControl;
        protected TabPage tabRegisterPage;
        protected TextBox txtRegisterDisplayName;
        protected TextBox txtRegisterPassword;
        protected TextBox txtRegisterEmail;
        protected Panel btnRedirectLogin;
        protected Panel btnRegisterContinue;
        protected TabPage tabRegisterMpinPage;
        protected Panel pnlRegisterMpinHolder;
        protected Panel registerMpin_1;
        protected Panel registerMpin_6;
        protected Panel registerMpin_5;
        protected Panel registerMpin_4;
        protected Panel registerMpin_3;
        protected Panel registerMpin_2;
        protected Panel registerMpinText;
        protected Panel btnRegisterContinue2;
        protected TabPage tabRegisterCatSelection;
        protected PictureBox registerCatGif;
        protected Panel btnRegisterContinue3;
        protected Panel btnRegisterCatSelectionBackward;
        protected Panel btnRegisterCatSelectionForward;
        protected TabPage tabLoginPage;
        protected TextBox txtLoginEmail;
        protected TextBox txtLoginPassword;
        protected Panel btnRedirectRegister;
        protected Panel btnLogin;
        protected Panel btnLoginPassShow;
        protected Panel btnRegisterPassShow;
        protected Panel btnLoginForgotPass;
        protected Panel pnlLoginForgotPassOtpHolder;
        protected Panel loginForgotPassOtp_1;
        protected Panel loginForgotPassOtp_6;
        protected Panel loginForgotPassOtp_5;
        protected Panel loginForgotPassOtp_4;
        protected Panel loginForgotPassOtp_3;
        protected Panel loginForgotPassOtp_2;
        private TabPage tabLoginForgotPassEmail;
        private TextBox txtLoginForgotPassEmail;
        private Panel btnLoginGoBack;
        private Panel btnLoginForgotPassNext;
        private TabPage tabLoginForgotPassOtp;
        private Panel btnLoginForgotPassLastNext;
        private TabPage tabLoginChangePass;
        private TextBox txtLoginChangePass1;
        private Panel btnLoginForgotPassChangePass;
        private TextBox txtLoginChangePass2;
        private Panel btnLoginShowChangePass1;
        private Panel btnLoginShowChangePass2;
    }
}
