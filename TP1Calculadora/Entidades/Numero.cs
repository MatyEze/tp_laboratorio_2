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

        /// <summary>
        /// toma un string, y setea el valor del numero, si el string pasado no es un numero se setea en 0
        /// </summary>
        public string SetNumero
        {
            set { this.numero = ValidarNumero(value); }
        }
        /// <summary>
        /// crea un Numero y se setea su valor en 0
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// crea un Numero y setea su valor dependiendo del double pasado
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        ///  crea un Numero y setea su valor dependiendo del string pasado (si el string no es valido su valor se setea en 0)
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero) 
        {
            this.SetNumero = numero;
        }

        /// <summary>
        /// recibe un string para transformarlo y retornarlo si no lo logra retorna 0
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarNumero(string strNumero)
        {
            double valueReturn;
            double.TryParse(strNumero, out valueReturn);
            return valueReturn;
        }

        /// <summary>
        /// recibe un numero en forma de string y verifica si es binario
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>retorna true si es binario, false si no lo es</returns>
        static private bool EsBinario(string binario)
        {
            bool retorno = true;
            if (binario == string.Empty)
                retorno = false;

            //recorro el string para verificar que solo haya 0 y 1
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

        /// <summary>
        /// recibe un numero binario en forma de string (se verifica que lo sea) y lo transforma a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>devuelve un string con el numero en decimal, o "valor invalido" si el string ingresado no era un binario</returns>
        static public string BinarioDecimal(string binario)
        {
            string retorno = "Valor Invalido";
            if (EsBinario(binario))
            {
                retorno = Convert.ToInt32(binario, 2).ToString();
            }
            return retorno;
        }

        /// <summary>
        /// recibe un double y si se trata de un numero positivo lo transforma a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>retorna el binario en froma de string, si el valor ingresado no era el correcto devuelve "valor invalido"</returns>
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

        /// <summary>
        /// recibe un string y si se trata de un numero positivo lo transforma a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>retorna el binario en froma de string, si el valor ingresado no era el correcto devuelve "valor invalido"</returns>
        static public string DecimalBinario(string numero)
        {
            string retorno = "Valor Invalido";
            double numAux;
            if (double.TryParse(numero, out numAux)) //verifico que sea un numero y lo transformo a double
            {
                retorno = DecimalBinario(numAux);
            }
            return retorno;
        }

        /// <summary>
        /// suma y retorna los valores de dos Numeros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns>resultado (double)</returns>
        public static double operator +(Numero numero1, Numero numero2)
        {
            return numero1.numero + numero2.numero;
        }

        /// <summary>
        /// resta y retorna los valores de dos Numeros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns>resultado (double)</returns>
        public static double operator -(Numero numero1, Numero numero2)
        {
            return numero1.numero - numero2.numero;
        }

        /// <summary>
        /// multiplica y retorna los valores de dos Numeros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns>resultado (double)</returns>
        public static double operator *(Numero numero1, Numero numero2)
        {
            return numero1.numero * numero2.numero;
        }

        /// <summary>
        /// divide y retorna los valores de dos Numeros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns>resultado (double), si se divide por 0 retorna double.MinValue</returns>
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
