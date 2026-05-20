using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de productos comprados: ");
            int[] productos = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine("Cuanto te salio el producto " + (i + 1) + "?: ");
                productos[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(productos);
            Console.WriteLine("El producto mas barato salio $" + productos[0]);
            Console.WriteLine("El producto mas caro salio $" + productos[productos.Length - 1]);
            Console.ReadKey();
        }
    }
}
