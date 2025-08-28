using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizacionCompartida
{
    internal class Domicilio
    {
        private string _calle;
        private int _numero;
        private string _barrio;

        public Domicilio(string ca, int num, string ba)
        {
            this._calle = ca;
            this._numero = num;
            this._barrio = ba;
        }

        public string Calle
        {
            get { return _calle; }
            set { _calle = value; }
        }

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public string Barrio
        {
            get { return _barrio; }
            set { _barrio = value; }
        }

        public override string ToString()
        {
            return $"Domicilio Calle:{_calle}, número:{_numero}, barrio:{_barrio}";
        }
    }
}
