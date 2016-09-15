using System;
using System.Collections;  //ArrayList için kullandık bu kütüphaneyi
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop11_generic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList liste = new ArrayList();
            liste.Add("ahmet");
            liste.Add(23213);
            liste.Add(true);
            liste.Add('a');
            //kullanacağım zaman sürekli unboxing yapmam lazım
            string ad = (string)liste[0];//unboxing

          

            List<string> metinlistesi = new List<string>();
            List<int> sayilistesi = new List<int>();

            metinlistesi.Add("ramazan");
            sayilistesi.Add(5);
            //--------------

            //Hasta<string, string, string> hasta = new Hasta<string, string, string>();
            //hasta.HastaOzellikleri = "ali";  //string verdik 
            


            //Hasta<int, string, string> hasta2 = new Hasta<int, string, string>();
            //hasta2.HastaOzellikleri = 5;  //int verdik.

            //----------

            //Hasta<GribalEnfeksiyon<string>, string, string> hasta3 = new Hasta<GribalEnfeksiyon<string>, string, string>();

            //GribalEnfeksiyon<string> enfk = new GribalEnfeksiyon<string>();
            //enfk.Adi = "falanfilanca";
            //enfk.Antidot = "Adaçayı,ıhlamur";
            //enfk.LD = 9;
            //hasta3.HastaOzellikleri = enfk;

            //-----------------------
           
            Hasta<GribalEnfeksiyon<string>, AgriKesici> hasta4 = new Hasta<GribalEnfeksiyon<string>, AgriKesici>();
            
           // hasta4.Ilaclar=

        }
    }
}
