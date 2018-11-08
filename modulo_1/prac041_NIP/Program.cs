using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca su NIP para ingresar a su cuenta");
            try
            {
                int c = 0;
                while(c < 3){
                    int NIP = int.Parse(Console.ReadLine());
                    if (NIP == 1234)
                    {
                        Console.WriteLine("Ingresa a su cuenta ");
                        Console.WriteLine("Saldo $6.50 ");
                        return;
                    }else{
                        Console.WriteLine("Usted tiene " + (2 - c) + " intentos");
                    }

                    c++;
                }
                Console.WriteLine("Cuenta bloqueada, por favor pase a ventanilla");
            }
            catch (Exception ex)
            {
                var res = ex.Message;
                Console.WriteLine("El numero que introduciste no es valido");
                return;
            }

        }
    }
}
