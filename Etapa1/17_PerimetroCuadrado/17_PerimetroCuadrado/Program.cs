using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PerimetroCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresen la longitud de su cuadrado: ");
            int longitud = int.Parse(Console.ReadLine());
            double perimetro = 4 * longitud;
            double superficie = Math.Pow(longitud, 2);
            Console.WriteLine("El perimetro de su cuadrado es: " + perimetro);
            Console.WriteLine("La superficie de su cuadrado es: " + superficie);
            Console.ReadKey();
        }
    }
}
