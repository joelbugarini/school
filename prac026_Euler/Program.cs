using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor de la constante de Euler");
            Console.WriteLine("Ingrese el numero de iteraciones");
            double iteraciones = Convert.ToInt64(Console.ReadLine());
            double euler = 0;

            for (int i = 1; i < iteraciones; i++)
            {
                euler += (1/factorial(i));
            }
            Console.WriteLine("e = " + euler);
        }

        static double factorial(double i){
            if (i <= 1)
                return 1;
            return i * factorial(i - 1);
        }
    }
}
