using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop8_abstract
{
   public abstract class Cari //abstract yaparsak bu sınıftan instance alınmaz.
    {
        public abstract string CariKodu { get; set; }//miras verilen sınıfta bunu zorunlu olarak override et.
        public string Unvan { get; set; }


        //abstract metotların gövdesi olmaz.
        public abstract string[] getBanks();  //string[] dizisi döndüren metot  //miras verilen sınıfta bunu zorunlu olarak override et.

        public decimal getKDV() 
        {

            return 0.18m; //m yazmazsak double kabul ediyor.bizde decimal olması için m yazdık.
        }


    }

   public class CariMusteri:Cari  //miras verdik.
   {

       private string cariKod;

       public override string CariKodu
       {
           get
           {
               return cariKod;
           }
           set
           {
               cariKod = value;
           }
       }

       public override string[] getBanks()
       {
           return new string[]{"isbankası","ziraat bankası"};
       }
   }

   public class CariTedarikci : Cari
   {

       string cariKodu;

       public override string CariKodu
       {
           get
           {
               return cariKodu;
                   
           }
           set
           {
               cariKodu = value;
           }
       }

       public override string[] getBanks()
       {
           return new string[] {"TEB","GARANTİ","ŞEKERBANK"};
       }
   }



}
