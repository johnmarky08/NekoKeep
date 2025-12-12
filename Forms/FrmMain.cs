using NekoKeep.Backend;
using NekoKeep.Backend.Classes;
using NekoKeep.Backend.Databases;
using NekoKeep.Backend.Interfaces;
using System.Reflection;

namespace NekoKeep.Forms
{
    public partial class FrmMain : Form
    {
        private readonly AppContext ctx;
        private readonly List<ITag> currentTags = [];
        private int nameFilterState = 0;
        private int lastUpdatedFilterState = 0;
        public FrmMain(AppContext ctx)
        {
            InitializeComponent();
            UpdateTagPanel();
            Cursor = Cursors.Default;

            this.ctx = ctx;
            EnableDoubleBuffer(this);
            EnableDoubleBuffer(ctxMain);
            EnableDoubleBuffer(pnlCatChatBubble);
            EnableDoubleBuffer(pnlViewPassMpinHolder);

            txtCatChat.Text = $"Welcome, {User.Session!.DisplayName}!";
            btnMainContextMenu.BackgroundImage = Properties.Resources.ResourceManager.GetObject("icon_" + User.Session!.CatPresetId) as Image;
            ReloadAccounts();
        }

        private async void ReloadAccounts()
        {
            bool sortByDate = lastUpdatedFilterState != 0;
            bool descending = lastUpdatedFilterState == 2 || nameFilterState == 2;
            List<Account> accounts = User.ViewAccounts(sortByDate, descending, currentTags);
            await AddAccountsToPanel(accounts);
        }

        private static void EnableDoubleBuffer(Control control)
        {
            var prop = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            prop?.SetValue(control, true, null);

            foreach (Control child in control.Controls)
            {
                EnableDoubleBuffer(child);
            }
        }

        private bool catChatInitilized = false;
        private async void FrmMain_Load(object? sender, EventArgs e)
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            pnlCatChatBubble.Hide();
            catChatInitilized = true;
        }

        private void BtnMainContextMenu_Click(object sender, EventArgs e)
        {
            ctxMain.Parent?.SuspendLayout();
            try
            {
                ctxMain.BringToFront();

                if (ctxMain.Visible) ctxMain.Hide();
                else ctxMain.Show();

                ctxMain.Invalidate();
                ctxMain.Update();
            }
            finally
            {
                ctxMain.Parent?.ResumeLayout(false);
            }
        }

        private void PnlCatTrigger_MouseEnter(object sender, EventArgs e)
        {
            txtCatChat.Text = $"Welcome, {User.Session!.DisplayName}!";
            pnlCatChatBubble.Show();
        }

        private void PnlCatTrigger_MouseLeave(object sender, EventArgs e)
        {
            if (catChatInitilized) pnlCatChatBubble.Hide();
        }

        private void BtnCtxMain_Profile_Click(object sender, EventArgs e)
        {
            var profile = new FrmProfile(ctx);
            ctx.SwitchTo(profile);
        }

