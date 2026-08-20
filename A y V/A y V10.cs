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
            int edad;
            int[] barrio = new int[5];
            int menores = 0;
            int mayores = 0;
            int intermedio = 0;
            for (int i = 0; i < barrio.Length; i++)
            {
                Console.Write("Ingrese la edad de la persona " + (i + 1) + " : ");

                edad = Convert.ToInt32(Console.ReadLine());

                barrio[i] = edad;
            }
            foreach (int clasificacion in barrio)
            {

                if (clasificacion < 18)
                {
                    menores++;
                }
                if (clasificacion >= 18 && clasificacion < 65)
                {
                    intermedio++;
                }
                else
                {
                    mayores++;
                }
            }
            Console.WriteLine("en el barrio hay:");
            Console.WriteLine(mayores + " personas mayores");
            Console.WriteLine(intermedio + " personas intermedias");
            Console.WriteLine(menores + " personas menores");
        }
    }
}