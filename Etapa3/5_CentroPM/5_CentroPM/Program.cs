using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CentroPM
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0;
            int[] vidasPokemon = new int[6];
            int registro = 0;
            while (opcion != 13)
            {

                Console.WriteLine("----Bienvenido al Centro Poke-Remedio----");
                Console.WriteLine("----MENU----");
                Console.WriteLine("1: Registar nuevo pokemon");
                Console.WriteLine("2: Mostrar la vida de todos los pokemones");
                Console.WriteLine("3: Curar pokemon");
                Console.WriteLine("4: Dañar pokemon");
                Console.WriteLine("5: Curar a todos los pokemones");
                Console.WriteLine("6: Mostrar pokemones debilitados");
                Console.WriteLine("7: Mostrar el pokémon con mayor vida");
                Console.WriteLine("8: Mostrar el pokémon con menor vida");
                Console.WriteLine("9: Calcular promedio de vida del equipo");
                Console.WriteLine("10: Ordenar pokemones por vida de menor a mayor");
                Console.WriteLine("11: Ordenar pokemones por vida de mayor a menor");
                Console.WriteLine("12: Simular ataque enemigo a todo el equipo");
                Console.WriteLine("13: Salir");
                Console.WriteLine("");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        if (registro != 6)
                        {

                            Console.WriteLine("Cuantos puntos de vida tiene su pokemon?: ");
                            vidasPokemon[registro] = int.Parse(Console.ReadLine());
                            while (vidasPokemon[registro] > 100 || vidasPokemon[registro] < 0)
                            {
                                Console.WriteLine("El valor no es correcto vuelva a intentarlo");
                                Console.WriteLine("Cuantos puntos de vida tiene su pokemon?: ");
                                vidasPokemon[registro] = int.Parse(Console.ReadLine());
                            }
                            registro++;
                            Console.WriteLine("");
                            Console.WriteLine("Pokemon guardado correctamente en la posciion: " + (registro - 1));
                            Console.WriteLine("");

                        }
                        else if (registro == 6)
                        {
                            Console.Clear();
                            Console.WriteLine("No hay suficiente espacio en el centro");
                            Console.WriteLine("");
                        }


                        break;

                    case 2:
                        Console.Clear();
                        if (registro == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados");
                            Console.WriteLine("");
                        }

                        for (int i = 0; i < registro; i++)
                        {
                            Console.WriteLine("Pokemon " + i + " - Vida: " + vidasPokemon[i]);
                            Console.WriteLine("");
                        }
                        break;

                    case 3:
                        Console.Clear();
                        if (registro == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados");
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.WriteLine("");
                            Console.ReadKey();
                            break;
                        }

                        Console.WriteLine("Ingrese la posicion del pokemon que desees curar: ");
                        int curar_poke = int.Parse(Console.ReadLine());
                        if (curar_poke >= 0 && curar_poke < registro)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese los puntos que quiere curar: ");
                            int puntos_curar = int.Parse(Console.ReadLine());

                            vidasPokemon[curar_poke] += puntos_curar;

                            if (vidasPokemon[curar_poke] > 100)
                            {
                                vidasPokemon[curar_poke] = 100;
                            }
                            Console.WriteLine("");
                            Console.WriteLine("El pokemon fue curado");
                            Console.WriteLine("Vida del pokemon: " + vidasPokemon[curar_poke]);
                            Console.WriteLine("");
                        }

                        else
                        {
                            Console.WriteLine("El pokemon no esta registrado");
                            Console.WriteLine("");
                        }
                        break;

                    case 4:
                        Console.Clear();
                        if (registro == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados");
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.WriteLine("");
                            Console.ReadKey();
                            break;
                        }

                        Console.WriteLine("Ingrese la posicion del pokemon atacado: ");
                        int dañar_pokemon = int.Parse(Console.ReadLine());

                        if (dañar_pokemon >= 0 && dañar_pokemon < registro)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese el daño recibido: ");
                            int daño = int.Parse(Console.ReadLine());

                            vidasPokemon[dañar_pokemon] -= daño;

                            if (vidasPokemon[dañar_pokemon] < 0)
                            {
                                vidasPokemon[dañar_pokemon] = 0;
                            }

                            Console.WriteLine("");
                            Console.WriteLine("El pokemon recibio daño. Vida actual: " + vidasPokemon[dañar_pokemon]);
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("El pokemon no esta registrado");
                            Console.WriteLine("");
                        }
                        break;

                    case 5:
                        Console.Clear();
                        if (registro == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados");
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.WriteLine("");
                            Console.ReadKey();
                            break;
                        }

                        Console.WriteLine("Ingrese los puntos de curacion general: ");
                        int curacion = int.Parse(Console.ReadLine());

                        for (int i = 0; i < registro; i++)
                        {
                            vidasPokemon[i] += curacion;

                            if (vidasPokemon[i] > 100)
                            {
                                vidasPokemon[i] = 100;
                            }
                        }

                        Console.WriteLine("");
                        Console.WriteLine("Todos los pokemones fueron curados");
                        break;

                    case 6:
                        if (registro == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados");
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.WriteLine("");
                            Console.ReadKey();
                            break;
                        }

                        int pokemones_debilitados = 0;

                        Console.WriteLine("Pokemones debilitados: ");

                        for (int i = 0; i < registro; i++)
                        {
                            if (vidasPokemon[i] == 0)
                            {
                                Console.WriteLine("Pokemon en posicion: " + i);
                                Console.WriteLine("");
                                pokemones_debilitados++;
                            }
                        }

                        if (pokemones_debilitados > 0)
                        {
                            Console.WriteLine("Total de debilitados: " + pokemones_debilitados);
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("No hay pokemones debilitados");
                        }
                        break;

                    case 7:
                        Console.Clear();
                        if (registro == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados");
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.WriteLine("");
                            Console.ReadKey();
                            break;
                        }

                        int mayor_vida = vidasPokemon[0];
                        int posicion_mayor = 0;

                        for (int i = 0; i < registro; i++)
                        {
                            if (vidasPokemon[i] > mayor_vida)
                            {
                                mayor_vida = vidasPokemon[i];
                                posicion_mayor = i;
                            }
                            
                        }

                        Console.WriteLine("El pokemon de mayor vida es: " + posicion_mayor);
                        Console.WriteLine("Vida: " + mayor_vida);
                        Console.WriteLine("");
                        break;

                    case 8:
                        Console.Clear();
                        if (registro == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados");
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.WriteLine("");
                            Console.ReadKey();
                            break;
                        }

                        int menor_vida = vidasPokemon[0];
                        int posicion_menor = 0;

                        for (int i = 0; i < registro; i++)
                        {
                            if (vidasPokemon[i] < menor_vida)
                            {
                                menor_vida = vidasPokemon[i];
                                posicion_menor = i;
                            }

                        }

                        Console.WriteLine("El pokemon de mayor vida es: " + posicion_menor);
                        Console.WriteLine("Vida: " + menor_vida);
                        Console.WriteLine("");
                        break;

                    case 9:
                        Console.Clear();
                        if (registro == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados");
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.WriteLine("");
                            Console.ReadKey();
                            break;
                        }

                        float suma = 0;
                        for (int i = 0; i < registro; i++)
                        {
                            suma += vidasPokemon[i];
                        }

                        float promedio = suma / registro;
                        Console.WriteLine("Promedio de vida del equipo: " + promedio);
                        Console.WriteLine("");

                        if (promedio >= 70)
                        {
                            Console.WriteLine("El equipo esta en buen estado");
                        }

                        else if (promedio >= 31 && promedio <= 69)
                        {
                            Console.WriteLine("El equipo nesecita curacion");
                        }

                        else
                        {
                            Console.WriteLine("El equipo esta en peligro");
                        }
                        break;

                    case 10:
                        Console.Clear();
                        if (registro == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados");
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.WriteLine("");
                            Console.ReadKey();
                            break;
                        }

                        for (int i = 0; i < registro; i++)
                        {
                            for (int j = 0; j < registro - i - 1; j++)
                            {
                                if (vidasPokemon[j] > vidasPokemon[j + 1])
                                {
                                    int a = vidasPokemon[j];
                                    vidasPokemon[j] = vidasPokemon[j + 1];
                                    vidasPokemon[j + 1] = a; 
                                }
                            }
                        }

                        Console.WriteLine("Vidas ordenadas de menor a mayor:");
                        for (int i = 0; i < registro; i++)
                        {
                            Console.WriteLine(vidasPokemon[i]);
                        }
                        break;

                    case 11:
                        Console.Clear();
                        if (registro == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados");
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.WriteLine("");
                            Console.ReadKey();
                            break;
                        }

                        for (int i = 0; i < registro; i++)
                        {
                            for (int j = 0; j < registro - i - 1; j++)
                            {
                                if (vidasPokemon[j] < vidasPokemon[j + 1])
                                {
                                    int a = vidasPokemon[j];
                                    vidasPokemon[j] = vidasPokemon[j + 1];
                                    vidasPokemon[j + 1] = a;
                                }
                            }
                        }

                        Console.WriteLine("Vidas ordenadas de mayor a menor:");
                        for (int i = 0; i < registro; i++)
                        {
                            Console.WriteLine(vidasPokemon[i]);
                        }
                        break;

                    case 12:
                        Console.Clear();
                        if (registro == 0)
                        {
                            Console.WriteLine("No hay pokemones registrados");
                            Console.WriteLine("Presione cualquier tecla para continuar");
                            Console.WriteLine("");
                            Console.ReadKey();
                            break;
                        }

                        Random aleatorio = new Random();

                        int daño_recibido = aleatorio.Next(5, 26);

                        Console.WriteLine("¡Un pokémon salvaje atacó al equipo!");
                        Console.WriteLine("Daño recibido por todos:");

                        for (int i = 0; i < registro; i++)
                        {
                            vidasPokemon[i] -= daño_recibido;

                            if (vidasPokemon[i] < 0)
                            {
                                vidasPokemon[i] = 0;
                            }
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Las vidas fueron actualizadas.");
                        break;
                }
            }

            if (opcion == 13)
            {
                Console.Clear();
                Console.WriteLine("Gracias por utilizar el sistema Poke-Remedio");
                Console.WriteLine("Presione cualquier tecla para cerrar el programa");
                Console.ReadKey();
            }
        }
    }
}
