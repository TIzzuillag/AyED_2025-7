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
            int num;
            int num2;
            int plata = 100;
            int apuesta;
         

            do
            {
                Console.Write("Ingrese su apuesta: ");
                apuesta = Convert.ToInt32(Console.ReadLine());
               
                if (apuesta<plata && apuesta!= 0)
                {
                 
                 Console.Write("Ingrese el primer dado: ");
                num = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el segundo dado: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                    int suma = num + num2;
                    Console.WriteLine("valor del dado: "+suma);
                   if (suma==7 || suma==11)
                    {
                        plata = plata + apuesta * 2;
                        Console.WriteLine("GANASTE, tu dinero es de: " + plata);
      
                    }
                    else
                    {
                        plata = plata - apuesta;
                        Console.WriteLine(" PERDISTE, tu dinero es de: " + plata);
                    }
                }




            } while (apuesta != 0 && plata > 0);

            Console.WriteLine("te quedaste sin dinero");
        }

    }
}
