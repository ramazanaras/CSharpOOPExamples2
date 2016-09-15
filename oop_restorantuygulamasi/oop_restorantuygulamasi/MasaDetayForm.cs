using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_restorantuygulamasi
{
    public partial class MasaDetayForm : Form
    {
        public MasaDetayForm()
        {
            InitializeComponent();
        }

        public Masa Masa { get; set; }//Masa tipinde eleman //MasaListeForm'daki masa_Click metodunda  mdf.Masa = m; olarak buraya yolladık.

        private void MasaDetayForm_Load(object sender, EventArgs e)
        {
            lblMasaNo.Text = Masa.Kodu;
            lblTutar.Text = Masa.Tutar.ToString("C2");//C2 yazarak sonuna TL yazarız.

            foreach (Urun u in Masa.Urunler)
            {
                listView1.Items.Add(u.ListOlustur());   
            }
            
            cmbUrun.DataSource = Urun.Liste;//comboboxa daha önceden eklenmiş olan bütün ürünleri getir.(DataSource obje tipinde değer alıyor(yani içine ne atarsan alır).bizde Urun tipinde bir değer yolladık)
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun u = (Urun)cmbUrun.SelectedItem;
            Masa.Urunler.Add(u);
            listView1.Items.Add(u.ListOlustur());
        }
    }
}
