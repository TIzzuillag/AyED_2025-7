using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Capicua
{
    class Program
    {
        static void Main(string[] args)
        {
            EsCapicua();
        }

        static void EsCapicua()
        {
            Console.Write("ingrese un numero entero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int numero = num;
            int numero0 = 0;
            int digito;

            while (numero > 0)
            {
                digito = numero % 10;
                numero0 = (numero0 * 10) + digito;
                numero = numero / 10;
            }

            if (num == numero0)
            {
                Console.WriteLine("El numro " + num + " es caicua");
            }
            else
            {
                Console.WriteLine("El numro " + num + " no es cpicua");
            }
        }
    }
}
