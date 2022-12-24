using BostonHamburger.Enumlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonHamburger.Siniflar
{
    public class Siparis
    {
        public Boyut Boyut { get; set; }

        public int Adet { get; set; }

        public decimal ToplamTutar { get; set; }

        public List<EkstraMalzeme> EkstraMalzemeler { get; set; }

        public Menu Menu { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += Menu.Fiyat;
            if (Boyut == Boyut.Orta)
                ToplamTutar += ToplamTutar * 0.10m;
            else if (Boyut == Boyut.Buyuk)
                ToplamTutar += ToplamTutar * 0.25m;
            foreach (var malzeme in EkstraMalzemeler)
            {
                ToplamTutar += malzeme.Fiyat;
            }
            //ToplamTutar += EkstraMalzemeler.Sum(e => e.Fiyat); //Linqu Çözümü
            ToplamTutar *= Adet;
        }
        public override string ToString()
        {
            string ekstralar = "Ekstralar" + Environment.NewLine; 

            if (EkstraMalzemeler.Count() == 0) //Ekstra Malzeme Yoksa
            return  "Menü Adi: " + Menu.MenuAdi + Environment.NewLine +
                    "Adedi: " + Adet + Environment.NewLine +
                    "Boyutu: " + Boyut + Environment.NewLine +
                    "Toplam Tutar: " + ToplamTutar;
            
            foreach (var item in EkstraMalzemeler)
                ekstralar += item.EkstraAdi + Environment.NewLine;

            return "Menü Adi: " + Menu.MenuAdi + Environment.NewLine +
                   "Adedi: " + Adet + Environment.NewLine +
                   "Boyutu: " + Boyut + Environment.NewLine +
                   ekstralar + "Toplam Tutar: " + ToplamTutar;
        }
    }
}
