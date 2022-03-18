using System;

namespace Ejercicio_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); Console.WriteLine("Ingrese la capacidad en litros del baldes: ");
            int balde = int.Parse(Console.ReadLine());
            int tiempo = 90;

            int llenar = balde * tiempo;
            Console.WriteLine("El balde de " + balde + " litros se demora: " + llenar + " minutos");

        }
    }
    }
