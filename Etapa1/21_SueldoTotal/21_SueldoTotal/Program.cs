using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_SueldoTotal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de horas que trabaja: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese lo que le pagan por hora: ");
            int valor = int.Parse(Console.ReadLine());
            float sueldo_total = horas * valor;
            Console.WriteLine("Su sueldo total es: " + sueldo_total + "$");
            Console.ReadKey();
        }
    }
}
