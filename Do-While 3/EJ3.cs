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

            int edad;
            int contador = 0;
            int mayor = 0;
            int menor = 0;
            int edades = 0;
            do
            {
                Console.Write("ingrese la edad de la persona: ");
                edad = Convert.ToInt32(Console.ReadLine());
                contador++;
                edades = edades + edad;
               
                    if (edad>18)
                    {
                    mayor++;
                   }
                else
                {
                    menor++;
                }



            } while (edad >0 );
            contador = contador - 1;
            menor = menor - 1;
            edades = edades - edad;
            int porcentaje = edades / contador;
            Console.WriteLine("el promedio de edades son "+porcentaje);
            Console.WriteLine("personas mayores: "+mayor);
            Console.WriteLine("personas menores: "+menor);
        }
    }
}