using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_pizzasiparis_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sepet siparisSepet = new Sepet();//bir tane sepet oluşturduk.
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            Siparis sip = SiparisHesapla();
            siparisSepet.Siparisler.Add(sip);
            lblToplamTutar.Text = siparisSepet.ToplamFiyat.ToString("C");
            listSepet.Items.Add(sip);
        }


        Siparis SiparisHesapla() 
        {
            Siparis s = new Siparis();//yeni bir sipariş oluşturuyoruz.
            s.Adet = (int)nudAdet.Value;
            Pizza p = new Pizza();
            p.Ebat = (PizzaEbat)cmbEbat.SelectedItem;
            p.Tur = (PizzaTur)listPizzalar.SelectedItem;
            p.Kenar = rdbInceKenar.Checked ? (KenarTur)rdbInceKenar.Tag : (KenarTur)rdbKalinKenar.Tag;//ternary if
            foreach (CheckBox item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    p.Malzemeler.Add((PizzaMalzeme)item.Tag);
                }
            }
            s.Pizza = p;
            return s;//Siparis nesnesi dönüyor.
        
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Siparis s = SiparisHesapla();
            txtTutar.Text = s.Fiyat.ToString("C");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PizzaEbat kucuk = new PizzaEbat { Adi = "Küçük", Carpan = 1 };
            //cmbEbat.Items.Add(kucuk);
            //yukarıdaki gibide ekleme yapabilirdik direk aşağıdaki gibi yaptık.
            cmbEbat.Items.Add(new PizzaEbat { Adi = "Küçük Boy", Carpan = 1 });
            cmbEbat.Items.Add(new PizzaEbat { Adi = "Orta Boy", Carpan = 1.5m });
            cmbEbat.Items.Add(new PizzaEbat { Adi = "Büyük Boy", Carpan = 2 });
            cmbEbat.Items.Add(new PizzaEbat { Adi = "Maksi Boy", Carpan = 2.5m });


            listPizzalar.Items.Add(new PizzaTur {Adi="Klasik",Fiyat=14 });
            listPizzalar.Items.Add(new PizzaTur { Adi = "Karışık", Fiyat = 17 });
            listPizzalar.Items.Add(new PizzaTur { Adi = "Extravaganza", Fiyat = 21});
            listPizzalar.Items.Add(new PizzaTur { Adi = "Italiano", Fiyat = 23 });
            listPizzalar.Items.Add(new PizzaTur { Adi = "Turkish", Fiyat = 18});
            listPizzalar.Items.Add(new PizzaTur { Adi = "Kayseri Ateşi", Fiyat = 19 });

            //radiobutonların tag özelliğine objeyi  attık.
            rdbInceKenar.Tag = new KenarTur {Adi="İnce Kenar",EkFiyat=0 };
            rdbKalinKenar.Tag = new KenarTur {Adi="Kalın Kenar",EkFiyat=2 };



            //her checkbox'ı çekip tag özelliğine pizza malzeme türünde bir değişken koyarak her ek malzemenin fiyatını belirlemiş oluruz.
            foreach (CheckBox item in groupBox1.Controls)
            {
                item.Tag = new PizzaMalzeme {Adi=item.Text,EkFiyat=0.25m };
            }
        }

        private void btnSiparisOnay_Click(object sender, EventArgs e)
        {
           
           MessageBox.Show(string.Format("Toplam Sipariş Adetiniz {0} \n Toplam Sipariş Tutarınız: {1}", siparisSepet.ToplamSiparisAdeti, siparisSepet.ToplamFiyat));
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)//PrintPage eventi
        {
            ////temel yazdırma
            //Graphics sayfa = e.Graphics;
            //Font yazitipi=new System.Drawing.Font("Arial",12);
            //sayfa.DrawString("Bilge Adam", yazitipi,Brushes.Blue,20,65);//bu şekilde Bilge Adam yazar.//tek satır

            //------------
            Graphics sayfa = e.Graphics;
            int y = 65;
            Font yazitipi = new System.Drawing.Font("Arial", 12);
            sayfa.DrawString(txtAdi.Text+" "+txtSoyadi.Text+"-"+txtTelefon.Text, yazitipi, Brushes.Blue, 20, y);//20 x konumu oluyor.
           
            foreach (Siparis item in siparisSepet.Siparisler)
            {
                y += 20; //y konumunu artırki alta geçsin.
                sayfa.DrawString(item.ToString(),yazitipi,Brushes.Blue,30,y);
                    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // printDocument1.Print();//direk yazdırır.Dialog soncuunda yazdır dersek aşağıdaki gibi yaparız

            if (printDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
          
        }
    }
}
