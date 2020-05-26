using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noveno_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.Write("Digite el primer numero: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite el segundo numero: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite el tercer numero: ");
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("\nEl numero mayor es " + a);
                }
            }

            if (b > a && b > c)
            {
                Console.WriteLine("\nEl numero mayor es " + b);
            }

            if (c > a && c > b)
            {
                Console.WriteLine("\nEl numero mayor es " + c);
            }


            Console.ReadKey();

        }
    }
}
