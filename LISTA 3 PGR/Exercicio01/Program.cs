using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;

            Console.WriteLine(" Exercício 1 da LISTA 3");

            do
            {
                Console.Write(" Digite o valor");
                valor = double.Parse(Console.ReadLine());
            } while (valor < 0);
        }
    }
}
