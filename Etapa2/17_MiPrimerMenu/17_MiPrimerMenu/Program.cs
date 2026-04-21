using System;

namespace _17_MiPrimerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, bienvenido al programa elige una de estas 3 opciones: 1)pizza, 2)pancho, 3)papitas 4)salir: ");
            int opcion = int.Parse(Console.ReadLine());
            while (opcion != 4)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Te gusta la pizza");
                        break;
                    case 2:
                        Console.WriteLine("Te gustan los panchos");
                        break;
                    case 3:
                        Console.WriteLine("Te gusta las papitas");
                        break;
                    default:
                        Console.WriteLine("Sos wachin");
                        break;
                }

                opcion = int.Parse(Console.ReadLine());
            }
        }
    }
}
