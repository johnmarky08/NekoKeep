namespace NekoKeep.Forms
{
    public partial class FrmSettings : Form
    {
        private AppContext ctx;
        public FrmSettings(AppContext ctx)
        {
            InitializeComponent();
            this.ctx = ctx;
        }

        private void BtnSettingsAccount_Click(object sender, EventArgs e)
        {
            btnSettingsAccount.BackgroundImage = Properties.Resources.account__selected_;
            btnSettingsBackup.BackgroundImage = Properties.Resources.Backup;
            btnSettingsAbout.BackgroundImage = Properties.Resources.About_Us;
        }

        private void BtnSettingsBackup_Click(object sender, EventArgs e)
        {
            btnSettingsBackup.BackgroundImage = Properties.Resources.backup__selected_;
            btnSettingsAccount.BackgroundImage = Properties.Resources.Account;
            btnSettingsAbout.BackgroundImage = Properties.Resources.About_Us;
        }

        private void BtnSettingsAbout_Click(object sender, EventArgs e)
        {
            btnSettingsAbout.BackgroundImage = Properties.Resources.About_us__selected_;
            btnSettingsAccount.BackgroundImage = Properties.Resources.Account;
            btnSettingsBackup.BackgroundImage = Properties.Resources.Backup;
        }

        private void BtnCloseMainContextMenu_Click(object sender, EventArgs e)
        {
            var mainForm = new FrmMain(ctx);
            ctx.SwitchTo(mainForm);
        }
    }
}
