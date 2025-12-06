namespace NekoKeep.Forms
{
    public partial class FrmMain : Form
    {
        private readonly AppContext ctx;
        public FrmMain(AppContext ctx)
        {
            InitializeComponent();
            this.ctx = ctx;
        }
    }
}
