using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop10_events
{
     delegate void GectiKaldiEventHandler(object sender,GectiKaldiEventArgs e);

    class GectiKaldiEventArgs:EventArgs
    {
    public double Ortalama { get; set; }
    public string AdSoyad { get; set; }
    }


    class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        private double vize;

        public double Vize
        {
            get { return vize; }
            set { vize = value; DurumKontrol(); }
        }

        private double final;

        public double Final
        {
            get { return final; }
            set { final = value; DurumKontrol(); }
        }

        void DurumKontrol() 
        {
            if (Ortalama>=70)
            {
                if (Gecti!=null)
                    Gecti(this, new GectiKaldiEventArgs { AdSoyad = Adi + " " + Soyadi, Ortalama = Ortalama });   
               
            }
            else
            {
                if(Kaldi!=null)
                Kaldi(this, new GectiKaldiEventArgs { AdSoyad = Adi + " " + Soyadi, Ortalama = Ortalama });
            }
        
        }


        public double Ortalama { get { return Vize * 0.4 + Final * 0.6; } }

        public event GectiKaldiEventHandler Gecti;
        public event GectiKaldiEventHandler Kaldi;


        public override string ToString()
        {
            return Adi + " " + Soyadi+ " "+Ortalama ;
        }
    }
}
