using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SimuladorJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            int vida = 10;
            int hambre = 10;
            int cant_dias = 1;
            int cant_comida_cru = 0;
            int cant_comida_co = 0;
            bool refugio = false;
            bool fogata = false;
            int materiales = 0;
            int opcion = 0;



            while (opcion != 8) 
            {
                Console.WriteLine("----ESTADISTICAS----");
                Console.WriteLine("Vida: " + vida);
                Console.WriteLine("Hambre:" + hambre);
                Console.WriteLine("Dias:" + cant_dias);
                Console.WriteLine("Comida cruda: " + cant_comida_cru);
                Console.WriteLine("Comida cocida: " + cant_comida_co);
                Console.WriteLine("Refugio: " + refugio);
                Console.WriteLine("Fogata: " + fogata);
                Console.WriteLine("Materiales: " + materiales);
                Console.WriteLine("");

                Console.WriteLine("----MENU----");
                Console.WriteLine("1: Buscar comida");
                Console.WriteLine("2: Explorar la isla");
                Console.WriteLine("3: Construir refugio");
                Console.WriteLine("4: Encender fogata");
                Console.WriteLine("5: Cocinar comida");
                Console.WriteLine("6: Comer comida cocida");
                Console.WriteLine("7: Descansar");
                Console.WriteLine("8: Salir");
                Console.WriteLine("");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Random comida = new Random();
                        int chan_comida = comida.Next(0, 100);
                        if (chan_comida < 40)
                        {
                            Console.Clear();
                            Console.WriteLine("No encontraste comida cruda");
                            Console.WriteLine("");
                            if (hambre > 0)
                            {
                                hambre -= 2;
                            }
                            else
                            {
                                vida -= 2;
                            }
                            cant_dias++;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Encontraste comida cruda");
                            Console.WriteLine("");
                            if (hambre > 0)
                            {
                                hambre -= 2;
                            }
                            else
                            {
                                vida -= 2;
                            }
                            cant_comida_cru += 2;
                            cant_dias++;
                        }
                        vida--;
                        break;

                    case 2:
                        Console.Clear();
                        Random explorar = new Random();
                        int chan_explo = explorar.Next(0, 100);
                        if (chan_explo > 50)
                        {
                            Console.Clear();
                            Console.WriteLine("Encontraste materiales");
                            Console.WriteLine("");
                            if (hambre > 0)
                            {
                                hambre -= 2;
                            }
                            else
                            {
                                vida -= 2;
                            }
                            cant_dias++;
                            materiales++;
                        }
                        else if (chan_explo < 30 && chan_explo > 20)
                        {
                            Console.Clear();
                            Console.WriteLine("No encontraste nada");
                            Console.WriteLine("");
                            if (hambre > 0)
                            {
                                hambre -= 2;
                            }
                            else
                            {
                                vida -= 2;
                            }
                            cant_dias++;
                        }
                        else if (chan_explo < 20)
                        {
                            Console.Clear();
                            Console.WriteLine("Te lastimaste");
                            Console.WriteLine("");
                            if (hambre > 0)
                            {
                                hambre -= 2;
                            }
                            else
                            {
                                vida -= 2;
                            }
                            cant_dias++;
                            vida -= 2;
                        }
                        break;

                    case 3:
                        if (refugio == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Ya tenes refugio");
                            Console.WriteLine("");
                        }
                        else if (materiales < 3)
                        {
                            Console.Clear();
                            Console.WriteLine("No tenes materiales para el refugio");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Construiste el refugio");
                            Console.WriteLine("");
                            if (hambre > 0)
                            {
                                hambre -= 2;
                            }
                            else
                            {
                                vida -= 2;
                            }
                            cant_dias++;
                            materiales -= 3;
                            refugio = true;
                        }
                        break;

                    case 4:
                        if (fogata == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Ya tenes fogata");
                            Console.WriteLine("");
                            
                        }
                        else if (materiales < 0)
                        {
                            Console.Clear();
                            Console.WriteLine("No tenes materiales para la fogata");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Construiste la fogata");
                            Console.WriteLine("");
                            if (hambre > 0)
                            {
                                hambre -= 2;
                            }
                            else
                            {
                                vida -= 2;
                            }
                            cant_dias++;
                            materiales -= 1;
                            fogata = true;
                        }
                        break;

                    case 5:
                        if (fogata == true && cant_comida_cru >= 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Cocinaste la comida con exito");
                            Console.WriteLine("");
                            if (hambre > 0)
                            {
                                hambre -= 2;
                            }
                            else
                            {
                                vida -= 2;
                            }
                            cant_comida_co++;
                            cant_comida_cru--;
                            cant_dias++;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No puedes cocinar comida");
                            Console.WriteLine("");
                        }
                        break;

                    case 6:
                        if (cant_comida_co >= 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Comiste");
                            Console.WriteLine("");
                            cant_dias++;
                            cant_comida_co--;
                            hambre += 4;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("No puedes comer");
                            Console.WriteLine("");
                        }
                        break;

                    case 7:
                        if (refugio == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Dormiste");
                            Console.WriteLine("");
                            if (hambre > 0)
                            {
                                hambre -= 2;
                            }
                            else
                            {
                                vida -= 2;
                            }
                            cant_dias++;
                            vida += 3;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Dormiste");
                            Console.WriteLine("");
                            if (hambre > 0)
                            {
                                hambre -= 2;
                            }
                            else
                            {
                                vida -= 2;
                            }

                            cant_dias++;
                            vida++;
                        }
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida");
                        Console.WriteLine("");
                        break;
                }
                if (vida > 10)
                {
                    vida = 10;
                }
                if (vida < 0)
                {
                    vida = 0;
                }
                if (hambre > 10)
                {
                    hambre = 10;
                }
                if (hambre < 0)
                {
                    hambre = 0;
                }
                if (vida < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Perdiste el juego");
                    Console.WriteLine("");
                    opcion = 8;
                }
            }
            Console.WriteLine("Gracias por jugar");
            Console.WriteLine("Toque cualquier tecla");
            Console.ReadKey();
        }
    }
}
