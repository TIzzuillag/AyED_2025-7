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

            int numero;
            int[] rifas = new int[15];
            int trifa;
            int vendida = 0;


            for (int i = 0; i < rifas.Length; i++)
            {

                Console.Write("Ingrese el numero de la rifa " + (i + 1) + " : ");

                numero = Convert.ToInt32(Console.ReadLine());
                if (numero > 0)
                {
                    rifas[i] = numero;
                }
                else
                {
                    Console.WriteLine("Ingrese un numero");
                    i--;
                }
            }



            Console.Write("Ingrese el numero de su rifa : ");

            trifa = Convert.ToInt32(Console.ReadLine());


            foreach (int vendido in rifas)
            {
                if (trifa == vendido)
                {
                    vendida++;
                }

            }


            if (vendida == 1)
            {
                Console.WriteLine("esa numero no esta disponible");
            }
            else
            {
                Console.WriteLine("esa numero esta disponible");
            }


        }
    }
}
