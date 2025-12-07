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
            typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
               ?.SetValue(ctxMain, true, null);

            txtCatChat.Text = $"Hello, {User.Session!.DisplayName}!";
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
            txtCatChat.Text = $"Hello, {User.Session!.DisplayName}!";
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCtxMain_Profile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            FrmMainAddAccount addForm = new FrmMainAddAccount();
            addForm.OnAccountSaved += AddAccountToPanel1; // Use panel1
            addForm.ShowDialog();
        }

        private int currentTop = 25; // vertical position of first row
        private int rowHeight = 75;  // height of each account row

        private void AddAccountToPanel1(AccountData data)
        {
            Panel accountPanel = new Panel();
            accountPanel.Width = panel1.Width - 20;
            accountPanel.Height = rowHeight;
            accountPanel.Top = currentTop;
            accountPanel.Left = 0;
            accountPanel.BackColor = Color.Transparent;

            Font lblFont = new Font("Comic Sans MS", 15, FontStyle.Regular);

            // First line: Name, Email, Password, Tags
            Label lblName = new Label();
            lblName.Text = data.Name;
            lblName.Font = lblFont;
            lblName.AutoSize = true;
            lblName.Left = 16;
            lblName.Top = 17;
            accountPanel.Controls.Add(lblName);

            Label lblEmail = new Label();
            lblEmail.Text = data.Email;
            lblEmail.Font = lblFont;
            lblEmail.AutoSize = true;
            lblEmail.Left = 394;
            lblEmail.Top = 17;
            accountPanel.Controls.Add(lblEmail);

            Label lblPassword = new Label();
            lblPassword.Text = data.Password;
            lblPassword.Font = lblFont;
            lblPassword.AutoSize = true;
            lblPassword.Left = 661;
            lblPassword.Top = 17;
            accountPanel.Controls.Add(lblPassword);

            // 🔥 Display Tags here
            Label lblTags = new Label();
            lblTags.Text = data.Tags; // comes from lblTag in FrmMainAddAccount
            lblTags.Font = lblFont;
            lblTags.AutoSize = true;
            lblTags.Left = 893;
            lblTags.Top = 17;
            accountPanel.Controls.Add(lblTags);

            // Second line: Notes
            Label lblNotes = new Label();
            lblNotes.Text = data.Notes;
            lblNotes.Font = lblFont;
            lblNotes.AutoSize = true;
            lblNotes.Left = 16;
            lblNotes.Top = 17 + 25;
            accountPanel.Controls.Add(lblNotes);

            // Add the row panel to panel1
            panel1.Controls.Add(accountPanel);

            // Update Y position for next row
            currentTop += rowHeight + 10;
        }





        private void btnAddAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnldelete_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
