using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___AvengersAir
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] pasajeros = new string[80, 6];

            for (int i = 0; i < 80; i++)
            {
                pasajeros[i, 5] = "Libre";
            }

            int opcion = 0;

            do
            {
                Console.Clear();

                int disponibles = 0;
                for (int i = 0; i < 80; i++)
                {
                    if (pasajeros[i, 5] == "Libre")
                    {
                        disponibles++;
                    }
                }
                int ocupados = 80 - disponibles;

                Console.WriteLine("-----MENU-----");
                Console.WriteLine("");
                Console.WriteLine("Asientos disponibles: " + disponibles);
                Console.WriteLine("Asientos ocupados: " + ocupados);
                Console.WriteLine("");
                Console.WriteLine("1. Vender asiento");
                Console.WriteLine("2. Devolver asiento");
                Console.WriteLine("3. Modificar asiento");
                Console.WriteLine("4. Calcular ventas");
                Console.WriteLine("5. Buscar pasajeros por edad");
                Console.WriteLine("6. Obtener asientos con DNI par");
                Console.WriteLine("7. Salir ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Ingrese su numero de asiento (1, 80): ");
                        int asiento = int.Parse(Console.ReadLine());
                        int indice = asiento - 1;

                        if (indice >= 0 && indice < 80 && pasajeros[indice, 5] == "Libre")
                        {
                            Console.Write("Ingrese su nombre: ");
                            pasajeros[indice, 0] = Console.ReadLine();
                            Console.Write("Ingrese su apellido: ");
                            pasajeros[indice, 1] = Console.ReadLine();
                            Console.Write("Ingrese su edad: ");
                            pasajeros[indice, 2] = Console.ReadLine();
                            Console.Write("Ingrese su DNI: ");
                            pasajeros[indice, 3] = Console.ReadLine();
                            Console.Write("Ingrese su nacionalidad: ");
                            pasajeros[indice, 4] = Console.ReadLine();

                            pasajeros[indice, 5] = "Ocupado";
                            Console.WriteLine("Asiento vendido");
                        }
                        else
                        {
                            Console.WriteLine("Asiento no disponible");
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Ingrese el numero del asiento que quiere devolver(1, 80): ");
                        int asiento2 = int.Parse(Console.ReadLine()) - 1;

                        if (asiento2 >= 0 && asiento2 < 80)
                        {
                            if (pasajeros[asiento2, 5] == "Ocupado")
                            {
                                pasajeros[asiento2, 0] = "";
                                pasajeros[asiento2, 1] = "";
                                pasajeros[asiento2, 2] = "";
                                pasajeros[asiento2, 3] = "";
                                pasajeros[asiento2, 4] = "";
                                pasajeros[asiento2, 5] = "Libre";

                                Console.WriteLine("El asiento esta disponible ahora");
                            }
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("Ingrese su numero de asiento a modificar(1, 80): ");
                        int modificar = int.Parse(Console.ReadLine());

                        if (modificar >= 0 && modificar < 80 && pasajeros[modificar, 5] == "Ocupado")
                        {
                            Console.Write("Ingrese su nuevo nombre: ");
                            pasajeros[modificar, 0] = Console.ReadLine();
                            Console.Write("Ingrese su nuevo apellido: ");
                            pasajeros[modificar, 1] = Console.ReadLine();
                            Console.Write("Ingrese su nueva edad: ");
                            pasajeros[modificar, 2] = Console.ReadLine();
                            Console.Write("Ingrese su nuevo DNI: ");
                            pasajeros[modificar, 3] = Console.ReadLine();
                            Console.Write("Ingrese su nueva nacionalidad: ");
                            pasajeros[modificar, 4] = Console.ReadLine();

                            Console.WriteLine("Datos actualizados");
                        }
                        else
                        {
                            Console.WriteLine("Asiento no disponible");
                        }
                        break;

                    case 4:
                        Console.Clear();
                        int total_caja = 0;
                        for (int i = 0; i < 80; i++)
                        {
                            if (pasajeros[i, 5] == "Ocupado")
                            {
                                int n_asiento = i + 1;
                                if (n_asiento <= 20) total_caja += 200;
                                else if (n_asiento == 40 || n_asiento == 41 || n_asiento == 42 || n_asiento == 43) total_caja += 80;
                            }
                        }
                        Console.WriteLine("Recaudacion total: $" + total_caja);
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.Clear();
                        Console.Write("Ingrese la edad a buscar: ");
                        string edad = Console.ReadLine();
                        bool pasajero = false;

                        for (int i = 0; i < 80; i++)
                        {
                            if (pasajeros[i, 5] == "Ocupado" && pasajeros[i, 2] == edad)
                            {
                                Console.WriteLine("Asiento " + (i + 1) + ": " + pasajeros[i, 0] + " " + pasajeros[i, 1]);
                                pasajero = true;
                            }
                        }
                        if (pasajero == false)
                        {
                            Console.WriteLine("No se encontraron pasajeros con esa edad");
                        }
                        Console.ReadKey();
                        break;

                    case 6:
                        Console.Clear();
                        for (int i = 0; i < 80; i++)
                        {
                            if (pasajeros[i, 5] == "Ocupado")
                            {
                                int dni = int.Parse(pasajeros[i, 3]);
                                if (dni % 2 == 0)
                                {
                                    Console.WriteLine("Asiento " + (i + 1) + " - DNI: " + dni + " - " + pasajeros[i, 0]);
                                }
                            }
                        }
                        Console.ReadKey();
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("Saliendo del programa");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        Console.ReadKey();
                        break;
                }
            }
            while (opcion != 7);
        }
    }
}
