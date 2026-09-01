using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ContarRegresivo

{
    class Program
    {
        static void Main(string[] args)
        {
            ContarRegresivo();
        }
        static void ContarRegresivo()
        {
            int contador = 0;
            int num;
            Console.Write("Ingrese un numero:");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                num = num - 1;
                Console.WriteLine(num);
                contador++;
            }
        }
    }
}