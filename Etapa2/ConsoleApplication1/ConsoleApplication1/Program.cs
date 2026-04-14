using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Teclea un numero(0 para salir): ");
            numero = Convert.ToInt32(Console.ReadLine());
            while(numero != 0)
                {
                if(numero % 2 == 0)
                    {
                    Console.WriteLine("es par");
                    }
                    
                else
                    {
                    Console.WriteLine("es impaar");
                    }
                Console.Write("Teclea otro (0 para salir): ");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.ReadKey();
        }        

    }
}
