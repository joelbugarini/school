using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que muestra una Sumatoria");
            Console.WriteLine("Ingrese el limite superior");
            int limite = Convert.ToInt16(Console.ReadLine());
            int suma = 0;
            if(limite > 1) {
                Console.Write(" 𝚺  = ");
                for(int x = 1;x <= limite; x += 1){
                    suma += x;
                    if(x != limite) Console.Write(x + " + ");
                    else Console.Write(x + " = ");
                }
                Console.WriteLine(suma);
            }
            else Console.WriteLine("Limite demasiado pequeño");
        }
    }
}
