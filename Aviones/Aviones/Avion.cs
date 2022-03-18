using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviones
{
    internal class Avion
    {

        private int IdAvion;
        private string Modelo;
        private string Aerolinea;
        private string Velocidad;
        private string Motores;

        public void SetIdAvion(int IdAvion)
        {
            this.IdAvion = IdAvion;
        }
        public void SetModelo(string Modelo)
        {
            this.Modelo = Modelo;
        }
        public void SetAerolinea(string Aerolinea)
        {
            this.Aerolinea = Aerolinea;
        }
        public void SetVelocidad(string Velocidad)
        {
            this.Velocidad = Velocidad;
        }

        public void SetMotores(string Motores)
        {
            this.Motores = Motores;
        }

        public string GetAvion()
        {
            return IdAvion + "     " + Modelo + "     " + Aerolinea + "      " + Velocidad + "     " + Motores;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public string GetAerolinea()
        {
            return Aerolinea;
        }

        public string GetVelocidad()
        {
            return Velocidad;
        }
        public string GetMotores()
        {
            return Motores;
        }
    }
}
