using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NESNEYE_YÖNELİMLİ_PROJE_ÖDEVİ
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Alici alici = new Alici();
        Satici satici = new Satici();
        public string durumm;
        private void panel1_Paint(object sender, PaintEventArgs e){}
        private void Form2_Load(object sender, EventArgs e){}
        private void GirişYapBtnn_Click(object sender, EventArgs e)
        {
            this.durumm = kayitol.durum.ToString();
            MessageBox.Show(durumm);
            if (IDtextbox.Text == alici.KullaniciAdi && PSWtextBox.Text == alici.Sifre && durumm == "1")
            {
                Form11 form55 = new Form11();
                form55.Show(); //form2 göster diyoruz
                this.Hide();// bu yani form1 gizle diyoruz  
            }
            else if (IDtextbox.Text == satici.KullaniciAdi && PSWtextBox.Text == satici.Sifre && durumm == "0")
            {
                Form13 form55 = new Form13();
                form55.Show(); //form2 göster diyoruz
                this.Hide();// bu yani form1 gizle diyoruz  
            }
            else if (IDtextbox.Text == "admin" && PSWtextBox.Text == "admin")
            {
                Anasayfa form55 = new Anasayfa();
                form55.Show(); //form2 göster diyoruz
                this.Hide();// bu yani form1 gizle diyoruz  
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı");
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            kayitol Kayitol = new kayitol();
            Kayitol.Show();
            this.Hide();
        }
    }
}
