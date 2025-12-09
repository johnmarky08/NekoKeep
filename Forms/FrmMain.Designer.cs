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
            btnCtxMain_Settings = new Panel();
            btnCtxMain_Logout = new Panel();
            btnCtxMain_Profile = new Panel();
            pnlCatChatBubble = new Panel();
            txtCatChat = new Label();
            pnlCatTrigger = new Panel();
            flowLayoutPanelAccounts = new FlowLayoutPanel();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label11 = new Label();
            label1 = new Label();
            pnldelete = new Panel();
            btndeletecancel = new Panel();
            btndeleteok = new Panel();
            panel4 = new Panel();
            btnAddAccount = new Panel();
            btnlogoutok = new Panel();
            panel3 = new Panel();
            ctxMain.SuspendLayout();
            pnlCatChatBubble.SuspendLayout();
            flowLayoutPanelAccounts.SuspendLayout();
            panel1.SuspendLayout();
            pnldelete.SuspendLayout();
            panel4.SuspendLayout();
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
            ctxMain.Controls.Add(btnCtxMain_Settings);
            ctxMain.Controls.Add(btnCtxMain_Logout);
            ctxMain.Controls.Add(btnCtxMain_Profile);
            ctxMain.Location = new Point(1309, 114);
            ctxMain.Name = "ctxMain";
            ctxMain.Size = new Size(192, 184);
            ctxMain.TabIndex = 1;
            ctxMain.Visible = false;
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
            // btnCtxMain_Logout
            // 
            btnCtxMain_Logout.Cursor = Cursors.Hand;
            btnCtxMain_Logout.Location = new Point(0, 122);
            btnCtxMain_Logout.Name = "btnCtxMain_Logout";
            btnCtxMain_Logout.Size = new Size(192, 62);
            btnCtxMain_Logout.TabIndex = 1;
            // 
            // btnCtxMain_Profile
            // 
            btnCtxMain_Profile.Cursor = Cursors.Hand;
            btnCtxMain_Profile.Location = new Point(0, 0);
            btnCtxMain_Profile.Name = "btnCtxMain_Profile";
            btnCtxMain_Profile.Size = new Size(192, 62);
            btnCtxMain_Profile.TabIndex = 0;
            btnCtxMain_Profile.Click += BtnCtxMain_Profile_Click;
            btnCtxMain_Profile.Paint += btnCtxMain_Profile_Paint;
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
            flowLayoutPanelAccounts.Controls.Add(panel1);
            flowLayoutPanelAccounts.Location = new Point(161, 136);
            flowLayoutPanelAccounts.Name = "flowLayoutPanelAccounts";
            flowLayoutPanelAccounts.Size = new Size(1287, 648);
            flowLayoutPanelAccounts.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pnldelete);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1266, 628);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1130, 17);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 14;
            label4.Text = "Actions";
            label4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(893, 17);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 13;
            label3.Text = "Tags";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(661, 17);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 12;
            label2.Text = "Passwords";
            label2.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(394, 17);
            label11.Name = "label11";
            label11.Size = new Size(70, 28);
            label11.TabIndex = 11;
            label11.Text = "Emails";
            label11.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 0;
            label1.Text = "Accounts";
            label1.Visible = false;
            // 
            // pnldelete
            // 
            pnldelete.BackgroundImage = Properties.Resources.Delete_Section3;
            pnldelete.BackgroundImageLayout = ImageLayout.Center;
            pnldelete.Controls.Add(btndeletecancel);
            pnldelete.Controls.Add(btndeleteok);
            pnldelete.Location = new Point(386, 227);
            pnldelete.Name = "pnldelete";
            pnldelete.Size = new Size(556, 324);
            pnldelete.TabIndex = 21;
            pnldelete.Visible = false;
            pnldelete.Paint += pnldelete_Paint;
            // 
            // btndeletecancel
            // 
            btndeletecancel.Location = new Point(314, 223);
            btndeletecancel.Name = "btndeletecancel";
            btndeletecancel.Size = new Size(158, 51);
            btndeletecancel.TabIndex = 1;
            // 
            // btndeleteok
            // 
            btndeleteok.Location = new Point(82, 223);
            btndeleteok.Name = "btndeleteok";
            btndeleteok.Size = new Size(158, 51);
            btndeleteok.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources._1;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Controls.Add(btnAddAccount);
            panel4.Location = new Point(1315, 787);
            panel4.Name = "panel4";
            panel4.Size = new Size(114, 100);
            panel4.TabIndex = 22;
            panel4.Paint += panel4_Paint;
            // 
            // btnAddAccount
            // 
            btnAddAccount.BackColor = Color.Transparent;
            btnAddAccount.Location = new Point(27, 23);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(84, 74);
            btnAddAccount.TabIndex = 23;
            btnAddAccount.Click += btnAddAccount_Click;
            btnAddAccount.Paint += btnAddAccount_Paint;
            // 
            // btnlogoutok
            // 
            btnlogoutok.Location = new Point(85, 200);
            btnlogoutok.Name = "btnlogoutok";
            btnlogoutok.Size = new Size(158, 51);
            btnlogoutok.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Location = new Point(750, 108);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 22;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MAIN_UI_Screen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1600, 941);
            Controls.Add(flowLayoutPanelAccounts);
            Controls.Add(panel4);
            Controls.Add(pnlCatTrigger);
            Controls.Add(pnlCatChatBubble);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnldelete.ResumeLayout(false);
            panel4.ResumeLayout(false);
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
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label11;
        private Panel pnldelete;
        private Panel btndeletecancel;
        private Panel btndeleteok;
        private Panel panel4;
        private Panel panel5;
        private Panel btnlogoutok;
        private Panel btnAddAccount;
        private Panel panel3;
    }
}