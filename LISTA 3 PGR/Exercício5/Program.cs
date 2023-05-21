using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício5Lista3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;
            double result = 0;
            int cont = 0;

            Console.WriteLine(" Exercício 5 da Lista 3 ");

            do
            {
                Console.WriteLine("Digtite um Valor:");
                valor = double.Parse(Console.ReadLine());

            } while (valor < 0);

            do
            {
                cont++;
                result = valor * cont;
                Console.WriteLine("{0} x {1} = {2}", cont, valor, result);

            } while (cont < 10);

        }
    }
}
