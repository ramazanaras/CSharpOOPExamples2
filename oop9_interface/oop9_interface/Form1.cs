using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop9_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*c# ta 5 temel tipi vardır.
             struct,enum,interface,delegate,class
             */
        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        ISutCekebilable forvet;
        IOyunKurabilable ortasaha;
        
        private void button1_Click(object sender, EventArgs e)
        {

            Arda a = new Arda();
            forvet = a;
            //ortasaha = a; hata verir çünkü Ardaya IOyunKurabilable 'ı implemente etmedik.

            Sabri s = new Sabri();
            ortasaha = s;


            VoleVur(a);
            //VoleVur(s);//hata verir çünkü Sabri'de ISutCekebilable implemente edilmemiş.

            ArtistikCalimAt(s);
            ArtistikCalimAt(a);//Arda'da IOyunKurabilable implemente ettik hata vermez.

        }
        void VoleVur(ISutCekebilable oyuncu) 
        {
            oyuncu.SutCek(506.4f, 90f);
        
        }
        void ArtistikCalimAt(IOyunKurabilable oyuncu) 
        {
            oyuncu.CalimAt(423,85);
        }
    }
}
