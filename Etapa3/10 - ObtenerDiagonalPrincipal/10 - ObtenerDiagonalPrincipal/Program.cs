using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___ObtenerDiagonalPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de la matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz1 = new int[n, n];
            int[] diagonal = new int[n];

            Random aleatorio = new Random();

            Console.WriteLine("Matriz:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz1[i, j] = aleatorio.Next(1, 10);
                    Console.Write(matriz1[i, j] + " ");
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < n; i++)
            {
                diagonal[i] = matriz1[i, i];
            }

            Console.WriteLine("Diagonal Principal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(diagonal[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
