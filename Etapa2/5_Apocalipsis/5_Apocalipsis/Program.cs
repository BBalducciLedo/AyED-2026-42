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
            Console.WriteLine("Tenes comida? (SI/NO): ");
            bool comida = bool.Parse(Console.ReadLine());
            Console.WriteLine("Tenes refugio? (SI/NO): ");
            bool refugio = bool.Parse(Console.ReadLine());
            Console.WriteLine("Tenes un bate? (SI/NO): ");
            bool bate = bool.Parse(Console.ReadLine());
            Console.WriteLine("Tenes agua? (SI/NO): ");
            bool agua = bool.Parse(Console.ReadLine());
            Console.WriteLine("Tenes un botiquin? (SI/NO): ");
            bool botiquin = bool.Parse(Console.ReadLine());
            Console.WriteLine("Tenes linterna? (SI/NO): ");
            bool linterna = bool.Parse(Console.ReadLine());
            Console.WriteLine("Tenes mochila? (SI/NO): ");
            bool mochila = bool.Parse(Console.ReadLine());
            Console.WriteLine("Tenes mechero? (SI/NO): ");
            bool mechero = bool.Parse(Console.ReadLine());
        }
    }
}
