using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
           float vPesos=Pesos();


            Console.WriteLine("ingrese la cantiadad de dolares que desea convertir");
            float dolar = float.Parse(Console.ReadLine());
            float dolar_pesos = dolar*vPesos;
            Console.WriteLine("COP "+dolar_pesos);

            Dolar(vPesos);

        }
        static float Pesos()
        {
            Console.WriteLine("---------------Conversor de dolar a pesos---------------");
            Console.WriteLine("ingrese el valor del peso");
            float vPesos = float.Parse(Console.ReadLine());
            return vPesos;
            
        }
        static void Dolar(float vPesos)
        {
            Console.WriteLine("---------------Conversor de pesos a dolares---------------");
            float dolar = 1;
            float conversor = dolar / vPesos;
            Console.WriteLine("ingrese la cantiadad de pesos que desea convertir");
            float pesos=float.Parse(Console.ReadLine());
            float pesos_dolares = conversor * pesos;
            Console.WriteLine("USD "+pesos_dolares);
        }

    }
}
