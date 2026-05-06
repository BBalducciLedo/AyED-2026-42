using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            int puntos = 0;
            int puntos_compu = 0;
            int partidas_ganadas = 0;
            int partidas_compu = 0;
            bool partida = false;
            int opcion = 0;
            int chan_carta;
            Random carta;

            while (opcion != 4)
            {
                if (partida == false)
                {
                    carta = new Random();
                    puntos = carta.Next(4, 21);
                    carta = new Random();
                    puntos_compu = carta.Next(4, 21);
                }
                Console.Clear();
                Console.WriteLine("----BLACKJACK SIMPLE----");
                Console.WriteLine("");
                Console.WriteLine("Partidas ganadas: " + partidas_ganadas);
                Console.WriteLine("Partidas perdidas: " + partidas_compu);
                Console.WriteLine("Puntaje del jugador: " + puntos);
                Console.WriteLine("");
                Console.WriteLine("1. Pedir carta");
                Console.WriteLine("2. Plantarse");
                Console.WriteLine("3. Ver reglas");
                Console.WriteLine("4. Salir");
                Console.WriteLine("");
                Console.WriteLine("Ingrese una opcion: ");
                partida = true;
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        carta = new Random();
                        chan_carta = carta.Next(2, 11);
                        if (chan_carta == 11)
                        {
                            if (puntos + 11 > 21)

                            {
                                chan_carta = 1;
                            }
                        }
                        puntos += chan_carta;
                        break;

                    case 2:
                        partida = false;
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("----REGLAS----");
                        Console.WriteLine("");
                        Console.WriteLine("• El jugador compite contra la computadora, que actúa como crupier.");
                        Console.WriteLine("• El objetivo es acercarse lo más posible a 21 puntos sin pasarse.");
                        Console.WriteLine("• Cada carta suma puntos al puntaje total del jugador o del crupier.");
                        Console.WriteLine("• Si el jugador supera los 21 puntos, pierde la partida automáticamente.");
                        Console.WriteLine("• Si el jugador decide plantarse, deja de pedir cartas y comienza el turno del crupier.");
                        Console.WriteLine("• El crupier debe pedir cartas automáticamente mientras tenga menos de 17 puntos.");
                        Console.WriteLine("• Cuando el crupier llega a 17 puntos o más, se planta.");
                        Console.WriteLine("• Si el crupier supera los 21 puntos, gana el jugador.");
                        Console.WriteLine("• Si ninguno se pasa de 21, gana quien tenga el puntaje más alto.");
                        Console.WriteLine("• Si ambos terminan con el mismo puntaje, la partida queda empatada.");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida)");
                        break;
                }
                if (puntos > 20)
                {
                    partida = false;
                    if(puntos > 21)
                    {
                        Console.WriteLine("Te pasate con " + puntos + " puntos");
                        Console.WriteLine("");
                    }
                }
                if (partida == false)
                {
                    while (puntos_compu < 17)
                    {
                        carta = new Random();
                        chan_carta = carta.Next(2, 11);
                        puntos_compu += chan_carta;
                    }
                    Console.WriteLine("Puntos crupier: " + puntos_compu);
                    Console.WriteLine("");

                    if (puntos_compu > puntos && puntos_compu < 22 || puntos > 21)
                    {
                        Console.WriteLine("Perdiste");
                        Console.WriteLine("");
                        partidas_compu++;
                    }
                    
                    else if (puntos == puntos_compu || puntos_compu > 21 && puntos > 21)
                    {
                        Console.WriteLine("Empataron");
                        Console.WriteLine("");
                    }
                    else if (puntos_compu > 21 || puntos > puntos_compu)
                    {
                        Console.WriteLine("Ganaste");
                        Console.WriteLine("");
                        partidas_ganadas++;
                    }
                    Console.WriteLine("Toque cualquier tecla");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("Gracias por jugar");
            Console.WriteLine("Toque cualquier tecla");
            Console.ReadKey();
        }
    }
}
