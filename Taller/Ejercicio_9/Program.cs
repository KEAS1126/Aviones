using System;

namespace Ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su sueldo: ");
            float sueldo=float.Parse(Console.ReadLine());
            float comision = 10f / 100f;
            float comisionMes = sueldo * comision;
            float sueldoComision = sueldo + comisionMes;
            Console.WriteLine("Sueldo: "+sueldo+"  Porcentaje comision : 10%");
            Console.WriteLine("Comision mes: "+comisionMes+"  Sueldo con comision: "+sueldoComision);
        }
    }
}
