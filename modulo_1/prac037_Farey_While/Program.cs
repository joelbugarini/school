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

            if(n < 0){ Console.WriteLine("Solo numeros naturales"); return; }

            string num = n + "/" + n;

            int i = 1;
            while ( i <= n)
            {
                int c = 1;
                while (c <= n)
                {
                    Console.Write(i + "/" + c);
                    if(c < n) Console.Write("  ");
                    c++;
                }
                i++;
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
