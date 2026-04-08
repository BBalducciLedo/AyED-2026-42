using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Apocalipsis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tenes comida? (si/no): ");
            string comida = Console.ReadLine().ToLower();
            Console.WriteLine("Tenes refugio? (si/no): ");
            string refugio = Console.ReadLine().ToLower();
            Console.WriteLine("Tenes agua? (si/no): ");
            string agua = Console.ReadLine().ToLower();
            Console.WriteLine("Tenes un botiquin? (si/no): ");
            string botiquin = Console.ReadLine().ToLower();
            Console.WriteLine("Tenes mochila? (si/no): ");
            string mochila = Console.ReadLine().ToLower();
            bool tenes_comida = (comida == "si");
            bool tenes_refugio = (refugio == "si");
            bool tenes_agua = (agua == "si");
            bool tenes_botiquin = (botiquin == "si");
            bool tenes_mochila = (mochila == "si");
            if (tenes_comida && tenes_agua && tenes_botiquin)
            {
                Console.Write("Sobrevivis al apocalipsis");
            }
            else if (tenes_mochila && tenes_comida) {
                Console.Write("Sobrevivis al apocalipsis");
            }
            else if (tenes_mochila && tenes_refugio)
            {
                Console.Write("No sobrevivis al apocalipsis");
            }
            else if (tenes_refugio && tenes_agua)
            {
                Console.Write("Sobrevivis al apocalipsis");
            }
            else
            {
                Console.Write("No sobrevivis al apocalipsis");
            }
            Console.ReadKey();
        }
    }
}
