using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el ancho de un rectangulo: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura de un rectangulo: ");
            int y = int.Parse(Console.ReadLine());
            int perimetro = 2 * (x + y);
            int area = x * y;
            double diagonal = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine("El perimetro del rectangulo es: " + perimetro);
            Console.WriteLine("El area del rectangulo es: " + area);
            Console.WriteLine("La diagonal del rectangulo es: " + diagonal);
            Console.ReadKey();
        }
    }
}
