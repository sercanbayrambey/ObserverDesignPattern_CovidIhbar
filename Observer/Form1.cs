using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form1 : Form
    {
        Ihbarlar ihbarlar;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ihbarlar = new Ihbarlar();
            ihbarlar.YeniYerelYetkiliEkle(new KarakolaBildirObserver());
            ihbarlar.YeniYerelYetkiliEkle(new BelediyeyeBildirObserver());
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ihbar ihbar = new Ihbar();
            ihbar.Sehir = tboxSehir.Text;
            ihbar.Ilce = tboxIlce.Text;
            ihbar.AcikAdres = tboxAcikAdres.Text;
            ihbar.IhbarAciklama = tboxAciklama.Text;
            ihbarlar.IhbarList.Add(ihbar);
        }
    }
}
