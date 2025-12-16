using NekoKeep.Backend;
using NekoKeep.Backend.Databases;
using System.Reflection;

namespace NekoKeep.Forms
{
    public partial class FrmLoading : Form
    {
        public bool IsSuccessful { get; private set; }
        public FrmLoading()
        {
            InitializeComponent();

            var prop = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            prop?.SetValue(this, true, null);
        }

        private async void FrmLoadingScreen_Shown(object sender, EventArgs e)
        {
            try
            {
                // Connect to MainDB and create all tables if they don't exist or delete them and recreate them
                MainDB.Connect();
                // MainDB.DropAllTables(); // Uncomment to drop tables 
                MainDB.CreateAllTables();

                await Task.Delay(3000);
                IsSuccessful = true;
                Close();
            }
            catch (Exception ex)
            {
                Utils.ThrowError("Failed to connect to the database. Please check your configuration.\n\n" + ex.Message);
                IsSuccessful = false;
                Close();
            }
        }
    }
}
