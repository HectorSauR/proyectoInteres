using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteresSimple
{
    class CInteresCompuesto
    {
        public double cantidadCapitalizada(double Inicial,double tasa,int tiempo)
        {
            double temp;

            temp = Math.Pow((1 + tasa), tiempo);

            temp = Inicial * temp;

            return Math.Round(temp, 2);
        }
        public double valorPresente(double final, double tasa, int tiempo)
        {
            double temp;

            temp = final / Math.Pow((1 + tasa), tiempo);

            return Math.Round(temp, 2);
        }
        public double valorPresenteXCapital(double periodos, double tasa, int tiempo)
        {
            double temp1,temp2,resul;

            temp1 = Math.Pow((1 + tasa), tiempo) - 1;

            temp2 = tasa*Math.Pow((1 + tasa), tiempo);

            resul = periodos * (temp1 / temp2);

            return Math.Round(resul, 2);
        }

        public double recuperacionCapital(double inicial, double tasa, int tiempo)
        {
            double temp1, temp2, resul;

            temp1 = Math.Pow((1 + tasa), tiempo) - 1;

            temp2 = tasa * Math.Pow((1 + tasa), tiempo);

            resul = inicial * (temp2 / temp1);

            return Math.Round(resul, 2);
        }

        public double valorCapitalizdo(double capital, double tasa, int tiempo)
        {
            double temp1, resul;

            temp1 = Math.Pow((1 + tasa), tiempo) - 1;

            resul = capital * (temp1 / tasa);

            return Math.Round(resul, 2);
        }

        public double fondoAmortizacion(double final, double tasa, int tiempo)
        {
            double temp1, resul;

            temp1 = Math.Pow((1 + tasa), tiempo) - 1;

            resul = final * (tasa / temp1);

            return Math.Round(resul, 2);
        }
        public double tiempoFinalPresente(double final, double tasa, double inicial)
        {
            double temp1,temp2, resul;

            temp1 = Math.Log(final / inicial);
            temp2 = Math.Log(1 + tasa);

            resul = temp1 / temp2;

            return Math.Round(resul, 2);
        }
        public double tiempoCapitalFinal(double final, double tasa, double capital)
        {
            double temp1, temp2, resul;

            temp1 = Math.Log((final * tasa / capital)+1);
            temp2 = Math.Log(1 + tasa);

            resul = temp1 / temp2;

            return Math.Round(resul, 2);
        }
        public double tiempoCapitalInicial(double inicial, double tasa, double capital)
        {
            double temp1, temp2, resul;

            temp1 = Math.Log((-inicial   * tasa / capital) + 1);
            temp2 = Math.Log(1 + tasa);

            resul = -(temp1 / temp2);

            return Math.Round(resul, 2);
        }

        public double tasaInicialFinal(double inicial, int tiempo, double final)
        {
            double temp1, temp2, resul;

            temp1 = final / inicial;
            temp2 = 1 / tiempo;

            resul = (Math.Pow(temp1,temp2)-1);

            return Math.Round(resul, 2);
        }
    }
}
