using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = Factorial();
            Console.WriteLine("El factorial es: " + resultado);
        }

        static int Factorial()
        {
            int contador = 1;
            int factorial = 1;
            int num;

            Console.Write("Ingrese un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (contador <= num)
            {
                factorial = factorial * contador;
                contador++;
            }

            return factorial;
        }
    }
}


