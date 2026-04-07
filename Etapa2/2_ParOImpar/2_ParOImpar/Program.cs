using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ParOImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero entero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0) {
                Console.WriteLine("El numero es par");
                if (numero == 0) { 
                Console.WriteLine("El numero es par");
                 }
                }
            else {
                Console.WriteLine("El numero es impar");
                  }
            Console.ReadKey();
        }
    }
}
