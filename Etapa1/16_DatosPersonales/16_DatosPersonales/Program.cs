using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_DatosPersonales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            string edad = Console.ReadLine();
            Console.Write("Ingrese su ciudad: ");
            string ciudad = Console.ReadLine();
            Console.WriteLine("Sus datos personales son: " + nombre + ", " + edad  + ", " + ciudad);
            Console.ReadKey();
        }
    }
}
