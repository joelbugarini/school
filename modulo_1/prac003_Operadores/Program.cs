using System;

namespace prac003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("b=");
            double b = Convert.ToDouble(Console.ReadLine());
                        
            
            Console.WriteLine("a+b=" + (a+b));
            Console.WriteLine("a-b=" + (a-b));
            Console.WriteLine("a*b=" + (a*b));
            Console.WriteLine("a/b=" + (a/b));

        }
    }
}
