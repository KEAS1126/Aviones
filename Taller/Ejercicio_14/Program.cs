using System;

namespace Ejercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string articulo = Articulo();
            int unidades = Unidades(articulo);
            int valor=Valor();
            string compra=Compra(valor,unidades);
            Console.WriteLine(compra);  
            
        }
        static string Articulo()
        {
            Console.WriteLine("Ingrese su articulo: ");
            string articulo=Console.ReadLine(); 
            
            return articulo;
        }
        static int Unidades(string articulo)
        {
            Console.WriteLine("¿Cuantas unidades de "+articulo+" desea? ");
            int unidades = int.Parse(Console.ReadLine());
            return unidades;
        }
        static int Valor()
        {
            Console.WriteLine("Ingrese el precio del articulo: ");
            int valor = int.Parse(Console.ReadLine());
            return valor;
        }
        static string Compra(int valor,int unidades)
        {
            float iva = 1.20f;
            int valorSinIva = valor * unidades;
            int valorConIva = valorSinIva * (int)iva;
            return $"{valorSinIva},{ valorConIva}";  
        }


    }
}
