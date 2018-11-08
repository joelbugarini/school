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
            if (iteraciones >= 1 && iteraciones <= 100)
            {

            double euler = 0;

            for (int i = 1; i < iteraciones; i++)
            {
                euler += (1/factorial(i));
            }
            Console.WriteLine("e = " + euler);
            }
            else { Console.WriteLine("Recuerde que el intervalo tiene que estrar entre 1 y 100"); }
        }

        static double factorial(double i){
            if (i <= 1)
                return 1;
            return i * factorial(i - 1);
        }
    }
}
