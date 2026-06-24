using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___MatrizAleatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de filas: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor minimo: ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor maximo ");
            int max = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, m];
            Random aleatorio = new Random();
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = aleatorio.Next(min, max + 1);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j  < m; j ++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
