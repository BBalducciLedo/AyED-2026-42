using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la base de su triangulo: ");
            int basetriangulo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura de su triangulo: ");
            int altura = int.Parse(Console.ReadLine());
            double area = basetriangulo * altura / (2);
            Console.WriteLine("El area de su triangulo es: " + area);
            Console.ReadKey();

        }
    }
}
