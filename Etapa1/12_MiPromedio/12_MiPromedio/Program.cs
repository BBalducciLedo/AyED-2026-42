using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_MiPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro numero: ");
            int numero3 = int.Parse(Console.ReadLine());
            double promedio = (numero1 + numero2 + numero3) / 3;
            Console.WriteLine("Su promedio es: " + promedio);
            Console.ReadKey();
        }
    }
}
