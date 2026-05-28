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
            int A;
            int B;
            int resultado = 0;
            int i = 1;

            Console.Write("Ingrese el valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());

            do
            {
                resultado = resultado + A;

                i++;

            } while (i <= B);

            Console.WriteLine("El resultado es " + resultado);
        }
    }
}
