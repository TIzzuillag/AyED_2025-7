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
            Console.Write("ingrese el dinero ");
            int plata = 0;
            int guardado = 0;

            do

            {
                Console.Write("Cuanta plata hay");
                plata = Convert.ToInt32(Console.ReadLine());

                guardado = guardado + plata;


            } while (plata > 0 );

            Console.WriteLine("La cantidad de plata guardada es de:" + guardado);
        }
    }
}
