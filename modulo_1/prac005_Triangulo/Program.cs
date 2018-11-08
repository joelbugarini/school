using System;

namespace prac005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area del triangulo");
            Console.WriteLine("inserte la base del triangulo");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("inserte la altura del triangulo");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El area es = " + b*h/2);

        }
    }
}
