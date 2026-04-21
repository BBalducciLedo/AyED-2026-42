using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Vuelto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el total de sus compras: ");
            int total = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el dinero entregado de sus compras: ");
            int entregado = int.Parse(Console.ReadLine());
            int vuelto = entregado - total;
            int billete_diezmil = 0;
            int billete_dosmil = 0;
            int billete_mil = 0;
            int billete_quinientos = 0;
            int billete_doscientos = 0;
            int billete_cien = 0;
            int billete_cincuenta = 0;
            int billete_veinte = 0;
            int billete_diez = 0;
            int billete_uno = 0;
            while (entregado < total)
            {
                Console.WriteLine("Te falta plata");
                Console.Write("Ingrese el total de sus compras: ");
                total = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el dinero entregado de sus compras: ");
                entregado = int.Parse(Console.ReadLine());
            }
            while (vuelto != 0) { 
                    if (vuelto >= 10000)
                    {
                        vuelto -= 10000;
                        billete_diezmil += 1;
                        
                    }
                    else if (vuelto >= 2000)
                    {
                        vuelto -= 2000;
                        billete_dosmil += 1;
                        
                    }
                    else if (vuelto >= 1000)
                    {
                        vuelto -= 1000;
                        billete_mil += 1;
                        
                    }
                    else if (vuelto >= 500)
                    {
                        vuelto -= 500;
                        billete_quinientos += 1;
                        
                    }
                    else if (vuelto >= 200)
                    {
                        vuelto -= 200;
                        billete_doscientos += 1;
                        
                    }
                    else if (vuelto >= 100)
                    {
                        vuelto -= 100;
                        billete_cien += 1;
                        
                    }
                    else if (vuelto >= 50)
                    {
                        vuelto -= 50;
                        billete_cincuenta += 1;
                        
                    }
                    else if (vuelto >= 20)
                    {
                        vuelto -= 20;
                        billete_veinte += 1;
                        
                    }
                    else if (vuelto >= 10)
                    {
                        vuelto -= 10;
                        billete_diez += 1;
                        
                    }
                    else if (vuelto >= 1)
                    {
                        vuelto -= 1;
                        billete_uno += 1;
                        
                    }
                }
            Console.WriteLine("Billetes diez mil: " + billete_diezmil);
            Console.WriteLine("Billetes dos mil: " + billete_dosmil);
            Console.WriteLine("Billetes mil: " + billete_mil);
            Console.WriteLine("Billetes quinientos: " + billete_quinientos);
            Console.WriteLine("Billetes doscientos: " + billete_doscientos);
            Console.WriteLine("Billetes cien: " + billete_cien);
            Console.WriteLine("Billetes cincuenta: " + billete_cincuenta);
            Console.WriteLine("Billetes veinte: " + billete_veinte);
            Console.WriteLine("Billetes diez: " + billete_diez);
            Console.WriteLine("Billetes uno: " + billete_uno);

            if (entregado == total)
            {
                Console.Write("Pagaste bien");
            }
            
            Console.ReadKey();
        }
    }
}
