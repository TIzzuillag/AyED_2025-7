

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Promedios


{
    class Program
    {
        static void Main(string[] args)
        {
            Promedios();
        }
        static void Promedios()
        {
            int quiere;
            int num;

            int pares = 0;
            int impares = 0;
            int mayor = 0;
            int menor = 0;
            int cero = 0;
            Console.Write("cuantos numros qiere ingresar");
            quiere = Convert.ToInt32(Console.ReadLine());
            int[] contador = new int[quiere];
            for (int i = 0; i < contador.Length; i++)
            {
                Console.Write("Ingrese un numer");
                num = Convert.ToInt32(Console.ReadLine());
                contador[i] = num;
            }
            foreach (int nume in contador)
            {
                if (nume > 0)
                {
                    mayor++;
                }
                if (nume < 0)
                {
                    menor++;
                }
                if (nume == 0)
                {
                    cero++;
                }
                if (nume % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine("cantidd de positivos :" + mayor);
            Console.WriteLine("cantidd de negativos :" + menor);
            Console.WriteLine("cantidd de cero :" + cero);
            Console.WriteLine("hay " + pares + " numeros pres");
            Console.WriteLine("hay " + impares + " numeros impares");
        }
    }
}
