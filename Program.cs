using NekoKeep.Forms;

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

            using (var splash = new FrmLoading())
            {
                splash.ShowDialog();
            }

            var ctx = new AppContext();
            var login = new FrmOnboarding(ctx);
            ctx.SwitchTo(login);
            Application.Run(ctx);
        }
    }
}