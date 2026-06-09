using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("desea ingresar una venta (S/N).");
            int monto=0;
            int recau = 0;
            string opcion;
            int contador = 0;
            int mayor=0;
            do
            {

                opcion = (Console.ReadLine());
                if (opcion ==  "S")
                {
                    Console.Write("ingrese el monto de la venta ");

                  
                    monto = Convert.ToInt32(Console.ReadLine());
                    recau = recau + monto;
                    if (monto>mayor)
                    {
                       mayor=monto;

                    }

                   
                    


                        contador++;
                   Console.WriteLine("Si desea continuar ingresando más ventas(S / N)");
                }


            } while (opcion!="N");
            Console.WriteLine("hubo "+ contador+ " ventas" );
            Console.WriteLine("la venta mayor fue de " + mayor );
            Console.WriteLine("recaudado:" + recau);
        }

        }
    }

