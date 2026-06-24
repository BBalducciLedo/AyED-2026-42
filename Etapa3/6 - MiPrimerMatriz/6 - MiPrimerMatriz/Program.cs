using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___MiPrimerMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de filas: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de columnas: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, m];
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey(); 
        }
    }
}
