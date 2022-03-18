using System;

namespace Ejercicio_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float tiempo = 5f;
            float montaña = 7f;
            float mitadMontaña = 3.5f;
            float tiempoMitad = tiempo * mitadMontaña/montaña;
            Console.WriteLine("La mitad del recorrido tiene una distancia de: "+tiempoMitad+" metros");
        }
    }
}
