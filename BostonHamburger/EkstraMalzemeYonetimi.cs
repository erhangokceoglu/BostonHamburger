using BostonHamburger.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BostonHamburger
{
    public partial class EkstraMalzemeYonetimi : Form
    {
        public EkstraMalzemeYonetimi()
        {
            InitializeComponent();
        }

        private void btnEkstraMalzeme_Click(object sender, EventArgs e)
        {
            SiparisYonetimi.ekstralar.Add(new EkstraMalzeme { EkstraAdi = txtEkstra.Text.Trim(), Fiyat = nudEkstaFiyat.Value });
            MessageBox.Show("Ekstra malzeme eklenmiştir.");
        }
    }
}
