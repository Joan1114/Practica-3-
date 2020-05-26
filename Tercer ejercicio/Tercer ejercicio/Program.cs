using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tercer_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;
            int multiplo;

            Console.Write("Digite el primer dato: ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("DIgite el segundo dato: ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            multiplo = Num1 / Num2;

            if (multiplo == 0)
            {
                Console.WriteLine("\nEl segundo dato es multiplo del primero ");
            }
            else
            {
                Console.WriteLine("\nEl segundo dato no es multiplo del primero ");
            }
            Console.WriteLine("\nPulse una tecla para continuar");
            Console.ReadKey();

        }
    }
}
