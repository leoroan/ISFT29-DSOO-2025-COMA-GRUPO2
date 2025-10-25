using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosEmpresa
{
    internal class Empleado
    {
        private string _nombre;
        private int _edad;
        private string _cargo;

        public Empleado(string nombre, int edad, string cargo)
        {
            this._nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this._edad = edad;
            this._cargo = cargo ?? throw new ArgumentNullException(nameof(cargo));
        }

        public string Nombre { get => this._nombre; set => this._nombre = value; }
        public int Edad { get => this._edad; set => this._edad = value; }
        public string Cargo { get => this._cargo; set => this._cargo = value; }

        public override string ToString()
        {
            return $"Empleado : {this.Nombre}, Edad: {this.Edad}, Cargo: {this.Cargo}";
        }


    }
}
