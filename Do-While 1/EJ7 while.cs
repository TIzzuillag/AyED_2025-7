using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese las 5 notas");
            int notas = 0;
            int nota;
            int contador = 1;
            do
            {
                Console.WriteLine("ingrese la nota " + contador);

                nota = Convert.ToInt32(Console.ReadLine());
                notas = notas + nota;
                contador++;
            } while (contador < 6);
            notas = notas / 5;
            Console.WriteLine("el promedio final es " + nota);
        }
    }
}
