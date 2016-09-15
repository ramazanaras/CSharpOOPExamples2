using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop10_asyncronousdelegates
{
    public delegate void SayHandler();  //delegate

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        void Sayici1()
        {
            DateTime baslangic = DateTime.Now;
            for (int i = 0; i < 100000; i++)
            {
                listBox1.Items.Add(i);
            }

            TimeSpan sonuc = DateTime.Now - baslangic;
            MessageBox.Show(sonuc.TotalMilliseconds.ToString());
        
        }

        void takipci1(IAsyncResult sonuc)
        {
            SayHandler saydirici = (SayHandler)sonuc.AsyncState;
            saydirici.EndInvoke(sonuc);
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SayHandler saydirici = new SayHandler(Sayici1);
            AsyncCallback callback = new AsyncCallback(takipci1);
            saydirici.BeginInvoke(callback, saydirici);//begininvoke ile metodu asenkron olarak çalışırabiliriz.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void sayici2() {

            for (int i = 0; i < 100000; i++)
            {
                listBox2.Items.Add(i);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SayHandler saydirici2 = new SayHandler(sayici2);//SayHandler saydirici2 =sayici2 direk böylede verebiliriz.
            saydirici2.BeginInvoke(takipci1, saydirici2);

        }

        
    }
}
