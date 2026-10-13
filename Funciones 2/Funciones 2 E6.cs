using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            SegundoMayor();
        }

        static void SegundoMayor()
        {
            Console.Write("Ingrese la cantidad de numeros: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            int mayor = 0;
            int segundoMayor = 0;
            bool hayMayor = false;
            bool haySegundo = false;

            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write("Ingrese un numero entero: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (!hayMayor)
                {
                    mayor = num;
                    hayMayor = true;
                }
                else if (num > mayor)
                {
                    segundoMayor = mayor;
                    mayor = num;
                    haySegundo = true;
                }
                else if (num < mayor)
                {
                    if (!haySegundo || num > segundoMayor)
                    {
                        segundoMayor = num;
                        haySegundo = true;
                    }
                }
            }

            if (haySegundo)
            {
                Console.WriteLine("El segundo numero mas grande es: " + segundoMayor);
            }
            else
            {
                Console.WriteLine("No existe un segundo valor diferente al mayor.");
            }
        }

    }
}