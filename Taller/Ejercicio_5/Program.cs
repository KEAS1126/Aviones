using System;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su distancia en kilometros: ");
            float distancia = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tiempo en horas: ");
            float tiempo = float.Parse(Console.ReadLine());
            FormulaVelocidad(distancia,tiempo);




        }
        static void FormulaVelocidad(float distancia,float tiempo)
        {
            float velocidad = distancia / tiempo;
            Console.WriteLine(distancia+" Km "+" ÷ "+tiempo+" h "+" = "+velocidad+" Km/h");
        }
    }
}
