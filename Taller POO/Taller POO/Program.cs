using System;
using System.Collections.Generic;

namespace Taller_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Modulo_clientes cliente = new();
            Console.WriteLine("Ingrese su nombre: ");
            string nombre=Console.ReadLine();
            cliente.SetNombre(nombre);
            Console.WriteLine("Ingrese su direccion: ");
            string direccion = Console.ReadLine();
            cliente.SetDireccion(direccion);
            Console.WriteLine("Ingrese su numero de telefono: ");
            string telefono = Console.ReadLine();
            cliente.SetTelefono(telefono);
            Console.WriteLine("Ingrese su documento de indentidad: ");
            string cedula= Console.ReadLine();
            cliente.SetCedula(cedula);


            List<string> clientes = new List<string>();

            clientes.Add(Obtener(cliente));
            Console.WriteLine(clientes[0]);

            
            
        }

        static string Obtener(Modulo_clientes cliente)
        {
            return cliente.GetNombre() + cliente.GetDireccion() + cliente.GetTelefono() + cliente.GetCedula();
        }




    }
}
