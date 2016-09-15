using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_pizzasiparis_otomasyonu
{
    class Pizza
    {
        //constructor 
        public Pizza()//sınıf oluşurken çalışır.
        {
            Malzemeler = new List<PizzaMalzeme>();//new'leme yaptık.yoksa hata verir.
        }

        public PizzaEbat Ebat { get; set; } //Ebat bilgisinin birden fazla özelliği(alt bilgisi) olduğu için sınıf olarak tasarladık.diğerleri içinde öyle yaptık.
        public PizzaTur Tur { get; set; }
        public KenarTur Kenar { get; set; }
        public List<PizzaMalzeme> Malzemeler { get; set; }
        public decimal Fiyat
        {
            get
            {
                decimal fiyat = 0;
                fiyat += Tur.Fiyat;
                fiyat *= Ebat.Carpan;
                fiyat += Kenar.EkFiyat;
                foreach (PizzaMalzeme item in Malzemeler)
                {
                    fiyat += item.EkFiyat;
                }
                return fiyat;
            }
        }

        public override string ToString()
        {
            string malzemeler = "";//eklenen malzemelerin ismini bir string içinde topladık.
            foreach (PizzaMalzeme item in Malzemeler)
            {
                malzemeler += item.Adi + "-";
            }
            return string.Format("{0},{1},{2},{3}",Ebat.Adi,Tur.Adi,Kenar.Adi,malzemeler);

        }



    }
}
