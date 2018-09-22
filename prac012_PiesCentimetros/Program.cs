using System;

namespace prac012
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pies a Centimetros");
            //30.48
            Console.Write("Escriba el numero de Pies: ");
            double cm = 30.48 * Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(cm+"cm");
        }
    }
}
