using System;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float descuento = 15f / 100f;
            Console.WriteLine("Ingrese el nombre de su producto: ");
            string producto = Console.ReadLine();
            Console.WriteLine("Ingrese el valor de su producto: ");
            float valor = float.Parse(Console.ReadLine());
            Console.WriteLine("Producto: " + producto + " valor: " + valor + " Descuento: 15% ");
            Console.WriteLine("Valor total: " + Descuento(descuento, valor));

        }
        static float Descuento(float descuento, float valor)
        {
            float aplicaDescuento = valor - (descuento * valor);
            return aplicaDescuento;
        }


    }
}
