using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int loteria = r.Next(1, 101);
            Console.WriteLine("Ingrese el numero: ");
            int numero = int.Parse(Console.ReadLine());
            int intentos = 1;
            while (loteria != numero) {
                
                if (numero < loteria) Console.WriteLine("Estas por debajo del numero ganador");
                else if (numero > loteria) Console.WriteLine("Estas por encima del numero ganador ");
                Console.WriteLine("Ingrese el numero: ");
                numero = int.Parse(Console.ReadLine());
                intentos++;
            }
            Console.WriteLine("Felicitaciones has ganado");
            Console.WriteLine("Numero de intentos: " + intentos);
            Console.WriteLine("Numero ganador"+loteria);


        }
    }
}
