using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizacionCompartida
{
    internal class Persona
    {
        private string _nombre;
        private Domicilio _domicilio;
        private Television _tv;

        public Persona(string n, string c, int num, string ba)
        {
            Domicilio dom = new Domicilio(c, num, ba);
            this._nombre = n;
            this._domicilio = dom;
        }

        public Persona(string nombre, Domicilio dom)
        {
            this._nombre = nombre;
            this._domicilio = dom;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Television Tv
        {
            get { return _tv; }
            set { _tv = value; }
        }

        public Domicilio Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }

        public override string ToString()
        {
            if (this._tv != null)
            {
                return $"Persona Nombre:{_nombre}, vive en: " + _domicilio.ToString() + " y tiene TV: " + this._tv.ToString();
            }
            return $"Persona Nombre:{_nombre} " + _domicilio.ToString();
        }
    }
}
