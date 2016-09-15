using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_otopark_otomasyonu
{
    class Arac
    {
        //constructor 
        public Arac()//Her Arac nesnesi tanımladığımda Giris değerini otomatikman atamış oluruz.
        {
            Giris = DateTime.Now;
        }
        public string Plaka { get; set; }
        public AracTip Tip { get; set; } //bir özellik içinde birden fazla değer tutacaksa onu sınıf(class) haline getirmemiz gerekir.
        public bool Kontak { get; set; }
        public bool Abone { get; set; }
        public DateTime Giris { get; set; } //Giris zamnı
        public DateTime Cikis { get; set; } //çıkış zamanı


        public int Sure  //aracın içeride kaldığı süre
        {
            get
            {
                /* Tam span iki süre arasındaki zaman farklını bulmamızı sağlar */ 
                TimeSpan fark = (Cikis - Giris);
                if (fark-TimeSpan.FromHours((int)fark.TotalHours)>TimeSpan.Zero ) //5 saat 10 dakikadan -5 saati çıkar 0 dan büyükse manasında misal.
                {
                    fark=fark.Add(TimeSpan.FromHours(1));// 1 saat ekle fazladan.
                }
                return (int)fark.TotalHours; //6 saat olur misal
            }
        }

        public decimal Ucret
        {
            get 
            {
                decimal toplam = Tip.Fiyat * (Sure - 1) + Tip.Fiyat * 2 ;
                if (Abone)//Abone true ise
                {
                    toplam *= 0.80m;  //yüzde 20 indirim yapıyoruz.
                }
                return toplam;
            }

        }


        public override string ToString()
        {
            string metinAbone = Abone ? "Abone" : "Abone Değil"; //ternary if //Abone true ise Abone olsun ,değilse Abone Değil olsun.
            string metinKontak = Kontak ? "Kontak Var" : "Kontak Yok";
            return string.Format("{0}-{1}-{2}-{3}", Plaka, Tip.Adi, metinAbone,metinKontak);
        }




    }


    class AracTip
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public override string ToString()
        {
            return Adi;
        }
    }

}
