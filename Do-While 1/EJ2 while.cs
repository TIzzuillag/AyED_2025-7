using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota = 0;
            string error = "";
            do
            {
                Console.WriteLine(error);
                Console.Write("ingrese una nota: ");
                nota = int.Parse(Console.ReadLine());
                error = "la nota ingresada no es valida";
            } while (nota < 1 || nota > 10);

            Console.WriteLine("Nota" + nota);
        }
    }
}
