using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_PresupuestoHospitalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el presupuesto anual: ");
            double presupuesto = double.Parse(Console.ReadLine());
            double gine = presupuesto * 0.40;
            double trauma = presupuesto * 0.30;
            double pediatra = presupuesto * 0.30;

            Console.WriteLine("El presupuesto anual que se distribuye en 40 %, 30 % y 30 %: ");
            Console.WriteLine("Ginecologia: $" + gine);
            Console.WriteLine("Traumatología: $" + trauma);
            Console.WriteLine("Pediatría: $" + pediatra);

            Console.ReadKey();
        }
    }
}
