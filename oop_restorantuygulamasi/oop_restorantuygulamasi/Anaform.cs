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
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }
        /*5 Temel Tip vardır C# ta
         *Class
         *Interface
         *Struct
         *Enum
         *Delegate
         *
         * 
         */

        /*5 Temel Kural
         Encapsulation
         * Inheritance
         * Polymorphism
         * Constructor
          Access Modifiers
         */
        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunForm uf = new UrunForm();
            uf.MdiParent = this;//this:bu form
            uf.Show();

            
            
        }

        private void salonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalonForm sf = new SalonForm();
            sf.MdiParent = this;
            sf.Show();
        }

        private void siparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisForm sf = new SiparisForm();
            sf.MdiParent = this;
            sf.Show();
        }
    }
}
