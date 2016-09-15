using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_pizzasiparis_otomasyonu
{
    class PizzaTur
    {
        public string  Adi { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return Adi;
        }
    }
}
