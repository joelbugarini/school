using System;

namespace prac013
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Programa para convertir de grados Centígrados a
            grados Fahrenheit. Considere que F = C * 9.0 / 5.0 +32.
            La temperatura en centígrados debe ser mayor a -32 en
            caso contrario imprimir un mensaje de error. */
            Console.WriteLine("Programa para convertir de grados Centígrados a grados Fahrenheit.");
            Console.Write("Ingrese la temperatura en ºC:");

            double c = Convert.ToDouble(Console.ReadLine());
            if(c >= 32){
                double f = c * 9.0 / 5.0 + 32;
                Console.WriteLine(f + "F");
            }else{
                Console.WriteLine("Error de temperatura");
            }

        }
    }
}
