using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Contador


{
    class Program
    {
        static void Main(string[] args)
        {
            Contador();
        }
        static void Contador()
        {
            int quiere;
            int num;
            int promedio = 0;
            int pares = 0;
            int impares = 0;

            Console.Write("cuantos numeros desea ingresar?");
            quiere = Convert.ToInt32(Console.ReadLine());
            int[] contador = new int[quiere];

            for (int i = 0; i < contador.Length; i++)
            {
                Console.Write("Ingrese un numero:");
                num = Convert.ToInt32(Console.ReadLine());
                contador[i] = num;
            }
            int mayor = contador[0];
            int menor = contador[0];
            foreach (int nume in contador)
            {
                if (nume > mayor)
                {
                    mayor = nume;
                }
                if (nume < menor)
                {
                    menor = nume;
                }
                promedio += nume;

                if (nume % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }
            promedio = promedio / quiere;

            Console.WriteLine("el promedio es de:" + promedio);
            Console.WriteLine("el numero mayor es :" + mayor);
            Console.WriteLine("el numero menor es :" + menor);
            Console.WriteLine("hay " + pares + " numeros pares");
            Console.WriteLine("hay " + impares + " numeros impares");
        }

    }
}

