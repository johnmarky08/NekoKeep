using System.Threading.Tasks;

namespace NekoKeep
{
    public partial class FrmLoadingScreen : Form
    {
        public FrmLoadingScreen()
        {
            InitializeComponent();
            Shown += FrmLoadingScreen_Shown!;
        }

        private async void FrmLoadingScreen_Shown(object sender, EventArgs e)
        {
            await Task.Delay(3000);
            Close();
        }
    }
}
