using System;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese las tres notas: ");
            int nota_1 = int.Parse(Console.ReadLine());
            int nota_2 = int.Parse(Console.ReadLine());
            int nota_3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Su nota es: " + CalcularNota(nota_1, nota_2, nota_3));

        }
        static int CalcularNota(int nota_1, int nota_2, int nota_3)
        {

            int notaFinal = (nota_1 + nota_2 + nota_3) / 3;
            return notaFinal;
        }
    }
}
