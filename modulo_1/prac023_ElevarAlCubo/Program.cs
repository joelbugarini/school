using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números naturales pares elevados al cubo");
            Console.Write("ℕ = { ");
            for (int i = 1; i <= 10; i++)
            {
                if(i % 2 == 0){
                    Console.Write(Math.Pow(i,3));
                    if(i+2 <= 10) Console.Write(", ");
                }
            }
            Console.WriteLine(" }");
        }
    }
}



