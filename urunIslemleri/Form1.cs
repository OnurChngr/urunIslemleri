using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urunIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        urun u = new urun();

        private void button1_Click(object sender, EventArgs e)
        {
            u.urunNo = txtUrunNo.Text;
            u.urunCesit = txtCesit.Text;
            u.kategori = txtKategori.Text;
            u.fiyat =int.Parse( txtFiyat.Text);
            u.stok = int.Parse(txtstok.Text);
            lstUrun.Items.Add(u.urunNo+" "+u.urunCesit+" "+u.kategori+" "+u.fiyat+" "+u.stok);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            u.bakiye();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblBakiye.Text = ("Bakiye Miktarınız"+u.para.ToString());
            //class eklendi
        }
    }
}
