using System;

namespace prac008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema verificador de Edad");
            Console.WriteLine("Cuantos años tienes?");
            int edad = Convert.ToInt16(Console.ReadLine());

            if (edad < 0)                   Console.WriteLine("No me amenaces");
            if (edad > 120)                 Console.WriteLine("Siguele pues!");
            if (edad > 17 && edad < 121)    Console.WriteLine("Bienvenido");
            if (edad > 0 && edad < 18)      Console.WriteLine("Señora, su hijo esta viendo cosas feas!");

        }
    }
}
