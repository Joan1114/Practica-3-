using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que pida al usuario un numero entero y diga si es par.

            int numero;
            int q;
            double r;

            Console.Write("Digite el numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            q = numero / 2;
            r = (double)numero / 2;

            if (q - r == 0)
                Console.WriteLine("\nËl numero " + numero + " es par");
            else
                Console.WriteLine("\nEl numero " + numero + " no es par");

            Console.ReadKey();
        }
    }
}
