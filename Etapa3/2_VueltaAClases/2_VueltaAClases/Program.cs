using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp = 0;
            int ex_total = 0;
            int tps_aprob = 0;
            Console.WriteLine("Ingrese la cantidad de TPs hechos: ");
            int[] tps = new int[int.Parse(Console.ReadLine())];
            Console.WriteLine("Ingrese la cantidad de examenes hechos: ");
            int[] exa = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < tps.Length; i++)
            {
                Console.WriteLine("Ingrese la nota del TP " + (i + 1) + ": ");
                tmp = int.Parse(Console.ReadLine());
                while (tmp < 0 || tmp > 10)
                {
                    Console.WriteLine("Valor invalido");
                    Console.WriteLine("Intentelo otra vez");
                    tmp = int.Parse(Console.ReadLine());
                }
                tps[i] = tmp;
            }
            for (int i = 0; i < exa.Length; i++)
            {
                Console.WriteLine("Ingrese la nota del examen " + (i + 1) + ": ");
                tmp = int.Parse(Console.ReadLine());
                while (tmp < 0 || tmp > 10)
                {
                    Console.WriteLine("Valor invalido");
                    Console.WriteLine("Intentelo otra vez");
                    tmp = int.Parse(Console.ReadLine());
                }
                exa[i] = tmp;
                ex_total += tmp;
            }
            float promedio = ex_total / exa.Length;
            for (int i = 0; i < tps.Length; i++)
            {
                if (tps[i] >= 6)
                {
                    tps_aprob++;
                }
            }
            tmp = tps_aprob * 100;
            float por_tps = tmp / tps.Length;
            Console.WriteLine("El porcentaje de TPs aprobados es: " + por_tps + " y el promedio de examenes es: " + promedio);
            if (promedio >= 6 && por_tps >= 75)
            {
                Console.WriteLine("Aprobaste la materia");
            }
            else
            {
                Console.WriteLine("No aprobaste la materia");
            }
            Console.ReadKey();
        }
    }
}
