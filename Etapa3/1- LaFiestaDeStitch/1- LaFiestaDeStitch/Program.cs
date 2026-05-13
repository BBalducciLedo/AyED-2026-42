using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int comida = 0;
            int tmp = 0;
            Console.WriteLine("Ingrese la cantidad de invitados: ");
            int[] invitados = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < invitados.Length; i++)
            {
                Console.WriteLine("Ingrese la cantidad del invitado " + (i + 1) + ":");
                tmp = int.Parse(Console.ReadLine());
                while (tmp < 1 || tmp > 100)
                {
                    Console.WriteLine("Valor invalido");
                    Console.WriteLine("Intentelo de nuevo");
                    tmp = int.Parse(Console.ReadLine());
                }
                comida += tmp;
                invitados[i] = tmp;
            }
            int promedio = comida / invitados.Length;
            Console.WriteLine("El promedio de lo que comen los invitados es: " + promedio);
            Console.ReadKey();
        }
    }
}
