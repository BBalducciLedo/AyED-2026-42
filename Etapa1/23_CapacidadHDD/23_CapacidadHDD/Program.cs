using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_CapacidadHDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una cantidad de cilindros en bytes: ");
            int bytes = int.Parse(Console.ReadLine());
            int kb = bytes / 1024;
            int mg = kb / 1024;
            int gb = mg / 1024;
            Console.WriteLine("Sus cilindros en kilobytes: " + kb);
            Console.WriteLine("Sus cilindros en megabytes: " + mg);
            Console.WriteLine("Sus cilindros en gigabytes: " + gb);
            Console.ReadKey();
        }
    }
}
