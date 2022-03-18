using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_POO
{
    internal class Modulo_clientes
    {
        string Nombre;
        string Direccion;
        string Telefono;
        string Cedula;

        public string GetNombre()
        {
            return Nombre;
        }
        public void SetNombre( string Nombre)
        {
            this.Nombre = Nombre;
        }
        public string GetDireccion()
        {
            return Direccion;
        }
        public void SetDireccion(string Direccion)
        {
            this.Direccion = Direccion;
        }

        public string GetTelefono()
        {
            return Telefono;
        }
        public void SetTelefono(string Telefono)
        {
            this.Telefono = Telefono;
        }
        public string GetCedula()
        {
            return Cedula;
        }
        public void SetCedula(string Cedula)
        {
            this.Cedula = Cedula;
        }
        public string GetDocumento()
        {
            return Cedula;
        }
        


    }



}
