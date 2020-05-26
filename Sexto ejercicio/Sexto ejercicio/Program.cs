using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sexto_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1;
            int N2;
            int Result;

            Console.Write("Digite el primer numero: ");
            N1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el segundo numero: ");
            N2 = Convert.ToInt32(Console.ReadLine());

            if (N2 > 0)
            {
                Result = N1 / N2;
                Console.WriteLine("\n\nEl resultaado de la division es: " + Result);
            }
            else 
            {
                Console.WriteLine("Error: No se puede dividir entre 0 ");
            } 

            Console.ReadKey();
        }
    }
}
