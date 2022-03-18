using System;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de Km de su recorrido: ");
            float kilometros=float.Parse(Console.ReadLine());
            float valor =( kilometros * 150)*2;
            if (kilometros > 1000)
            {
                float descuento = 30f / 100f;
                float aplicaDescuento = valor-(valor * descuento);
                Console.WriteLine("Su descuento  es: "+" $"+aplicaDescuento);

            } else Console.WriteLine("No aplica descuento: "+" $"+valor);

        }
       
    
        
    }
}
