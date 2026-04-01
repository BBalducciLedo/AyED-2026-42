using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DobleYTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero entero: ");
            int numero = int.Parse(Console.ReadLine());
            int doble = numero * 2;
            int triple = numero * 3;
            Console.WriteLine("El doble del numero es: " + doble);
            Console.WriteLine("El triple del numero es: " + triple);
            Console.ReadKey();
        }
    }
}
