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
            string asistencia;
            string[] asis = new string[20];

            int presente = 0;
            int ausente = 0;




            for (int i = 0; i < asis.Length; i++)
            {

                Console.Write("Ingrese la asistencia del alumno (p o a): ");

                asistencia = (Console.ReadLine());
                if (asistencia == "p")
                {
                    presente++;
                }
                if (asistencia == "a")
                {
                    ausente++;
                }
                if (asistencia != "p" && asistencia != "a")
                {
                    Console.WriteLine("Ingrese si es presente(p) o ausente(a)");
                    i--;
                }
            }

            Console.WriteLine("el alumno tuvo un total de " + ausente + " insasitencias");
            if (ausente > 6)
            {
                Console.WriteLine("el alumno quedo libre por tener mas de 6 faltas");
            }
            else
            {
                Console.WriteLine("el alumno esta regular");
            }

            
        }
    }
}