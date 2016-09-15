using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop7_static
{
    class Ogrenci
    {
        //ctor tab tab yazınca çıkar.
        public Ogrenci()//constructor
        {
            TanimliOgrenciSayisi++;  //sınıf oluşurken buda 1 artıcak.
        }
        public static int TanimliOgrenciSayisi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string OkulNo { get; set; }
        public string TCKN { get; set; }

        public override string ToString()
        {
            return Adi + " " + Soyadi;
        }

        public static void YoklamaAl()
        { 
          //static metotda static olmayan elemanlara ulaşamayız.  
          //Adi ,Soyadi'na ulaşamayız
            //TanimliOgrenciSayisina' ulaşılabilir.

            //metot içinden istance öğelere(adi,soyadi gibi) ulaşılamaz.sadece static elemanlara ulaşılabilir.çünkü bu metot çalıştığında hiç bir örneğe bağlı olarak çalışmayacaktır.

        }



    }
}
