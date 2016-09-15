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
    public partial class SalonForm : Form
    {
        public SalonForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           Salon s=new Salon(txtAdi.Text,(int)numMasaSayisi.Value,txtOnek.Text);
            //s.Adi=txtAdi.Text;
            //for (int i = 1; i <= numMasaSayisi.Value; i++)
            //{
            //    Masa m = new Masa();
            //    m.Kodu = string.Format("{0}{1}",txtOnek.Text,i);
            //    s.Masalar.Add(m);//masaları ekledik salona.
            //}  
            //yukarıdaki for döngüsünü constructor'ın içinde yaptık.o şekildede yapılabilir.

           Salon.Salonlar.Add(s);//bütün projede Salonlara erişebilelim diye atadık.static yapmıştık zaten.İçinde bir sürü salon tutacak.Veritabanı gibi birşey.

           listView1.Items.Add(s.ListOlustur());
        }
    }
}
