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

            int nave;
            int pesoextra;
            Console.WriteLine("Ingrese el peso de carga;");
            nave = Convert.ToInt32(Console.ReadLine());
            if (nave <= 5000)
            {
             Console.WriteLine("Despegue autorizado. Buen viaje, Mando");
            }
             else
              {
                pesoextra = nave - 5000;
                Console.WriteLine("Alerta: Exceso de peso. Debes descargar" +  pesoextra, "kg para despegar");
              }


        }
    }
}
