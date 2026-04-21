using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            while (cont < 101)
            {
                if (cont % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                if (cont % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                if (cont % 3 == 0 && cont % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                if (cont % 3 != 0 && cont % 5 != 0)
                {
                    Console.WriteLine(cont);
                }
                cont += 1;
            }
            Console.ReadKey();
        }
    }
}
