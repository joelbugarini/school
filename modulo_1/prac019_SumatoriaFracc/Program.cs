using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sumatoria de Fracciones");
            double suma = 0;
            for(int x = 1; x <= 50; x++){
                suma += (1.0/x);
                if (x != 50) Console.Write("1/"+x + " + ");
                else Console.Write(x + " =~ ");
            }
            Console.WriteLine(suma);
        }
    }
}
