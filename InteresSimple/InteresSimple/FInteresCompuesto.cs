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
    public partial class FInteresCompuesto : Form
    {
        Form frm;
        CInteresCompuesto IntCom;
        public FInteresCompuesto(Form form)
        {
            InitializeComponent();
            frm = form;
        }

        private void FInteresCompuesto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularPerido();
        }

        private void CalcularPerido()
        {
            
        }

        private void FInteresCompuesto_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Show();
        }
    }
}
