using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MiDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            float numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro numero: ");
            float numero2 = int.Parse(Console.ReadLine());
            float resultado = numero1 / numero2;
            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadKey();

        }
    }
}
