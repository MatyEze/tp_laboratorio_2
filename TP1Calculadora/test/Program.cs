using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero(4);
            Numero numero1 = new Numero("2");

            string num = Numero.DecimalBinario(1998);
            double numTest2 = numero * numero1;
            Console.WriteLine(numTest2);
            Console.ReadKey();
           
        }
    }
}
