using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___MatrizRotada90
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de la matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz1 = new int[n, n];
            int[,] matriz2 = new int[n, n];

            Random aleatorio = new Random();

            Console.WriteLine("Matriz Normal");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz1[i, j] = aleatorio.Next(1, 10);
                    Console.Write(matriz1[i, j] + " ");

                }
                Console.WriteLine(" ");
            }
            
            Console.WriteLine("Matriz Rotada");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz2[j, n - 1 - i] = matriz1[i, j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz2[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
         
    }
}
