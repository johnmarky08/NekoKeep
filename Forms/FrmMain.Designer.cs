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
            pnlAddAccHolder = new Panel();
            btnAddAccount = new Panel();
            pnlLogout = new Panel();
            btnLogoutCancel = new Panel();
            btnLogoutConfirm = new Panel();
            pnlDelete = new Panel();
            btnDeleteCancel = new Panel();
            btnDeleteOk = new Panel();
            tblAccounts = new TableLayoutPanel();
            tblHeaders = new TableLayoutPanel();
            lblHeaderBorder = new Label();
            lblHeaderActions = new Label();
            lblHeaderTags = new Label();
            lblHeaderReq = new Label();
            lblHeaderEmail = new Label();
            lblHeaderDisplayName = new Label();
            lblHeaderType = new Label();
            txtSearch = new TextBox();
            btnSearch = new Panel();
            pnlFilter = new Panel();
            flowLayoutPanelFilterTags = new FlowLayoutPanel();
            btnFilterLastUpdated = new Panel();
            btnFilterDisplayName = new Panel();
            btnFilter = new Panel();
            pnlViewPassMpin = new Panel();
            btnViewPassConfirm = new Panel();
            btnViewPassCancel = new Panel();
            pnlViewPassMpinHolder = new Panel();
            viewPassMpin_6 = new Panel();
            viewPassMpin_5 = new Panel();
            viewPassMpin_4 = new Panel();
            viewPassMpin_3 = new Panel();
            viewPassMpin_2 = new Panel();
            viewPassMpin_1 = new Panel();
            ctxMain.SuspendLayout();
            pnlCatChatBubble.SuspendLayout();
            pnlAddAccHolder.SuspendLayout();
            pnlLogout.SuspendLayout();
            pnlDelete.SuspendLayout();
            tblHeaders.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlViewPassMpin.SuspendLayout();
            pnlViewPassMpinHolder.SuspendLayout();
            SuspendLayout();
            // 
            // btnMainContextMenu
            // 
            btnMainContextMenu.BackColor = Color.Transparent;
            btnMainContextMenu.BackgroundImageLayout = ImageLayout.Zoom;
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
            txtCatChat.AutoEllipsis = true;
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
            btnAddAccount.Cursor = Cursors.Hand;
            btnAddAccount.Location = new Point(27, 23);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(84, 74);
            btnAddAccount.TabIndex = 23;
            btnAddAccount.Click += BtnAddAccount_Click;
            // 
            // pnlLogout
            // 
            pnlLogout.BackColor = Color.Transparent;
            pnlLogout.BackgroundImage = Properties.Resources.Logout_Section;
            pnlLogout.BackgroundImageLayout = ImageLayout.Center;
            pnlLogout.Controls.Add(btnLogoutCancel);
            pnlLogout.Controls.Add(btnLogoutConfirm);
            pnlLogout.Location = new Point(515, 385);
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
            // pnlDelete
            // 
            pnlDelete.BackColor = Color.Transparent;
            pnlDelete.BackgroundImage = Properties.Resources.Delete_Section3;
            pnlDelete.BackgroundImageLayout = ImageLayout.Center;
            pnlDelete.Controls.Add(btnDeleteCancel);
            pnlDelete.Controls.Add(btnDeleteOk);
            pnlDelete.Location = new Point(515, 344);
            pnlDelete.Name = "pnlDelete";
            pnlDelete.Size = new Size(556, 324);
            pnlDelete.TabIndex = 21;
            pnlDelete.Visible = false;
            // 
            // btnDeleteCancel
            // 
            btnDeleteCancel.Cursor = Cursors.Hand;
            btnDeleteCancel.Location = new Point(314, 223);
            btnDeleteCancel.Name = "btnDeleteCancel";
            btnDeleteCancel.Size = new Size(158, 51);
            btnDeleteCancel.TabIndex = 1;
            btnDeleteCancel.Click += BtnDeleteCancel_Click;
            // 
            // btnDeleteOk
            // 
            btnDeleteOk.Cursor = Cursors.Hand;
            btnDeleteOk.Location = new Point(82, 223);
            btnDeleteOk.Name = "btnDeleteOk";
            btnDeleteOk.Size = new Size(158, 51);
            btnDeleteOk.TabIndex = 0;
            btnDeleteOk.Click += BtnDeleteOk_Click;
            // 
            // tblAccounts
            // 
            tblAccounts.AutoScroll = true;
            tblAccounts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblAccounts.BackColor = Color.Transparent;
            tblAccounts.ColumnCount = 6;
            tblAccounts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblAccounts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblAccounts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblAccounts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblAccounts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblAccounts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblAccounts.Font = new Font("Comic Sans MS", 13F);
            tblAccounts.Location = new Point(173, 195);
            tblAccounts.Name = "tblAccounts";
            tblAccounts.RowCount = 1;
            tblAccounts.RowStyles.Add(new RowStyle());
            tblAccounts.Size = new Size(1250, 660);
            tblAccounts.TabIndex = 1;
            // 
            // tblHeaders
            // 
            tblHeaders.BackColor = Color.Transparent;
            tblHeaders.ColumnCount = 6;
            tblHeaders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tblHeaders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblHeaders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblHeaders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblHeaders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblHeaders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblHeaders.Controls.Add(lblHeaderBorder, 0, 1);
            tblHeaders.Controls.Add(lblHeaderActions, 5, 0);
            tblHeaders.Controls.Add(lblHeaderTags, 4, 0);
            tblHeaders.Controls.Add(lblHeaderReq, 3, 0);
            tblHeaders.Controls.Add(lblHeaderEmail, 2, 0);
            tblHeaders.Controls.Add(lblHeaderDisplayName, 1, 0);
            tblHeaders.Controls.Add(lblHeaderType, 0, 0);
            tblHeaders.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tblHeaders.Location = new Point(173, 137);
            tblHeaders.Name = "tblHeaders";
            tblHeaders.RowCount = 1;
            tblHeaders.RowStyles.Add(new RowStyle());
            tblHeaders.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblHeaders.Size = new Size(1253, 58);
            tblHeaders.TabIndex = 24;
            // 
            // lblHeaderBorder
            // 
            lblHeaderBorder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHeaderBorder.AutoSize = true;
            tblHeaders.SetColumnSpan(lblHeaderBorder, 6);
            lblHeaderBorder.Location = new Point(3, 29);
            lblHeaderBorder.Name = "lblHeaderBorder";
            lblHeaderBorder.Size = new Size(1247, 29);
            lblHeaderBorder.TabIndex = 6;
            lblHeaderBorder.Text = "------------------------------------------------------------------------------------------------------------------------------------------------------";
            lblHeaderBorder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeaderActions
            // 
            lblHeaderActions.AutoSize = true;
            lblHeaderActions.Dock = DockStyle.Fill;
            lblHeaderActions.Location = new Point(1065, 0);
            lblHeaderActions.Name = "lblHeaderActions";
            lblHeaderActions.Size = new Size(185, 29);
            lblHeaderActions.TabIndex = 5;
            lblHeaderActions.Text = "Actions";
            lblHeaderActions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeaderTags
            // 
            lblHeaderTags.AutoSize = true;
            lblHeaderTags.Dock = DockStyle.Fill;
            lblHeaderTags.Location = new Point(878, 0);
            lblHeaderTags.Name = "lblHeaderTags";
            lblHeaderTags.Size = new Size(181, 29);
            lblHeaderTags.TabIndex = 4;
            lblHeaderTags.Text = "Tags";
            lblHeaderTags.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeaderReq
            // 
            lblHeaderReq.AutoSize = true;
            lblHeaderReq.Dock = DockStyle.Fill;
            lblHeaderReq.Location = new Point(628, 0);
            lblHeaderReq.Name = "lblHeaderReq";
            lblHeaderReq.Size = new Size(244, 29);
            lblHeaderReq.TabIndex = 3;
            lblHeaderReq.Text = "Password / Provider";
            lblHeaderReq.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeaderEmail
            // 
            lblHeaderEmail.AutoSize = true;
            lblHeaderEmail.Dock = DockStyle.Fill;
            lblHeaderEmail.Location = new Point(378, 0);
            lblHeaderEmail.Name = "lblHeaderEmail";
            lblHeaderEmail.Size = new Size(244, 29);
            lblHeaderEmail.TabIndex = 2;
            lblHeaderEmail.Text = "Email";
            lblHeaderEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeaderDisplayName
            // 
            lblHeaderDisplayName.AutoSize = true;
            lblHeaderDisplayName.Dock = DockStyle.Fill;
            lblHeaderDisplayName.Location = new Point(128, 0);
            lblHeaderDisplayName.Name = "lblHeaderDisplayName";
            lblHeaderDisplayName.Size = new Size(244, 29);
            lblHeaderDisplayName.TabIndex = 1;
            lblHeaderDisplayName.Text = "Display Name";
            lblHeaderDisplayName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeaderType
            // 
            lblHeaderType.AutoSize = true;
            lblHeaderType.Dock = DockStyle.Fill;
            lblHeaderType.Location = new Point(3, 0);
            lblHeaderType.Name = "lblHeaderType";
            lblHeaderType.Size = new Size(119, 29);
            lblHeaderType.TabIndex = 0;
            lblHeaderType.Text = "Type";
            lblHeaderType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Comic Sans MS", 15F);
            txtSearch.Location = new Point(176, 58);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search an account...";
            txtSearch.Size = new Size(879, 28);
            txtSearch.TabIndex = 25;
            txtSearch.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(1066, 43);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(67, 58);
            btnSearch.TabIndex = 26;
            btnSearch.Click += BtnSearch_Click;
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.Transparent;
            pnlFilter.BackgroundImage = Properties.Resources.Filter;
            pnlFilter.BackgroundImageLayout = ImageLayout.Zoom;
            pnlFilter.Controls.Add(flowLayoutPanelFilterTags);
            pnlFilter.Controls.Add(btnFilterLastUpdated);
            pnlFilter.Controls.Add(btnFilterDisplayName);
            pnlFilter.Location = new Point(695, 115);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(745, 459);
            pnlFilter.TabIndex = 27;
            pnlFilter.Visible = false;
            // 
            // flowLayoutPanelFilterTags
            // 
            flowLayoutPanelFilterTags.AutoScroll = true;
            flowLayoutPanelFilterTags.Location = new Point(36, 86);
            flowLayoutPanelFilterTags.Name = "flowLayoutPanelFilterTags";
            flowLayoutPanelFilterTags.Size = new Size(673, 152);
            flowLayoutPanelFilterTags.TabIndex = 8;
            // 
            // btnFilterLastUpdated
            // 
            btnFilterLastUpdated.BackgroundImage = Properties.Resources.Filter_Last_Updated_Unsellect;
            btnFilterLastUpdated.BackgroundImageLayout = ImageLayout.Center;
            btnFilterLastUpdated.Location = new Point(238, 308);
            btnFilterLastUpdated.Name = "btnFilterLastUpdated";
            btnFilterLastUpdated.Size = new Size(173, 54);
            btnFilterLastUpdated.TabIndex = 1;
            btnFilterLastUpdated.Click += BtnFilterLastUpdated_Click;
            // 
            // btnFilterDisplayName
            // 
            btnFilterDisplayName.BackgroundImage = Properties.Resources.Filter_Name_Unsellect;
            btnFilterDisplayName.BackgroundImageLayout = ImageLayout.Center;
            btnFilterDisplayName.Location = new Point(49, 308);
            btnFilterDisplayName.Name = "btnFilterDisplayName";
            btnFilterDisplayName.Size = new Size(173, 54);
            btnFilterDisplayName.TabIndex = 0;
            btnFilterDisplayName.Click += BtnFilterDisplayName_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Transparent;
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.Location = new Point(1164, 34);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(78, 74);
            btnFilter.TabIndex = 27;
            btnFilter.Click += BtnFilter_Click;
            // 
            // pnlViewPassMpin
            // 
            pnlViewPassMpin.BackgroundImage = Properties.Resources.ViewPassMPIN;
            pnlViewPassMpin.Controls.Add(btnViewPassConfirm);
            pnlViewPassMpin.Controls.Add(btnViewPassCancel);
            pnlViewPassMpin.Controls.Add(pnlViewPassMpinHolder);
            pnlViewPassMpin.Location = new Point(0, 0);
            pnlViewPassMpin.Name = "pnlViewPassMpin";
            pnlViewPassMpin.Size = new Size(1600, 960);
            pnlViewPassMpin.TabIndex = 28;
            pnlViewPassMpin.Visible = false;
            // 
            // btnViewPassConfirm
            // 
            btnViewPassConfirm.BackColor = Color.Transparent;
            btnViewPassConfirm.Cursor = Cursors.Hand;
            btnViewPassConfirm.Location = new Point(842, 661);
            btnViewPassConfirm.Name = "btnViewPassConfirm";
            btnViewPassConfirm.Size = new Size(218, 51);
            btnViewPassConfirm.TabIndex = 4;
            btnViewPassConfirm.Click += BtnViewPassConfirm_Click;
            // 
            // btnViewPassCancel
            // 
            btnViewPassCancel.BackColor = Color.Transparent;
            btnViewPassCancel.Cursor = Cursors.Hand;
            btnViewPassCancel.Location = new Point(532, 661);
            btnViewPassCancel.Name = "btnViewPassCancel";
            btnViewPassCancel.Size = new Size(181, 51);
            btnViewPassCancel.TabIndex = 3;
            btnViewPassCancel.Click += BtnViewPassCancel_Click;
            // 
            // pnlViewPassMpinHolder
            // 
            pnlViewPassMpinHolder.BackColor = Color.Transparent;
            pnlViewPassMpinHolder.Controls.Add(viewPassMpin_6);
            pnlViewPassMpinHolder.Controls.Add(viewPassMpin_5);
            pnlViewPassMpinHolder.Controls.Add(viewPassMpin_4);
            pnlViewPassMpinHolder.Controls.Add(viewPassMpin_3);
            pnlViewPassMpinHolder.Controls.Add(viewPassMpin_2);
            pnlViewPassMpinHolder.Controls.Add(viewPassMpin_1);
            pnlViewPassMpinHolder.Location = new Point(260, 355);
            pnlViewPassMpinHolder.Name = "pnlViewPassMpinHolder";
            pnlViewPassMpinHolder.Size = new Size(1081, 236);
            pnlViewPassMpinHolder.TabIndex = 2;
            pnlViewPassMpinHolder.TabStop = true;
            pnlViewPassMpinHolder.KeyDown += PnlViewPassMpinHolder_KeyDown;
            // 
            // viewPassMpin_6
            // 
            viewPassMpin_6.BackgroundImage = Properties.Resources.MPIN_Blank;
            viewPassMpin_6.BackgroundImageLayout = ImageLayout.Center;
            viewPassMpin_6.Cursor = Cursors.IBeam;
            viewPassMpin_6.Location = new Point(904, 54);
            viewPassMpin_6.Name = "viewPassMpin_6";
            viewPassMpin_6.Size = new Size(146, 143);
            viewPassMpin_6.TabIndex = 3;
            // 
            // viewPassMpin_5
            // 
            viewPassMpin_5.BackgroundImage = Properties.Resources.MPIN_Blank;
            viewPassMpin_5.BackgroundImageLayout = ImageLayout.Center;
            viewPassMpin_5.Cursor = Cursors.IBeam;
            viewPassMpin_5.Location = new Point(730, 54);
            viewPassMpin_5.Name = "viewPassMpin_5";
            viewPassMpin_5.Size = new Size(146, 143);
            viewPassMpin_5.TabIndex = 3;
            // 
            // viewPassMpin_4
            // 
            viewPassMpin_4.BackgroundImage = Properties.Resources.MPIN_Blank;
            viewPassMpin_4.BackgroundImageLayout = ImageLayout.Center;
            viewPassMpin_4.Cursor = Cursors.IBeam;
            viewPassMpin_4.Location = new Point(556, 54);
            viewPassMpin_4.Name = "viewPassMpin_4";
            viewPassMpin_4.Size = new Size(146, 143);
            viewPassMpin_4.TabIndex = 3;
            // 
            // viewPassMpin_3
            // 
            viewPassMpin_3.BackgroundImage = Properties.Resources.MPIN_Blank;
            viewPassMpin_3.BackgroundImageLayout = ImageLayout.Center;
            viewPassMpin_3.Cursor = Cursors.IBeam;
            viewPassMpin_3.Location = new Point(382, 54);
            viewPassMpin_3.Name = "viewPassMpin_3";
            viewPassMpin_3.Size = new Size(146, 143);
            viewPassMpin_3.TabIndex = 2;
            // 
            // viewPassMpin_2
            // 
            viewPassMpin_2.BackgroundImage = Properties.Resources.MPIN_Blank;
            viewPassMpin_2.BackgroundImageLayout = ImageLayout.Center;
            viewPassMpin_2.Cursor = Cursors.IBeam;
            viewPassMpin_2.Location = new Point(208, 54);
            viewPassMpin_2.Name = "viewPassMpin_2";
            viewPassMpin_2.Size = new Size(146, 143);
            viewPassMpin_2.TabIndex = 1;
            // 
            // viewPassMpin_1
            // 
            viewPassMpin_1.BackgroundImage = Properties.Resources.MPIN_Blank;
            viewPassMpin_1.BackgroundImageLayout = ImageLayout.Center;
            viewPassMpin_1.Cursor = Cursors.IBeam;
            viewPassMpin_1.Location = new Point(34, 54);
            viewPassMpin_1.Name = "viewPassMpin_1";
            viewPassMpin_1.Size = new Size(146, 143);
            viewPassMpin_1.TabIndex = 0;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MAIN_UI_Screen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1600, 941);
            Controls.Add(pnlViewPassMpin);
            Controls.Add(btnMainContextMenu);
            Controls.Add(btnFilter);
            Controls.Add(pnlFilter);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(pnlDelete);
            Controls.Add(pnlLogout);
            Controls.Add(pnlCatTrigger);
            Controls.Add(pnlCatChatBubble);
            Controls.Add(pnlAddAccHolder);
            Controls.Add(ctxMain);
            Controls.Add(tblAccounts);
            Controls.Add(tblHeaders);
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
            pnlAddAccHolder.ResumeLayout(false);
            pnlLogout.ResumeLayout(false);
            pnlDelete.ResumeLayout(false);
            tblHeaders.ResumeLayout(false);
            tblHeaders.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlViewPassMpin.ResumeLayout(false);
            pnlViewPassMpinHolder.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Panel pnlAddAccHolder;
        private Panel btnAddAccount;
        private Panel pnlLogout;
        private Panel btnLogoutCancel;
        private Panel btnLogoutConfirm;
        private Panel pnlDelete;
        private Panel btnDeleteCancel;
        private Panel btnDeleteOk;
        private TableLayoutPanel tblAccounts;
        private TableLayoutPanel tblHeaders;
        private Label lblHeaderType;
        private Label lblHeaderReq;
        private Label lblHeaderEmail;
        private Label lblHeaderDisplayName;
        private Label lblHeaderActions;
        private Label lblHeaderTags;
        private Label lblHeaderBorder;
        private TextBox txtSearch;
        private Panel btnSearch;
        private Panel pnlFilter;
        private Panel btnFilterDisplayName;
        private Panel btnFilterLastUpdated;
        private FlowLayoutPanel flowLayoutPanelFilterTags;
        private Panel btnFilter;
        private Panel pnlViewPassMpin;
        protected Panel pnlViewPassMpinHolder;
        protected Panel viewPassMpin_6;
        protected Panel viewPassMpin_5;
        protected Panel viewPassMpin_4;
        protected Panel viewPassMpin_3;
        protected Panel viewPassMpin_2;
        protected Panel viewPassMpin_1;
        private Panel btnViewPassConfirm;
        private Panel btnViewPassCancel;
    }
}