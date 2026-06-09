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
            
            string opcion;
            int porcentaje=0;
            int p = 0;
            int a = 0;
            do
            {
               Console.WriteLine("quiere ingresar un alumno(y/n)");
opcion = (Console.ReadLine());
               
                if (opcion == "y")
                {
                  //  Console.Write("ingrese el nombre del alumno: ");
                   // string nombre = (Console.ReadLine());
                    Console.Write("ingrese su estado: ");
                    string presente = (Console.ReadLine());
                    if(presente=="p")
                    {
                      
                        p++;
                    }
                    if (presente == "a")
                    {
                        a++;
                       
                    }
                porcentaje++;
                }
               



            } while (opcion != "n");
            Console.WriteLine("hubieron "+p+" presente");
            Console.WriteLine("hubieron " + a + " ausentes"      +porcentaje   );

            int presen = a / porcentaje;
            int presen1 = presen * 100;
            Console.WriteLine("porcentaje de presentismo: "+presen1+"%");
        }
    }
}
