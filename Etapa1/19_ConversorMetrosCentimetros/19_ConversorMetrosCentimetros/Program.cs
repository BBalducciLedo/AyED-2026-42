using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ConversorMetrosCentimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una medida en metros: ");
            int metros = int.Parse(Console.ReadLine());
            int centimetros = metros * 100;
            int milimetros = metros * 1000;
            Console.WriteLine("Su medida en centimetros es: " + centimetros + "cm");
            Console.WriteLine("Su medida en milimetros es: " + milimetros + "mm");
            Console.ReadKey();
        }
    }
}
