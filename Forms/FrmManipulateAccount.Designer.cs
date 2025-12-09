namespace NekoKeep
{
    partial class FrmManipulateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManipulateAccount));
            pnlTitle = new Panel();
            pnlAccount = new Panel();
            btnAccX = new Panel();
            btnAccShowPass = new Panel();
            pnlAddTag = new Panel();
            btnTagX = new Panel();
            btnAddTagFinish = new Panel();
            txtTagName = new TextBox();
            btnAccountType_OAuth = new Panel();
            btnAccountType_Custom = new Panel();
            btnAddAccount = new Panel();
            txtAccNote = new TextBox();
            txtAccRequirement = new TextBox();
            txtAccEmail = new TextBox();
            txtAccName = new TextBox();
            flowLayoutPanelTags = new FlowLayoutPanel();
            btnAddTag = new Panel();
            pnlAccount.SuspendLayout();
            pnlAddTag.SuspendLayout();
            flowLayoutPanelTags.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.Transparent;
            pnlTitle.BackgroundImage = Properties.Resources.Group_7;
            pnlTitle.BackgroundImageLayout = ImageLayout.Center;
            pnlTitle.Location = new Point(646, 53);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(264, 75);
            pnlTitle.TabIndex = 0;
            // 
            // pnlAccount
            // 
            pnlAccount.BackColor = Color.Transparent;
            pnlAccount.BackgroundImage = Properties.Resources.Add_Account;
            pnlAccount.BackgroundImageLayout = ImageLayout.Center;
            pnlAccount.Controls.Add(btnAccX);
            pnlAccount.Controls.Add(btnAccShowPass);
            pnlAccount.Controls.Add(pnlAddTag);
            pnlAccount.Controls.Add(btnAccountType_OAuth);
            pnlAccount.Controls.Add(btnAccountType_Custom);
            pnlAccount.Controls.Add(btnAddAccount);
            pnlAccount.Controls.Add(txtAccNote);
            pnlAccount.Controls.Add(txtAccRequirement);
            pnlAccount.Controls.Add(txtAccEmail);
            pnlAccount.Controls.Add(txtAccName);
            pnlAccount.Controls.Add(flowLayoutPanelTags);
            pnlAccount.Location = new Point(239, 152);
            pnlAccount.Name = "pnlAccount";
            pnlAccount.Size = new Size(1073, 679);
            pnlAccount.TabIndex = 1;
            // 
            // btnAccX
            // 
            btnAccX.BackColor = Color.Transparent;
            btnAccX.BackgroundImage = Properties.Resources.Exit_Icon;
            btnAccX.BackgroundImageLayout = ImageLayout.Stretch;
            btnAccX.Cursor = Cursors.Hand;
            btnAccX.Location = new Point(973, 23);
            btnAccX.Name = "btnAccX";
            btnAccX.Size = new Size(40, 40);
            btnAccX.TabIndex = 4;
            btnAccX.Click += BtnAccX_Click;
            // 
            // btnAccShowPass
            // 
            btnAccShowPass.BackgroundImage = Properties.Resources.Show_Icon;
            btnAccShowPass.BackgroundImageLayout = ImageLayout.Stretch;
            btnAccShowPass.Cursor = Cursors.Hand;
            btnAccShowPass.Location = new Point(859, 294);
            btnAccShowPass.Name = "btnAccShowPass";
            btnAccShowPass.Size = new Size(60, 60);
            btnAccShowPass.TabIndex = 4;
            btnAccShowPass.Click += TxtAccShowPass_Click;
            // 
            // pnlAddTag
            // 
            pnlAddTag.BackColor = Color.Transparent;
            pnlAddTag.BackgroundImage = Properties.Resources.AddTagSection;
            pnlAddTag.BackgroundImageLayout = ImageLayout.Center;
            pnlAddTag.Controls.Add(btnTagX);
            pnlAddTag.Controls.Add(btnAddTagFinish);
            pnlAddTag.Controls.Add(txtTagName);
            pnlAddTag.Location = new Point(262, 156);
            pnlAddTag.Name = "pnlAddTag";
            pnlAddTag.Size = new Size(576, 335);
            pnlAddTag.TabIndex = 8;
            pnlAddTag.Visible = false;
            // 
            // btnTagX
            // 
            btnTagX.BackColor = Color.Transparent;
            btnTagX.BackgroundImage = Properties.Resources.Exit_Icon;
            btnTagX.BackgroundImageLayout = ImageLayout.Stretch;
            btnTagX.Cursor = Cursors.Hand;
            btnTagX.Location = new Point(509, 24);
            btnTagX.Name = "btnTagX";
            btnTagX.Size = new Size(40, 40);
            btnTagX.TabIndex = 5;
            btnTagX.Click += BtnTagX_Click;
            // 
            // btnAddTagFinish
            // 
            btnAddTagFinish.Cursor = Cursors.Hand;
            btnAddTagFinish.Location = new Point(209, 228);
            btnAddTagFinish.Name = "btnAddTagFinish";
            btnAddTagFinish.Size = new Size(157, 50);
            btnAddTagFinish.TabIndex = 2;
            btnAddTagFinish.Click += BtnAddTagFinish_Click;
            // 
            // txtTagName
            // 
            txtTagName.BackColor = Color.FromArgb(194, 194, 194);
            txtTagName.BorderStyle = BorderStyle.None;
            txtTagName.Font = new Font("Comic Sans MS", 20F);
            txtTagName.Location = new Point(188, 152);
            txtTagName.Name = "txtTagName";
            txtTagName.Size = new Size(323, 38);
            txtTagName.TabIndex = 3;
            // 
            // btnAccountType_OAuth
            // 
            btnAccountType_OAuth.BackgroundImage = Properties.Resources.OAuthType;
            btnAccountType_OAuth.BackgroundImageLayout = ImageLayout.Center;
            btnAccountType_OAuth.Cursor = Cursors.Hand;
            btnAccountType_OAuth.Location = new Point(471, 170);
            btnAccountType_OAuth.Name = "btnAccountType_OAuth";
            btnAccountType_OAuth.Size = new Size(170, 50);
            btnAccountType_OAuth.TabIndex = 17;
            btnAccountType_OAuth.Click += BtnAccountType_OAuth_Click;
            // 
            // btnAccountType_Custom
            // 
            btnAccountType_Custom.BackgroundImage = Properties.Resources.CustomType_Selected1;
            btnAccountType_Custom.BackgroundImageLayout = ImageLayout.Center;
            btnAccountType_Custom.Cursor = Cursors.Hand;
            btnAccountType_Custom.Location = new Point(274, 170);
            btnAccountType_Custom.Name = "btnAccountType_Custom";
            btnAccountType_Custom.Size = new Size(170, 50);
            btnAccountType_Custom.TabIndex = 16;
            btnAccountType_Custom.Click += BtnAccountType_Custom_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Cursor = Cursors.Hand;
            btnAddAccount.Location = new Point(460, 550);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(154, 46);
            btnAddAccount.TabIndex = 3;
            btnAddAccount.Click += BtnAddAccount_Click;
            // 
            // txtAccNote
            // 
            txtAccNote.BackColor = Color.FromArgb(194, 194, 194);
            txtAccNote.BorderStyle = BorderStyle.None;
            txtAccNote.Font = new Font("Comic Sans MS", 25F);
            txtAccNote.Location = new Point(410, 387);
            txtAccNote.Name = "txtAccNote";
            txtAccNote.Size = new Size(509, 47);
            txtAccNote.TabIndex = 15;
            // 
            // txtAccRequirement
            // 
            txtAccRequirement.BackColor = Color.FromArgb(194, 194, 194);
            txtAccRequirement.BorderStyle = BorderStyle.None;
            txtAccRequirement.Font = new Font("Comic Sans MS", 25F);
            txtAccRequirement.Location = new Point(317, 307);
            txtAccRequirement.Name = "txtAccRequirement";
            txtAccRequirement.Size = new Size(547, 47);
            txtAccRequirement.TabIndex = 14;
            txtAccRequirement.UseSystemPasswordChar = true;
            // 
            // txtAccEmail
            // 
            txtAccEmail.BackColor = Color.FromArgb(194, 194, 194);
            txtAccEmail.BorderStyle = BorderStyle.None;
            txtAccEmail.Font = new Font("Comic Sans MS", 25F);
            txtAccEmail.Location = new Point(255, 239);
            txtAccEmail.Name = "txtAccEmail";
            txtAccEmail.Size = new Size(664, 47);
            txtAccEmail.TabIndex = 13;
            // 
            // txtAccName
            // 
            txtAccName.BackColor = Color.FromArgb(194, 194, 194);
            txtAccName.BorderStyle = BorderStyle.None;
            txtAccName.Font = new Font("Comic Sans MS", 25F);
            txtAccName.Location = new Point(266, 101);
            txtAccName.Name = "txtAccName";
            txtAccName.Size = new Size(653, 47);
            txtAccName.TabIndex = 12;
            // 
            // flowLayoutPanelTags
            // 
            flowLayoutPanelTags.AutoScroll = true;
            flowLayoutPanelTags.Controls.Add(btnAddTag);
            flowLayoutPanelTags.Location = new Point(261, 447);
            flowLayoutPanelTags.Name = "flowLayoutPanelTags";
            flowLayoutPanelTags.Size = new Size(658, 82);
            flowLayoutPanelTags.TabIndex = 7;
            flowLayoutPanelTags.WrapContents = false;
            // 
            // btnAddTag
            // 
            btnAddTag.BackgroundImage = Properties.Resources.Add_Tag;
            btnAddTag.BackgroundImageLayout = ImageLayout.Center;
            btnAddTag.Cursor = Cursors.Hand;
            btnAddTag.Location = new Point(3, 3);
            btnAddTag.Name = "btnAddTag";
            btnAddTag.Size = new Size(191, 54);
            btnAddTag.TabIndex = 0;
            btnAddTag.Click += BtnAddTag_Click;
            // 
            // FrmManipulateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Main_UI__Custom___Add_Account__Screen1;
            ClientSize = new Size(1584, 941);
            Controls.Add(pnlAccount);
            Controls.Add(pnlTitle);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmManipulateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NekoKeep";
            pnlAccount.ResumeLayout(false);
            pnlAccount.PerformLayout();
            pnlAddTag.ResumeLayout(false);
            pnlAddTag.PerformLayout();
            flowLayoutPanelTags.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAccount;
        private Panel pnlTitle;
        private FlowLayoutPanel flowLayoutPanelTags;
        private Panel btnAddTag;
        private Panel btnAddTagFinish;
        private Panel pnlAddTag;
        private TextBox txtTagName;
        private TextBox txtAccName;
        private TextBox txtAccNote;
        private TextBox txtAccRequirement;
        private TextBox txtAccEmail;
        private Panel btnAddAccount;
        private Panel btnAccountType_OAuth;
        private Panel btnAccountType_Custom;
        private Panel btnAccShowPass;
        private Panel btnAccX;
        private Panel btnTagX;
    }
}