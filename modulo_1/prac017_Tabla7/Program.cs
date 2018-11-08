using System;

namespace prac016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que imprime tablas de multiplicar");
            Console.WriteLine("Ingrese la tabla que desea visualizar");
            double x = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(x + " x " + i + " = "+ i*x);
            }
        }
    }
}
