using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPerfecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Perfecto();
        }

        static void Perfecto()
        {
            int num;
            int suma = 0;

            Console.Write("Ingrese un numero entero positivo: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    suma += i;
                }
            }

            if (suma == num)
            {
                Console.WriteLine("El numero es perfecto.");
            }
            else
            {
                Console.WriteLine("El numero no es perfecto.");
            }
        }
    }
}
