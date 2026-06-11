using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio;
            double subtotal = 0;
            double descuento = 0;
            double total;

            Console.WriteLine("Ingrese los precios de los productos");

            do
            {
                Console.Write("Precio: ");
                precio = Convert.ToDouble(Console.ReadLine());

                if (precio > 0)
                {
                    subtotal += precio;
                }

            } while (precio != 0);

            if (subtotal > 15000)
            {
                descuento = subtotal * 0.10;
            }

            total = subtotal - descuento;


            Console.WriteLine("Subtotal: " + subtotal);
            Console.WriteLine("Descuento: " + descuento);
            Console.WriteLine("Total a pagar: " + total);
            Console.ReadKey();
        }
    }
}
    

