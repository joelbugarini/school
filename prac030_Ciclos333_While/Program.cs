using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ciclos Anidados para generar sequiencia numerica");
            int i = 1;
            while(i < 10)
            {
                int c = 0;
                while (c < i)
                {
                    Console.Write(i);
                    c++;
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
