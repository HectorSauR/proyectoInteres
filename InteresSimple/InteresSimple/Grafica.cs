using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InteresSimple;

namespace test_dibujo_csharp
{

    public partial class Form1 : Form
    {
        double _numero;
        bool _tipo;
        string _meses;
        CInteresSimple IS = new CInteresSimple();

        public double Numero { get => _numero; set => _numero = value; }
        public bool Tipo { get => _tipo; set => _tipo = value; }
        public string Meses { get => _meses; set => _meses = value; }

        public Form1(Double n, bool tipo, CInteresSimple ISS, string meses)
        {
            InitializeComponent();
            Numero = n;
            Tipo = tipo;
            IS = ISS;
            Meses = meses;
        }

        public void Dibujar(Double n, bool tipo)
        {
            Graphics papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            Font letra = new Font("Arial", 16);
            SolidBrush brocha = new SolidBrush(Color.Black);
            papel.DrawLine(lapiz, 60, 175, 400, 175);      
            int f = Convert.ToInt32(n)+1;
            int d = 500 / f;
            int c = 60;
            //dibujar recta
           // for(int i=0; i < f; i++)
            //{              
             //   papel.DrawLine(lapiz, c+(d*i), 150, c + (d * i), 200);
              //  papel.DrawString("" + i, letra, brocha, c + (d * i) + 5, 175);
           // }
            //cuando tipo es true quiere decir que es ganancia
            if(tipo == true)
            {
                papel.DrawLine(lapiz, 60, 75, 60, 175);
                papel.DrawLine(lapiz, 60, 75, 65, 80);
                papel.DrawLine(lapiz, 60, 75, 55, 80);
                papel.DrawString("$"+IS.CapitalInicial, letra, brocha,70, 90);
                papel.DrawString("0", letra, brocha, 40, 165);
                int pos = Convert.ToInt32(d * n);
                papel.DrawLine(lapiz, 400, 175, 400, 250);//recta
                papel.DrawLine(lapiz, 400, 250, 405, 245);
                papel.DrawLine(lapiz, 400, 250, 395, 245);
                papel.DrawString("$" + IS.ValorFinal, letra, brocha, 400, 250);
                papel.DrawString("" + IS.NumPeriodos, letra, brocha, 410, 165);

            }
            else
            {
                papel.DrawLine(lapiz, 60, 175, 60, 250);
                papel.DrawLine(lapiz, 60, 250, 55, 245);
                papel.DrawLine(lapiz, 60, 250, 65, 245);
                papel.DrawString("0", letra, brocha, 40, 165);
                papel.DrawString("$" + IS.CapitalInicial, letra, brocha, 70, 250);
                int pos = Convert.ToInt32(d * n);
                papel.DrawLine(lapiz, 400, 75, 395, 80);
                papel.DrawLine(lapiz, 400, 75, 405, 80);
                papel.DrawLine(lapiz, 400, 75, 400, 175);
                papel.DrawString("$" + IS.ValorFinal, letra, brocha, 400, 90);
                papel.DrawString("" + IS.NumPeriodos, letra, brocha, 410, 165);

            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dibujar(Numero, Tipo);
            lbl_periodo.Text = IS.NumPeriodos.ToString() +" "+ Meses;
            lbl_tasaInteres.Text = (IS.TasaDeInteres * 100).ToString()+"%";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
