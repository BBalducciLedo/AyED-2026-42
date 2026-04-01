using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_DimensionDeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un Radio: ");
            double radio = int.Parse(Console.ReadLine());
            double pi = 3.14159265;
            double superficie = 4 * pi * radio * radio;
            double volumen =4 * pi * Math.Pow( radio,3)/3;
            Console.WriteLine("La Superficie del Radio es: " + superficie);
            Console.WriteLine("El Volumen del Radio es: " + volumen);
            Console.ReadKey();
        }
    }
}
