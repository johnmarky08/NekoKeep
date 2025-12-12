using NekoKeep.Backend;
using NekoKeep.Backend.Classes;
using NekoKeep.Backend.Databases;

namespace NekoKeep.Forms
{
    public partial class FrmProfile : Form
    {
        private readonly AppContext ctx;
        private int selectedCatPresetId = User.Session!.CatPresetId;
        public FrmProfile(AppContext ctx)
        {
            InitializeComponent();
            this.ctx = ctx;

            txtSettingsProfile_DisplayName.Text = User.Session!.DisplayName;
            UpdateCatDisplay();
        }

        private void UpdateCatDisplay()
        {
            if (selectedCatPresetId < 1) selectedCatPresetId = 4;
            else if (selectedCatPresetId > 4) selectedCatPresetId = 1;

            picSettingsProfile_CatTheme.Image = selectedCatPresetId switch
            {
                1 => Properties.Resources.NekoKeep_Night_Cat1,
                2 => Properties.Resources.NekoKeep_Bluey_Cat1,
                3 => Properties.Resources.NekoKeep_Gray_Cat1,
                4 => Properties.Resources.NekoKeep_Orange_Cat1,
                _ => Properties.Resources.NekoKeep_Night_Cat1,
            };
        }

        private void BtnCloseMainContextMenu_Profile_Click(object sender, EventArgs e)
        {
            var mainForm = new FrmMain(ctx);
            ctx.SwitchTo(mainForm);
        }

        private void BtnSettingsProfile_Back_Click(object sender, EventArgs e)
        {
            selectedCatPresetId--;
            UpdateCatDisplay();
        }

        private void BtnSettingsProfile_Next_Click(object sender, EventArgs e)
        {
            selectedCatPresetId++;
            UpdateCatDisplay();
        }

        private void BtnSettingsProfile_Update_Click(object sender, EventArgs e)
        {
            List<string> successMessages = [];

            if (!string.IsNullOrWhiteSpace(txtSettingsProfile_DisplayName.Text) && !User.Session!.DisplayName.Equals(txtSettingsProfile_DisplayName.Text))
            {
                UsersDB.UpdateUserDisplayName(User.Session!.Id, txtSettingsProfile_DisplayName.Text);
                successMessages.Add("Display Name");
            }

            if (selectedCatPresetId != User.Session!.CatPresetId)
            {
                UsersDB.UpdateUserCatPresetId(User.Session!.Id, selectedCatPresetId);
                successMessages.Add("Cat Theme");
            }

            if (successMessages.Count > 0)
                Utils.ThrowSuccess((successMessages.Count == 2 ? $"{successMessages[0]} and {successMessages[1]}" : successMessages[0]) + " has been updated successfully.");
            else
                Utils.ThrowError("No changes were detected.");
        }
    }
}
