using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static public class Calculadora
    {
        static private string ValidarOperador(char operador)
        {
            string retorno = "+";
            if(operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                retorno = Convert.ToString(operador);
            }
            return retorno;
        }

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
