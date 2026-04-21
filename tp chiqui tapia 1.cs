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
            int Ttotal;
            float horas;
            float minutos;
            float six;
            float costohora;
            float costominuto;
            float preciototal;
            double IVA;
            Console.WriteLine("Ingrese la cantidad de minutos");
            Ttotal = Convert.ToInt32(Console.ReadLine());
            horas = Ttotal / 60;
            six = horas * 60;
            Console.WriteLine("La cantidad de horas es de:" + horas);
            minutos = Ttotal - six;
            Console.WriteLine("La cantidad de minutos es de:" + minutos);
            costohora = horas * 6000;
            costominuto = minutos * 150;
            preciototal = costohora + costominuto;
            IVA = preciototal * 1.21;
            Console.WriteLine("El precio total es de:" + IVA);


        }
    }
}
