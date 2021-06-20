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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        private void UrunlerBtn_Click(object sender, EventArgs e)
        {
            Urunler form5 = new Urunler();
            form5.Show(); //form2 göster diyoruz
            this.Hide();// bu yani form1 gizle diyoruz
        }
        private void CalisanlarBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
