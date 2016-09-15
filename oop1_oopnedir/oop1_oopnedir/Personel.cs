using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1_oopnedir
{
    //class Random 
    //{
    //    int Next() {return 0; }
    //    int Next(int max){};  //overloadı
    //     int Next(){int min,int max}{return 0};
    //}

  public  class Personel
    {
        /*
         Acces Modifiers(erişim belirleyici):Sınıfın içindeki elemanlara nerelerden erişileceğini belirleyen elemanlara Acces Modifiers denir 5 tanedir.
         * 
         * Private:özelliği sadece tanımlandığı sınıf içinden erişilebilir yapar.sınıf içinde access modifier yazılmadıysa private kabul edilir.
         * Protected->miras alınan sınıflardan erişilmeyi sağlar.
         * internal-->bulunduğu proje içindeki heryerde erişilebilmeyi sağlar.
         * protected internal-->hem miras alanlar hem de proje içindeki kullanılan yerlerde erişilebilir olur.
         * public:umumi demektir.her yerden erişilebilmeyi sağlar.hiçbir kısıtlama koymaz bütün izinleri açar.
         * 
         * 
         
         */


      /*
       * Constructor(yapıcı metot) -->Yapıcı metotdur Ramde nesneyi üreten metotdur.
       * 
       * Geriye dönüş tipi olmayan tek metotdur.
       * Tanımlanmazsa varsayılan olarak default constructor geçerlidir.(parametre almayan new Personel() metodu)
       * Tanımlanırsa DEfault iptal olur .tanımlı olan geçerlidir.
       * overload yapılabilir.
       * class oluşurken bizimde yapmak istediğimiz işlemler var ise onları yapmak için kullanabiliriz veya sınıfın tanımlanması sırasında parametre alarak tek satırda oluşmasını sağlayabiliriz.
       * 
       */

        //class içinde tanımlanan değişkenlere field (alan) denir.class ile üretilmiş her bir nesnenin özelliği olacaktır.

        //default erişimleri private'dir.
    // internal string Adi;//field
    // protected  string Soyadi;    //Form1den erişilmez çünkü Personel sınıfını miras almamış
    // protected internal  string SicilNo;
    //public   string TCKimlik;
    //   decimal Maas;
    //   DateTime İseGirisTarihi;


      public Personel()//constructor metot(çalışma anında belli işleri yaptırmak.instance alırken değer verebilmek genel amacı)
      {
          //class oluşurken(Personel prs=new Personel()) yapılması gereken işlemler yeralır

          //new 'lenmesi gereken şeyler için kullanılabilir ,başlangıçta değişkenlere değer atayabilmek için  gibi şeyler

          İseGirisTarihi = DateTime.Now;//bugünün tarihi
          Adi = "Noname"; //adını , soyadını,tckimlik no yu ,sicilno yu  girmeyi unutursa bunları atamak için
          Soyadi = "Anonymous";  
          TCKimlik = "Girilmedi";
          SicilNo = "Girilmedi";

      }
      public Personel(string adi,string soyadi) //constructor metot(overload hali)
      {
          İseGirisTarihi=DateTime.Now;
          Adi=adi;
          Soyadi = soyadi;
      }

      ~Personel()  //destructor-Son söz  (proje kapanınca çalışır.)
      {
          //mbox tab tab yapınca çıkar
          System.Windows.Forms.MessageBox.Show("Bayyy");
      
      }

       internal string Adi;
       internal string Soyadi;    
       internal  string SicilNo;
       public string TCKimlik;
      internal decimal Maas;
      internal  DateTime İseGirisTarihi;


      internal void IseAl() //void IseAl(Personel yenipersonel) bu şekilde parametre yollmayada gerek yok üstten bilgiler geliyor zaten
       {
       //veritabanına ekleme işlemi yapar.
       
       }


      internal decimal KidemTazminatiHesapla()
      {
           //hesaplama kodları bulunacaktır.
           return 0;
       }

      internal void Kov() 
       {

         decimal para = KidemTazminatiHesapla();
           //veritabanında işten çıkartma ile ilgili işlemler yapılacaktır.
       }

    }
}
