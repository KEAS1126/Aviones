using System;

namespace Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float parciales = 55f / 100f;
            float examenFinal = 30f / 100f;
            float trabajoFinal = 15f / 100f;
            promedioNotas(parciales, examenFinal, trabajoFinal);

        }
        static void promedioNotas(float parciales, float examenFinal, float trabajoFinal)
        {
            float notaFinal = (parciales + examenFinal + trabajoFinal) / 3;
            Console.WriteLine("Su nota final es: "+notaFinal);
        }

    }
}
