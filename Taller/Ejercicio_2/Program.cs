using System;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Suma");
            Console.WriteLine("2.Resta");
            Console.WriteLine("3.Multiplicar");
            Console.WriteLine("4.Dividir");

            Console.WriteLine("Ingrese su opcion: ");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el otro numero: ");
            float num2 = float.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Suma(num1, num2);
                    break;
                case 2:
                    Resta(num1, num2);
                    break;
                case 3:
                    Multiplicar(num1, num2);
                    break;
                case 4:
                    Dividir(num1, num2);
                    break;

            }

        }

        static void Suma(float num1, float num2)
        {
            float suma = num1 + num2;
            Console.WriteLine(num1 + "+" + num2 + "=" + suma);


        }
        static void Resta(float num1, float num2)
        {
            float resta = num1 - num2;
            Console.WriteLine(num1 + "-" + num2 + "=" + resta);

        }

        static void Multiplicar(float num1, float num2)
        {
            float multiplicar = num1 * num2;
            Console.WriteLine(num1 + "X" + num2 + "=" + multiplicar);
        }

        static void Dividir(float num1, float num2)
        {
            float dividir = num1 / num2;
            Console.WriteLine(num1 + "÷" + num2 + "=" + dividir);
        }
    }
}
