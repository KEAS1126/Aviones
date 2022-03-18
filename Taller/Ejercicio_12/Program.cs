using System;

namespace Ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de hombres en el grupo: ");
            int hombres = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de mujeres en el grupo: ");
            int mujeres = int.Parse(Console.ReadLine());

            Console.WriteLine(Porcentaje(hombres,mujeres));
        }
        static string Porcentaje(int hombres, int mujeres)
        {
            int totalAlumnos = hombres + mujeres;
            int porcentajeHombres = (100*hombres)/totalAlumnos;
            int porcentajeMujeres = (100*mujeres) / totalAlumnos;

            return $"Hombres: {porcentajeHombres}% Mujeres: {porcentajeMujeres}%";

        }

    }
}
