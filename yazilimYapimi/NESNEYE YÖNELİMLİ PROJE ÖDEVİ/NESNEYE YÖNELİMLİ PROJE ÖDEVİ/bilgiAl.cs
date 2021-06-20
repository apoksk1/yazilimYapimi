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
    public partial class bilgiAl : Form
    {
        public bilgiAl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Document raporum = new iTextSharp.text.Document();
            PdfWriter.GetInstance(raporum, new FileStream("‪C:Rapor.Pdf", FileMode.Create));
            raporum.Add(new Paragraph());
        }
    }
}
