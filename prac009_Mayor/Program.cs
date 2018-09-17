using System;

namespace prac009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Evalua el numero mayor");
            Console.WriteLine("Introduzca un numero: ");
            double uno = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca otro numero: ");
            double dos = Convert.ToDouble(Console.ReadLine());

            if(uno > dos) Console.WriteLine("El numero " + uno + " es mayor");
            if(uno < dos) Console.WriteLine("El numero " + dos + " es mayor");
            if(uno == dos) Console.WriteLine("Los numeros son Iguales");
        }
    }
}
