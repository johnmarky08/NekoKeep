using NekoKeep.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NekoKeep
{
    public partial class FrmMainAddAccount : Form
    {
        public FrmMainAddAccount()
        {
            InitializeComponent();
        }

        private void btnarrow_Click(object sender, EventArgs e)
        {

            panel3.Visible = false;
        }

        private void btnarrow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnArrowBack_Click(object sender, EventArgs e)
        {

            panel3.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        public event Action<AccountData> OnAccountSaved;

        private void btnAdd_Click(object sender, EventArgs e)
        {

            AddItemPanel(textBox1.Text);
            textBox1.Clear();

        }

        private void AddItemPanel(string text)
        {
            // Panel
            Panel itemPanel = new Panel();
            itemPanel.Width = 191;
            itemPanel.Height = 54;
            itemPanel.Margin = new Padding(3);
            itemPanel.BackColor = Color.Transparent;
            itemPanel.BackgroundImage = Properties.Resources.Rectangle_2;
            itemPanel.BackgroundImageLayout = ImageLayout.Center;

            // Label
            Label lbl = new Label();           // changed from 'lbltag' to 'lbl'
            lbl.Text = text;                   // assign text
            lbl.AutoSize = true;
            lbl.Font = new Font("Comic Sans MS", 15, FontStyle.Regular);
            lbl.BackColor = Color.Transparent;
            lbl.ForeColor = Color.Black;
            lbl.Left = 22;
            lbl.Top = 11;

            // Add label to panel
            itemPanel.Controls.Add(lbl);

            // Add panel to FlowLayoutPanel
            flowLayoutPanel1.Controls.Add(itemPanel);

            // Keep panel4 (Add Tag button) always last
            flowLayoutPanel1.Controls.Remove(panel4);
            flowLayoutPanel1.Controls.Add(panel4);

            panel5.Visible = false;
        }



        private void btnAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void itemPanel_Click(object sender, EventArgs e)
        {

        }

        private void pnlbox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        { // Collect all labels inside FlowLayoutPanel (ignore panel4)
            var tagLabels = flowLayoutPanel1.Controls
                .OfType<Panel>()              // get only panels
                .Where(p => p != panel4)      // ignore the "Add Tag" panel
                .Select(p => p.Controls.OfType<Label>().FirstOrDefault()?.Text)
                .Where(t => !string.IsNullOrEmpty(t))
                .ToList();

            string tags = string.Join(", ", tagLabels);

            // Create AccountData
            AccountData data = new AccountData()
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Notes = txtNotes.Text,
                Tags = tags
            };

            // Send data to FrmMain
            OnAccountSaved?.Invoke(data);

            this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbltag_Click(object sender, EventArgs e)
        {

        }

        private void itemPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        bool expand = false;



       

        private void FrmMainAddAccount_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
        bool isFirstImage = false;

        private void panel3_Click(object sender, EventArgs e)
        {
            if (isFirstImage)
            {
                panel3.BackgroundImage = Properties.Resources.Custom_Type;  // First image
            }
            else
            {
                panel3.BackgroundImage = Properties.Resources.Type_Custom_Drop_Down;  // Second image
            }

            // Toggle state
            isFirstImage = !isFirstImage;

            // Optional for nicer appearance
            panel3.BackgroundImageLayout = ImageLayout.Center;

            int panelHeight = panel7.Visible ? panel7.Height : 0;
            panel7.Visible = !panel7.Visible;
        }

        
    }
}
