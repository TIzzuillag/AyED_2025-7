using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero");
            int numero = Convert.ToInt32(Console.ReadLine());

            do
            {



                if (numero % 2 == 0)
                {
                    Console.WriteLine("los numeros pares son " + numero);
                }

                numero--;

            } while (numero > 1);
        }
    }
}
