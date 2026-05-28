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
                Console.WriteLine("1_Saludar");
                Console.WriteLine("2_Despedirse");
                Console.WriteLine("3_Salir");
                int opcion;
            do
            {
                Console.Write("Elegi la opcion");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Hola, ¿como estas?");
                }
                if (opcion == 2)
                {
                    Console.WriteLine("Adios, saliento al escritorio");
                }

                }while (opcion != 3);
           }        
                
        }
    }
