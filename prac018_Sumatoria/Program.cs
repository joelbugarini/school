using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que muestra una Sumatoria");
            Console.Write("Ingrese el limite superior: ");
            int limite = Convert.ToInt16(Console.ReadLine());
            int suma = 0;
            if(limite > 1) {
                Console.Write(" 𝚺 = ");
                for(int x = 1;x <= limite; x += 1){
                    suma += x;
                    if(x != limite) Console.Write(x + " + ");
                    else Console.Write(x + " = ");
                }
                Console.WriteLine(suma);
                Console.WriteLine("Por metodo de Gauss");
                Console.Write(" 𝚺 = n(n+1)/2 = ");
                Console.WriteLine(limite*(limite+1)/2);
            }
            else Console.WriteLine("Limite demasiado pequeño");
        }
    }
}
