using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        double numero;

        public string SetNumero
        {
            set { this.numero = ValidarNumero(value); }
        }

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            double num;
            if (double.TryParse(numero, out num))
                this.numero = num;
            else
                this.numero = 0;
        }

        private double ValidarNumero(string strNumero)
        {
            double valueReturn;
            if (!double.TryParse(strNumero, out valueReturn))
            {
                valueReturn = 0;
            }
            return valueReturn;
        }

        static private bool EsBinario(string binario)
        {
            bool retorno = true;
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }

        static public string BinarioDecimal(string binario)
        {
            string retorno = "Valor Invalido";
            if (EsBinario(binario))
            {
                retorno = Convert.ToInt32(binario, 2).ToString();
            }
            return retorno;
        }

        static public string DecimalBinario(double numero)
        {
            string retorno = "Valor Invalido";
            if (numero >= 0)
            {
                int num = (int)numero;
                retorno = Convert.ToString(num, 2);
            }
            return retorno;
        }

        static public string DecimalBinario(string numero)
        {
            string retorno = "Valor Invalido";
            double numAux;
            if (double.TryParse(numero, out numAux))
            {
                retorno = DecimalBinario(numAux);
            }
            return retorno;
        }

        public static double operator +(Numero numero1, Numero numero2)
        {
            return numero1.numero + numero2.numero;
        }

        public static double operator -(Numero numero1, Numero numero2)
        {
            return numero1.numero - numero2.numero;
        }

        public static double operator *(Numero numero1, Numero numero2)
        {
            return numero1.numero * numero2.numero;
        }

        public static double operator /(Numero numero1, Numero numero2)
        {
            double retorno;
            if (numero2.numero == 0)
                retorno = double.MinValue;
            else
                retorno = numero1.numero / numero2.numero;

            return retorno;
        }
    }
}
