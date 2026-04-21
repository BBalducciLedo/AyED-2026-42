using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escriba su edad: ");
            int edad = int.Parse(Console.ReadLine());
            int cont_edad = 1;
            while (cont_edad <= edad)
            {
                Console.WriteLine(cont_edad);
                cont_edad += 1;
            }
            Console.ReadKey();
        }
    }
}
