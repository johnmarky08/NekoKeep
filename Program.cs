namespace NekoKeep
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Load all secrets
            DotNetEnv.Env.Load();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using (var splash = new FrmLoadingScreen())
            {
                splash.ShowDialog();
            }

            Application.Run(new frmMain());
        }
    }
}