using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes
{
  partial  class Ogrenci   //sınıfın fiziksel olarak başka yerlerde bulunabilmesini sağlıyor.parça parça .(partial )
    {
        public string Adi { get; set; }

        public bool ImzaAt()
        {
            return true;
        }


    }
}
