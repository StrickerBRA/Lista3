using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício3Lista3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sexo;

            Console.WriteLine(" Exercício 3 da LISTA 3");

            do
            {
                Console.WriteLine(" Digite o Sexo: Para Feminino Digite (F) e Para Masculino Digite (M)");
                sexo = char.Parse(Console.ReadLine());

            } while (sexo != 'M' && sexo != 'F');
        }
    }
}
