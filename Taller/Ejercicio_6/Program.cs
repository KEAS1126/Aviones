using System;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float iva=1.19f;
            float descuento = 0.10f;
            
            Console.WriteLine("Ingrese el nombre de su producto: ");
            string producto =Console.ReadLine();
            Console.WriteLine("Ingrese el valor del producto: ");
            float valor=float.Parse(Console.ReadLine());

            float aplicaDescuento = Descuento(valor, descuento);
            Console.WriteLine("-----------------Factura--------------------");
            Console.WriteLine("Producto: "+producto+" valor: "+"$"+valor);
            Console.WriteLine("Descuento del 10%: " + "$" + aplicaDescuento + " IVA: " + "$" + Iva(iva, aplicaDescuento));
            Console.WriteLine("Total a pagar: "+ "$" + Iva(iva,aplicaDescuento));


        }
        static float Descuento(float valor, float descuento)
        {

            float aplicaDescuento = valor-(valor * descuento);
            return aplicaDescuento;
        }
        static float Iva(float iva,float aplicaDescuento)
        {
            float aplicaIva = aplicaDescuento * iva;
            return aplicaIva;


        }


        
    }
}
