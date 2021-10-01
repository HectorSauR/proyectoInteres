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
    public partial class FInteresSimple : Form
    {
        public FInteresSimple()
        {
            InitializeComponent();
        }

        private void FInteresSimple_Load(object sender, EventArgs e)
        {

        }

        private void rb_Interes_CheckedChanged(object sender, EventArgs e)
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

        private void rb_CapitalInicial_CheckedChanged(object sender, EventArgs e)
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

        private void rb_NumPeriodos_CheckedChanged(object sender, EventArgs e)
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

        private void rb_TasaInteres_CheckedChanged(object sender, EventArgs e)
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

        private void rb_ValorInicial_CheckedChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            CInteresSimple IS = new CInteresSimple();
            IS.Interes = double.Parse(txt_interes.Text);
            IS.NumPeriodos = double.Parse(txt_numeroPeriodos.Text);
            IS.TasaDeInteres = double.Parse(txt_tasaInteres.Text)/100;
            IS.CapitalInicial = double.Parse(txt_capInicial.Text);
            IS.ValorFinal = double.Parse(txt_ValorFinal.Text);

            if(rb_Interes.Checked == true)
            {
                IS.calcularInteres();
                txt_interes.Text = "$"+IS.Interes;
                if(int.Parse(txt_ValorFinal.Text) == 0)
                {
                    IS.calcularValorFinal();
                    txt_ValorFinal.Text = "" + IS.ValorFinal;
                }
            }
            if(rb_CapitalInicial.Checked == true)
            {
                IS.calcularCapitalInicial();
                txt_capInicial.Text = "$" + IS.CapitalInicial;
                if (int.Parse(txt_ValorFinal.Text) == 0)
                {
                    IS.calcularValorFinal();
                    txt_ValorFinal.Text = "" + IS.ValorFinal;
                }
            }
            if(rb_NumPeriodos.Checked == true)
            {
                IS.calcularNumPeriodos();
                txt_numeroPeriodos.Text = "" + IS.NumPeriodos;
                if (int.Parse(txt_ValorFinal.Text) == 0)
                {
                    IS.calcularValorFinal();
                    txt_ValorFinal.Text = "" + IS.ValorFinal;
                }
            }
            if(rb_TasaInteres.Checked == true)
            {
                IS.calcularTasaInteres();
                txt_tasaInteres.Text = "" + IS.TasaDeInteres;
                if (int.Parse(txt_ValorFinal.Text) == 0)
                {
                    IS.calcularValorFinal();
                    txt_ValorFinal.Text = "" + IS.ValorFinal;
                }
            }
            if (rb_ValorFinal.Checked)
            {
                IS.calcularValorFinal();
                txt_ValorFinal.Text = "$" + IS.ValorFinal;
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            txt_capInicial.Text = "0";
            txt_interes.Text = "0";
            txt_numeroPeriodos.Text = "0";
            txt_tasaInteres.Text = "0";
            txt_ValorFinal.Text = "0";
        }
    }
}
