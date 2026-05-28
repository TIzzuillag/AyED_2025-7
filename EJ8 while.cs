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
            Console.Write("ingrese la temperatura");
            int temperatura = Convert.ToInt32(Console.ReadLine());
            do
            {
                temperatura = temperatura - 2;
                Console.WriteLine("enfriando " + temperatura);

                temperatura--;
            } while (temperatura > 24);
            Console.WriteLine("temperatura ideal alcanzada " + temperatura);

        }
    }
}