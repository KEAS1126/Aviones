using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keas1126
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("ingrese su edad");
            edad=int.Parse (Console.ReadLine());

            mayor_edad(edad);

        }

        static void mayor_edad(int edad)
        {
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else {
                Console.WriteLine("No es mayor de edad");
                    }


}
    }
}
