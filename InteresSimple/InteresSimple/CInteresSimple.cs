using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteresSimple
{
    public class CInteresSimple
    {
        //atributos 
        double _interes;
        double _tasaDeInteres;
        double _capitalInicial;
        double _valorFinal;
        double _numPeriodos;
        bool _ganPer;
        //Propiedades
        public double Interes { get => _interes; set => _interes = value; }
        public double TasaDeInteres { get => _tasaDeInteres; set => _tasaDeInteres = value; }
        public double CapitalInicial { get => _capitalInicial; set => _capitalInicial = value; }
        public double ValorFinal { get => _valorFinal; set => _valorFinal = value; }
        public double NumPeriodos { get => _numPeriodos; set => _numPeriodos = value; }
        public bool GanPer { get => _ganPer; set => _ganPer = value; }

        //Método
        public void calcularInteres()
        {
            Interes = Math.Round(CapitalInicial * TasaDeInteres * NumPeriodos,2);
        }

        public void calcularTasaInteres()
        {
            if(Interes != 0)
            {
                TasaDeInteres = Math.Round(Interes / (CapitalInicial * NumPeriodos),2);
            }else
            {
                TasaDeInteres = Math.Round(((ValorFinal / CapitalInicial) - 1) / NumPeriodos,2);
            }
        }

        public void calcularCapitalInicial()
        {
            if (Interes != 0)
            {
                CapitalInicial = Math.Round(Interes / (TasaDeInteres * NumPeriodos),2);
            }
            else
            {
                CapitalInicial = Math.Round(ValorFinal / (1 + TasaDeInteres * NumPeriodos),2);
            }
        }

        public void calcularNumPeriodos()
        {
            if (Interes != 0)
            {
                NumPeriodos = Math.Round(Interes / (CapitalInicial * TasaDeInteres));
            }
            else
            {
                NumPeriodos = Math.Round(((ValorFinal / CapitalInicial) - 1) / TasaDeInteres,2);
            }
        }
        public void calcularValorFinal()
        {
            if (Interes != 0)
            {
                ValorFinal = Math.Round(CapitalInicial + Interes,2);
            }
            else
            {
                ValorFinal = Math.Round(CapitalInicial * (1 + TasaDeInteres * NumPeriodos),2);
            }
        }
    }

        
}