using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3_kapsulleme
{
    public class Ogrenci
    {
        //private string adi;
        //public void setAdi(string value)
        //{
        //    if (value=="Alper")
        //    {
        //        throw new Exception("Alper kabul edilemez"); 
        //    }
        //    adi = value;
        //}
        //public string getAdi()
        //{
        //    return adi;
        //}
        //eskiden yukarıdaki gibi yapılırdı.(javada hala bu şekilde yapılıyor.)


        /////////////////////////////////////////////////////////////////////////////////////////


        //NOT:propfull tab tab yazınca otomatik çıkıyor.

        private string adi;//değer sadece field da tutulur.

        public string Adi
        {
            get
            {
                return adi;
            }

            set
            {
                if (value == "Alper")
                {
                    throw new Exception("Alper eğeri kabul edilebilir bir değer değildi.");

                }

                adi = value;  //Alper değilse değeri ata.


            }//dışardan gönderilen değer value ile gelir.
        }

        //---------------------
        private DateTime dogumtarihi;

        public DateTime DogumTarihi
        {
            get
            {
                return dogumtarihi;
            }
            set
            {
                if (value <= DateTime.Now) //datetimepickerdan seçeceğimiz tarih şu anki tarihten küçükse atama yap değilse bugünün tarihini ata.
                {
                    dogumtarihi = value;
                }
                else//bugünün tarihinden büyük bir değer seçilirse bugünün tarihini al deriz.
                {
                    dogumtarihi = DateTime.Now;
                }
            }
        }

        //aynı metot gibi  
        public int Yas //sadece okubabilir(get) yaptık .set yapmadık.
        {
            get
            {
                //timespan zamansal büyüklük
                return (int)((DateTime.Now - DogumTarihi).TotalDays
                    / 365);

            }
        }

        //---------------------
        double vize; //NOT:Ctrl+R+E yapınca bu fieldın propertysini oluşturur.

        public double Vize
        {
            get
            {
                return vize;
            }
            set
            {
                if (value >= 0 && value <= 100)//böyleyse değeri ata.yoksa atama.(yani 0 ata)
                {
                    vize = value;
                }

            }
        }

        double final;

        public double Final
        {
            get
            {
                return final;
            }
            set
            {
                if (value >= 0 && value <= 100)//böyleyse değeri ata.yoksa atama.(yani 0 ata)
                {
                    final = value;
                }

            }
        }

        public double Ortalama 
        {
            get 
            {
                return Vize * 0.4 + Final * 0.6;
            
            }
        } 



        //------------------
        //NOT:prop  tab tab yapınca otomatik oluşturuyor.
        public int Soyadi { get; set; }//auto property
    /*
     Auto property --> fieldı içinde olan propertydir.Faydası tekrar field oluşturmayız böylelikle field kalabalığı oluşmamış olur.property fieldını kendi içinde oluşturur.(backing field )
     * auto property içerisindeki get ve set komutlarının içinde komut olamaz .olursa auto property bozulur.get veya set silinemez silinirse auto property bozulur
     */

        //gizleme işlemleri
        public string GozRengi {private get;  set; }
        public string TCKN { get; private set; }
    }
}
