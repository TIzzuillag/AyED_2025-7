using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            double[] temperaturas = new double[7];

            for (int i = 0; i < 7; i++)
            {
                Console.Write("Ingrese la temperatura del día " + (i + 1));
                temperaturas[i] = double.Parse(Console.ReadLine());
            }

         
            double mayor = temperaturas[0];
            double menor = temperaturas[0];
            double suma = 0;

            
            for (int i = 0; i < 7; i++)
            {
                if (temperaturas[i] > mayor)
                {
                    mayor = temperaturas[i];
                }

                if (temperaturas[i] < menor)
                {
                    menor = temperaturas[i];
                }

                suma = suma + temperaturas[i];
            }

            double promedio = suma / 7;

            
            Console.WriteLine();
            Console.WriteLine("Temperatura más alta: " + mayor);
            Console.WriteLine("Temperatura más baja: " + menor);
            Console.WriteLine("Promedio semanal: " + promedio);
        }

    }
}