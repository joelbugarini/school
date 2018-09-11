using System;

namespace prac002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu nombre plix");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce tu apellido por parte de tu papa");
            string apellidoPaterno = Console.ReadLine();
            Console.WriteLine("Introduce tu apellido por parte de tu mama");
            string apellidoMaterno = Console.ReadLine();
            Console.WriteLine("Que edad tienes");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mucho gusto " + nombre + " " + apellidoPaterno + " " + apellidoMaterno + " " + edad);
        }
    }
}
