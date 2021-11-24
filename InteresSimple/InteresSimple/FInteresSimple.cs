using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_dibujo_csharp;

namespace InteresSimple
{
    public partial class FInteresSimple : Form
    {
        Form frm;
        public FInteresSimple(Form form)
        {
            InitializeComponent();
            frm = form;
        }

        private void rb_CapitalInicial_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_capInicial.Enabled = false;
            if (txt_interes.Enabled == false)
            {
                txt_interes.Enabled = true;
            }
            if (txt_numeroPeriodos.Enabled == false)
            {
                txt_numeroPeriodos.Enabled = true;
            }
            if (txt_tasaInteres.Enabled == false)
            {
                txt_tasaInteres.Enabled = true;
            }
            if (txt_ValorFinal.Enabled == false)
            {
                txt_ValorFinal.Enabled = true;
            }
        }

        private void rb_NumPeriodos_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_numeroPeriodos.Enabled = false;
            if (txt_interes.Enabled == false)
            {
                txt_interes.Enabled = true;
            }
            if (txt_capInicial.Enabled == false)
            {
                txt_capInicial.Enabled = true;
            }
            if (txt_tasaInteres.Enabled == false)
            {
                txt_tasaInteres.Enabled = true;
            }
            if (txt_ValorFinal.Enabled == false)
            {
                txt_ValorFinal.Enabled = true;
            }
        }

        private void rb_TasaInteres_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_tasaInteres.Enabled = false;
            if (txt_interes.Enabled == false)
            {
                txt_interes.Enabled = true;
            }
            if (txt_capInicial.Enabled == false)
            {
                txt_capInicial.Enabled = true;
            }
            if (txt_numeroPeriodos.Enabled == false)
            {
                txt_numeroPeriodos.Enabled = true;
            }
            if (txt_ValorFinal.Enabled == false)
            {
                txt_ValorFinal.Enabled = true;
            }
        }

        private void rb_Interes_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_interes.Enabled = false;
            if (txt_capInicial.Enabled == false)
            {
                txt_capInicial.Enabled = true;
            }
            if (txt_numeroPeriodos.Enabled == false)
            {
                txt_numeroPeriodos.Enabled = true;
            }
            if (txt_tasaInteres.Enabled == false)
            {
                txt_tasaInteres.Enabled = true;
            }
            if (txt_ValorFinal.Enabled == false)
            {
                txt_ValorFinal.Enabled = true;
            }
        }

        private void rb_ValorFinal_CheckedChanged(object sender, EventArgs e)
        {
            txt_ValorFinal.Enabled = false;
            if (txt_interes.Enabled == false)
            {
                txt_interes.Enabled = true;
            }
            if (txt_capInicial.Enabled == false)
            {
                txt_capInicial.Enabled = true;
            }
            if (txt_numeroPeriodos.Enabled == false)
            {
                txt_numeroPeriodos.Enabled = true;
            }
            if (txt_tasaInteres.Enabled == false)
            {
                txt_tasaInteres.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CInteresSimple IS = new CInteresSimple();
            if (txt_interes.Text.StartsWith("$"))
            {
                IS.Interes = double.Parse(txt_interes.Text.Substring(1));
            }
            else
            {
                IS.Interes = double.Parse(txt_interes.Text);
            }
            if (txt_ValorFinal.Text.StartsWith("$"))
            {
                IS.ValorFinal = double.Parse(txt_ValorFinal.Text.Substring(1));
            }
            else
            {
                IS.ValorFinal = double.Parse(txt_ValorFinal.Text);
            }
            if (txt_capInicial.Text.StartsWith("$"))
            {
                IS.CapitalInicial = double.Parse(txt_capInicial.Text.Substring(1));
            }
            else
            {
                IS.CapitalInicial = double.Parse(txt_capInicial.Text);
            }
            IS.NumPeriodos = double.Parse(txt_numeroPeriodos.Text);
            IS.TasaDeInteres = double.Parse(txt_tasaInteres.Text) / 100;

            if (rb_Interes.Checked == true)
            {
                IS.calcularInteres();
                txt_interes.Text = "" + IS.Interes;
            }
            if (rb_CapitalInicial.Checked == true)
            {
                IS.calcularCapitalInicial();
                txt_capInicial.Text = "" + IS.CapitalInicial;
            }
            if (rb_NumPeriodos.Checked == true)
            {
                IS.calcularNumPeriodos();
                txt_numeroPeriodos.Text = "" + IS.NumPeriodos;

            }
            if (rb_TasaInteres.Checked == true)
            {
                IS.calcularTasaInteres();
                txt_tasaInteres.Text = "" + IS.TasaDeInteres;
            }
            if (rb_ValorFinal.Checked)
            {
                IS.calcularValorFinal();
                txt_ValorFinal.Text = "" + IS.ValorFinal;
            }
            if (rb_perdida.Checked == true)
            {
                IS.GanPer = true;
            }
            else
            {
                IS.GanPer = false;
            }
            if (int.Parse(txt_ValorFinal.Text) == 0)
            {
                IS.calcularValorFinal();
                txt_ValorFinal.Text = "" + IS.ValorFinal;
            }

            txt_capInicial.Text = "$" + txt_capInicial.Text;
            txt_interes.Text = "$" + txt_interes.Text;
            txt_ValorFinal.Text = "$" + txt_ValorFinal.Text;
            txt_tasaInteres.Text += "%";

            Form1 fr = new Form1(IS.NumPeriodos, IS.GanPer, IS, cb_tipoPeriodo.SelectedItem.ToString());
            fr.Show();
        }

        private void btn_borrar_Click_1(object sender, EventArgs e)
        {
            txt_capInicial.Text = "0";
            txt_interes.Text = "0";
            txt_numeroPeriodos.Text = "0";
            txt_tasaInteres.Text = "0";
            txt_ValorFinal.Text = "0";
        }

        private void FInteresSimple_Load(object sender, EventArgs e)
        {

        }

        private void txt_capInicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void FInteresSimple_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Show();
        }
    }
}
