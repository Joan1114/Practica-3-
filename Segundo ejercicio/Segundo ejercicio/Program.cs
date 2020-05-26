using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un programa que pida al usuario dos numeros enteros y diga cual de los dos es mayor

            int a;
            int b;

            Console.Write("DIgite el primer numero a comparar: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite el segundo numero a comparar: ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("El numero mayor es: " + a);
            }
            else
            {
                Console.WriteLine("El numero mayos es: " + b);
            } Console.ReadKey();
            
        }
    }
}
