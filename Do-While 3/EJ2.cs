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

            string opcion;
            double cantidad = 0;
            double p = 0;
            double a = 0;
            do
            {
                Console.WriteLine("quiere ingresar un alumno(y/n)");
                opcion = (Console.ReadLine());

                if (opcion == "y")
                {
                     Console.Write("ingrese el nombre del alumno: ");
                     string nombre = (Console.ReadLine());
                    Console.Write("ingrese su estado: ");
                    string presente = (Console.ReadLine());
                    if (presente == "p")
                    {

                        p++;
                    }
                    if (presente == "a")
                    {
                        a++;

                    }
                    cantidad++;

                }




            } while (opcion != "n");
            Console.WriteLine("hubieron " + p + " presente");
            Console.WriteLine("hubieron " + a + " ausentes" );

            double presen = p / cantidad;
            double porcentaje = presen * 100;
            Console.WriteLine("porcentaje de presentismo: " + porcentaje + "%");
        }
    }
}
