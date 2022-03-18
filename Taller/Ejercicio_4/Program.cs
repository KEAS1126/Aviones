using System;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese tres notas: ");
            float nota_1 = float.Parse(Console.ReadLine());
            float nota_2 = float.Parse(Console.ReadLine());
            float nota_3 = float.Parse(Console.ReadLine());
            float promedio_1 = 20f / 100f;
            float promedio_2 = 30f / 100f;
            float promedio_3 = 50f / 100f;
         
            Console.WriteLine("Su nota es: "+CalcularNota(nota_1, nota_2, nota_3, promedio_1, promedio_2, promedio_3));
        }
        static float CalcularNota(float nota_1, float nota_2, float nota_3, float promedio_1, float promedio_2, float promedio_3)
        {

            float notaFinal = ((nota_1 * promedio_1) + (nota_2 * promedio_2) + (nota_3 * promedio_3)) / 3;
            return notaFinal;
        }
    }
}
