using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuarto_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            int Num;
            int num;
            int Result;

            Console.Write("Ingrese el numero ");
            Num = int.Parse(Console.ReadLine());

            Result = Num % 10;

            if (Result == 0)
            {
                Console.WriteLine("\n" + Num + " Es multiplo de 10");
                Console.Write("\nDigite el segundo numero ");
                num = int.Parse(Console.ReadLine());
                Result = num % 10; 
            }
            else
            {
                Console.WriteLine("\n\nEl numero no es multiplo de 10, por ende pulse cualquier tecla para finalizar");
            }
            if (Result == 0)
            {
                Console.WriteLine("Tambien es multiplo de 10");
            }
            else
            {
                Console.WriteLine("\nEste no es multiplo de 10");
            }
            Console.ReadKey();
        }
    }
}
