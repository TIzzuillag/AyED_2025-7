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

            Console.WriteLine("Ingresa la temperatura del Domingo");
            int domingo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la temperatura del Lunes");
            int Lunes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la temperatura del Martes");
            int Martes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la temperatura del Miercoles");
            int Miercoles = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la temperatura del Jueves");
            int Jueves = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la temperatura del Viernes");
            int Viernes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la temperatura del Sabado");
            int Sabado = Convert.ToInt32(Console.ReadLine());

            //suma de todas las temperaturas
            int suma = domingo + Lunes + Martes + Miercoles + Jueves + Viernes + Sabado;
            Console.Write("La suma de temperatura da un total de" + suma);
        }
    }
}