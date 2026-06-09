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
            string opcion;
            int cero = 0;
            int positivos = 0;
            int negativos = 0;
            do
            {
                Console.WriteLine("quiere ingresar un numero(y/n)");
                opcion = (Console.ReadLine());
                if (opcion == "y")
                {
                    Console.Write("ingrese un numero: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num > 0)
                    {
                        positivos++;
                    }
                    if (num < 0)
                    {
                        negativos++;
                    }
                    if (num == 0)
                    {
                        cero++;
                    }
                }


            } while (opcion != "n");
            Console.WriteLine("numeros negativos: " + negativos);
            Console.WriteLine("numeros positivos: " + positivos);
            Console.WriteLine("numeros igual a cero: " + cero);
        }
    }
}
