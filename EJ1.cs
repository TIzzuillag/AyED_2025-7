using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int correcto = 42;
            Console.WriteLine("ADIVINA EL NUMERO");
            int num;
            int intentos = 0;
            do
            {

                num = Convert.ToInt32(Console.ReadLine());
               if (num>correcto)
                {
                    Console.WriteLine("el numero es menor");
                    intentos++;
                }
                if (num < correcto)
                {
                    Console.WriteLine("el numero es mayor");
                    intentos++;
                }
            } while (num != correcto && intentos!=5 );
            if (intentos == 5)
            {
                Console.WriteLine("te excedite en intentos");
            }
            if (intentos < 5)
            {
                Console.WriteLine("CORRECTO");
                Console.WriteLine("lo resolviste en " + intentos + " intentos");
            }
        }
    }
}
