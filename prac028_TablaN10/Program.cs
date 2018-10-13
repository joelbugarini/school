using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para imprimir una tabla de N*N");
            Console.WriteLine("Introduzca el valor de N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("N   10*N  100*N  1000*N");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + "   ");
                Console.Write(i*10 + "    ");
                Console.Write(i*100 + "    ");
                Console.WriteLine(i*1000);
            }
        }
    }
}
