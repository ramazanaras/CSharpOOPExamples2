using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_IEnumerable
{
    class Oyuncu
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int FormaNo { get; set; }
        public string Mevki { get; set; }
        public DateTime DogumTarihi { get; set; }

        public int Yas  //yaşı hesapladık
        {
            get
            {

                return DateTime.Now.Year - DogumTarihi.Year;

            }
        }




    }
}
