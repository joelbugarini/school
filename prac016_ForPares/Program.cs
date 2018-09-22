using System;

namespace prac016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que imprime numeros pares entre -100 a 100");
            for (int i = -100; i <= 100; i+=2)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
