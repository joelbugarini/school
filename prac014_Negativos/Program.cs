using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determinar si un numero es Negativo");

            int n = 0;
            try{
                n = Convert.ToInt32(Console.ReadLine());
            }catch(Exception){
                Console.WriteLine("Numero no valido");
                return;
            }

            if(n%2 ==0 && n > 0) Console.WriteLine("Numero par positivo");
            if(n%2 !=0 && n > 0) Console.WriteLine("Numero non positivo");
            if(n%2 ==0 && n < 0) Console.WriteLine("Numero par negativo");
            if(n%2 !=0 && n < 0) Console.WriteLine("Numero non negativo");
            if(n==0) Console.WriteLine("Numero es Cero");
        }
    }
}
