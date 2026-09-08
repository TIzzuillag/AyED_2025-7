using System;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros();
        }

        static void Numeros()
        {
            int num1;
            int num2;
            int inicio;
            int fin;
            int pares = 0;
            int impares = 0;
            int suma = 0;

            Console.Write("Ingrese el primer numero entero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo numero entero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                inicio = num1;
                fin = num2;
            }
            else
            {
                inicio = num2;
                fin = num1;
            }

            Console.WriteLine("Numeros comprendidos entre ambos:");

            for (int i = inicio; i <= fin; i++)
            {
                Console.WriteLine(i);

                suma += i;

                if (i % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine("Cantidad de numeros pares: " + pares);
            Console.WriteLine("Cantidad de numeros impares: " + impares);
            Console.WriteLine("Suma de todos los valores: " + suma);
        }
    }
}

