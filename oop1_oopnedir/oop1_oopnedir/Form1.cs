using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop1_oopnedir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Personeller personelform = new Personeller();//from oluşturduk.
        private void button1_Click(object sender, EventArgs e)
        {
            Personel prs = null;
            prs = new Personel();//nesne ürettik
          //  prs = new Personel("Ahmet", "kormaz");//adını soyaddını instance üretirken verdik.aşağıda kileri yazmamıza gerek kalmıyor.bu yöntem fazla kullanılmıyor genelde object initializer kullanılır bunun yerine.
            prs.Adi = textBox1.Text;
            prs.Soyadi = textBox2.Text;
            prs.SicilNo = textBox3.Text;
            prs.Maas = numericUpDown1.Value;

            personelform.PersonelEkle(prs);//Personeller formuna yolladık.

            //içlerini boşalt
            textBox1.Text = textBox2.Text = textBox3.Text = "";
            numericUpDown1.Value = 0;
            textBox1.Focus();//üstüne odakla(imleci buraya getir.)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personelform.Show();
        }

        

    }
}
