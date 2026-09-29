using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___El_EterNota
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] refugios = new int[20, 5];
            int cantidadRefugios = 0;

            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("==== MENÚ DEL ETERNOTA ====");
                Console.WriteLine("1. Agregar refugio");
                Console.WriteLine("2. Mostrar todos los refugios");
                Console.WriteLine("3. Ocupar refugio");
                Console.WriteLine("4. Mostrar ocupados");
                Console.WriteLine("5. Refugio con más suministros");
                Console.WriteLine("6. Promedio por zona");
                Console.WriteLine("7. Filtrar por zona");
                Console.WriteLine("8. Salir");
                Console.Write("Opción: ");

                string entradaMenu = Console.ReadLine();
                if (!int.TryParse(entradaMenu, out opcion))
                {
                    opcion = 0;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("--- AGREGAR NUEVO REFUGIO ---");

                        if (cantidadRefugios >= 20)
                        {
                            Console.WriteLine("No hay refugios... ¡Vamos a morir!.");
                        }
                        else
                        {
                            int codigo = 0;
                            int capacidad = 0;
                            int suministros = 0;
                            int zona = 0;
                            bool esValido;

                            do
                            {
                                esValido = true;
                                Console.Write("Ingrese Código de Refugio (numérico): ");
                                if (!int.TryParse(Console.ReadLine(), out codigo) || codigo <= 0)
                                {
                                    Console.WriteLine("El código debe ser un entero positivo.");
                                    esValido = false;
                                }
                                else
                                {
                                    for (int i = 0; i < cantidadRefugios; i++)
                                    {
                                        if (refugios[i, 0] == codigo)
                                        {
                                            Console.WriteLine("Error: Ya existe un refugio registrado con ese código.");
                                            esValido = false;
                                            break;
                                        }
                                    }
                                }
                            } while (!esValido);

                            do
                            {
                                esValido = true;
                                Console.Write("Ingrese Capacidad Máxima: ");
                                if (!int.TryParse(Console.ReadLine(), out capacidad) || capacidad <= 0)
                                {
                                    Console.WriteLine("No se puede sobrevivir debiendo...");
                                    esValido = false;
                                }
                            } while (!esValido);

                            do
                            {
                                esValido = true;
                                Console.Write("Ingrese Suministros Disponibles: ");
                                if (!int.TryParse(Console.ReadLine(), out suministros) || suministros <= 0)
                                {
                                    Console.WriteLine("No se puede sobrevivir debiendo...");
                                    esValido = false;
                                }
                            } while (!esValido);

                            do
                            {
                                esValido = true;
                                Console.WriteLine("Zonas: 1 = NORTE (Congreso) | 2 = SUR (Constitución) | 3 = OESTE (Flores) | 4 = CENTRO (Microcentro)");
                                Console.Write("Seleccione Zona (1-4): ");
                                if (!int.TryParse(Console.ReadLine(), out zona) || zona < 1 || zona > 4)
                                {
                                    Console.WriteLine("Zona invàlida, esa parte ya està perdida");
                                    esValido = false;
                                }
                            } while (!esValido);

                            refugios[cantidadRefugios, 0] = codigo;
                            refugios[cantidadRefugios, 1] = capacidad;
                            refugios[cantidadRefugios, 2] = suministros;
                            refugios[cantidadRefugios, 3] = zona;
                            refugios[cantidadRefugios, 4] = 0;

                            cantidadRefugios++;
                            Console.WriteLine("\n¡Refugio registrado exitosamente en la red de resistencia!");
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("--- LISTA DE TODOS LOS REFUGIOS ---");
                        if (cantidadRefugios == 0)
                        {
                            Console.WriteLine("No hay refugios registrados en el sistema.");
                        }
                        else
                        {
                            for (int i = 0; i < cantidadRefugios; i++)
                            {
                                string nombreZona = "";
                                switch (refugios[i, 3])
                                {
                                    case 1: nombreZona = "NORTE (Congreso)"; break;
                                    case 2: nombreZona = "SUR (Constitución)"; break;
                                    case 3: nombreZona = "OESTE (Flores)"; break;
                                    case 4: nombreZona = "CENTRO (Microcentro)"; break;
                                }

                                string estadoOcupado = (refugios[i, 4] == 1) ? "Sí" : "No";

                                Console.WriteLine($"Código: {refugios[i, 0]} | Capacidad: {refugios[i, 1]} | Suministros: {refugios[i, 2]} | Zona: {nombreZona} | Ocupado: {estadoOcupado}");
                            }
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("--- OCUPAR UN REFUGIO ---");

                        if (cantidadRefugios == 0)
                        {
                            Console.WriteLine("No hay refugios registrados en el sistema.");
                        }
                        else
                        {
                            int desocupados = 0;
                            Console.WriteLine("Refugios disponibles (NO ocupados):");
                            for (int i = 0; i < cantidadRefugios; i++)
                            {
                                if (refugios[i, 4] == 0)
                                {
                                    string nombreZona = "";
                                    switch (refugios[i, 3])
                                    {
                                        case 1: nombreZona = "NORTE (Congreso)"; break;
                                        case 2: nombreZona = "SUR (Constitución)"; break;
                                        case 3: nombreZona = "OESTE (Flores)"; break;
                                        case 4: nombreZona = "CENTRO (Microcentro)"; break;
                                    }

                                    Console.WriteLine($" - Código: {refugios[i, 0]} | Capacidad: {refugios[i, 1]} | Suministros: {refugios[i, 2]} | Zona: {nombreZona}");
                                    desocupados++;
                                }
                            }

                            if (desocupados == 0)
                            {
                                Console.WriteLine("No hay refugios disponibles para ocupar en este momento.");
                            }
                            else
                            {
                                bool seleccionadoConExito = false;
                                do
                                {
                                    Console.Write("\nIngrese el Código del refugio a ocupar: ");
                                    int codSeleccionado;
                                    if (!int.TryParse(Console.ReadLine(), out codSeleccionado))
                                    {
                                        Console.WriteLine("Código inválido. Intente de nuevo.");
                                        continue;
                                    }

                                    int indiceEncontrado = -1;
                                    for (int i = 0; i < cantidadRefugios; i++)
                                    {
                                        if (refugios[i, 0] == codSeleccionado)
                                        {
                                            indiceEncontrado = i;
                                            break;
                                        }
                                    }

                                    if (indiceEncontrado == -1)
                                    {
                                        Console.WriteLine("El código ingresado no corresponde a ningún refugio registrado.");
                                    }
                                    else if (refugios[indiceEncontrado, 4] == 1)
                                    {
                                        Console.WriteLine("No somos Okupas, esto ya està ocupado");
                                    }
                                    else
                                    {
                                        refugios[indiceEncontrado, 4] = 1;
                                        Console.WriteLine($"¡El refugio #{codSeleccionado} ha sido marcado como OCUPADO con éxito!");
                                        seleccionadoConExito = true;
                                    }
                                } while (!seleccionadoConExito);
                            }
                        }
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("--- REFUGIOS OCUPADOS ---");
                        int ocupadosContador = 0;

                        for (int i = 0; i < cantidadRefugios; i++)
                        {
                            if (refugios[i, 4] == 1)
                            {
                                string nombreZona = "";
                                switch (refugios[i, 3])
                                {
                                    case 1: nombreZona = "NORTE (Congreso)"; break;
                                    case 2: nombreZona = "SUR (Constitución)"; break;
                                    case 3: nombreZona = "OESTE (Flores)"; break;
                                    case 4: nombreZona = "CENTRO (Microcentro)"; break;
                                }

                                Console.WriteLine($"Código: {refugios[i, 0]} | Capacidad: {refugios[i, 1]} | Suministros: {refugios[i, 2]} | Zona: {nombreZona}");
                                ocupadosContador++;
                            }
                        }

                        if (ocupadosContador == 0)
                        {
                            Console.WriteLine("No hay ningún refugio ocupado actualmente.");
                        }
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("--- REFUGIO CON MÁS SUMINISTROS ---");

                        if (cantidadRefugios == 0)
                        {
                            Console.WriteLine("No hay refugios registrados.");
                        }
                        else
                        {
                            int maxSuministros = refugios[0, 2];
                            int conMismoMaximo = 0;

                            for (int i = 1; i < cantidadRefugios; i++)
                            {
                                if (refugios[i, 2] > maxSuministros)
                                {
                                    maxSuministros = refugios[i, 2];
                                }
                            }

                            for (int i = 0; i < cantidadRefugios; i++)
                            {
                                if (refugios[i, 2] == maxSuministros)
                                {
                                    conMismoMaximo++;
                                }
                            }

                            if (conMismoMaximo > 1)
                            {
                                Console.WriteLine($"Aclaración: Se encontraron {conMismoMaximo} refugios empatados con la cantidad máxima de {maxSuministros} suministros:\n");
                            }
                            else
                            {
                                Console.WriteLine($"El refugio con mayor cantidad de suministros ({maxSuministros}) es:\n");
                            }

                            for (int i = 0; i < cantidadRefugios; i++)
                            {
                                if (refugios[i, 2] == maxSuministros)
                                {
                                    string nombreZona = "";
                                    switch (refugios[i, 3])
                                    {
                                        case 1: nombreZona = "NORTE (Congreso)"; break;
                                        case 2: nombreZona = "SUR (Constitución)"; break;
                                        case 3: nombreZona = "OESTE (Flores)"; break;
                                        case 4: nombreZona = "CENTRO (Microcentro)"; break;
                                    }

                                    string estadoOcupado = (refugios[i, 4] == 1) ? "Sí" : "No";
                                    Console.WriteLine($"Código: {refugios[i, 0]} | Capacidad: {refugios[i, 1]} | Suministros: {refugios[i, 2]} | Zona: {nombreZona} | Ocupado: {estadoOcupado}");
                                }
                            }
                        }
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("--- PROMEDIO DE CAPACIDAD POR ZONA ---");

                        if (cantidadRefugios == 0)
                        {
                            Console.WriteLine("No hay refugios registrados.");
                        }
                        else
                        {
                            for (int z = 1; z <= 4; z++)
                            {
                                int sumaCapacidad = 0;
                                int contadorZona = 0;

                                for (int i = 0; i < cantidadRefugios; i++)
                                {
                                    if (refugios[i, 3] == z)
                                    {
                                        sumaCapacidad += refugios[i, 1];
                                        contadorZona++;
                                    }
                                }

                                string nombreZona = "";
                                switch (z)
                                {
                                    case 1: nombreZona = "NORTE (Congreso)"; break;
                                    case 2: nombreZona = "SUR (Constitución)"; break;
                                    case 3: nombreZona = "OESTE (Flores)"; break;
                                    case 4: nombreZona = "CENTRO (Microcentro)"; break;
                                }

                                if (contadorZona > 0)
                                {
                                    double promedio = (double)sumaCapacidad / contadorZona;
                                    Console.WriteLine($"Zona {z} - {nombreZona}: Promedio de Capacidad = {promedio:F2} personas ({contadorZona} refugio/s registrado/s)");
                                }
                                else
                                {
                                    Console.WriteLine($"Zona {z} - {nombreZona}: No posee refugios registrados.");
                                }
                            }
                        }
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("--- FILTRAR REFUGIOS POR ZONA ---");

                        if (cantidadRefugios == 0)
                        {
                            Console.WriteLine("No hay refugios registrados.");
                        }
                        else
                        {
                            int zonaBuscar = 0;
                            bool zonaValida = false;

                            do
                            {
                                Console.WriteLine("Zonas: 1 = NORTE | 2 = SUR | 3 = OESTE | 4 = CENTRO");
                                Console.Write("Ingrese la zona a filtrar (1-4): ");
                                if (!int.TryParse(Console.ReadLine(), out zonaBuscar) || zonaBuscar < 1 || zonaBuscar > 4)
                                {
                                    Console.WriteLine("Zona invàlida, esa parte ya està perdida\n");
                                }
                                else
                                {
                                    zonaValida = true;
                                }
                            } while (!zonaValida);

                            int encontrados = 0;
                            Console.WriteLine($"\nRefugios registrados en la Zona {zonaBuscar}:");

                            for (int i = 0; i < cantidadRefugios; i++)
                            {
                                if (refugios[i, 3] == zonaBuscar)
                                {
                                    string nombreZona = "";
                                    switch (refugios[i, 3])
                                    {
                                        case 1: nombreZona = "NORTE (Congreso)"; break;
                                        case 2: nombreZona = "SUR (Constitución)"; break;
                                        case 3: nombreZona = "OESTE (Flores)"; break;
                                        case 4: nombreZona = "CENTRO (Microcentro)"; break;
                                    }

                                    string estadoOcupado = (refugios[i, 4] == 1) ? "Sí" : "No";
                                    Console.WriteLine($"Código: {refugios[i, 0]} | Capacidad: {refugios[i, 1]} | Suministros: {refugios[i, 2]} | Zona: {nombreZona} | Ocupado: {estadoOcupado}");
                                    encontrados++;
                                }
                            }

                            if (encontrados == 0)
                            {
                                Console.WriteLine("No se encontraron refugios en esta zona.");
                            }
                        }
                        break;

                    case 8:
                        Console.WriteLine("Saliendo del sistema... ¡Que la nevada no te atrape!");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 8);
        }
    }
}
