using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números naturales pares elevados al cubo");
            Console.Write("ℕ3 = { ");
            int i = 1;
            while (i <= 10)
            {
                if(i % 2 == 0){
                    Console.Write(Math.Pow(i,3));
                    if(i+2 <= 10) Console.Write(", ");
                }
                i++;
            }
            Console.WriteLine(" }");
        }
    }
}



