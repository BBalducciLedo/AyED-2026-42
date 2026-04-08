using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_MonedasDelNivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneda_oro = 10;
            int moneda_plata = 2;
            Console.WriteLine("Cuantas monedas de oro consiguio?: ");
            int contador_monedasoro = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantas monedas de plata consiguio?: ");
            int contador_monedasplata = int.Parse(Console.ReadLine());
            int puntaje_oro = moneda_oro * contador_monedasoro;
            int puntaje_plata = moneda_plata * contador_monedasplata;
            int total = puntaje_oro + puntaje_plata;
            if (total < 50)
            {
                Console.WriteLine("Nivel insuficiente");
            }
            else if (total > 49 && total < 100)
            {
                Console.WriteLine("Nivel superado");
            }
            else if (total > 99)
            {
                Console.WriteLine("Nivel superado con bonus");
            }
            Console.ReadKey();
        }
    }
}
