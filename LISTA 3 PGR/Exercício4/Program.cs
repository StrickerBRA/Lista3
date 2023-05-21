using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercício4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;
            int cont = 0;

            Console.WriteLine(" Exercício 4 da LISTA 3");

            do
            {
                cont++;
                valor = 5 * cont;
                Console.WriteLine("5 x {0} = {1}", cont, valor);

            } while (cont < 10);
        }
    }
}
