using NekoKeep.Backend.Databases;
using System.Reflection;

namespace NekoKeep.Forms
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();

            var prop = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            prop?.SetValue(this, true, null);
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
