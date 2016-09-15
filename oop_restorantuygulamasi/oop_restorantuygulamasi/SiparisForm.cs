using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_restorantuygulamasi
{
    public partial class SiparisForm : Form
    {
        public SiparisForm()
        {
            InitializeComponent();
        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            //Salon s = new Salon();
            //this.Controls.Add(s);//Salon sınıfı Button sınıfından miras aldığı için this.Controls.Add(btn) 'içine butonu yazıyorduk şimdi s'yide içine yazabiliriz.

            foreach (Salon salon in Salon.Salonlar)
            {
                flowLayoutPanel1.Controls.Add(salon);
                salon.Click += salon_Click;
             
            }

        }

        void salon_Click(object sender, EventArgs e)
        {
            Salon s = (Salon)sender;//tıklanan Salonu alıyoruz.
            MasaListeForm msl = new MasaListeForm();
            msl.MdiParent = this.MdiParent;
            msl.Salon = s;
            msl.Show();
        }

        private void SiparisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Controls.Clear(); //bırakılmış nesneye erişilemiyor hatasını önler.
        }

      
    }
}
