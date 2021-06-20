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
    public partial class kayitol : Form
    {
        Satici satici = new Satici();
        public kayitol()
        {
            InitializeComponent();
        }
        public static string Id = " ";
        public static string Pass = " ";
        public static string isim = " ";
        public static int durum = 25;

        private void kayitol_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            durum = UruncomboBox.SelectedIndex;
            Id = textBox3.Text;
            Pass = textBox4.Text;
            isim = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void UruncomboBox_SelectedIndexChanged(object sender, EventArgs e)
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
