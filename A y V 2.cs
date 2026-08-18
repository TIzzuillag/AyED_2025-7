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
            int nt;
            int[] notas = new int[10];
            int contador = 0;
            int aprobados = 0;
            int desaprobados = 0;




            for (int i = 0; i < notas.Length; i++)
            {

                Console.Write("Ingrese la nota de los alumnos " + (i + 1) + ":");

                nt = Convert.ToInt32(Console.ReadLine());
                if (nt < 10)
                {
                    notas[i] = nt;
                }
                else
                {
                    Console.WriteLine("Ingrese un valor menor a 10");
                    i--;
                }
            }

            foreach (int suma in notas)
            {
                contador = contador + suma;
                if (suma >= 6)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
            }

            double promedio = contador / notas.Length;
            Console.WriteLine("el promedio de las notas es: " + promedio);
            Console.WriteLine("aprobaron: " + aprobados);
            Console.WriteLine("desaprobaron: " + desaprobados);


           

        }
    }
}

