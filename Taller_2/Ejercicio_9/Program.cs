using System;

namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero: ");
            int numero=int.Parse(Console.ReadLine());
            if (numero % 5 == 0) Console.WriteLine(numero+" multiplo de 5 "); 
        }
    }
}
