using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercício8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cont = 0;
            double result = 0;

            Console.WriteLine(" Exercício 8 da Lista 3 ");

            do
            {
                cont++;
                result = result + cont;

            } while (cont < 100);

            Console.WriteLine("A Soma dos Números Interiros Positivos no Itervalo de 1 a 100 é: {0}", result);
        }
    }
}
