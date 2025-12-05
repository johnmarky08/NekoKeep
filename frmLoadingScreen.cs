using NekoKeep.Backend.Databases;

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
            // Connect to MainDB and create all tables if they don't exist or delete them and recreate them
            MainDB.Connect();
            // MainDB.DropAllTables(); // Uncomment to drop tables 
            MainDB.CreateAllTables();

            await Task.Delay(3000);
            Close();
        }
    }
}
