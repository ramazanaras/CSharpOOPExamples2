using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6_struct_enum
{
    class Ogrenci
    {
        public Ogrenci()
        {
            Dersler = new List<Ders>();//new'ledik.yoksa Form1'de hata verirdi.
        }

        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public List<Ders> Dersler { get; set; } //referans tipli(turquaz renkli) bir elemandır.new'lemek gerekir(generic list) yukarıda constructor metotundada new'ledik.
        public Alan Alani { get; set; } //Alan tipinde (enum)
        
        public decimal Ortalama //öğrencinin genel ortalaması
        {
            get
            {
                decimal toplam = 0;
                foreach (Ders not in Dersler)
                {
                    toplam += not.Ortalama;
                }
                return toplam / Dersler.Count();
            }
        }

        public OgrenciDurum Durum  //OgrenciDurum tipinde (enum)
        {
            get
            {
                if (Ortalama>=70)
                {
                    return OgrenciDurum.Gecti;  //OgrenciDurum tipinde değer döndürür.
                }
                else if (Ortalama>=50)
                {
                    return OgrenciDurum.SartliGecti;
                }
                else
                {
                    return OgrenciDurum.Kaldi;
                }
            
            }   
        
        }


    }

    //classların ufak hali (struct) daha az yer kaplar.
    struct Ders// ayrı olarak ta oluşturabilirdik burda oluşturduk biz.
    {

        public string Adi { get; set; }
        public decimal Vize { get; set; }
        public decimal Final { get; set; }

        public decimal Ortalama//her bir dersin ortalaması
        {
            get
            {
                return Vize * 0.4m + Final * 0.6m;//m:decimal demek(m yazmasaydık double kabul ederdi hata verirdi)

            }
        }


    }

    enum OgrenciDurum
    {
        Gecti=100,
        SartliGecti=70,
        Devamsiz,
        Kaldi,
        SinifTekrari
    }





    enum Alan //seçenek listesi
    {
        Sayisal,
        Sozel,
        EsitAgirlik,
        Dil
    }


}
