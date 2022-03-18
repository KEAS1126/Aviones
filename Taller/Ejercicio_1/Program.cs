using System;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese tres numeros: ");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float num3 = float.Parse(Console.ReadLine());

            Console.WriteLine(num1 + "+" + num2 + "+" + num3 + "=" + Suma(num1, num2, num3));

        }
        static float Suma(float num1, float num2, float num3)
        {
            float suma = num1 + num2 + num3;

            return suma;
        }
    }
}
