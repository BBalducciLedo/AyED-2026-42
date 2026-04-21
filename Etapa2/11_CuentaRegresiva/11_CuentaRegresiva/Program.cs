using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba un numero positivo: ");
            int num = int.Parse(Console.ReadLine());
            int cont = 0;
            while (num >= 0)
            {
                Console.WriteLine(num);
                num = num - 1;
            }
            Console.ReadKey();
        }
    }
}
