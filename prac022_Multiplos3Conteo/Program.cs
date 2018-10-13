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
            int count = 0;
            for (int i = inferior; i <= superior; i++)
            {
                if (i % 3 == 0)
                {
                    count = count +1;
                    Console.Write(i);
                    if (i + 3 <= superior) Console.Write(",");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Son un total de " + count + " multiplos de 3");
        }
    }
}
