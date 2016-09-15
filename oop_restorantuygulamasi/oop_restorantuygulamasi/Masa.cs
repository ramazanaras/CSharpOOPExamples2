using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_restorantuygulamasi
{
    /*Encapsulation
     * 
     * Property:değişkenlere değer alıp atmak için komut çalıştıran ancak değişken gibi davranan bir yapıdır.
     * 
     * 
     */
  public  class Masa:Button
    {
        public Masa()
        {
            //buton gibi özelliklerini veriyoruz.
            this.Width = 70;
            this.Height = 70;
           // this.Text = Kodu;//dersek hatalı olur.çünkü constructor new'lendiğinde çalışıyordu .ama biz daha Kodu değişkenine bir şey atamadık.onun yerine m.Kodu'na değer atarken (set anında)this.Text'ede değeri ata diyoruz.aşağıda var zaten.
        }
        private string _Kodu;

        public string Kodu
        {
            get { return _Kodu; }
            set { _Kodu =this.Text= value; }//set edilirken masanın Textinide değeri atadı.(this.Text demek m.Text demektir.)
        }

        //field Değeri tutar
        private string _MusteriAdi;//Ctrl+R+E yapınca aşağıda property kısmını otomatik getiriyor.

        public string MusteriAdi//property:değere erişir
        {
            get { return _MusteriAdi; }
            set
            {
                if (value.Length < 3)
                {
                    throw new Exception("İsim 3 harften küçük olamaz");//hata fırlat.//Buraya Messagebox.show("İsim 3 harften küçük olamaz ") yazamayız.
                }
                _MusteriAdi = value;//3 ten küçük değilse değeri ata.
            }
        }

        private string _MusteriTelefon;

        public string MusteriTelefon
        {
            get { return _MusteriTelefon; }
            set
            {
                if (value.Length<7 && value.Length>0)
                {
                    throw new Exception("Gardaşım belamısın böyle telefon numarası mı olur.Yareppim ya!!");
                }
                _MusteriTelefon = value;
            }
        }

        public bool Rezerve = false;
        public bool Dolu = false;

        private List<Urun> _Urunler = new List<Urun>();//new'lememiz gerekiyor yoksa hata verir.yukarıda constuctor ın içindede new'leyebilirdik.

        public List<Urun> Urunler
        {
            get { return _Urunler; }
            set { _Urunler = value; }
        }

        //public decimal TutarGetir()//Her masanın kendi fiyatını hesaplayabildik.
        //{

        //    decimal s = 0;
        //    foreach (Urun u in Urunler)
        //    {
        //        s += u.Fiyat;
        //    }
        //    return s;
        //}
        //yukarıdaki gibi yapmak yerine aşağıdaki gibi property şeklinde yaptık.
        public decimal Tutar//Her masanın kendi fiyatını hesaplayabildik.
        {
            get
            {
                decimal s = 0;
                foreach (Urun u in Urunler)
                {
                    s += u.Fiyat;
                }
                return s;
            }
        }
    }
}
