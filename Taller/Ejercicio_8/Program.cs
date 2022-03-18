using System;

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su capital: ");
            float capital=float.Parse(Console.ReadLine());
            float porcentajeMensual = 2f / 100f;
            float gananciaMensual = capital * porcentajeMensual;
            float gananciaTotal = capital + gananciaMensual;
            Console.WriteLine("Capital invertido: "+capital+"  Porcentaje mensual: 2%");
            Console.WriteLine("Ganancia mensual: "+gananciaMensual+" Ganancia total: "+gananciaTotal);

        }
    }
}
