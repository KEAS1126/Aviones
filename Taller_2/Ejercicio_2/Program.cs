using System;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 10) Console.WriteLine("Su numero es: " + numero * 3);
        }
    }
}
