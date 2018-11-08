using System;

namespace prac007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversiones");
            Console.WriteLine("Introduzca una medida en metros");
            double mts = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(mts + "mts = " + mts*1000 + "mm");
            Console.WriteLine(mts + "mts = " + mts*100 + "cm");
            Console.WriteLine(mts + "mts = " + mts*10 + "dm");
            Console.WriteLine(mts + "mts = " + mts*0.001 + "km");
            Console.WriteLine(mts + "mts = " + mts*39.3701 + "in");
            Console.WriteLine(mts + "mts = " + mts*3.28084 + "ft");
            Console.WriteLine(mts + "mts = " + mts*0.000621371 + "mile");
        }
    }
}
