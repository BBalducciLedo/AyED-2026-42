using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");
            string msg = "ctOS";
            string enc = Level4.CaesarPlusOne(msg);
            bool ok = enc == "duPT"; // c->d, t->u, O->P, S->T
            Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");
            Console.ReadKey();
        }
    }

    static class Level4
    {
        public static string CaesarPlusOne(string s)
        {
            // TODO: implementar
            // Reglas: letras rotan (z→a, Z→A), mantener may/min; otros chars, igual.
            char[] result = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (c >= 'a' && c <= 'z')
                {
                    result[i] = (char)('a' + (c - 'a' + 1) % 26);
                }
                else if (c >= 'A' && c <= 'Z')
                {
                    result[i] = (char)('A' + (c - 'A' + 1) % 26);
                }
                else
                {
                    result[i] = c;
                }
            }

            return new string(result);
        }
    }
}
