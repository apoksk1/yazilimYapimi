namespace NESNEYE_YÖNELİMLİ_PROJE_ÖDEVİ
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.panel1 = new System.Windows.Forms.Panel();
            this.GirisLabel = new System.Windows.Forms.Label();
            this.CilisBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.CilisBtn);
            this.panel1.Controls.Add(this.GirisLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // GirisLabel
            // 
            this.GirisLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GirisLabel.AutoSize = true;
            this.GirisLabel.BackColor = System.Drawing.Color.Transparent;
            this.GirisLabel.Font = new System.Drawing.Font("Mistral", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GirisLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GirisLabel.Location = new System.Drawing.Point(182, 170);
            this.GirisLabel.Name = "GirisLabel";
            this.GirisLabel.Size = new System.Drawing.Size(441, 101);
            this.GirisLabel.TabIndex = 1;
            this.GirisLabel.Text = "HOŞ GELDİNİZ";
            // 
            // CilisBtn
            // 
            this.CilisBtn.BackColor = System.Drawing.Color.Transparent;
            this.CilisBtn.Location = new System.Drawing.Point(725, 0);
            this.CilisBtn.Name = "CilisBtn";
            this.CilisBtn.Size = new System.Drawing.Size(75, 33);
            this.CilisBtn.TabIndex = 3;
            this.CilisBtn.Text = "X";
            this.CilisBtn.UseVisualStyleBackColor = false;
            this.CilisBtn.Click += new System.EventHandler(this.CilisBtn_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label GirisLabel;
        private System.Windows.Forms.Button CilisBtn;
    }
}