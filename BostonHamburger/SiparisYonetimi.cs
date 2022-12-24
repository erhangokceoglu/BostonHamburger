using BostonHamburger.Enumlar;
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
    public partial class SiparisYonetimi : Form
    {
        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> onaylananSiparisler = new List<Siparis>();

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu{MenuAdi="Big King", Fiyat=78.25M},
            new Menu{MenuAdi="Double King Chicken", Fiyat=69.75M},
            new Menu{MenuAdi="Steakhouse", Fiyat=72.50M},
            new Menu{MenuAdi="Whooper", Fiyat=70.00M},
            new Menu{MenuAdi="Whooper Jr.", Fiyat=67.75M},
            new Menu{MenuAdi="Chicken Royal", Fiyat=71.25M}
        };

        public static List<EkstraMalzeme> ekstralar = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme{EkstraAdi="Ketçap", Fiyat=2.50M},
            new EkstraMalzeme{EkstraAdi="Mayonez", Fiyat=2.50M},
            new EkstraMalzeme{EkstraAdi="Hardal", Fiyat=2.75M},
            new EkstraMalzeme{EkstraAdi="BBQ", Fiyat=3.00M},
            new EkstraMalzeme{EkstraAdi="Ranch", Fiyat=2.00M},
            new EkstraMalzeme{EkstraAdi="Buffalo", Fiyat=2.25M}
        };
        public SiparisYonetimi()
        {
            InitializeComponent();
            if (tumSiparisler.Count > 0)
            {
                foreach (var item in tumSiparisler)
                {
                    listBoxMenu.Items.Add(item);    
                }
                TutarHesapla();
            }
        }

        private void SiparisYonetimi_Load(object sender, EventArgs e)
        {
            int x = 10;
            int y = 16;
            foreach (var item in menuler)
                cmbMenu.Items.Add(item);
            cmbMenu.SelectedIndex = 0;
            foreach (var item in ekstralar)
            {
                CheckBox a = new CheckBox();
                a.Tag = item;
                a.Text = item.EkstraAdi;
                a.Location = new Point(x, y);
                panelMalzeme.Controls.Add(a);
                y += 22;
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            List<EkstraMalzeme> secilenEkstraMalzemeler = new List<EkstraMalzeme>();
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.Menu = (Menu)cmbMenu.SelectedItem;
            if (rdbuttonKucuk.Checked)
                yeniSiparis.Boyut = Boyut.Kucuk;
            else if (rdbuttonOrta.Checked)
                yeniSiparis.Boyut = Boyut.Orta;
            else
                yeniSiparis.Boyut = Boyut.Buyuk;
            foreach (CheckBox item in panelMalzeme.Controls)
            {
                if (item.Checked)
                    secilenEkstraMalzemeler.Add((EkstraMalzeme)item.Tag);
            }
            yeniSiparis.EkstraMalzemeler = secilenEkstraMalzemeler;
            yeniSiparis.Adet = (int)numericUpDownAdet.Value;

            yeniSiparis.Hesapla();
            tumSiparisler.Add(yeniSiparis);
            // mevcutSiparisler.Add(yeniSiparis);

            listBoxMenu.Items.Add(yeniSiparis);
            TutarHesapla();
        }
        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < listBoxMenu.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)listBoxMenu.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString("C2");
            return toplamTutar;
        }

        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {
            //mevcut siparişleri temzileyecek.
            //listboxu temizleyecek
            //Tutar sıfırlanacak
            DialogResult dialogResult = MessageBox.Show("Toplam Sipariş Tutarı: " + TutarHesapla() + "\nSatın almayı tamamlamak istiyormusunuz?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < listBoxMenu.Items.Count; i++)
                {
                    Siparis gelenSiparis = (Siparis)listBoxMenu.Items[i];
                    onaylananSiparisler.Add(gelenSiparis);
                }
                listBoxMenu.Items.Clear();
                //mevcutSiparisler.Clear();
                TutarHesapla();
                MessageBox.Show("Siparişiniz Tamamlanmıştır. Afiyet Olsun :)");
            }
            else
                MessageBox.Show("İptal Edildi.");



        }
    }
}
