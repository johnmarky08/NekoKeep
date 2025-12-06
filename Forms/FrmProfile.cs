namespace NekoKeep.Forms
{
    public partial class FrmProfile : Form
    {
        private AppContext ctx;
        public FrmProfile(AppContext ctx)
        {
            InitializeComponent();
            this.ctx = ctx;
        }
    }
}
