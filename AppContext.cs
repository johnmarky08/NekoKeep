namespace NekoKeep
{

    public class AppContext : ApplicationContext
    {
        public AppContext() { }

        public void SwitchTo(Form next)
        {
            var old = MainForm;
            MainForm = next;
            MainForm.FormClosed += (s, e) => { if (Application.OpenForms.Count == 0) ExitThread(); };
            MainForm.Invalidate();
            MainForm.Update();
            MainForm.Show();
            old?.Hide();
            old?.Close();
        }
    }
}
