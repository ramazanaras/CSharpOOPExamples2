using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop9_interface_oyuncakci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kuruvazor k = new Kuruvazor();
            OyuncakAl(k);
            Apachee a = new Apachee();
            OyuncakAl(a);

            Barbie b = new Barbie();
            //OyuncakAl(b); hata verir.çünkü IAtesEdebilable'ı implemente etmemiş.
        }

        void OyuncakAl(IAtesEdebilable oyuncak)//Ateş eden oyuncak al 
        {
            oyuncak.AtesEt();
        
        }

    }
}
