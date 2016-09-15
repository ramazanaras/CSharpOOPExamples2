using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_otopark_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Arac arc = new Arac();//her araç oluştuğunda constructorda Giriş süresinide veriyoruz.
            arc.Plaka = txtPlaka.Text;
            arc.Tip = (AracTip)lstAracTip.SelectedItem;//objeyi çıkardık.
            arc.Kontak = chkKontak.Checked; //seçili ise true seçili değilse false döndürür.
            arc.Abone = chkAbone.Checked;
            lstAraclar.Items.Add(arc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AracTip aractipi=new AracTip();
            //aractipi.Adi = "Otomobil(1)";
            //aractipi.Fiyat = 1;
            //lstAracTip.Items.Add(aractipi);
            //yukarıdaki gibi de ekleyebilirdik ama biz aşağıdaki gibi ekleme yaptık.
            lstAracTip.Items.Add(new AracTip {Adi="Otomobil(1)",Fiyat=1 });  //Saatlik ücreti yani arabanın tipine göre saatlik otopark fiyatı.
            lstAracTip.Items.Add(new AracTip { Adi = "Mininüs(2)", Fiyat = 2 });
            lstAracTip.Items.Add(new AracTip { Adi = "Otobüs(4)", Fiyat = 4 });
            lstAracTip.Items.Add(new AracTip { Adi = "Kamyon(4)", Fiyat = 4 });
            lstAracTip.Items.Add(new AracTip { Adi = "Tır(8)", Fiyat = 8 });
        }

   

        private void lstAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAraclar.SelectedItem == null) return;  //eğer seçili değilse hiçbir işlem yapma


            Arac secili = (Arac)lstAraclar.SelectedItem;
            secili.Cikis = DateTime.Now;
            lblPlaka.Text = secili.Plaka;
            lblSure.Text = secili.Sure.ToString();
            lblUcret.Text = secili.Ucret.ToString("C2");//C2 yazarsak sonuna TL koyar.

        }

        List<Arac> CikisYapanlar = new List<Arac>();//Arac tipinde  değer ister bizden.
        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstAraclar.SelectedItem == null) return; //hiçbir şey seçilmemişse aşağıdaki kodları çalıştırma direk bulunduğu  scopedan(parantez) çık.return direk çıkmak demek.

            Arac secili = (Arac)lstAraclar.SelectedItem;
            CikisYapanlar.Add(secili);//Arac tipinde değeri atadık.
            lstAraclar.Items.Remove(secili);
        }

        private void btnSatisRaporu_Click(object sender, EventArgs e)
        {
            Rapor form = new Rapor();//Rapor formu
            decimal total = 0;//toplam fiyat
            foreach (Arac item in CikisYapanlar)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.Plaka;//ilk kolon
                li.SubItems.Add(item.Tip.Adi);
                li.SubItems.Add(item.Abone?"Abone":"Değil");//ternary if
                li.SubItems.Add(item.Sure.ToString());
                li.SubItems.Add(item.Ucret.ToString("C2"));
                form.listView1.Items.Add(li);//Rapor formundaki listviewe ekleme yaptık.
                total += item.Ucret;
            }
            form.lblToplamUcret.Text = total.ToString("C2");//C2 dersek sonuna TL ekler.
            form.lblToplamArac.Text = CikisYapanlar.Count().ToString();
            form.Show();
        }
    }
}
