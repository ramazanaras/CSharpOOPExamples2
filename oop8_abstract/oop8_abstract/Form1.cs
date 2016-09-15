using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop8_abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CariMusteri musteri = new CariMusteri();
            musteri.CariKodu = "AB34324";
            HavaleYap(musteri);


            CariTedarikci tedarikci = new CariTedarikci();
            tedarikci.CariKodu = "bb342";
            HavaleYap(tedarikci);

            

        }

        void HavaleYap(Cari c) 
        {

            string[] bankalar = c.getBanks();
        
        
        }

    }
}
