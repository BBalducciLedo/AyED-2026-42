using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Calculando
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Introduce un segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Elije una opcion:");
            Console.WriteLine("1.Sumar");
            Console.WriteLine("2.Restar");
            Console.WriteLine("3.Dividir");
            Console.WriteLine("4.Multiplicar");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine(Sumar(numero, numero2));
                    break;


                case 2:
                    Console.WriteLine(Restar(numero, numero2));
                    break;

                case 3:
                    Console.WriteLine(Dividir(numero, numero2));
                    break;

                case 4:
                    Console.WriteLine(Multiplicar(numero, numero2));
                    break;

                default:
                    Console.WriteLine("No es una operacion valida");
                    break;
            }
            Console.ReadKey();
        }
        static int Sumar(int n1, int n2)
        {
            Console.WriteLine("");
            return n1 + n2;
        }

        static int Restar(int n1, int n2)
        {
            Console.WriteLine("");
            return n1 - n2;
        }

        static int Dividir(int n1, int n2)
        {
            Console.WriteLine("");
            return n1 / n2;
        }

        static int Multiplicar(int n1, int n2)
        {
            Console.WriteLine("");
            return n1 * n2;
        }
    }
}
