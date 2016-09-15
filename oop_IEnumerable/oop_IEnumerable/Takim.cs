using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;//Color sınıfı bu kütüphanede yer alır.
using System.Collections;  //IEnumerable interface'nin gelmesi için bu kütüphaneyi ekledik.

namespace oop_IEnumerable
{
    class Takim : IEnumerable, IEnumerator//Takimin kendisi bir koleksiyon oldu 
    {
        //public Takim()//constructor 
        //{
        //    Oyuncular = new List<Oyuncu>();
        //}

        public string Adi{ get; set; }
        public DateTime KurulusYili { get; set; }
        public Color[] Renkler { get; set; }
        public string TeknikDirektor { get; set; }
        public string Sponsor { get; set; }
        public string Baskan { get; set; }

        private List<Oyuncu> oyuncular=new List<Oyuncu>();//burda newledik.Yada sadece aşağıdaki gibi property olarak alıp yukarıdaki constructordada new 'leyebilirdik.

        public List<Oyuncu> Oyuncular
        {
            get { return oyuncular; }
            set { oyuncular = value; }
        }


        public IEnumerator GetEnumerator()
        {
            return this;  //Takimin kendisi bir koleksiyon oldu
        }

        int sayac = -1;

        //sıradaki elemanı getirir.
        public object Current
        {
            get { return oyuncular[sayac]; }
        }
        //bir sonraki adımda listede eleman var mı diye bakar.varsa true dönderir.yoksa false dönderir.
        public bool MoveNext()
        {
            return sayac++< Oyuncular.Count;
        }

        public void Reset()
        {
            sayac = 0;
        }
    }
}
