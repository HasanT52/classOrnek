using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_hesap_Click(object sender, EventArgs e)
        {
            int yukseklik = Convert.ToInt32(textYuksek.Text);
            int taban = Convert.ToInt32(textTaban.Text);

            ucgen ucgen = new ucgen();
            ucgen.Yukseklik = yukseklik;
            ucgen.Taban = taban;
         

            int sonuc = ucgen.alanHesapla();            

            MessageBox.Show(sonuc.ToString());
        }
    }
}
