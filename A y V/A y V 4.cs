using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            int billetera;
            int precio;
            int[] kiosco = new int[8];


            for (int i = 0; i < kiosco.Length; i++)
            {

                Console.Write("Ingrese el precio del producto " + (i + 1) + " : ");

                precio = Convert.ToInt32(Console.ReadLine());
                if (precio > 0)
                {
                    kiosco[i] = precio;

                }


                else
                {
                    Console.WriteLine("Ingrese un monto");
                    i--;
                }
            }
            Console.Write("¿Cuanto dinero tiene?:");
            billetera = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kiosco.Length; i++)
            {

                if (kiosco[i] <= billetera)
                {
                    int alcanza = billetera / kiosco[i];


                    Console.WriteLine("Puede comprar " + alcanza + " del producto" + (i + 1));

                }
                else
                {
                    Console.WriteLine("No puede comprar el producto" + (i + 1));
                }
            }
        }
    }
}
