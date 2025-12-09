using NekoKeep.Backend;
using NekoKeep.Backend.Classes;
using NekoKeep.Backend.Databases;
using NekoKeep.Backend.Interfaces;
using NekoKeep.Forms;
using System.Data;
using System.Reflection;

namespace NekoKeep
{
    public partial class FrmManipulateAccount : Form
    {
        private readonly AppContext ctx;
        private readonly Account? account;

        public FrmManipulateAccount(AppContext ctx, Account? account = null)
        {
            InitializeComponent();
            UpdateTagPanel();

            EnableDoubleBuffer(this);
            EnableDoubleBuffer(flowLayoutPanelTags);
            foreach (Panel panel in flowLayoutPanelTags.Controls)
            {
                EnableDoubleBuffer(panel);
            }

            this.ctx = ctx;
            this.account = account;

            if (account != null)
            {
                pnlTitle.BackgroundImage = Properties.Resources.Edit_Account;
                txtAccName.Text = account.Data.DisplayName;
                txtAccEmail.Text = account.Data.Email;
                txtAccNote.Text = account.Data.Note ?? string.Empty;

                var tagNames = account.Data.Tags.Select(t => t.DisplayName);
                foreach (Panel panel in flowLayoutPanelTags.Controls.OfType<Panel>())
                {
                    if (panel == btnAddTag) continue;

                    var label = (Label)panel.Controls[0];
                    if (tagNames.Contains(label.Text))
                    {
                        panel.BackgroundImage = Properties.Resources.Tag_Bg_Selected;
                        tags.Add(label.Text);
                    }
                }

                if (account is OAuthAccount oauthAcc)
                {
                    ChangeToOAuthAccountType();
                    txtAccRequirement.Text = oauthAcc.Data.Provider;
                }
                else ChangeToCustomAccountType();
            }
        }

        private void BtnAddTag_Click(object sender, EventArgs e) => pnlAddTag.Visible = true;

        private static void EnableDoubleBuffer(Control control)
        {
            var prop = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            prop?.SetValue(control, true, null);
        }

        private void BtnAddTagFinish_Click(object sender, EventArgs e)
        {
            string tagName = txtTagName.Text.Trim();
            if (string.IsNullOrEmpty(tagName))
            {
                Utils.ThrowError("Tag name cannot be empty.");
                return;
            }
            else if (TagsDB.RetrieveAccountTags(User.Session!.Id).Select(tag => tag.DisplayName).Contains(txtTagName.Text))
            {
                Utils.ThrowError("Tag name already exists.");
                return;
            }

            TagsDB.CreateTag(User.Session!.Id, tagName);
            txtTagName.Clear();
            pnlAddTag.Visible = false;
            UpdateTagPanel();
        }

        private void UpdateTagPanel()
        {
            flowLayoutPanelTags.SuspendLayout();
            flowLayoutPanelTags.Controls.Clear();
            List<ITag> tags = TagsDB.RetrieveTags(User.Session!.Id);
            foreach (var tag in tags)
            {
                AddItemPanel(tag.DisplayName!);
            }

            // Keep Add Tag button always last
            flowLayoutPanelTags.Controls.Remove(btnAddTag);
            flowLayoutPanelTags.Controls.Add(btnAddTag);
            flowLayoutPanelTags.ResumeLayout();
        }

        private void AddItemPanel(string text)
        {
            // Panel
            Panel itemPanel = new()
            {
                Width = 191,
                Height = 54,
                Margin = new Padding(3),
                BackColor = Color.Transparent,
                BackgroundImage = Properties.Resources.Tag_Bg,
                BackgroundImageLayout = ImageLayout.Center
            };

            // Label
            Label lbl = new()
            {
                Text = text,
                Font = new Font("Comic Sans MS", 15, FontStyle.Regular),
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Size = new Size(191, 54),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoEllipsis = true,
                Cursor = Cursors.Hand,
            };
            lbl.Click += Tag_CLick;

            // Add label to panel
            itemPanel.Controls.Add(lbl);

            // Add panel to FlowLayoutPanel
            flowLayoutPanelTags.Controls.Add(itemPanel);
        }

        private string type = "Custom";
        private readonly HashSet<string> tags = [];
        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            string accountName = txtAccName.Text.Trim();
            string email = txtAccEmail.Text.Trim();
            string typeRequirement = txtAccRequirement.Text.Trim();
            string? notes = txtAccNote.Text.Trim();
            if (string.IsNullOrWhiteSpace(accountName) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(typeRequirement))
            {
                Utils.ThrowError("Account Name, Username, and Password cannot be empty.");
                return;
            }
            else if (!Utils.ValidateEmail(email))
            {
                Utils.ThrowError("Invalid email format.");
                return;
            }

