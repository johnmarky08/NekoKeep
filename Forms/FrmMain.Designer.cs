namespace NekoKeep.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            btnMainContextMenu = new Panel();
            ctxMain = new Panel();
            btnCtxMain_Logout = new Panel();
            btnCtxMain_Settings = new Panel();
            btnCtxMain_Profile = new Panel();
            pnlCatChatBubble = new Panel();
            txtCatChat = new Label();
            pnlCatTrigger = new Panel();
            flowLayoutPanelAccounts = new FlowLayoutPanel();
            pnlAccounts = new Panel();
            pnlLogout = new Panel();
            btnLogoutCancel = new Panel();
            btnLogoutConfirm = new Panel();
            lblActions = new Label();
            lblTags = new Label();
            lblPass = new Label();
            lblEmails = new Label();
            lblAccounts = new Label();
            pnlDelete = new Panel();
            btnDeleteCancel = new Panel();
            btnDeleteOk = new Panel();
            pnlAddAccHolder = new Panel();
            btnAddAccount = new Panel();
            ctxMain.SuspendLayout();
            pnlCatChatBubble.SuspendLayout();
            flowLayoutPanelAccounts.SuspendLayout();
            pnlAccounts.SuspendLayout();
            pnlLogout.SuspendLayout();
            pnlDelete.SuspendLayout();
            pnlAddAccHolder.SuspendLayout();
            SuspendLayout();
            // 
            // btnMainContextMenu
            // 
            btnMainContextMenu.BackColor = Color.Transparent;
            btnMainContextMenu.BackgroundImageLayout = ImageLayout.Center;
            btnMainContextMenu.Cursor = Cursors.Hand;
            btnMainContextMenu.Location = new Point(1359, 33);
            btnMainContextMenu.Name = "btnMainContextMenu";
            btnMainContextMenu.Size = new Size(89, 77);
            btnMainContextMenu.TabIndex = 0;
            btnMainContextMenu.Click += BtnMainContextMenu_Click;
            // 
            // ctxMain
            // 
            ctxMain.BackColor = Color.Transparent;
            ctxMain.BackgroundImage = Properties.Resources.Main_Context_Menu;
            ctxMain.BackgroundImageLayout = ImageLayout.Center;
            ctxMain.Controls.Add(btnCtxMain_Logout);
            ctxMain.Controls.Add(btnCtxMain_Settings);
            ctxMain.Controls.Add(btnCtxMain_Profile);
            ctxMain.Location = new Point(1309, 114);
            ctxMain.Name = "ctxMain";
            ctxMain.Size = new Size(192, 184);
            ctxMain.TabIndex = 1;
            ctxMain.Visible = false;
            // 
            // btnCtxMain_Logout
            // 
            btnCtxMain_Logout.Cursor = Cursors.Hand;
            btnCtxMain_Logout.Location = new Point(0, 122);
            btnCtxMain_Logout.Name = "btnCtxMain_Logout";
            btnCtxMain_Logout.Size = new Size(192, 62);
            btnCtxMain_Logout.TabIndex = 1;
            btnCtxMain_Logout.Click += BtnCtxMain_Logout_Click;
            // 
            // btnCtxMain_Settings
            // 
            btnCtxMain_Settings.Cursor = Cursors.Hand;
            btnCtxMain_Settings.Location = new Point(0, 62);
            btnCtxMain_Settings.Name = "btnCtxMain_Settings";
            btnCtxMain_Settings.Size = new Size(192, 60);
            btnCtxMain_Settings.TabIndex = 2;
            btnCtxMain_Settings.Click += BtnCtxMain_Settings_Click;
            // 
            // btnCtxMain_Profile
            // 
            btnCtxMain_Profile.Cursor = Cursors.Hand;
            btnCtxMain_Profile.Location = new Point(0, 0);
            btnCtxMain_Profile.Name = "btnCtxMain_Profile";
            btnCtxMain_Profile.Size = new Size(192, 62);
            btnCtxMain_Profile.TabIndex = 0;
            btnCtxMain_Profile.Click += BtnCtxMain_Profile_Click;
            // 
            // pnlCatChatBubble
            // 
            pnlCatChatBubble.BackColor = Color.Transparent;
            pnlCatChatBubble.BackgroundImage = Properties.Resources.Cat_Bubble;
            pnlCatChatBubble.BackgroundImageLayout = ImageLayout.Center;
            pnlCatChatBubble.Controls.Add(txtCatChat);
            pnlCatChatBubble.Location = new Point(47, 692);
            pnlCatChatBubble.Name = "pnlCatChatBubble";
            pnlCatChatBubble.Size = new Size(401, 123);
            pnlCatChatBubble.TabIndex = 2;
            // 
            // txtCatChat
            // 
            txtCatChat.Font = new Font("Comic Sans MS", 18F);
            txtCatChat.Location = new Point(17, 27);
            txtCatChat.Name = "txtCatChat";
            txtCatChat.Size = new Size(369, 33);
            txtCatChat.TabIndex = 0;
            txtCatChat.Text = "Meow, meow~";
            txtCatChat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCatTrigger
            // 
            pnlCatTrigger.BackColor = Color.Transparent;
            pnlCatTrigger.Location = new Point(6, 807);
            pnlCatTrigger.Name = "pnlCatTrigger";
            pnlCatTrigger.Size = new Size(152, 135);
            pnlCatTrigger.TabIndex = 3;
            pnlCatTrigger.MouseEnter += PnlCatTrigger_MouseEnter;
            pnlCatTrigger.MouseLeave += PnlCatTrigger_MouseLeave;
            // 
            // flowLayoutPanelAccounts
            // 
            flowLayoutPanelAccounts.AutoScroll = true;
            flowLayoutPanelAccounts.BackColor = Color.Transparent;
            flowLayoutPanelAccounts.Controls.Add(pnlAccounts);
            flowLayoutPanelAccounts.Location = new Point(161, 136);
            flowLayoutPanelAccounts.Name = "flowLayoutPanelAccounts";
            flowLayoutPanelAccounts.Size = new Size(1287, 648);
            flowLayoutPanelAccounts.TabIndex = 4;
            // 
            // pnlAccounts
            // 
            pnlAccounts.AutoScroll = true;
            pnlAccounts.Controls.Add(pnlLogout);
            pnlAccounts.Controls.Add(lblActions);
            pnlAccounts.Controls.Add(lblTags);
            pnlAccounts.Controls.Add(lblPass);
            pnlAccounts.Controls.Add(lblEmails);
            pnlAccounts.Controls.Add(lblAccounts);
            pnlAccounts.Controls.Add(pnlDelete);
            pnlAccounts.Location = new Point(3, 3);
            pnlAccounts.Name = "pnlAccounts";
            pnlAccounts.Size = new Size(1266, 628);
            pnlAccounts.TabIndex = 0;
            // 
            // pnlLogout
            // 
            pnlLogout.BackgroundImage = Properties.Resources.Logout_Section;
            pnlLogout.BackgroundImageLayout = ImageLayout.Center;
            pnlLogout.Controls.Add(btnLogoutCancel);
            pnlLogout.Controls.Add(btnLogoutConfirm);
            pnlLogout.Location = new Point(386, 257);
            pnlLogout.Name = "pnlLogout";
            pnlLogout.Size = new Size(556, 257);
            pnlLogout.TabIndex = 22;
            pnlLogout.Visible = false;
            // 
            // btnLogoutCancel
            // 
            btnLogoutCancel.Cursor = Cursors.Hand;
            btnLogoutCancel.Location = new Point(325, 177);
            btnLogoutCancel.Name = "btnLogoutCancel";
            btnLogoutCancel.Size = new Size(157, 42);
            btnLogoutCancel.TabIndex = 1;
            btnLogoutCancel.Click += BtnLogoutCancel_Click;
            // 
            // btnLogoutConfirm
            // 
            btnLogoutConfirm.Cursor = Cursors.Hand;
            btnLogoutConfirm.Location = new Point(73, 177);
            btnLogoutConfirm.Name = "btnLogoutConfirm";
            btnLogoutConfirm.Size = new Size(155, 42);
            btnLogoutConfirm.TabIndex = 0;
            btnLogoutConfirm.Click += BtnLogoutConfirm_Click;
            // 
            // lblActions
            // 
            lblActions.AutoSize = true;
            lblActions.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActions.Location = new Point(1130, 17);
            lblActions.Name = "lblActions";
            lblActions.Size = new Size(81, 28);
            lblActions.TabIndex = 14;
            lblActions.Text = "Actions";
            lblActions.Visible = false;
            // 
            // lblTags
            // 
            lblTags.AutoSize = true;
            lblTags.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTags.Location = new Point(893, 17);
            lblTags.Name = "lblTags";
            lblTags.Size = new Size(57, 28);
            lblTags.TabIndex = 13;
            lblTags.Text = "Tags";
            lblTags.Visible = false;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPass.Location = new Point(661, 17);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(109, 28);
            lblPass.TabIndex = 12;
            lblPass.Text = "Passwords";
            lblPass.Visible = false;
            // 
            // lblEmails
            // 
            lblEmails.AutoSize = true;
            lblEmails.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmails.Location = new Point(394, 17);
            lblEmails.Name = "lblEmails";
            lblEmails.Size = new Size(70, 28);
            lblEmails.TabIndex = 11;
            lblEmails.Text = "Emails";
            lblEmails.Visible = false;
            // 
            // lblAccounts
            // 
            lblAccounts.AutoSize = true;
            lblAccounts.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAccounts.Location = new Point(16, 17);
            lblAccounts.Name = "lblAccounts";
            lblAccounts.Size = new Size(95, 28);
            lblAccounts.TabIndex = 0;
            lblAccounts.Text = "Accounts";
            lblAccounts.Visible = false;
            // 
            // pnlDelete
            // 
            pnlDelete.BackgroundImage = Properties.Resources.Delete_Section3;
            pnlDelete.BackgroundImageLayout = ImageLayout.Center;
            pnlDelete.Controls.Add(btnDeleteCancel);
            pnlDelete.Controls.Add(btnDeleteOk);
            pnlDelete.Location = new Point(386, 227);
            pnlDelete.Name = "pnlDelete";
            pnlDelete.Size = new Size(556, 324);
            pnlDelete.TabIndex = 21;
            pnlDelete.Visible = false;
            // 
            // btnDeleteCancel
            // 
            btnDeleteCancel.Location = new Point(314, 223);
            btnDeleteCancel.Name = "btnDeleteCancel";
            btnDeleteCancel.Size = new Size(158, 51);
            btnDeleteCancel.TabIndex = 1;
            // 
            // btnDeleteOk
            // 
            btnDeleteOk.Location = new Point(82, 223);
            btnDeleteOk.Name = "btnDeleteOk";
            btnDeleteOk.Size = new Size(158, 51);
            btnDeleteOk.TabIndex = 0;
            // 
            // pnlAddAccHolder
            // 
            pnlAddAccHolder.BackColor = Color.Transparent;
            pnlAddAccHolder.BackgroundImage = Properties.Resources._1;
            pnlAddAccHolder.BackgroundImageLayout = ImageLayout.Center;
            pnlAddAccHolder.Controls.Add(btnAddAccount);
            pnlAddAccHolder.Location = new Point(1315, 787);
            pnlAddAccHolder.Name = "pnlAddAccHolder";
            pnlAddAccHolder.Size = new Size(114, 100);
            pnlAddAccHolder.TabIndex = 22;
            // 
            // btnAddAccount
            // 
            btnAddAccount.BackColor = Color.Transparent;
            btnAddAccount.Location = new Point(27, 23);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(84, 74);
            btnAddAccount.TabIndex = 23;
            btnAddAccount.Click += BtnAddAccount_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MAIN_UI_Screen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1600, 941);
            Controls.Add(pnlCatTrigger);
            Controls.Add(pnlCatChatBubble);
            Controls.Add(flowLayoutPanelAccounts);
            Controls.Add(pnlAddAccHolder);
            Controls.Add(ctxMain);
            Controls.Add(btnMainContextMenu);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NekoKeep";
            Load += FrmMain_Load;
            ctxMain.ResumeLayout(false);
            pnlCatChatBubble.ResumeLayout(false);
            flowLayoutPanelAccounts.ResumeLayout(false);
            pnlAccounts.ResumeLayout(false);
            pnlAccounts.PerformLayout();
            pnlLogout.ResumeLayout(false);
            pnlDelete.ResumeLayout(false);
            pnlAddAccHolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void FrmMain_Load1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel btnMainContextMenu;
        private Panel ctxMain;
        private Panel btnCtxMain_Profile;
        private Panel btnCtxMain_Settings;
        private Panel btnCtxMain_Logout;
        private Panel pnlCatChatBubble;
        private Label txtCatChat;
        private Panel pnlCatTrigger;
        private FlowLayoutPanel flowLayoutPanelAccounts;
        private Panel pnlAccounts;
        private Label lblAccounts;
        private Label lblActions;
        private Label lblTags;
        private Label lblPass;
        private Label lblEmails;
        private Panel pnlDelete;
        private Panel btnDeleteCancel;
        private Panel btnDeleteOk;
        private Panel pnlAddAccHolder;
        private Panel btnAddAccount;
        private Panel pnlLogout;
        private Panel btnLogoutCancel;
        private Panel btnLogoutConfirm;
    }
}