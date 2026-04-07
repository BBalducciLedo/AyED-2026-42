using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_BecasJuanPedro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese sus ingresos mensuales: ");
            int ingresos = int.Parse(Console.ReadLine());
            if (edad > 19 && ingresos <= 100000 || edad < 19 && ingresos == 0 || edad == 19 && ingresos <= 50000){
                Console.WriteLine("Puede tener la beca");
                }
            else {
                Console.WriteLine("No puede tener la beca");
            }
            
            Console.ReadKey();
        }
    }
}
