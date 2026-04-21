using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_WhileYWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.WriteLine("Numeros impares del 0 al 100");
            while (contador < 101)
            {
              if (contador % 2 != 0)
                {
                    Console.WriteLine(contador);
                }
                contador += 1;
            }
            Console.WriteLine("Numeros pares del 0 al 100");
            contador = 0;
            while (contador < 101)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador += 1;
            }
            contador = 0;
            Console.WriteLine("Numeros del 0 al 100");
            while (contador < 101)
            {
                Console.WriteLine(contador);
                contador += 1;
            }
            contador = 100;
            Console.WriteLine("Numeros del 100 al 0");
            while (contador > -1)
            {               
                Console.WriteLine(contador);
                contador -= 1;
            }
            Console.WriteLine("Numeros multiplos de 3 del 0 al 100");
            contador = 0;
            while (contador < 101)
            {
                if (contador % 3 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador += 1;
            }
            Console.WriteLine("Numeros multiplos de 3 y 2 del 0 al 100");
            contador = 0;
            while (contador < 101)
            {
                if (contador % 2 == 0 && contador % 3 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador += 1;
            }
            Console.ReadKey();
        }
    }
}