        private void BtnCtxMain_Settings_Click(object sender, EventArgs e)
        {
            var settingsForm = new FrmSettings(ctx);
            ctx.SwitchTo(settingsForm);
        }

        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            var manipulateAccountForm = new FrmManipulateAccount(ctx);
            ctx.SwitchTo(manipulateAccountForm);
        }

        int toDeleteId = -1;
        (CustomAccount?, Label?, Panel?) toViewPass = (null, null, null);

        private async Task AddAccountsToPanel(List<Account> accounts)
        {
            Cursor = Cursors.WaitCursor;

            accounts = [.. accounts.OrderByDescending(acc => acc is CustomAccount)];

            if (InvokeRequired)
            {
                await Invoke(async () => await AddControlsToTableAsync(accounts));

            }
            else
                await AddControlsToTableAsync(accounts);
            Cursor = Cursors.Default;
        }

        private static Panel CreatePanelWithLabel(string text, Size size)
        {

            Panel panel = new()
            {
                Size = size,
                AutoScroll = true,
            };
            Label label = new()
            {
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
            };
            panel.Controls.Add(label);

            return panel;
        }

        private async Task AddControlsToTableAsync(List<Account> prepared)
        {
            tblAccounts.SuspendLayout();
            tblAccounts.Controls.Clear();

            int i = 0;
            const int batchSize = 50;
            for (int start = 0; start < prepared.Count; start += batchSize)
            {
                int end = Math.Min(start + batchSize, prepared.Count);
                for (int idx = start; idx < end; idx++)
                {
                    var accountRaw = prepared[idx];
                    IAccount account = accountRaw.Data;
                    Label type = new()
                    {
                        Text = typeof(OAuthAccount) == accountRaw.GetType() ? "OAuth" : "Custom",
                        TextAlign = ContentAlignment.MiddleCenter,
                        Size = new Size(119, 45),
                    };
                    Panel displayName = CreatePanelWithLabel(account.DisplayName, new Size(244, 45));
                    Panel email = CreatePanelWithLabel(account.Email, new Size(244, 45));
                    Panel req = CreatePanelWithLabel(type.Text.Equals("OAuth") ? ((IOAuthAccount)account).Provider : "********", new Size(244, 45));
                    Panel tags = CreatePanelWithLabel(string.Join(", ", account.Tags.Select(tag => tag.DisplayName).Order()), new Size(181, 45));
                    Panel actions = new()
                    {
                        BackgroundImage = type.Text.Equals("OAuth") ? Properties.Resources.OAuthActions : Properties.Resources.CustomActions_Show,
                        BackgroundImageLayout = ImageLayout.Center,
                        BackColor = Color.Transparent,
                        Size = new Size(185, 39),
                    };

                    Panel editAction = new()
                    {
                        Size = new Size(30, 30),
                        Location = type.Text.Equals("OAuth") ? new Point(56, 5) : new Point(35, 5),
                        Cursor = Cursors.Hand
                    };
                    editAction.Click += (s, e) =>
                    {
                        var manipulateAccountForm = new FrmManipulateAccount(ctx, accountRaw);
                        ctx.SwitchTo(manipulateAccountForm);
                    };

                    Panel deleteButton = new()
                    {
                        Size = new Size(30, 30),
                        Location = type.Text.Equals("OAuth") ? new Point(98, 5) : new Point(77, 5),
                        Cursor = Cursors.Hand,
                    };
                    deleteButton.Click += (s, e) =>
                    {
                        pnlDelete.Visible = true;
                        toDeleteId = account.Id;
                    };

                    Panel showPassButton = new()
                    {
                        Size = new Size(30, 30),
                        Location = new Point(119, 5),
                        Cursor = Cursors.Hand,
                        Visible = !type.Text.Equals("OAuth"),
                    };
                    showPassButton.Click += (s, e) =>
                    {
                        if (((Label)req.Controls[0]).Text.Equals("********"))
                        {
                            toViewPass = ((CustomAccount)accountRaw, (Label)req.Controls[0], actions);
                            pnlViewPassMpin.Visible = true;
                            pnlViewPassMpinHolder.Focus();
                        }
                        else
                        {
                            ((Label)req.Controls[0]).Text = "********";
                            actions.BackgroundImage = Properties.Resources.CustomActions_Show;
                        }
                    };

                    actions.Controls.Add(editAction);
                    actions.Controls.Add(deleteButton);
                    actions.Controls.Add(showPassButton);

                    Label? note = account.Note != null ? new()
                    {
                        Text = " Note: " + account.Note,
                        TextAlign = ContentAlignment.MiddleLeft,
                        AutoEllipsis = true,
                        Size = new Size(1056, 45),
                    } : null;
                    Label border = new()
                    {
                        Text = "------------------------------------------------------------------------------------------------------------------------------------------------------",
                        TextAlign = ContentAlignment.MiddleCenter,
                        Size = new Size(1247, 20),
                    };

                    tblAccounts.Controls.Add(type, 0, i);
                    tblAccounts.Controls.Add(displayName, 1, i);
                    tblAccounts.Controls.Add(email, 2, i);
                    tblAccounts.Controls.Add(req, 3, i);
                    tblAccounts.Controls.Add(tags, 4, i);
                    tblAccounts.Controls.Add(actions, 5, i);

                    bool hasNote = note != null;
                    if (hasNote)
                    {
                        tblAccounts.Controls.Add(note!, 0, ++i);
                        tblAccounts.SetColumnSpan(note!, 6);
                    }

                    tblAccounts.Controls.Add(border, 0, ++i);
                    tblAccounts.SetColumnSpan(border, 6);

                    i++;
                }

                tblAccounts.ResumeLayout();
                tblAccounts.PerformLayout();
                await Task.Yield();
                tblAccounts.SuspendLayout();
            }

            tblAccounts.ResumeLayout();
            tblAccounts.PerformLayout();
            tblAccounts.Invalidate(true);
        }

        private void BtnCtxMain_Logout_Click(object sender, EventArgs e) => pnlLogout.Visible = true;

        private void BtnLogoutCancel_Click(object sender, EventArgs e) => pnlLogout.Visible = false;

        private void BtnLogoutConfirm_Click(object sender, EventArgs e)
        {
            User.Logout();
            var onboardingForm = new FrmOnboarding(ctx);
            ctx.SwitchTo(onboardingForm);
        }

        private void BtnDeleteOk_Click(object sender, EventArgs e)
        {
            if (toDeleteId == -1) return;

            AccountsDB.DeleteAccount(toDeleteId);
            toDeleteId = -1;
            pnlDelete.Visible = false;
            ReloadAccounts();
            Utils.ThrowSuccess("Account deleted successfully.");
        }

        private void BtnDeleteCancel_Click(object sender, EventArgs e)
        {
            toDeleteId = -1;
            pnlDelete.Visible = false;
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            string? text = string.IsNullOrWhiteSpace(txtSearch.Text) ? null : txtSearch.Text;
            List<Account> accounts = Search.Get(text);
            await AddAccountsToPanel(accounts);
        }

        private void UpdateTagPanel()
        {
            flowLayoutPanelFilterTags.SuspendLayout();
            flowLayoutPanelFilterTags.Controls.Clear();
            List<ITag> tags = TagsDB.RetrieveTags(User.Session!.Id);
            foreach (var tag in tags)
            {
                AddItemPanel(tag.DisplayName!);
            }

            flowLayoutPanelFilterTags.ResumeLayout();
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
            lbl.Click += (s, e) =>
            {
                ITag tag = TagsDB.RetrieveTags(User.Session!.Id).First(tag => tag.DisplayName == text);

                if (currentTags.Select(tag => tag.DisplayName).Contains(text))
                {
                    itemPanel.BackgroundImage = Properties.Resources.Tag_Bg;
                    currentTags.Remove(tag);
                }
                else
                {
                    itemPanel.BackgroundImage = Properties.Resources.Tag_Bg_Selected;
                    currentTags.Add(tag);
                }
            };

            // Add label to panel
            itemPanel.Controls.Add(lbl);

            // Add panel to FlowLayoutPanel
            flowLayoutPanelFilterTags.Controls.Add(itemPanel);
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            if (pnlFilter.Visible) ReloadAccounts();
            pnlFilter.Visible = !pnlFilter.Visible;
        }

        private void BtnFilterDisplayName_Click(object sender, EventArgs e)
        {
            btnFilterLastUpdated.BackgroundImage = Properties.Resources.Filter_Last_Updated_Unsellect;
            lastUpdatedFilterState = 0;
            nameFilterState = (nameFilterState + 1) % 3;

            btnFilterDisplayName.BackgroundImage =
                nameFilterState switch
                {
                    0 => Properties.Resources.Filter_Name_Unsellect,
                    1 => Properties.Resources.Filter_Name_Ascending,
                    _ => Properties.Resources.Filter_Name_Descending
                };
        }

        private void BtnFilterLastUpdated_Click(object sender, EventArgs e)
        {
            btnFilterDisplayName.BackgroundImage = Properties.Resources.Filter_Name_Unsellect;
            nameFilterState = 0;
            lastUpdatedFilterState = (lastUpdatedFilterState + 1) % 3;

            btnFilterLastUpdated.BackgroundImage =
                lastUpdatedFilterState switch
                {
                    0 => Properties.Resources.Filter_Last_Updated_Unsellect,
                    1 => Properties.Resources.Last_Updated_Ascending,
                    _ => Properties.Resources.Last_Update_Descending
                };
        }

        private string mpin = "";
        private void PnlViewPassMpinHolder_KeyDown(object? sender, KeyEventArgs e)
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
                var results = pnlViewPassMpinHolder.Controls.Find("viewPassMpin_" + i, true);
                if (results.Length > 0 && results[0] is Panel panel)
                {
                    panel.BackgroundImage = i <= mpin.Length
                        ? Properties.Resources.Asterisk
                        : Properties.Resources.MPIN_Blank;

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

        private void BtnViewPassCancel_Click(object sender, EventArgs e)
        {
            ClearMpinDisplay();
            pnlViewPassMpin.Visible = false;
        }

        private void BtnViewPassConfirm_Click(object sender, EventArgs e)
        {
            if (!Utils.ValidateMpin(mpin)) Utils.ThrowError("The MPIN you entered is not valid.");
            else if (!User.VerifyMpin(mpin)) Utils.ThrowError("The MPIN you entered is incorrect.");
            else
            {
                string decryptedPass = toViewPass.Item1!.ViewPassword(mpin);
                toViewPass.Item2!.Text = decryptedPass;
                toViewPass.Item3!.BackgroundImage = Properties.Resources.CustomActions;
            }

            ClearMpinDisplay();
            pnlViewPassMpin.Visible = false;
        }
    }
}
