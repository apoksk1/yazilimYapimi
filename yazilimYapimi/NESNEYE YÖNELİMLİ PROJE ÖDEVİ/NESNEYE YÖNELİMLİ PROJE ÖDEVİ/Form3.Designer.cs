namespace NESNEYE_YÖNELİMLİ_PROJE_ÖDEVİ
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.AnasayfaPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UrunlerBtn = new System.Windows.Forms.PictureBox();
            this.UrunlerLabel = new System.Windows.Forms.Label();
            this.AnasayfaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrunlerBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // AnasayfaPanel
            // 
            this.AnasayfaPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AnasayfaPanel.BackgroundImage")));
            this.AnasayfaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnasayfaPanel.Controls.Add(this.pictureBox1);
            this.AnasayfaPanel.Controls.Add(this.UrunlerBtn);
            this.AnasayfaPanel.Controls.Add(this.UrunlerLabel);
            this.AnasayfaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnasayfaPanel.Location = new System.Drawing.Point(0, 0);
            this.AnasayfaPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AnasayfaPanel.Name = "AnasayfaPanel";
            this.AnasayfaPanel.Size = new System.Drawing.Size(899, 679);
            this.AnasayfaPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UrunlerBtn
            // 
            this.UrunlerBtn.BackColor = System.Drawing.Color.Transparent;
            this.UrunlerBtn.Image = ((System.Drawing.Image)(resources.GetObject("UrunlerBtn.Image")));
            this.UrunlerBtn.Location = new System.Drawing.Point(251, 234);
            this.UrunlerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UrunlerBtn.Name = "UrunlerBtn";
            this.UrunlerBtn.Size = new System.Drawing.Size(374, 333);
            this.UrunlerBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UrunlerBtn.TabIndex = 4;
            this.UrunlerBtn.TabStop = false;
            this.UrunlerBtn.Click += new System.EventHandler(this.UrunlerBtn_Click);
            // 
            // UrunlerLabel
            // 
            this.UrunlerLabel.AutoSize = true;
            this.UrunlerLabel.BackColor = System.Drawing.Color.Transparent;
            this.UrunlerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunlerLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UrunlerLabel.Location = new System.Drawing.Point(408, 207);
            this.UrunlerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UrunlerLabel.Name = "UrunlerLabel";
            this.UrunlerLabel.Size = new System.Drawing.Size(63, 25);
            this.UrunlerLabel.TabIndex = 0;
            this.UrunlerLabel.Text = "İzinler";
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 679);
            this.Controls.Add(this.AnasayfaPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.AnasayfaPanel.ResumeLayout(false);
            this.AnasayfaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrunlerBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AnasayfaPanel;
        private System.Windows.Forms.Label UrunlerLabel;
        private System.Windows.Forms.PictureBox UrunlerBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}