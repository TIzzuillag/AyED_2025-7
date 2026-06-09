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
  
           
            int num;
            string opcion;
            int contador = 0;
            do
            {
                Console.WriteLine("quiere ingresar un numero(y/n)");
                opcion = (Console.ReadLine());
                if (opcion=="y")
                {
                    Console.Write("ingrese un numero: ");
                    num = Convert.ToInt32(Console.ReadLine());
                }
               
            } while (opcion != "n");
            Console.WriteLine("hola mundo");
        }
    }
}
