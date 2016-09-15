using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_IEnumerable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Takim adanaspor = new Takim();

            //Oyuncu o = new Oyuncu();
            //o.Adi = "Ramazan";
            //o.Soyadi = "Aras";
            //adanaspor.Oyuncular.Add(o);
            
            //yukarıdaki gibi de ekleme yapılabilirdi.
            adanaspor.Oyuncular.Add(new Oyuncu {Adi="Arda" ,Soyadi="Turan"});
            adanaspor.Oyuncular.Add(new Oyuncu { Adi = "Nordin", Soyadi = "Amrabat" });
            adanaspor.Oyuncular.Add(new Oyuncu { Adi = "Günay Gül", Soyadi = "Öztürk" });


            foreach (Oyuncu item in adanaspor) //Takim sınıfının koleksyion gibi dönmesini sağladık(IEnumerable 'la)
            {
                MessageBox.Show(item.Adi+" "+item.Soyadi);
            }


            /*NOT:IEnumrable daki amaç kendi oluşturduğumuz sınıfları nasıl liste haline getirebiliriz nasıl içinde dolaşılabilir hale ,nasıl koleksiyon haline dönüştürebiliriz onu sağladık.*/
        }
    }
}
