using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prueba de try y catch");
            int entero = readEntero();

            Console.WriteLine("Gracias el numero es " + entero);
        }
        public static int readEntero(){
            try{
                Console.WriteLine("Escriba un entero");
                int res = int.Parse(Console.ReadLine());
                return res;
            }catch(Exception ex){
                var res = ex.Message;
                Console.WriteLine("El numero que introduciste no es valido");
                Console.WriteLine("Intentalo de nuevo");
                return readEntero();
            }

        }
    }
}
