using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ciclos Anidados para generar sequiencia numerica");
            Console.WriteLine("Ingrese el limite de la secuencia");
            long limite = long.Parse(Console.ReadLine());
            if(limite <1) { Console.WriteLine("Solo numeros mayores a 0"); return; }

            int i = 1;
            while(i <= limite)
            {
                int c = 0;
                while (c < i)
                {
                    if(i <= 9) Console.Write(" ");
                    Console.Write(i + " ");
                    c++;
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
