using NekoKeep.Backend.Classes;
using System.Reflection;

namespace NekoKeep.Forms
{
    public partial class FrmMain : Form
    {
        private readonly AppContext ctx;
        public FrmMain(AppContext ctx)
        {
            InitializeComponent();

            this.ctx = ctx;
            EnableDoubleBuffer(ctxMain);
            EnableDoubleBuffer(pnlAccounts);
            EnableDoubleBuffer(pnlCatChatBubble);

            txtCatChat.Text = $"Welcome, {User.Session!.DisplayName}!";
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
            FrmManipulateAccount addForm = new(ctx);
            //addForm.OnAccountSaved += AddAccountToPanel; // Use account panel
            addForm.ShowDialog();
        }

        private int currentTop = 25; // vertical position of first row
        private readonly int rowHeight = 75;  // height of each account row

        private void AddAccountToPanel(AccountData data)
        {
            Panel accountPanel = new()
            {
                Width = pnlAccounts.Width - 20,
                Height = rowHeight,
                Top = currentTop,
                Left = 0,
                BackColor = Color.Transparent
            };

            Font lblFont = new("Comic Sans MS", 15, FontStyle.Regular);

            // First line: Name, Email, Password, Tags
            Label lblName = new()
            {
                Text = data.Name,
                Font = lblFont,
                AutoSize = true,
                Left = 16,
                Top = 17
            };
            accountPanel.Controls.Add(lblName);

            Label lblEmail = new()
            {
                Text = data.Email,
                Font = lblFont,
                AutoSize = true,
                Left = 394,
                Top = 17
            };
            accountPanel.Controls.Add(lblEmail);

            Label lblPassword = new()
            {
                Text = data.Password,
                Font = lblFont,
                AutoSize = true,
                Left = 661,
                Top = 17
            };
            accountPanel.Controls.Add(lblPassword);

            // 🔥 Display Tags here
            Label lblTags = new()
            {
                Text = data.Tags, // comes from lblTag in FrmMainAddAccount
                Font = lblFont,
                AutoSize = true,
                Left = 893,
                Top = 17
            };
            accountPanel.Controls.Add(lblTags);

            // Second line: Notes
            Label lblNotes = new()
            {
                Text = data.Notes,
                Font = lblFont,
                AutoSize = true,
                Left = 16,
                Top = 17 + 25
            };
            accountPanel.Controls.Add(lblNotes);

            // Add the row panel to accountPanel
            pnlAccounts.Controls.Add(accountPanel);

            // Update Y position for next row
            currentTop += rowHeight + 10;
        }

        private void BtnCtxMain_Logout_Click(object sender, EventArgs e) => pnlLogout.Visible = true;

        private void BtnLogoutCancel_Click(object sender, EventArgs e) => pnlLogout.Visible = false;

        private void BtnLogoutConfirm_Click(object sender, EventArgs e)
        {
            User.Logout();
            var onboardingForm = new FrmOnboarding(ctx);
            ctx.SwitchTo(onboardingForm);
        }
    }
}
