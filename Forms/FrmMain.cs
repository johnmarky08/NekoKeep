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
    }
}
