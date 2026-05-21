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
            Console.Write("Ingrese la contraseña");
            string contraseña = (Console.ReadLine());
            string contra;
            do
            {
                Console.WriteLine("Contraseña erronea");

                contra = (Console.ReadLine());
                if (contraseña != contra)
                {
                    Console.WriteLine("error");
                }

            } while (contraseña != contra);
            Console.WriteLine("Contraseña correcta");

        }
    }
}
