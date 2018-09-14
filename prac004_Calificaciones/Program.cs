using System;

namespace prac004_Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula promedios de Calificaciones");
            Console.WriteLine("Introduzca la calificacion del primer parcial");
            double parcial_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca la calificacion del segundo parcial");
            double parcial_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca la calificacion integradora");
            double integradora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Calificacion Total: " + (parcial_1 + parcial_2 + integradora)/3);
        }
    }
}
