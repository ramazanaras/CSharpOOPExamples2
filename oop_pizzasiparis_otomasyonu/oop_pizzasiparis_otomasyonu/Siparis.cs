using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_pizzasiparis_otomasyonu
{
    class Siparis
    {
        public Pizza Pizza { get; set; }   //Pizza tipinde 
        public int Adet { get; set; }
        public decimal Fiyat
        {
            get
            {
                return Pizza.Fiyat * Adet;

            }

        }



        public override string ToString()
        {
            return Pizza.ToString() + " Adet :" + Adet + "Fiyat :" + Fiyat;
        }
    }
}
