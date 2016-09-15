using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5_polymorhism
{
    class Ogrenci:Insan
    {
        public decimal Vize { get; set; }
        public decimal Final { get; set; }

        //ToString() metodu polymorphisme güzel bir örnektir.
        //override boşluk yazınca metot çıkar.
        public override string ToString()
        {
            return Adi + " " + Soyadi;
        }

        public override void YogurtYe()
        {
            //Düzgün ye hızlı ye.
        }


    }
}
