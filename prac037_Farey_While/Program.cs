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

            int i = 1;
            while ( i <= n)
            {
                int c = 1;
                while (c <= n)
                {
                    Console.Write(i + "/" + c);
                    if(c < n || i < n) Console.Write(", ");
                    c++;
                }
                i++;
            }
            Console.WriteLine();
        }
    }
}
