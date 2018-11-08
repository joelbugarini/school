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
            int i = 0;
            while (sum(i) < lim)
            {
                Console.Write(sum(i));
                if (sum(i+1) <= lim) Console.Write(",");
                i++;
            }
            Console.WriteLine();
        }

        static long sum(long n){
            long a = 0;
            long b = 1;
            long i = 0;
            while (i < n)
            {
                long temp = a;
                a = b;
                b = temp + b;
                i++;
            }
            return a;
        }
    }
}
