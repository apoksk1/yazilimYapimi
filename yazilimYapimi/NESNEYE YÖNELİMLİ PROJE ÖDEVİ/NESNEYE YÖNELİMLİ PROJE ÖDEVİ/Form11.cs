using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
namespace NESNEYE_YÖNELİMLİ_PROJE_ÖDEVİ
{

    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        Urunler urunler = new Urunler();
        Urunlerr urunlerr = new Urunlerr();
        Satici satici = new Satici();
        Calisanlar calisanlar = new Calisanlar();
        Urun urun = new Urun();

        public int sayac = 0;
        public int a = 0;
        public int deger2;
        public static double dolar,euro,frank;
        private void Form11_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/search?q=dolar&source=lmns&bih=757&biw=753&hl=en-GB&sa=X&ved=2ahUKEwi_q7Su_aXxAhUCjqQKHVB3D_UQ_AUoAHoECAEQAA");
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser2.Navigate("https://www.google.com/search?q=euro&bih=781&biw=768&hl=en-GB&sxsrf=ALeKk00hZjRRKf9jNtDLOA6vJXkrOpwcSg%3A1624186137518&ei=GR3PYK2MH4OSkwWiloKIAg&oq=eu&gs_lcp=Cgdnd3Mtd2l6EAMYBTIECCMQJzIECCMQJzIECCMQJzIECAAQQzIHCAAQhwIQFDICCAAyAggAMgIIADICCAAyAggAMgIIADICCAAyAggAMgIIADICCAA6BwgjELADECc6BwgAEEcQsAM6BwgAELADEEM6BQgAEJECOgIILlCAg6QBWMGHpAFg7JqkAWgCcAJ4AIABfogB4wKSAQMwLjOYAQCgAQGqAQdnd3Mtd2l6yAEKwAEB&sclient=gws-wiz");
            webBrowser2.ScriptErrorsSuppressed = true;
            webBrowser3.Navigate("https://www.google.com/search?q=isvi%C3%A7re+frang%C4%B1&bih=781&biw=324&hl=en-GB&sxsrf=ALeKk006yVAAkvOdNVF4UPVZH_BA690eog%3A1624188828651&ei=nCfPYKyfJ4-Di-gPhMCHEA&oq=isvi%C3%A7re&gs_lcp=Cgdnd3Mtd2l6EAMYADIKCAAQywEQRhCCAjIFCAAQywEyBQguEMsBMgUIABDLATIFCAAQywEyBQgAEMsBMgUIABDLATIFCAAQywEyBQguEMsBMgUILhDLATIFCAAQywEyBQgAEMsBMgUILhDLATIFCAAQywEyBQgAEMsBOgcIIxCwAxAnOgcIABBHELADOgQIIxAnOgQIABBDOgIIADoICC4QxwEQowI6AgguOgQILhBDOggILhDHARCvAVC-rQ5YpcYOYLXODmgCcAJ4AIABpwGIAYgIkgEDMC44mAEAoAEBqgEHZ3dzLXdpesgBCsABAQ&sclient=gws-wiz");
            webBrowser3.ScriptErrorsSuppressed = true;
        }
        private void StokBtn_Click(object sender, EventArgs e)
        {
            int i;
            i = urunlerr.Urunn.Length;
            KasiyerStoklistBox.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            for (int j = 0; j < i; j++)
            {
                KasiyerStoklistBox.Items.Add(urunlerr.Urunn[j] + "");
                listBox2.Items.Add(urunlerr.stok1[j]+"");
                listBox3.Items.Add(urunlerr.fiyat1[j]+"TL");
            }
            label3.Text = Convert.ToString(satici.para);
        } 
        private void SatisYapBtn_Click(object sender, EventArgs e)
        {
            bool a = Urunler.durum1;
            urunler.izinAl(satici.Ad, satici.Urun[deger2], satici.Stok[deger2]);
            if (a == true)
            {
                urunlerr.SatisYap(deger2,satici);
            }
            else
            {
                MessageBox.Show("İzin Verilmedi");
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sayac < 5)
            {
                satici.Urun[sayac] = textBox1.Text;
                satici.Stok[sayac] = textBox2.Text;
                satici.Fiyat[sayac] = textBox3.Text;
                listBox1.Items.Add(satici.Urun[sayac] + " " + satici.Stok[sayac] + " " + satici.Fiyat[sayac] + " TL");
                sayac = sayac + 1;
            }
            else
            {
                MessageBox.Show("Daha Fazla Ürün Ekleyemezsiniz");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           deger2 = listBox1.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            urunlerr.stokazalt(deger2,satici,urunlerr);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string kur1;
            
            HtmlElementCollection htmlElementCollection = webBrowser1.Document.All;
            foreach (HtmlElement name in htmlElementCollection)
            {
                if (name.GetAttribute("className") == "DFlfde SwHCTb")
                {
                    kur1 = name.InnerText;
                    double deger = Convert.ToDouble(kur1);
                    dolar =  deger;
                    
                }
            }
            bool a = Urunler.durum;
            urunler.paraaEkle();
            if(a == true) 
            {
                calisanlar.paraEkle(satici);
                MessageBox.Show("İzin verildi");
            }
            else
            {
                MessageBox.Show("İzin Yok");
            }
            label3.Text = Convert.ToString(satici.para);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            deger2 = listBox3.SelectedIndex;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string kur1;

            HtmlElementCollection htmlElementCollection = webBrowser2.Document.All;
            foreach (HtmlElement name in htmlElementCollection)
            {
                if (name.GetAttribute("className") == "DFlfde SwHCTb")
                {
                    kur1 = name.InnerText;
                    double deger = Convert.ToDouble(kur1);
                    dolar = deger;

                }
            }
            bool a = Urunler.durum;
            urunler.paraaEkle();
            if (a == true)
            {
                calisanlar.paraEkle(satici);
                MessageBox.Show("İzin verildi");
            }
            else
            {
                MessageBox.Show("İzin Yok");
            }
            label3.Text = Convert.ToString(satici.para);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string kur1;

            HtmlElementCollection htmlElementCollection = webBrowser3.Document.All;
            foreach (HtmlElement name in htmlElementCollection)
            {
                if (name.GetAttribute("className") == "DFlfde SwHCTb")
                {
                    kur1 = name.InnerText;
                    double deger = Convert.ToDouble(kur1);
                    dolar = deger;

                }
            }
            bool a = Urunler.durum;
            urunler.paraaEkle();
            if (a == true)
            {
                calisanlar.paraEkle(satici);
                MessageBox.Show("İzin verildi");
            }
            else
            {
                MessageBox.Show("İzin Yok");
            }
            label3.Text = Convert.ToString(satici.para);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            deger2 = listBox2.SelectedIndex;
        }

        private void KasiyerStoklistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deger2 = KasiyerStoklistBox.SelectedIndex;
        }

        
    }
}
