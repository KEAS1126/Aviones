using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviones
{
    internal class AvionServicio
    {

        List<Avion> aviones = new();
        public void Crear()
        {

            Avion avion = new();
            Random rand = new Random();
            int id_codigo = rand.Next(1, 1000);
            avion.SetIdAvion(id_codigo);


            Console.WriteLine("Ingrese el modelo del avion: ");
            avion.SetModelo(Console.ReadLine());

            Console.WriteLine("Ingrese la aerolinea del avion: ");
            avion.SetAerolinea(Console.ReadLine());

            Console.WriteLine("Ingrese la velocidad del avion: ");
            avion.SetVelocidad(Console.ReadLine());

            Console.WriteLine("Ingrese los motores del avion: ");
            avion.SetMotores(Console.ReadLine());



            aviones.Add(avion);

        }

        public void Listar()
        {
            foreach (Avion avion in aviones)
            {
                Console.WriteLine(avion.GetAvion());
            }

        }

        public void Editar()
        {


            foreach (Avion avion in aviones)
            {
                Console.WriteLine("Ingrese el modelo que desea editar: ");
                string modelo = Console.ReadLine();

                if (avion.GetModelo() == modelo)
                {
                    Console.WriteLine("Ingrese su modelo: ");    
                    modelo = Console.ReadLine();
                    avion.SetModelo(modelo);
                    Console.WriteLine("Se registro con exito");

                }
                else
                {
                    Console.WriteLine("El modelo no se encuentra registrado");
                }


                
            }

            Avion avion1=new ();
            Console.WriteLine("Ingrese la aerolinea que desea editar: ");
            string aerolinea=Console.ReadLine();
            Avion dato = aviones.Find(dato=>avion1.GetAerolinea()==aerolinea);

            if (dato.Equals( aerolinea))
            {
                Console.WriteLine("Ingrese su aerolinea: ");
                aerolinea = Console.ReadLine();
                avion1.SetAerolinea(aerolinea);
                Console.WriteLine("Se registro con exito");
            }
            else
            {
                Console.WriteLine("El modelo no se encuentra aerolinea");
            }

            

        }
    }
}
