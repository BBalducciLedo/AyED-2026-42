using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MiSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe un Numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Escriba otro Numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            int resultado = (numero1 + numero2);
            Console.WriteLine("El resultado de la suma es: " + resultado);
            Console.ReadKey();

        }
    }
}
