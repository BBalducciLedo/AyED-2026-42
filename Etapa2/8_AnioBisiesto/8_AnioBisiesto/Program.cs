using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_AnioBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un año: ");
            int anio = int.Parse(Console.ReadLine());
            if (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0)
            {
                Console.Write("El año es bisiesto");
            }
            else
            {
                Console.Write("El año no es bisiesto");
            }
            Console.ReadKey();
        }
    }
}
