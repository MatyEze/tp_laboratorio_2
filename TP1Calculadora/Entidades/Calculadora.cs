using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static public class Calculadora
    {
        /// <summary>
        /// metodo estatico que recibe un char verificando que sea un operador valido " (+) (-) (/) (*) " para retornarlo como string
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>retorna el operador en forma de string, si el char no era valido retorna "+"</returns>
        static private string ValidarOperador(char operador)
        {
            string retorno = "+";
            if(operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                retorno = Convert.ToString(operador);
            }
            return retorno;
        }

        /// <summary>
        /// metodo estatico que recibe dos Numeros y un operador en forma de string para realizar sus determinadas operaciones y devlolver el resultado
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador">operadores validos (+) (-) (/) (*)</param>
        /// <returns>resultado (double), si el operador es invalido realizara una suma</returns>
        static public double Operar(Numero num1, Numero num2, string operador)
        {
            double valueRet = 0;
            switch (ValidarOperador(Convert.ToChar(operador)))
            {
                case "+":
                    valueRet = num1 + num2;
                    break;
                case "-":
                    valueRet = num1 - num2;
                    break;
                case "*":
                    valueRet = num1 * num2;
                    break;
                case "/":
                    valueRet = num1 / num2;
                    break;
            }
            return valueRet;
        }
    }
}
