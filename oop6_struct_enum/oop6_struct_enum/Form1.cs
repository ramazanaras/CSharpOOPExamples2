using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop6_struct_enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci(); //constructorda  List<Ders> bunu new ledik yoksa aşağıda  ogr.Dersler.Add(d) bu hata verirdi.
            ogr.Adi = "Alaaddin";
            ogr.Soyadi = "Ozdemir";
            ogr.Alani = Alan.Sayisal;  //Alan tipinde değer attık.

            Ders d = new Ders {Adi="matematik",Vize=60,Final=40 };//object initializer(constructorın önemini azaltan bir yöntemdir.Genelde object initializer kullanılır.)
            Ders d2 = new Ders {Adi="Fizik",Vize=87,Final=60 };
            ogr.Dersler.Add(d);//Ders tipinde eleman istiyordu bizde atadık.
            ogr.Dersler.Add(d2);

            //enumlar int'e cast edilebilir
            int durum =(int) ogr.Durum;  //70 değerini bize verir.çünkü Durumu şartlı  geçti çıkmıştı.
            //int'ler enumlara cast edilebilir.
            OgrenciDurum drm = (OgrenciDurum)100; //drm:geçti değerini atar.100'ün karşılığını verir.

            

           MessageBox.Show(ogr.Ortalama.ToString());//öğrencinin ortalamasını yazar.

            MessageBox.Show(ogr.Durum.ToString());//öğrencinin ortalamasına göre  durumuna baktık.Şartlı geçti yazar.

            switch (ogr.Durum)
            {
                case OgrenciDurum.Gecti:
                    MessageBox.Show("helal olsun direk geçtin");
                    break;
                case OgrenciDurum.SartliGecti:
                    MessageBox.Show("neyse şimdilik geç bakalım ama daha çok çalış olmaz böyle");
                    break;
                case OgrenciDurum.Devamsiz:
                    MessageBox.Show("pii bi görevin bu bunuda yapmadın mı");
                    break;
                case OgrenciDurum.Kaldi:
                    MessageBox.Show("seneye yine bekleriz");
                    break;
                case OgrenciDurum.SinifTekrari:
                    MessageBox.Show("seneye yine birlikteyiz.");
                    break;
                default:
                    break;
            }


        }
    }
}
