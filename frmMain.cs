namespace NekoKeep
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnRedirectRegister_Click(object sender, EventArgs e) => mainTabControl.SelectedTab = tabRegisterPage;
    }
}

