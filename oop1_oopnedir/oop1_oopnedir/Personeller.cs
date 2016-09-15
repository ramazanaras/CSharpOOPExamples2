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
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }

        private void Personeller_Load(object sender, EventArgs e)
        {

        }

        Personel[] personeller = new Personel[100];
        int sayac = 0;
        public void PersonelEkle(Personel yp)
        {
            personeller[sayac] = yp;
            listBox1.Items.Add(yp.Adi+" "+yp.Soyadi);
            sayac++;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex==-1)//hiçbir şey seçili değilse
            {
                return;//metottdan çık(void button1_Click metodundan)
            }
            Personel kovulacak = personeller[listBox1.SelectedIndex];
            kovulacak.Kov();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
        }

        private void Personeller_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//uygulamayı kapat.
        }
    }
}
