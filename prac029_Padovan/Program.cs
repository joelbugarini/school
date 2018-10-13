using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serie de Padovan");
            Console.WriteLine("Ingrese el limite: ");
            int limite = Convert.ToInt32(Console.ReadLine());

            Console.Write("P("+limite+") = ");
            for (int i = 0; i < limite; i++)
            {
                Console.Write(P(i) + ", ");
            }
            Console.WriteLine();
        }

        static int P(int n){
            if (n == 0) return 1;
            if (n == 1) return 1;
            if (n == 2) return 1;
            return P(n - 2) + P(n - 3);
        }
    }
}
