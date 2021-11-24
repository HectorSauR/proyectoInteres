using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteresSimple
{
    public partial class FSeleccionInteres : Form
    {
        public FSeleccionInteres()
        {
            InitializeComponent();
        }

        private void FSeleccionInteres_Load(object sender, EventArgs e)
        {

        }

        private void btnCompuesto_Click(object sender, EventArgs e)
        {
            FInteresCompuesto frm = new FInteresCompuesto(this);
            frm.Show();
            this.Hide();
        }

        private void btnSimple_Click(object sender, EventArgs e)
        {
            FInteresSimple frm = new FInteresSimple(this);
            frm.Show();
            this.Hide();
        }

        private void FSeleccionInteres_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Hasta la proxima!");
        }
    }
}
