using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1 = 0;
            double valor2 = 0;

            Console.WriteLine(" Exercício 2 da LISTA 3");

            Console.WriteLine(" Digite o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine(" Digite o segundo valor: ");
                valor2 = double.Parse(Console.ReadLine());
            } while(valor2 <= valor1);

        }
    }
}
