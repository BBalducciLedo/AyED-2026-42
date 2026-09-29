using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Balatrito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== MINI BALATRO ===");
            Console.WriteLine();

            // Generar una mano aleatoria de 5 cartas
            string[] mano = GenerarManoAleatoria();

            // Analizar que tipo de mano se obtuvo
            string tipo = TipoDeMano(mano);

            // Calcular el valor de las cartas
            int basePts = PuntajeBase(mano);

            // Obtener el multiplicador de la jugada
            double mult = Multiplicador(tipo);

            // Calcular puntaje antes de Jokers
            double total = basePts * mult;

            // Jokers disponibles
            bool jokerX2 = true;
            bool jokerMas10 = true;

            // Aplicar los efectos de los Jokers
            total = AplicarJokers(total, jokerX2, jokerMas10);

            // Mostrar el resultado
            MostrarResumen(mano, tipo, basePts, mult, total);

            // Esperar a que el usuario presione una tecla antes de salir
            Console.ReadKey();
        }

        // ====================================================
        // CREAR TODAS LAS FUNCIONES NECESARIAS DEBAJO DEL MAIN
        // ====================================================

        static string[] GenerarManoAleatoria()
        {
            string[] rangos = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
            string[] palos = { "H", "D", "C", "S" };
            string[] mano = new string[5];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                int indiceRango = rnd.Next(0, rangos.Length);
                int indicePalo = rnd.Next(0, palos.Length);
                mano[i] = rangos[indiceRango] + palos[indicePalo];
            }

            return mano;
        }

        static string TipoDeMano(string[] mano)
        {
            int maxRepeticiones = 0;
            int cantidadTrio = 0;
            int cantidadPares = 0;

            for (int i = 0; i < mano.Length; i++)
            {
                char rangoActual = mano[i][0];
                int contador = 0;

                for (int j = 0; j < mano.Length; j++)
                {
                    if (mano[j][0] == rangoActual)
                    {
                        contador++;
                    }
                }

                if (contador > maxRepeticiones)
                {
                    maxRepeticiones = contador;
                }
            }

            for (int i = 0; i < mano.Length; i++)
            {
                bool yaContado = false;
                for (int k = 0; k < i; k++)
                {
                    if (mano[i][0] == mano[k][0])
                    {
                        yaContado = true;
                        break;
                    }
                }

                if (!yaContado)
                {
                    int contador = 0;
                    for (int j = 0; j < mano.Length; j++)
                    {
                        if (mano[j][0] == mano[i][0])
                        {
                            contador++;
                        }
                    }

                    if (contador == 3)
                    {
                        cantidadTrio++;
                    }
                    else if (contador == 2)
                    {
                        cantidadPares++;
                    }
                }
            }

            if (maxRepeticiones == 4)
            {
                return "Poker";
            }
            if (cantidadTrio == 1 && cantidadPares == 1)
            {
                return "Full";
            }
            if (maxRepeticiones == 3)
            {
                return "Trio";
            }
            if (maxRepeticiones == 2)
            {
                return "Par";
            }

            return "Nada";
        }

        static int PuntajeBase(string[] mano)
        {
            int suma = 0;

            for (int i = 0; i < mano.Length; i++)
            {
                char rango = mano[i][0];

                switch (rango)
                {
                    case 'A':
                        suma += 14;
                        break;
                    case 'K':
                        suma += 13;
                        break;
                    case 'Q':
                        suma += 12;
                        break;
                    case 'J':
                        suma += 11;
                        break;
                    case 'T':
                        suma += 10;
                        break;
                    default:
                        suma += (int)Char.GetNumericValue(rango);
                        break;
                }
            }

            return suma;
        }

        static double Multiplicador(string tipo)
        {
            switch (tipo)
            {
                case "Poker":
                    return 4.0;
                case "Full":
                    return 3.5;
                case "Trio":
                    return 2.5;
                case "Par":
                    return 1.5;
                default:
                    return 1.0;
            }
        }

        static double AplicarJokers(double puntaje, bool x2, bool mas10)
        {
            double resultado = puntaje;

            if (x2)
            {
                resultado *= 2;
            }

            if (mas10)
            {
                resultado += 10;
            }

            return resultado;
        }

        static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
        {
            Console.Write("Mano: ");
            for (int i = 0; i < mano.Length; i++)
            {
                Console.Write("[" + mano[i] + "] ");
            }
            Console.WriteLine();

            Console.WriteLine("Tipo de mano: " + tipo);
            Console.WriteLine("Puntaje base: " + basePts);
            Console.WriteLine("Multiplicador: x" + mult);
            Console.WriteLine("Puntaje final: " + total);
        }
    }
}
