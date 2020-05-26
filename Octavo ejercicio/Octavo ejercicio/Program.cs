using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octavo_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;

            Console.Write("Digite el primer dato ");
            Num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite el segundo dato ");
            Num2 = int.Parse(Console.ReadLine());

            if (Num1 >= 0)
            {
                Console.WriteLine(Num1 + " Es positivo ");
            }
            else
            {
                Console.WriteLine(Num1 + " No es positivo ");
            } if (Num2 >= 0)
            {
                Console.WriteLine(Num2 + " Es positivo ");
            }
            else
            {
                Console.WriteLine(Num2 + " No es positivo");
            } 
            Console.ReadKey();
        }
    }
}
