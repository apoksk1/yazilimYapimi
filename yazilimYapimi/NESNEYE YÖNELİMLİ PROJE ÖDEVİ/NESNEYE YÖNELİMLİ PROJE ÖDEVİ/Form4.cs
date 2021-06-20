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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        Calisanlar calisanlar = new Calisanlar();
        Satici satici = new Satici();
        Alici alici = new Alici();
        public int deger = 0;

        public static string urrun;
        public static string sttok;
        public static string fiyyat,isimm;
        public static bool durum = false;
        public static bool durum1 = false;
        public static bool durum2 = false;
        public static bool durum3 = false;
        public static bool durum4 = false;
        private void GeriBtn_Click(object sender, EventArgs e)
        {
            Anasayfa form5 = new Anasayfa();
            form5.Show(); //form2 göster diyoruz
            this.Hide();// bu yani form1 gizle diyoruz
        }

        private void Gidalabel_Click(object sender, EventArgs e)
        {

        }
        public void izinAl(string isim, string urunAdi, string stttok)
        {
            isimm = isim;
            urrun = urunAdi;
            sttok = stttok;
            //listBox3.Items.Add(fiyat + "eklemek istiyor");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(isimm + " ");
            listBox2.Items.Add(urrun + " den " + sttok + " kg/adet eklemek istiyor");
            if (durum2 == true)
            {
                listBox3.Items.Add("Hesabına 100 tl eklemek istiyor");
            }
        }
        public void paraaEkle()
        {
            durum2 = true;
        }
        public void aliciParaEkle()
        {
            durum3 = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (durum3 == true)
            {
                listBox4.Items.Add(isimm + " ");
                listBox5.Items.Add("Hesabına 100 tl eklemek istiyor");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (durum3 == true)
            {
                durum4 = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            durum4 = false;
        }

        private void StokBilgiBtn_Click(object sender, EventArgs e)
        {
            durum = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            durum1 = true;
            if(durum2 == true)
            {
                durum = true;
            }
        }
    }
}
