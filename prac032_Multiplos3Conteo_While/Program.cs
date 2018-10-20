using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplos de 3 dado un rango");
            int inferior = 0;
            int superior = 0;
            while(inferior == 0 || superior == 0){
                try{
                    Console.WriteLine("Ingrese el limite inferior");
                    inferior = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el limite superior");
                    superior = Convert.ToInt32(Console.ReadLine());
                }catch(Exception){
                    Console.WriteLine("Solo pueden ser numeros enteros");
                }
            }

            int count = 0;
            int i = inferior;
            while (i <= superior)
            {
                if (i % 3 == 0)
                {
                    count = count +1;
                    Console.Write(i);
                    if (i + 3 <= superior) Console.Write(",");
                }
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Son un total de " + count + " multiplos de 3");
        }
    }
}
