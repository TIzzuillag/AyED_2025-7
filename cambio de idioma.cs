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
            Console.WriteLine("Elegi un idioma para saludar");
            Console.WriteLine("Ingles / Frances / Aleman");
            Console.WriteLine("Ingrese la inicial de la comida que quiera comprar");

            string opcion = (Console.ReadLine());
            switch (opcion)
            {
                case "I":
                    Console.WriteLine("Hello");
                    break;
                case "F":
                    Console.WriteLine("Salut");
                    break;
                case "A":
                    Console.WriteLine("Hallo");
                    break;
                default:
                    Console.WriteLine("Idioma no encontrado");
                    break;
            }



        }
    }
}
