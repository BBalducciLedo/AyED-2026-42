using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_TipoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su primer lado: ");
            int lado1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese se segundo lado: ");
            int lado2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su tercer lado: ");
            int lado3 = int.Parse(Console.ReadLine());
            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 >lado1)
            {
                Console.WriteLine("Se puede formar un triamgulo");

                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Su triangulo es equilatero");
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("Su triangulo es isoceles");
                }
                else
                {
                    Console.WriteLine("Su triangulo es escaleno");
                }
            }
            else
            {
                Console.WriteLine("No se puede formar un triangulo");
            }
            Console.ReadKey();
        }
    }
}
