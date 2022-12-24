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
    public partial class MenuYonetimi : Form
    {
        public MenuYonetimi()
        {
            InitializeComponent();
        }

        private void btnMenuKaydet_Click(object sender, EventArgs e)
        {
            SiparisYonetimi.menuler.Add(new Menu { MenuAdi = txtMenu.Text, Fiyat = nudFiyat.Value });

            MessageBox.Show("Menü eklenmiştir.");
        }
    }
}
