using System;

namespace prac015
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que imprime numeros del -10 al 10 uno a uno!");
            for(int i=-10; i<=10; i++){
                Console.WriteLine(i.ToString());
            }
        }
    }
}
