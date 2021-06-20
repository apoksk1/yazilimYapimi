using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace NESNEYE_YÖNELİMLİ_PROJE_ÖDEVİ
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void Form9_Load(object sender, EventArgs e){}
        private void CilisBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form5 = new Form2();
            form5.Show(); //form2 göster diyoruz
        }
    }
    public class Market
    {
        public string[] Subeler = new string[2];
        public string[] subeAdres = new string[2];
        public Market()
        {
            this.Subeler[0] = "A Subesi";
            this.Subeler[1] = "B Subesi";
            this.subeAdres[0] = "Gaziantep";
            this.subeAdres[1] = "Osmaniye";
        }
    }
    public class Calisanlar : Market
    {
        public Calisanlar()
        {
            this.yillikIzin = 14;
            this.gorev[0] = "Kasiyer";
            this.gorev[1] = "Mudur Yardımcısı";
            this.gorev[2] = "Mudur";
        }
        public string Soyad;
        public double para;
        public string durum;
        public string KullaniciAdi;
        public int yillikIzin;
        public string Sifre;
        public string Ad;
        public string Adres;
        public int TC;
        public DateTime baslamaTarihi;
        public string gorevyeri;
        public string[] gorev = new string[3];
        public void paraEkle(Calisanlar c)
        {
            c.para = c.para + Form11.dolar;
        }
        public void aparaEkle(Calisanlar c)
        {
            c.para = c.para + Form13.dolar1;
        }
    }
    public class Urun : Market
    {
        public string[] Urunn = new string[10];
        public int[] stok1 = new int[10];
        public double[] fiyat1 = new double[10];

        public int a = 0;
        public void SatisYap(int m,Satici u)
        {
            int c;
            a = a + 1;
            c = 4 + a;
            Urunn[c] = u.Urun[m];
            stok1[c] = Convert.ToInt32(u.Stok[m]);
            fiyat1[c] = Convert.ToInt32(u.Fiyat[m]);
        }
        public void stokazalt(int l, Calisanlar e, Urun urun) 
        {
            double sonuc = (e.para) - (urun.fiyat1[l]) - (urun.fiyat1[l])*1/100;
            if (sonuc > 0) 
            {
                string text;
                stok1[l] = stok1[l] - 1;
                e.para = sonuc;
                DateTime satis = DateTime.Now;
                text = "Satıs Tarihi " + satis + " Urun tipi " + Urunn[l] + " Fiyat " + fiyat1[l] + " Stok " + 1;
                SaveFileDialog file = new SaveFileDialog();
                file.Filter = "PDF DOSYALARI(*.pdf)|*.pdf";
                file.Title = "RAPOR";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    FileStream dosya = File.Open(file.FileName, FileMode.Create);
                    Document pdf = new Document();
                    PdfWriter.GetInstance(pdf,dosya);
                    pdf.Open();
                    pdf.AddAuthor("Ali");
                    pdf.AddCreator("Arda");
                    pdf.AddTitle("RAPOR");
                    pdf.AddSubject("Konu");
                    pdf.AddKeywords("c# pdf");
                    pdf.AddCreationDate();
                    Paragraph elements = new Paragraph(text);
                    pdf.Add(elements);
                    pdf.Close();
                }
               
            }
            else
            {
                MessageBox.Show("Lütfen Hesabınıza para ekleyiniz");
            }
        }
        public void SatinAL(int i, Urun u, int A)
        {
            u.stok1[i] = u.stok1[i] + A;
        }
        public void alımYap(int a, Calisanlar e, Urun urun)
        {
            e.para = Convert.ToInt32(e.para) - Convert.ToInt32(urun.fiyat1[a]);
        }
    }
    public class Alici : Calisanlar
    {
        public Alici()
        {
            this.para = 2000;
            this.KullaniciAdi = kayitol.Id.ToString();
            this.Sifre = kayitol.Pass.ToString();
        }
    }
    public class Satici : Calisanlar
    {
        public Satici()
        {
            this.para = 2000;
            this.KullaniciAdi = kayitol.Id.ToString();
            this.Sifre = kayitol.Pass.ToString();
            this.Ad = kayitol.isim.ToString();
        }
        public string[] Urun = { " ", " ", " ", " ", " " };
        public string[] Fiyat = { " ", " ", " ", " ", " " };
        public string[] Stok = { " ", " ", " ", " ", " " };
    }

    public class Urunlerr : Urun
    {
        public Urunlerr()
        {
            this.Urunn[0] = "Buğday";
            this.Urunn[1] = "Arpa";
            this.Urunn[2] = "Yulaf";
            this.Urunn[3] = "Petrol";
            this.Urunn[4] = "Pamuk";
            this.stok1[0] = 50;
            this.stok1[1] = 40;
            this.stok1[2] = 100;
            this.stok1[3] = 70;
            this.stok1[4] = 25;
            this.fiyat1[0] = 75;
            this.fiyat1[1] = 85;
            this.fiyat1[2] = 20;
            this.fiyat1[3] = 25;
            this.fiyat1[4] = 35;
        }
        public void indirimYap(int indirim, int i)
        {
            this.fiyat1[i] = (this.fiyat1[i] - (this.fiyat1[i] * indirim) / 100);
        }
    }

}