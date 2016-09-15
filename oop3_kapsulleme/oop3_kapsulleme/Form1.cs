using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop3_kapsulleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ogrenci o = new Ogrenci();
            //try
            //{
            //    o.setAdi(textBox1.Text);
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message); 
            //}
           
            //o.getAdi();

            //yukarıdakiler eski yöntem




            try
            {
                Ogrenci o = new Ogrenci();
                o.Adi = textBox1.Text;
                o.DogumTarihi = dateTimePicker1.Value;
                MessageBox.Show(o.Yas.ToString());

                //o.TCKN = "213"; //hata verir çünkü auto propertysinde private set yaptık.değer atayamayız
                //o.GozRengi = "mavi"; //değer atayabiliriz ama aşağıdaki gibi okuyamayız.
                //MessageBox.Show(o.GozRengi); //hata verir çünkü auto propertysinde private get yaptık değeri okuyamayız 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); 
            }
          


        }
    }
}
