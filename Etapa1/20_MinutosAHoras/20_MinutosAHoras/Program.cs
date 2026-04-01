using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_MinutosAHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una cantidad de minutos: ");
            int minutos = int.Parse(Console.ReadLine());
            int horas = minutos / 60;
            int minutos2 = minutos % 60;
            Console.WriteLine("Sus minutos equivalen a: " + horas + " horas y " + minutos2 + " minutos");
            Console.ReadKey();
        }
    }
}
