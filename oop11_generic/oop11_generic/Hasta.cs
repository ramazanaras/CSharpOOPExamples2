using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop11_generic
{
    class Hasta<Temsili,IlacTip>  where IlacTip:Ilac
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TCKN { get; set; }

        public Temsili HastaOzellikleri { get; set; }
        public List<IlacTip> Ilaclar { get; set; }
        //public T2 Raporlar { get; set; }
        //public T3 Tahliller { get; set; }
    }
     
    class Ilac
    {
        public string Adi { get; set; }
        public string Marka { get; set; }
        
    }

    class AgriKesici : Ilac
    {
        public int Mg { get; set; }
    
    }

    class GribalEnfeksiyon<Tip>
    {
        public string Adi { get; set; }
        public string Tur { get; set; }
        public float LD { get; set; }  //LetalDoz(bu hastalığa yakalananların ölüm oranı)
        public Tip Antidot { get; set; }
        


    }

}
