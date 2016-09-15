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
    public partial class MasaListeForm : Form
    {
        public MasaListeForm()
        {
            InitializeComponent();
        }
        public Salon Salon { get; set; } //Siparis formundaki salon_Click'teki  msl.Salon = s; olarak atadık.

        private void MasaListeForm_Load(object sender, EventArgs e)
        {
            lblSalonAdi.Text = Salon.Adi;
            foreach (Masa masa in Salon.Masalar)
            {
                flowLayoutPanel1.Controls.Add(masa);
                masa.Click += masa_Click;//masa tıklanınca 
            }
        }

        void masa_Click(object sender, EventArgs e)//herhangi bir masaya tıklandığında MasaDetayFormu açtırıcaz
        {
            Masa m=(Masa)sender;//tıklanan Masayı aldık.
            MasaDetayForm mdf = new MasaDetayForm();
            mdf.Masa = m;//tıklanan masayı gönderdik.(MasaDetayFormuna)
            mdf.MdiParent = this.MdiParent;
            mdf.Show();
        }
    }
}
