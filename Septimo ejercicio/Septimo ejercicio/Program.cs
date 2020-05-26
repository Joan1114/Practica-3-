
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Septimo_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            int resultado;
            int result;

            Console.Write("Digite el numero: ");
            Num = int.Parse(Console.ReadLine());

            resultado = Num % 4;
            result = Num % 5;

            if (resultado == 0)
            {
                Console.WriteLine("\n" + Num + " Es multiplo de 4 ");
            }
            else
            {
                Console.WriteLine("\n" + Num + " No es multiplo de 4 ");
            } if (result == 0)
            {
                Console.WriteLine("\n" + Num + " Es multiplo de 5 ");
            }
            else
            {
                Console.WriteLine("\n" + Num + " No es multiplo de 5 ");
            }  
            Console.ReadKey();

        }
    }
}
