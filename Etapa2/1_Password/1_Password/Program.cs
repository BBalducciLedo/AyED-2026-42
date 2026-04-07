using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña = "xdloluwu";
            Console.Write("Ingrese la contraseña: ");
            string usuario = Console.ReadLine().ToLower();
            if(usuario == contraseña) {
                Console.WriteLine("La contraseña coincide");
                 }
            else {
                Console.WriteLine("La contraseña no coincide");
                 }
            Console.ReadKey();
        }
    }
}
