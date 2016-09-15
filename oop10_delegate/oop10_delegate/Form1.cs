using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop10_delegate
{
    public delegate void MesajVerHandler(string mesaj);  //delegate

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         Bir sayıyı taşımak için değişken kullanabiliyoruz. Peki ya metotu taşımak istersek?
        İnşatteki Kum çimento tuğla elemanları taşıyan Field ise 
         Kepçe Vinç Dozer taşıyan ve çalıştıran Delegate dir.
         
         */
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void KutudaMesajVer(string msg) 
        {
            MessageBox.Show(msg);
        }
        void LabeldeMesajVer(string msg) 
        {
            label1.Text = msg;
        
        }
        void TextBoxDaMesajVer(string msg)
        {
            textBox1.Text = msg;
        }
        void CaptiondaMesajVer(string msg)
        {
            this.Text = msg;//formun yukardaki ismi
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //delegate içinde metod tutar.
            MesajVerHandler mesajverici = new MesajVerHandler(KutudaMesajVer);

            mesajverici += LabeldeMesajVer;
            mesajverici += TextBoxDaMesajVer;
            mesajverici += CaptiondaMesajVer; 

            mesajverici.Invoke("Merhaba dünya");
        }
    }
}
