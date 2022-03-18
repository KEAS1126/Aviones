using System;

namespace Ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horasT=0;
            int horasV = 0;
            string nombre = Nombre();
            int salario = HorasTrabajadas(horasT) * ValorHoras(horasV);
            
            Console.WriteLine(nombre+" tiene un salario de "+" $ "+salario);

        }
        static string Nombre()
        {
            Console.WriteLine("Ingrese su nombre: ");
            String nombre = Console.ReadLine();
            return nombre;

        }
        static int HorasTrabajadas(int horasT)
        {
            Console.WriteLine("Ingrese las horas trabajadas: ");
            horasT = int.Parse(Console.ReadLine());
            return horasT;
        }
        static int ValorHoras(int horasV)
        {
            Console.WriteLine("Ingrese el valor por hora: ");
            horasV = int.Parse(Console.ReadLine());
            return horasV;
        }

    }
}
