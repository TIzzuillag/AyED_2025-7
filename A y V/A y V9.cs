using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int devolver;
            int precio;
            int todo = 0;
            int[] farmacia = new int[10];


            for (int i = 0; i < farmacia.Length; i++)
            {

                Console.Write("Ingrese el precio del pducto " + (i + 1) + " : ");

                precio = Convert.ToInt32(Console.ReadLine());
                if (precio > 0)
                {
                    farmacia[i] = precio;
                }
                else
                {
                    Console.WriteLine("Ingrese un monto");
                    i--;
                }
            }
            foreach (int total in farmacia)
            {
                todo = todo + total;
            }
            Console.WriteLine("el precio recaudado del dia: " + todo + " pesos");
            Console.Write("Ingrese el producto que quiera devolver: ");
            devolver = Convert.ToInt32(Console.ReadLine());
            devolver = devolver - 1;
            Console.WriteLine("el precio de ese producto es de: " + farmacia[devolver] + " pesos");
            farmacia[devolver] = 0;
            todo = 0;
            foreach (int total in farmacia)
            {
                todo = todo + total;


            }
            Console.WriteLine("el precio recaudado del dia menos ese producto es de: " + todo + " pesos");
        }

    }
}

