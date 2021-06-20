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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/search?q=dolar&source=lmns&bih=757&biw=753&hl=en-GB&sa=X&ved=2ahUKEwi_q7Su_aXxAhUCjqQKHVB3D_UQ_AUoAHoECAEQAA");
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser2.Navigate("https://www.google.com/search?q=euro&bih=781&biw=768&hl=en-GB&sxsrf=ALeKk00hZjRRKf9jNtDLOA6vJXkrOpwcSg%3A1624186137518&ei=GR3PYK2MH4OSkwWiloKIAg&oq=eu&gs_lcp=Cgdnd3Mtd2l6EAMYBTIECCMQJzIECCMQJzIECCMQJzIECAAQQzIHCAAQhwIQFDICCAAyAggAMgIIADICCAAyAggAMgIIADICCAAyAggAMgIIADICCAA6BwgjELADECc6BwgAEEcQsAM6BwgAELADEEM6BQgAEJECOgIILlCAg6QBWMGHpAFg7JqkAWgCcAJ4AIABfogB4wKSAQMwLjOYAQCgAQGqAQdnd3Mtd2l6yAEKwAEB&sclient=gws-wiz");
            webBrowser2.ScriptErrorsSuppressed = true;
            webBrowser3.Navigate("https://www.google.com/search?q=isvi%C3%A7re+frang%C4%B1&bih=781&biw=324&hl=en-GB&sxsrf=ALeKk006yVAAkvOdNVF4UPVZH_BA690eog%3A1624188828651&ei=nCfPYKyfJ4-Di-gPhMCHEA&oq=isvi%C3%A7re&gs_lcp=Cgdnd3Mtd2l6EAMYADIKCAAQywEQRhCCAjIFCAAQywEyBQguEMsBMgUIABDLATIFCAAQywEyBQgAEMsBMgUIABDLATIFCAAQywEyBQguEMsBMgUILhDLATIFCAAQywEyBQgAEMsBMgUILhDLATIFCAAQywEyBQgAEMsBOgcIIxCwAxAnOgcIABBHELADOgQIIxAnOgQIABBDOgIIADoICC4QxwEQowI6AgguOgQILhBDOggILhDHARCvAVC-rQ5YpcYOYLXODmgCcAJ4AIABpwGIAYgIkgEDMC44mAEAoAEBqgEHZ3dzLXdpesgBCsABAQ&sclient=gws-wiz");
            webBrowser3.ScriptErrorsSuppressed = true;
        }
        Urunler urunler = new Urunler();
        Urun urun = new Urun();
        Alici alici = new Alici();
        Urunlerr urunlerr = new Urunlerr();
        public int deger;
        public static double dolar1, euro1, frank1;
        private void StokBilgiBtn_Click(object sender, EventArgs e)
        {
            int i;
            i = urunlerr.Urunn.Length;
            StoklistBox1.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (int j = 0; j < i; j++)
            {
                StoklistBox1.Items.Add(urunlerr.Urunn[j] + "");
                listBox1.Items.Add(urunlerr.stok1[j] + "");
                listBox2.Items.Add(urunlerr.fiyat1[j] + "TL");
            }
            label3.Text = Convert.ToString(alici.para);
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            urunlerr.stokazalt(deger, alici, urunlerr);
        }

        private void StoklistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            deger = StoklistBox1.SelectedIndex;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            deger = listBox1.SelectedIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            deger = listBox2.SelectedIndex;
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
                    dolar1 = deger;
                }
            }
            urunler.aliciParaEkle();
            bool a = Urunler.durum4;
            if (a == true)
            {
                Calisanlar calisanlar = new Calisanlar();
                calisanlar.aparaEkle(alici);
                MessageBox.Show("İzin verildi");
            }
            else
            {
                MessageBox.Show("İzin Yok");
            }
            label3.Text = Convert.ToString(alici.para);
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
                    dolar1 =  deger;
                }
            }
            urunler.aliciParaEkle();
            bool a = Urunler.durum4;
            if (a == true)
            {
                Calisanlar calisanlar = new Calisanlar();
                calisanlar.aparaEkle(alici);
                MessageBox.Show("İzin verildi");
            }
            else
            {
                MessageBox.Show("İzin Yok");
            }
            label3.Text = Convert.ToString(alici.para);
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
                    dolar1 = deger;
                }
            }
            urunler.aliciParaEkle();
            bool a = Urunler.durum4;
            if (a == true)
            {
                Calisanlar calisanlar = new Calisanlar();
                calisanlar.aparaEkle(alici);
                MessageBox.Show("İzin verildi");
            }
            else
            {
                MessageBox.Show("İzin Yok");
            }
            label3.Text = Convert.ToString(alici.para);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int deger1; 
            int i;
            i = urunlerr.Urunn.Length;
            deger1 = Convert.ToInt32(textBox1.Text);
            StoklistBox1.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (int j = 0; j < i; j++)
            {
                if (deger1 >= urunlerr.fiyat1[j])
                {
                    StoklistBox1.Items.Add(urunlerr.Urunn[j] + "");
                    listBox1.Items.Add(urunlerr.stok1[j] + "");
                    listBox2.Items.Add(urunlerr.fiyat1[j] + "TL");
                }
                else
                {
                    j++;
                }
            }

        }
    }
}
