using System;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escriba una opcion: ");
                Console.WriteLine("1.convertir de horas a segundos");
                Console.WriteLine("2.convertir de minutos a segundos");
                Console.WriteLine("3.convertir horas y minutos a segundos");
                Console.WriteLine("4.salir");

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("ingrese las horas: ");
                        int horas = int.Parse(Console.ReadLine());
                        HorasSegundos(horas);
                        break;
                    case "2":
                        Console.WriteLine("ingrese los minutos: ");
                        int minutos = int.Parse(Console.ReadLine());
                        MinutosSegundos(minutos);
                        break;
                    case "3":
                        Console.WriteLine("ingrese las horas: ");
                        horas = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese los minutos: ");
                        minutos = int.Parse(Console.ReadLine());
                        HorasMinutosSegundos(horas, minutos);
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                }
               

            }
        }

        static void HorasSegundos(int horas)
        {
            int segundos=(horas*60)*60;
            Console.WriteLine(horas+"h son "+segundos+"seg");
        }
        static void MinutosSegundos(int minutos)
        {
            int segundos = minutos * 60;
            Console.WriteLine(minutos+"min son "+segundos+"seg");
        }
        static void HorasMinutosSegundos(int horas,int minutos)
        {
            int segundos = (horas * 60) * 60 + (minutos * 60);
            Console.WriteLine(horas+"h y "+minutos+"min son "+segundos+"seg");

        }
    }
}
