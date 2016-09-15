using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop7_static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             class ismine nokta yazılarak ulaşılan elemanlara static elemanlar denir.
             * Amaci instance alarak zaman ve bellek harcamasını azaltmak.
             * Messagebox.Show(); static 'e güzel bir örnektir.
             * TanimliOgrenciSayisini static yaparsak Ogrenci Classına bağlı olmuş oluyor.Artırınca burdaki globaldekini artırıyor. 
             * 
             * Static elemanlar global oluyor .
             */





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.Adi = "murtaza";

            Ogrenci o2 = new Ogrenci();
            o2.Adi = "Kadriye";


            //Ogrenci.TanimliOgrenciSayisi;//Direk Ogrenci classından bağlanabiliyoruz çünkü static yaptık.


            Ogrenci.YoklamaAl();//static metoda ulaştık.
        }
    }
}
