using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ciclos Anidados para generar sequiencia numerica");
            for (int i = 1; i < 10; i++)
            {
                for (int c = 0; c < i; c++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