            if (this.account == null)
            {
                if (type.Equals("Custom"))
                {
                    if (!Utils.ValidatePassword(typeRequirement))
                    {
                        Utils.ThrowError("Your password must be at least 8 characters and include uppercase and lowercase letters, a number, and a special character.");
                        return;
                    }

                    ICustomAccount account = new CustomAccountDto()
                    {
                        UserId = User.Session!.Id,
                        Email = email,
                        DisplayName = accountName,
                        Password = typeRequirement,
                        Note = string.IsNullOrWhiteSpace(notes) ? null : notes,
                        Tags = TagsDB.ResolveTags([.. tags])
                    };

                    AccountsDB.CreateAccount(account);
                }
                else if (type.Equals("OAuth"))
                {
                    IOAuthAccount account = new OAuthAccountDto()
                    {
                        UserId = User.Session!.Id,
                        Email = email,
                        DisplayName = accountName,
                        Provider = typeRequirement,
                        Note = string.IsNullOrWhiteSpace(notes) ? null : notes,
                        Tags = TagsDB.ResolveTags([.. tags])
                    };

                    AccountsDB.CreateAccount(account);
                }

                Utils.ThrowSuccess("Account added successfully.");
            }
            else
            {
                if (type.Equals("Custom"))
                {
                    if (!Utils.ValidatePassword(typeRequirement))
                    {
                        Utils.ThrowError("Your password must be at least 8 characters and include uppercase and lowercase letters, a number, and a special character.");
                        return;
                    }

                    ICustomAccount account = new CustomAccountDto()
                    {
                        Id = this.account.Data.Id,
                        UserId = this.account.Data.UserId,
                        Email = email,
                        DisplayName = accountName,
                        Password = typeRequirement,
                        Note = string.IsNullOrWhiteSpace(notes) ? null : notes,
                        Tags = TagsDB.ResolveTags([.. tags])
                    };

                    AccountsDB.UpdateAccount(account);
                }
                else if (type.Equals("OAuth"))
                {
                    IOAuthAccount account = new OAuthAccountDto()
                    {
                        Id = this.account.Data.Id,
                        UserId = this.account.Data.UserId,
                        Email = email,
                        DisplayName = accountName,
                        Provider = typeRequirement,
                        Note = string.IsNullOrWhiteSpace(notes) ? null : notes,
                        Tags = TagsDB.ResolveTags([.. tags])
                    };

                    AccountsDB.UpdateAccount(account);
                }

                Utils.ThrowSuccess("Account edited successfully.");
            }

            ClearAccFields();
            var mainForm = new FrmMain(ctx);
            ctx.SwitchTo(mainForm);
        }

        private void Tag_CLick(object? sender, EventArgs e)
        {
            Label label = (Label)sender!;
            Control panel = label.Parent!;
            string tagName = label.Text;

            if (!tags.Contains(tagName))
            {
                panel.BackgroundImage = Properties.Resources.Tag_Bg_Selected;
                tags.Add(tagName);
            }
            else
            {
                panel.BackgroundImage = Properties.Resources.Tag_Bg;
                tags.Remove(tagName);
            }
        }

        private void BtnAccountType_Custom_Click(object sender, EventArgs e)
        {
            if (account != null)
            {
                Utils.ThrowError("You are not allowed to edit an account's type.");
                return;
            }
            ChangeToCustomAccountType();
            ClearAccFields();
        }

        private void ChangeToCustomAccountType()
        {
            btnAccountType_Custom.BackgroundImage = Properties.Resources.CustomType_Selected;
            btnAccountType_OAuth.BackgroundImage = Properties.Resources.OAuthType;
            pnlAccount.BackgroundImage = Properties.Resources.Add_Account;
            type = "Custom";

            btnAccShowPass.Visible = true;
            txtAccRequirement.UseSystemPasswordChar = true;
            txtAccRequirement.Size = new Size(547, 47);
        }

        private void BtnAccountType_OAuth_Click(object sender, EventArgs e)
        {
            if (account != null)
            {
                Utils.ThrowError("You are not allowed to edit an account's type.");
                return;
            }
            ChangeToOAuthAccountType();
            ClearAccFields();
        }

        private void ChangeToOAuthAccountType()
        {
            btnAccountType_OAuth.BackgroundImage = Properties.Resources.OAuthType_Selected;
            btnAccountType_Custom.BackgroundImage = Properties.Resources.CustomType;
            pnlAccount.BackgroundImage = Properties.Resources.Add_Account_2;
            type = "OAuth";

            btnAccShowPass.Visible = false;
            txtAccRequirement.UseSystemPasswordChar = false;
            txtAccRequirement.Size = new Size(602, 47);
        }

        private void ClearAccFields()
        {
            txtAccName.Clear();
            txtAccEmail.Clear();
            txtAccRequirement.Clear();
            txtAccNote.Clear();
            tags.Clear();
            foreach (Panel panel in flowLayoutPanelTags.Controls)
            {
                if (panel == btnAddTag) continue;
                panel.BackgroundImage = Properties.Resources.Tag_Bg;
            }
        }

        private void TxtAccShowPass_Click(object sender, EventArgs e)
        {
            if (txtAccRequirement.UseSystemPasswordChar)
            {
                txtAccRequirement.UseSystemPasswordChar = false;
                btnAccShowPass.BackgroundImage = Properties.Resources.Hide_Icon;
            }
            else
            {
                txtAccRequirement.UseSystemPasswordChar = true;
                btnAccShowPass.BackgroundImage = Properties.Resources.Show_Icon;
            }
        }

        private void BtnTagX_Click(object sender, EventArgs e)
        {
            txtTagName.Clear();
            pnlAddTag.Visible = false;
        }

        private void BtnAccX_Click(object sender, EventArgs e)
        {
            var mainForm = new FrmMain(ctx);
            ctx.SwitchTo(mainForm);
        }
    }
}
