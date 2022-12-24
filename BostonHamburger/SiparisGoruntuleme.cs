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
    public partial class SiparisGoruntuleme : Form
    {
        public SiparisGoruntuleme()
        {
            InitializeComponent();
        }

        private void SiparisGoruntuleme_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satisAdedi = 0;

            foreach (Siparis siparis in SiparisYonetimi.onaylananSiparisler)
            {
                ciro += siparis.ToplamTutar;

                foreach (EkstraMalzeme ekstraMalzeme in siparis.EkstraMalzemeler)
                {
                    ekstraMalzemeGeliri += ekstraMalzeme.Fiyat;
                }
                satisAdedi += siparis.Adet;
                lstSiparis.Items.Add(siparis);
            }
            //lblCiro.Text = SiparisYonetimi.onaylananSiparisler.Sum(c=>c.ToplamTutar).ToString("C2");
            lblCiro.Text = ciro.ToString("C2");
            lblEkstraMalzemeFiyat.Text = ekstraMalzemeGeliri.ToString("C2");
            lblSatilanUrun.Text = lstSiparis.Items.Count.ToString();
            lblSiparisAdet.Text = satisAdedi.ToString();
        }
    }
}
