using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_dibujo_csharp
{

    public partial class Form1 : Form
    {
        double _numero;
        bool _tipo;

        public double Numero { get => _numero; set => _numero = value; }
        public bool Tipo { get => _tipo; set => _tipo = value; }

        public Form1(Double n, bool tipo)
        {
            InitializeComponent();
            Numero = n;
            Tipo = tipo;
        }

        public void Dibujar(Double n, bool tipo)
        {
            Graphics papel = pictureBox1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            papel.DrawLine(lapiz, 60, 175, 560, 175);      
            int f = Convert.ToInt32(n)+1;
            int d = 500 / f;
            int c = 60;
            //dibujar recta
            for(int i=0; i <= f; i++)
            {              
                papel.DrawLine(lapiz, c+(d*i), 150, c + (d * i), 200);
            }
            //cuando tipo es true quiere decir que es ganancia
            if(tipo == true)
            {
                papel.DrawLine(lapiz, 60, 75, 60, 175);
                int pos = Convert.ToInt32(d * n);
                papel.DrawLine(lapiz, 60+pos, 175, 60+pos, 250);
            } else
            {
                papel.DrawLine(lapiz, 60, 175, 60, 250);
                int pos = Convert.ToInt32(d * n);
                papel.DrawLine(lapiz, 60 + pos, 75, 60 + pos, 175);
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
        }
    }
}
