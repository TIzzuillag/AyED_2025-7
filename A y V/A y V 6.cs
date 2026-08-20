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
            int venta2;
            int ventas1 = 0;
            int ventas;
            int ventas2 = 0;
            int contador = 0;
            int contador2 = 0;
            int[] sucursales = new int[5];
            int[] sucursales2 = new int[5];





            for (int i = 0; i < sucursales.Length; i++)
            {

                Console.Write("Ingrese el registro de la sucursal 1: ");
                ventas = Convert.ToInt32(Console.ReadLine());
                sucursales[i] = ventas;


                ventas1 = ventas;


                for (int a = 0; a < 1; a++)
                {
                    Console.Write("Ingrese el registro de la sucursal 2: ");
                    venta2 = Convert.ToInt32(Console.ReadLine());
                    sucursales2[i] = venta2;


                    ventas2 = venta2;



                }
                if (ventas2 < ventas1)
                {
                    Console.WriteLine("En el dia " + (i + 1) + " vendio mas la SUCURSAL 1");
                    contador++;
                }

                if (ventas2 > ventas1)
                {
                    Console.WriteLine("En el dia " + (i + 1) + " vendio mas la SUCURSAL 2");
                    contador2++;
                }

            }




            if (contador > contador2)
            {
                Console.WriteLine("La mayor facturazion fue de la sucursal 1");
            }

            else
            {
                Console.WriteLine("La mayor facturazion fue de la sucursal 2");
            }



        }
    }
}