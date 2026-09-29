using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Sumando2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Introduce un segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.Write(Sumar(numero, numero2));
            Console.ReadKey();
        }

        static int Sumar(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
