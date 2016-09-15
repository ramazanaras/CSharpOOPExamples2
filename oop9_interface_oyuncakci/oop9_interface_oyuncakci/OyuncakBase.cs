using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop9_interface_oyuncakci
{
    enum OyuncakTur
    {
    Pelus,
    Tabanca,
    Araba,
    Ucak,
    Tren,
    Barbie,
    Gemi
    }

    struct OyuncakEbat
    {
        public float Yukseklik { get; set; }
        public float Genislik { get; set; }
        public float Derinlik { get; set; }
    
    }

    class OyuncakBase
    {
        public string Kodu { get; set; }
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public string Barkod { get; set; }
        public OyuncakTur Tur { get; set; }
        public OyuncakEbat Boyut { get; set; }
        public float Agirlik { get; set; }

    }
}
