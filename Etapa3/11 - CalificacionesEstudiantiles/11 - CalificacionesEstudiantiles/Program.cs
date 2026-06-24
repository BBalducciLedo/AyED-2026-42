using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___CalificacionesEstudiantiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de estudiantes: ");
            int n = int.Parse(Console.ReadLine());

            string[,] estudiantes = new string[n , 3];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Datos estudiante " + (i + 1) + ":");

                Console.Write("Nombre: ");
                estudiantes[i, 0] = Console.ReadLine();

                Console.Write("Edad: ");
                estudiantes[i, 1] = Console.ReadLine();

                Console.Write("Calificacion: ");
                estudiantes[i, 2] = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Lista de estudiantes:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(estudiantes[i, 0] + " " + estudiantes[i, 1] + " " + estudiantes[i, 2]);
            }
            Console.ReadKey();
        }
    }
}
