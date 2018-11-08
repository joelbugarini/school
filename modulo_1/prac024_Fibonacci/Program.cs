using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serie de Fibonacci");
            Console.WriteLine("Ingrese el limite superior");
            long lim = Convert.ToInt64(Console.ReadLine());
            for (int i = 0; sum(i) < lim; i++)
            {
                Console.Write(sum(i));
                if (sum(i+1) <= lim) Console.Write(",");
            }
            Console.WriteLine();
        }

        static long sum(long n){
            long a = 0;
            long b = 1;

            for (long i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
