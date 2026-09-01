using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ContarHasta

{
    class Program
    {
        static void Main(string[] args)
        {
            ContarHasta();
        }
        static void ContarHasta()
        {
            int contador = 1;
            int num;
            Console.Write("Ingrese un numero:");
            num = Convert.ToInt32(Console.ReadLine());
            while (contador <= num)
            {

                Console.WriteLine(contador);
                contador++;
            }
        }
    }
}
