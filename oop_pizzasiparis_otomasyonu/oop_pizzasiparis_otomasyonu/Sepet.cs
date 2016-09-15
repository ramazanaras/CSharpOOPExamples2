using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_pizzasiparis_otomasyonu
{
    class Sepet
    {
        public Sepet()//constructor
        {
            Siparisler = new List<Siparis>(); //new 'leme yaptık.yoksa hata verirdi.
        }

        public List<Siparis> Siparisler { get; set; }
        public decimal ToplamFiyat
        {
            get
            {
                decimal total = 0;
                foreach (Siparis item in Siparisler)
                {
                    total += item.Fiyat;
                    
                }
                return total;
            }
        }
        public decimal ToplamSiparisAdeti
        {
            get
            {
                decimal adet = Siparisler.Count();
                return adet;
            }
        }


    }
}
