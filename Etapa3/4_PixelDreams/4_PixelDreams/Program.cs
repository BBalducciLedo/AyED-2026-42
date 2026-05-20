using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de participantes: ");
            int[] participantes = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < participantes.Length; i++)
            {
                Console.WriteLine("Cuantos puntos hizo el participante " + (i + 1) + "?: ");
                participantes[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(participantes);
            Array.Reverse(participantes);
            for (int i = 0; i < participantes.Length; i++)
            {
                Console.WriteLine((i + 1) + "° lugar: " + participantes[i]);
            }
            Console.ReadKey();
        }
    }
}
