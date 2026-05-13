using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0___CargandoEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una edad para cada estudiante: ");
            int[] edades = new int[5];
            for (int i = 0; i < edades.Length; i++)
            {
                edades[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("La edad del estudiante " + (i + 1) + " es: " + edades[i]);
            }
            Console.ReadKey();

        }
    }
}
