using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplos de 3 dado un rango");
            Console.WriteLine("Ingrese el limite inferior");
            int inferior = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el limite superior");
            int superior = Convert.ToInt32(Console.ReadLine());
            int i = inferior;
            while (i <= superior)
            {
                if (i%3 == 0) {
                    Console.Write(i);
                    if (i+3 <= superior) Console.Write(",");
                }

                i++;
            }
            Console.WriteLine();
        }
    }
}
