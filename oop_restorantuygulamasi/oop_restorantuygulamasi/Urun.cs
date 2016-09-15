using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  //ListViewItem i kullanmak için yazdık.bu kütüphaneyi

namespace oop_restorantuygulamasi
{
    //Classta şunları tutabiliriz
    //değişken(field)
    //Method
    //event

    //Access Modifiers
    /*private:Sadece sınıf içinde erişilebilir.o classın dışında kimsee ulaşamaz bu değişkene 
     * protected:Miras alınan sınıflarda kullanılabilir.
     * internal:Proje içindekiler kullanabilir(namespace içindeki herkes kullanabilir.)
     * protected internal:Hem proje içi her yerde.Hem miras alana aktarılır anlamına gelir.
     * public:Her yerden erişilebilir.
     * 
     */
    //Constructor Method
    /*
     * Bir sınıftan instance alınırken(yani new komutu kullanılarak yeni bir değişken üretirken)çalışmasını istediğimiz komutları constructorda belirtebiliyoruz.Yani sınıf doğarken komut çalıştırmaktır.
     * Constructor;
     * Sınıf ile aynı isimde olmalıdır.
     * Geriye dönüş tipi olmayan bir methoddur.
     * Constructor default olarak tanımlıdır
     * Eğer constructor tanımlanırsa default iptal olur.
     * overload yapılabilir.
     * 
     * Polymorphism:metodun miras alınan sınıfta değiştirilmesini sağlar.
     * 
     * 
     * 
     */
  public  class Urun //classın varsayılanı internal.'dır.
    {
        //constructor(ctor tab tab yazınca çıkıyor)
        public Urun()
        {
           // Liste.Add(this);//this:üretilmiş olan instance'ı kasteder.(Urun u=new Urun()'daki u değeri)

        }
        //constructor
        public Urun(string adi,decimal fiyat)//overload ettik.
        {
            Adi = adi;
            Fiyat = fiyat;
            //Liste.Add(this);burdada ekliyebilirdik.yada UrunForm'daki  Urun.Liste.Add(u); şeklindede ekleyebiliriz.
        }

        public string Adi; //hiçbirşey yazmazsak default private'dır.
        public decimal Fiyat;

        //içinde Urun barındıran liste
        public static List<Urun> Liste = new List<Urun>();//static değişken  projenin heryerinden ulaşabileceğimiz bir değişkendir.Sınıfın adıyla çağrılır.Urun. şeklinde çağırabiliriz. Projenin en globalinde tanımlanan değişkendir.Direk Urun sınıfına bağlı olmuş oluyor.Yani bir nevi Ramde veritabanı yapmış gibi birşey oluyoruz.


        //metot
        public  ListViewItem ListOlustur() //ListViewItem tipinde bir değer döndürür
        {
            ListViewItem li = new ListViewItem();
            li.Text = Adi;
            li.SubItems.Add(Fiyat.ToString("C2"));//C2 demek sonuna TL eklemek demek.
            return li;  //ListViewItem tipinde bizde bir değer döndürdük.
        }

        public override string ToString()
        {
            return this.Adi;
        }
    }
}
