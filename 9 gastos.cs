using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los gastos de los 5 dias");

            int acumulador = 0;

            int contador = 0;

            for (int = i; i <= 5; i++) 
            {
                Console.Write("Cual fue el gasto del dia" + i);

                int plata = Convert.ToInt32(Console.ReadLine());

                acumulador = acumulador + plata;

                if (plata > 500)
                {
                    contador++;
                }
                Console.WriteLine("El gasto total es de: " + acumulador);
                Console.WriteLine("Las veces que el gasto es menos de 0 es : " + contador);

               
            }
        }
}
