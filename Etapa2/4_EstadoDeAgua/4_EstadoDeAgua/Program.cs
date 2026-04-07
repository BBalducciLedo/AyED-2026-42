using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EstadoDeAgua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una temperatura en grados celcius: ");
            int valor = int.Parse(Console.ReadLine());
            if (valor <= 0)
            {
                Console.WriteLine("Se congela");
            }
            if (valor >= 100)
            {
                Console.WriteLine("Hierve");
            }
            if (valor >= 1 && valor <= 99)
            {
                Console.WriteLine("Está en estado líquido");
            }
            Console.ReadKey();
        }
    }
}
