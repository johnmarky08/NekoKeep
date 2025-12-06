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
            ctxMain.SuspendLayout();
            pnlCatChatBubble.SuspendLayout();
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
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MAIN_UI_Screen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1600, 941);
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
    }
}