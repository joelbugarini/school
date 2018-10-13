using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sucesion de Farey");
            Console.WriteLine("Ingrese el numero limite");
            long n = Convert.ToInt64(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int c = 1; c <= n; c++)
                {
                    Console.Write(i + "/" + c);
                    if(c < n || i < n) Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
