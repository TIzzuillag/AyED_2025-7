using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su contraseña correcta");
            string contra = (Console.ReadLine());
            string contraa;
            do
            {
                Console.WriteLine("verifique la contraseña");

                contraa = (Console.ReadLine());
                if (contra != contraa)
                {
                    Console.WriteLine("error");
                }


            } while (contra != contraa);
            Console.WriteLine("contraseña valida");
        }
    }
}