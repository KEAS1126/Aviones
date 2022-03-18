using System;

namespace Ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el precio del computadora: ");
            float precio=float.Parse(Console.ReadLine());
            float precioSinIva = Descuento(precio);
            Console.WriteLine("Precio sin iva: " + precio);
            Console.WriteLine("Total a pagar: "+PrecioConIva(precioSinIva));
        }
        static float Descuento(float precio)
        {
            float valor = 1000000;
            if (precio>=valor)
            {
                float descuento = 10f / 100f;
                float aplicaDescuento = precio - (precio * descuento);
                return aplicaDescuento;
            }
            else { return  precio; }
        }
        static string PrecioConIva(float precioSinIva)
        {
            float iva = 1.20f;
            float aplicaIva = precioSinIva * iva;
            return $"Precio total:  { aplicaIva}";
        }
    }

}
