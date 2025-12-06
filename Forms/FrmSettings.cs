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
    }
}
