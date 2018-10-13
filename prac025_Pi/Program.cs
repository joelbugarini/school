using System;
using System.Collections.Generic;
using System.Linq;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serie de π (Pi)");
            Console.WriteLine("Ingrese el numero de iteraciones");
            int iteraciones = Convert.ToInt32(Console.ReadLine());
            int limite = iteraciones * 2;
            double pi = 0;

            for (int i = 1; i < limite; i+=2)
            {
                if(i%4==1){
                    pi += 4.0/i;
                } else{
                    pi -= 4.0 / i;
                }
                //Console.Write("4/" + i + (i % 2.0 == 0? " + ":" - "));
            }

            Console.WriteLine("π = " + pi);
        }
    }
}
