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
          Console.WriteLine("Ingresa la temperatura del Dia");

            int acumulador = 0;

            int contador = 0;
            
            for (int i = 1; i <= 7; i++) 
            {
                Console.Write("cual fue la temperatura del dia:" + i);

                int temperatura = Convert.ToInt32(Console.ReadLine());

                acumulador = acumulador + temperatura;

                if (temperatura < 0)

                    contador++;

            }

            
                Console.Write("la temperatura total es de:" + acumulador);

                Console.Write("la temperatura menor a 0 es de:" + contador);
            


        }
    }
}
