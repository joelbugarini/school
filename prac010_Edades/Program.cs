using System;

namespace prac010
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clasificador de Edades");
            Console.WriteLine("Cuantos años tienes?");
            int edad = Convert.ToInt16(Console.ReadLine());

            if (edad > 120) Console.WriteLine("Dificil de Creer!");
            if (edad > 0 && edad < 12) Console.WriteLine("Niño");
            if (edad > 13 && edad < 17) Console.WriteLine("Adolecente");
            if (edad > 18 && edad < 25) Console.WriteLine("Joven Adulto");
            if (edad > 26 && edad < 45) Console.WriteLine("Adulto");
            if (edad > 46 && edad < 60) Console.WriteLine("Adulto Mayor");
            if (edad > 61 && edad < 120) Console.WriteLine("Edad Avanzada");

        }
    }
}
