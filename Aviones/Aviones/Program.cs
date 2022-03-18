using System;

namespace Aviones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AvionServicio datos = new();
     

            while (true) {
                Console.WriteLine("Ingrese una opcion: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                       
                        datos.Crear();
                        break;
                    case "2":
                        datos.Listar();
                        break;
                    case "3":
                        datos.Editar();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            }

            

           
            

            
            
        }
    }
}
