using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_CelciusFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un valor en Grados Celcius: ");
            double Celcius = int.Parse(Console.ReadLine());
            double Kelvin = Celcius + 273.15;
            double Fahrenheit = (Celcius * 1.8) + 32;
            Console.WriteLine("Los grados Kelvin son: " + Kelvin);
            Console.WriteLine("Los grados Fahrenheit son: " + Fahrenheit);
            Console.ReadKey();
        }
    }
}
