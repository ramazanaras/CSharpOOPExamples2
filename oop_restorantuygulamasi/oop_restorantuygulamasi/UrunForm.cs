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
    public partial class UrunForm : Form
    {
        public UrunForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //ListViewItem li = new ListViewItem();
            //li.Text = txtAdi.Text;//ilk kolon
            //li.SubItems.Add(txtFiyat.Text); //ikinci kolon
            //lstUrun.Items.Add(li);
            //yukarıdakileri yapmak yerine Urun sınıfında bir metot oluşturduk.ve aşağıdada lstUrun.Items.Add(u.ListOlustur()); bu şekilde oluşturduk.

            //new diyerek ramde yeni bir ürün tanımlamış oluruz.
            Urun u = new Urun(txtAdi.Text, txtFiyat.Value);//constructor sınıf oluşurken değerleri atadık.aşağıdakine gerek kalmadı.
            //u.Adi = txtAdi.Text;
            //u.Fiyat = txtFiyat.Value;

            Urun.Liste.Add(u);//static 'e değeri attık.yani içinde bir çok ürün olacak dedik.

            lstUrun.Items.Add(u.ListOlustur());

        }
    }
}
