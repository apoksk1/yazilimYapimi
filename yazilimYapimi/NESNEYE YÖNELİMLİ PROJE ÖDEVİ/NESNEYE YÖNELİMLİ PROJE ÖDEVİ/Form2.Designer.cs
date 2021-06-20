namespace NESNEYE_YÖNELİMLİ_PROJE_ÖDEVİ
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GirişYapBtnn = new System.Windows.Forms.Button();
            this.PSWtextBox = new System.Windows.Forms.TextBox();
            this.IDtextbox = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.Label();
            this.KullaniciAdi = new System.Windows.Forms.Label();
            this.GirişYap = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.GirişYap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Mistral", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 645);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.GirişYapBtnn);
            this.panel2.Controls.Add(this.PSWtextBox);
            this.panel2.Controls.Add(this.IDtextbox);
            this.panel2.Controls.Add(this.sifre);
            this.panel2.Controls.Add(this.KullaniciAdi);
            this.panel2.Location = new System.Drawing.Point(114, 165);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 381);
            this.panel2.TabIndex = 1;
            // 
            // GirişYapBtnn
            // 
            this.GirişYapBtnn.Font = new System.Drawing.Font("Mistral", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirişYapBtnn.Location = new System.Drawing.Point(108, 239);
            this.GirişYapBtnn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GirişYapBtnn.Name = "GirişYapBtnn";
            this.GirişYapBtnn.Size = new System.Drawing.Size(167, 61);
            this.GirişYapBtnn.TabIndex = 6;
            this.GirişYapBtnn.Text = "Giriş Yap";
            this.GirişYapBtnn.UseVisualStyleBackColor = true;
            this.GirişYapBtnn.Click += new System.EventHandler(this.GirişYapBtnn_Click);
            // 
            // PSWtextBox
            // 
            this.PSWtextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PSWtextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PSWtextBox.Location = new System.Drawing.Point(312, 148);
            this.PSWtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PSWtextBox.Name = "PSWtextBox";
            this.PSWtextBox.PasswordChar = '*';
            this.PSWtextBox.Size = new System.Drawing.Size(254, 50);
            this.PSWtextBox.TabIndex = 5;
            // 
            // IDtextbox
            // 
            this.IDtextbox.BackColor = System.Drawing.SystemColors.Window;
            this.IDtextbox.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IDtextbox.Location = new System.Drawing.Point(312, 94);
            this.IDtextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IDtextbox.Name = "IDtextbox";
            this.IDtextbox.Size = new System.Drawing.Size(254, 50);
            this.IDtextbox.TabIndex = 4;
            // 
            // sifre
            // 
            this.sifre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sifre.AutoSize = true;
            this.sifre.BackColor = System.Drawing.Color.Transparent;
            this.sifre.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sifre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sifre.Location = new System.Drawing.Point(110, 162);
            this.sifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(86, 48);
            this.sifre.TabIndex = 3;
            this.sifre.Text = "Şifre:";
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KullaniciAdi.AutoSize = true;
            this.KullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.KullaniciAdi.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciAdi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KullaniciAdi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KullaniciAdi.Location = new System.Drawing.Point(110, 96);
            this.KullaniciAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Size = new System.Drawing.Size(208, 48);
            this.KullaniciAdi.TabIndex = 2;
            this.KullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // GirişYap
            // 
            this.GirişYap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GirişYap.AutoSize = true;
            this.GirişYap.BackColor = System.Drawing.Color.Transparent;
            this.GirişYap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GirişYap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GirişYap.Location = new System.Drawing.Point(340, 37);
            this.GirişYap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GirişYap.Name = "GirişYap";
            this.GirişYap.Size = new System.Drawing.Size(237, 79);
            this.GirişYap.TabIndex = 0;
            this.GirişYap.Text = "Giriş Yap";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mistral", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(389, 239);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 61);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kayıt Ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 645);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Market Yönetim";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox PSWtextBox;
        private System.Windows.Forms.TextBox IDtextbox;
        private System.Windows.Forms.Label sifre;
        private System.Windows.Forms.Label KullaniciAdi;
        private System.Windows.Forms.Label GirişYap;
        private System.Windows.Forms.Button GirişYapBtnn;
        private System.Windows.Forms.Button button1;
    }
}