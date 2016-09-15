using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop5_polymorhism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = textBox1.Text;
            ogr.Soyadi = textBox2.Text;
            ogr.Vize = numericUpDown1.Value;  //decimal tipte
            ogr.Final = numericUpDown2.Value;

            //MessageBox.Show(ogr.ToString());
            listBox1.Items.Add(ogr);//ogr nesnesini attık.


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex==-1) //hiçbirşey seçili değilse 
            {
                return;//aşağıdaki kodları çalıştırma (metottan çık.)
            }

            Ogrenci secilen = (Ogrenci)listBox1.SelectedItem;//unboxing yaptık.
            textBox1.Text = secilen.Adi;
            textBox2.Text = secilen.Soyadi;
            numericUpDown1.Value = secilen.Vize;
            numericUpDown2.Value = secilen.Final;

            secilen.YogurtYe();

        }
    }
}
