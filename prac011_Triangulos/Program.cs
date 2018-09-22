using System;
using System.Collections.Generic;
using System.Linq;

namespace prac011
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determinar el Tipo de un Triangulo");
            Console.Write("Porfavor ingrese un lado: ");

            List<double> lados = new List<double>();

            lados.Add(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Porfavor ingrese otro lado: ");
            lados.Add(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Porfavor ingrese otro lado: ");
            lados.Add(Convert.ToDouble(Console.ReadLine()));

            if(lados.Any(x => x <= 0)){
                Console.WriteLine("No puede existir un triangulo de lado 0");
            }
            else{
                double max = lados.Max();
                double min1 = lados.Min();
                double min2 = lados.OrderBy(x => x).Skip(1).First();

                if (min1 + min2 > max)
                {
                    if (max == min1 && min1 == min2)
                        Console.WriteLine("Equilatero");
                    else if (max != min1 && min1 != min2 && max != min2)
                        Console.WriteLine("Escaleno");
                    else
                        Console.WriteLine("Isoseles");
                }
                else
                {
                    Console.WriteLine("No es un triangulo");
                }
            }
        }
    }
}
