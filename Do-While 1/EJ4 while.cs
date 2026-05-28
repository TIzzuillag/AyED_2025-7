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
            int numero;
            int i = 1;

            Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));

                i++;

            } while (i <= 12);

        }
    }
}
