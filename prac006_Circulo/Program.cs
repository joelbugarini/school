using System;

namespace prac006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area del Circulo");
            Console.WriteLine("Porfavor indique el radio del circulo");
            double radio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area es: " + Math.PI*(Math.Pow(radio,2)));
        }
    }
}
