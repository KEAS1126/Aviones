using System;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número: ");
            float numero = float.Parse(Console.ReadLine());
            if (numero >= 10) Console.WriteLine("Su numero es: "+numero * 3);
            else Console.WriteLine("Su numero es: " + numero / 4);
                

        }
    }
}
