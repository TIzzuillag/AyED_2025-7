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
            int num;
            int minimo = 0;
            int contador = 0;

            do
            {
                Console.Write("Ingrese un número: ");
                num = Convert.ToInt32(Console.ReadLine());

             
                if (num >= 0)
                {
                    contador++;


                    if (contador == 1)
                    {
                        minimo = num;
                    }

                     if (num < minimo)
                    {
                        minimo = num;
                    }
                }

            } while (num >= 0);

         
            if (contador > 0)
            {
                Console.WriteLine("El número más chico es: " + minimo);
            }
          
        }
    }
}
