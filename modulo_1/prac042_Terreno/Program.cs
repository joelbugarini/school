using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular el valor de un terreno");
            double frente = 0, fondo = 0, precio = 0;

            while(frente == 0 || fondo == 0|| precio == 0){
                try{
                    Console.WriteLine("Introduzca los m2 de frente");
                    frente = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introduzca los m2 de fondo");
                    fondo = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introduzca el precio por m2");
                    precio = Convert.ToDouble(Console.ReadLine());
                }catch(Exception){
                    Console.WriteLine("Numero no valido, vuelve a intentarlo");
                }
            }

            Console.WriteLine("Valor del predio = $" + frente * fondo * precio);
        }
    }
}
