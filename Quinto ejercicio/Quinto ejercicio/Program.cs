using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinto_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            int num;
            int Result;

            Console.Write("Digite el primer numero: ");
            Num = int.Parse(Console.ReadLine());

            if (Num > 0)
            {
                Console.Write("Digite el segundo numero: ");
                num = int.Parse(Console.ReadLine());
                Result = Num * num;
                Console.WriteLine("\nEl resultado del producto es: " + Result);
            }
            else
            {
                Console.WriteLine("El producto de 0 por cualquier numero es 0 ");
            }
            
            Console.ReadKey();
        }
    }
}
