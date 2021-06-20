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
    class Market
    {
        public string[] Subeler = new string[2];
        public string[] subeAdres = new string[2];
        public string girisTuru;
        public Market()
        {
            this.Subeler[0] = "A Subesi";
            this.Subeler[1] = "B Subesi";
            this.subeAdres[0] = "Gaziantep";
            this.subeAdres[1] = "Osmaniye";
        }
    }
    class Calisanlar : Market
    {
        public int[] yillikIzin = new int[3];
        public int[] haftalikizin = new int[3];
        public string[] ID = new string[4];
        public string[] Password = new string[4];
        public string[] gorevv=new string[3];
        public string[] AdSoyad = new string[3];
        public string[] Adres = new string[3];
        public int[] maas = new int[3];
        public DateTime baslamaTarihi;
        public string[] gorev = new string[4];
        public string[] gorevyeri = new string[3];
        public Calisanlar()
        {
            this.yillikIzin[0] = 14;
            this.yillikIzin[1] = 14;
            this.yillikIzin[2] = 14;
            this.haftalikizin[0] = 52;
            this.haftalikizin[1] = 52;
            this.haftalikizin[2] = 52;
            this.gorev[0] = "Kasiyer";
            this.gorev[2] = "Mudur";
            this.gorev[1] = "Mudur Yardimcisi";
            this.gorev[3] = "Admin";
            for (int i = 0; i < gorev.Length; i++)
            {
                this.ID[i] = this.gorev[i];
                this.Password[i] = this.gorev[i];
            }
            this.AdSoyad[0] = "Ali PANPALLI";
            this.Adres[0] = "ORGANİZE SANAYİ BÖLGESİ 1 NOLU CD NO 27 GAZİANTEP";
            this.maas[0] = 3000;
            this.baslamaTarihi = DateTime.Now;
            this.gorevv[0] = this.gorev[0];
            this.gorevyeri[0] = this.Subeler[0];
            this.AdSoyad[1] = "Arda ASKIN";
            this.Adres[1] = "ZİYAPAŞA BLV ÖZGİ A NO 10 K 3 D 9 ADANA 1130";
            this.maas[1] = 5000;
            this.baslamaTarihi = DateTime.Now;
            this.gorevv[1] = this.gorev[1];
            this.gorevyeri[1] = this.Subeler[1];
            this.AdSoyad[2] = "Abdulkadir CULHA";
            this.Adres[2] = "C.YURDAKUL C 282.SN 311";
            this.maas[2] = 4500;
            this.baslamaTarihi = DateTime.Now;
            this.gorevv[2] = this.gorev[2];
            this.gorevyeri[2] = this.Subeler[1];
            this.girisTuru = " ";
        }
        public void giristuru(string i)
        {
            for(int j = 0; j < this.ID.Length; j++)
            {
                if (this.gorev[j] == i)
                {    
                        this.girisTuru = this.gorev[j];
                        MessageBox.Show(girisTuru.ToString());
                }
            }
        }
        public void zamYap(int zamMiktari, int index)
        {     
                this.maas[index] = (this.maas[index] + (this.maas[index] * zamMiktari) / 100);
                MessageBox.Show(girisTuru);    
        }
        public void terfiVer(int yeniGorev, int index)
        {   
                if (yeniGorev + index == 1)
                {
                    this.gorevv[index] = this.gorev[1];
                }
                else if (yeniGorev + index == 2)
                {
                    this.gorevv[index] = this.gorev[2];
                }
                else
                {
                    MessageBox.Show("En Yüksek Terfide Yükseltme Yapılamaz!!");
                }
        }
        public void subeDegistir(int yeniGorevYeri, int index)
        {          
                this.gorevyeri[index] = this.Subeler[yeniGorevYeri];
        }
        public void HaftalikIzinVer(int i)
        {
            this.haftalikizin[i] = this.haftalikizin[i] - 1;
        }
        public void YillikIzinVer(int i)
        {
            this.yillikIzin[i] = this.yillikIzin[i] - 1;
        }
        } 
    class Urun : Market
    {
        public string[] TemizlikUrun = new string[2];
        public string Adress;
        public string[] GidaUrun = new string[2];
        public string[] KampanyaUrun = new string[2];
        public int[] stok1 = new int[2];
        public int[] fiyat1 = new int[2];
        public Urun()
        {   
            this.TemizlikUrun[0] = "AUrunu";
            this.TemizlikUrun[1] = "BUrunu";
            this.GidaUrun[0] = "CUrunu";
            this.GidaUrun[1] = "DUrunu";
            this.KampanyaUrun[0] = "EUrunu";
            this.KampanyaUrun[1] = "FUrunu";
        }
    }
    class Temizlik : Urun
    {
        public Temizlik()
        {
            this.stok1[0] = 50;
            this.stok1[1] = 40;
            this.fiyat1[0] = 20;
            this.fiyat1[1] = 10;
            this.Adress = "Bursa";
        }
        public void indirimYap(int indirim, int i)
        {       
                this.fiyat1[i] = (this.fiyat1[i] - (this.fiyat1[i] * indirim) / 100);                 
        }
    }
    class Gida : Urun
    {
        public Gida()
        {
            this.stok1[0] = 50;
            this.stok1[1] = 40;
            this.fiyat1[0] = 20;
            this.fiyat1[1] = 10;
            this.Adress = "İzmir";
        }
        public void indirimYap(int indirim, int i)
        {            
                this.fiyat1[i] = (this.fiyat1[i] - (this.fiyat1[i] * indirim) / 100);     
        }
    }
    class Kampanya : Urun
    {
        public Kampanya()
        {
            this.stok1[0] = 50;
            this.stok1[1] = 40;
            this.fiyat1[0] = 20;
            this.fiyat1[1] = 10;
            this.Adress = "Manisa";
        }
        public void indirimYap(int indirim, int i)
        {          
                this.fiyat1[i] = (this.fiyat1[i] - (this.fiyat1[i] * indirim) / 100); 
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form5 = new Form2();
            form5.Show(); //form2 göster diyoruz
            this.Hide();// bu yani form1 gizle diyoruz   
        }
    }
}
