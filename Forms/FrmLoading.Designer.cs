namespace NekoKeep.Forms
{
    partial class FrmLoading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoading));
            loadingGif = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)loadingGif).BeginInit();
            SuspendLayout();
            // 
            // loadingGif
            // 
            loadingGif.BackgroundImageLayout = ImageLayout.Center;
            loadingGif.Image = Properties.Resources.loading;
            loadingGif.Location = new Point(0, 0);
            loadingGif.Name = "loadingGif";
            loadingGif.Size = new Size(400, 240);
            loadingGif.SizeMode = PictureBoxSizeMode.CenterImage;
            loadingGif.TabIndex = 0;
            loadingGif.TabStop = false;
            // 
            // FrmLoadingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 240);
            Controls.Add(loadingGif);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLoadingScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NekoKeep - Loading";
            Shown += FrmLoadingScreen_Shown;
            ((System.ComponentModel.ISupportInitialize)loadingGif).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox loadingGif;
    }
}