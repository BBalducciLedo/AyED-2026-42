using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___SumandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de las matrices: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz1 = new int[n, n];
            int[,] matriz2 = new int[n, n];
            int[,] matriz_suma = new int[n, n];

            Random aleatorio = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz1[i, j] = aleatorio.Next(1, 101);
                    Console.Write(matriz1[i, j] + " ");
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz2[i, j] = aleatorio.Next(1, 101);
                    Console.Write(matriz2[i, j] + " ");
                }
                Console.WriteLine("");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz_suma[i, j] = matriz1[i, j] + matriz2[i, j];
                    Console.Write(matriz_suma[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
