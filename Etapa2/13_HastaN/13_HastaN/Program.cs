using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un valor: ");
            int n = int.Parse(Console.ReadLine());
            int cont = 1;
            while (cont < n + 1) 
            {
                if (cont % 2 == 0)
                {
                    Console.WriteLine(cont);
                }
                cont += 1;
            }
            Console.ReadKey();
        }
    }
}
