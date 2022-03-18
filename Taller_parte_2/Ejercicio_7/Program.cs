using System;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su número: ");
            int numero=int.Parse(Console.ReadLine());
            if (numero % 2 == 0) Console.WriteLine(numero + " Es par");
            else Console.WriteLine(numero +" Es impar");
        }
    }
}
