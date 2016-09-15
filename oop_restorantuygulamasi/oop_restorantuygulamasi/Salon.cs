using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_restorantuygulamasi
{
    /*Inheritance(Miras)
     * Sınıfın özelliklerini başka bir sınıfa aktararak kendi ailesinden(oğlu ) olmasını sağlaması işlemidir.
     */
  public  class Salon:Button//Butonun özelliklerini aktardık.
    {
        public Salon()
        {

        }
        //constructor
        public Salon(string adi,int masaSayisi,string masaOnek)//sınıf oluşurken(Salon s=new Salon()) yapılacak işlemler burada yer alır.
        {
            Adi = adi;
            OnEk = masaOnek;
            for (int i = 1; i <= masaSayisi; i++)
            {
                Masa m = new Masa();
                m.Kodu = string.Format("{0}{1}", masaOnek, i);
                this.Masalar.Add(m);//masaları ekledik salona. //this bu instance(Salon s=new Salon()'daki s demektir.)//her bir salona bir sürü masa ekledik.
            }

            //buton gibi davranması için butonda verdiğimiz özellikleri veriyoruz.
            this.Text = adi; //s.Text demek istedik yani
            this.Width = 100;
            this.Height = 100;
        }

        public string Adi { get; set; }
        public string OnEk { get; set; }
        private List<Masa> _Masalar = new List<Masa>();//Ctrl+R+E yaparak propertysini oluşturabiliriz

        public List<Masa> Masalar
        {
            get { return _Masalar; }
            set { _Masalar = value; }
        }

        private static List<Salon> _Salonlar = new List<Salon>();//static yaptık.çünkü global olarak bunu kullancaz.Veritabanı gibi birşey.içinde bir sürü salon olacak.

        public static List<Salon> Salonlar
        {
            get { return Salon._Salonlar; }
            set { Salon._Salonlar = value; }
        }

        //metot
        public ListViewItem ListOlustur() //ListViewItem tipinde değer döndüren metot
        {

            ListViewItem li = new ListViewItem();
            li.Text = Adi;//ilk kolon
            li.SubItems.Add(Masalar.Count.ToString()); //ikinci kolon
            li.SubItems.Add(OnEk); //üçüncü kolon

            return li;//burdada ListViewItem tipinde değer döndürdük.
        }

    }
}
