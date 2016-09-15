using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.Adi = "ramazan";  //Adi property si başka yerden
            o.Soyadi = "aras"; //Soyadi property si başka yerden geliyor .sonuç olarak herikisinide birleştiriyor.


           // Tools.ConnectionString erişebiliriz bu şekilde(static)
        }
    }

    public partial class Ogrenci
    {
        public string Soyadi { get; set; }
    
    }

}
