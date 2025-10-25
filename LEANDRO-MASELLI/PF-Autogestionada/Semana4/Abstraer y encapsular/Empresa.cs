using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleadosEmpresa
{
    internal class Empresa
    {
        private string _nombre;
        private List<Empleado> _empleados;

        public Empresa(string nombre)
        {
            this._nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this._empleados = new List<Empleado>();
        }

        public string Nombre { get => this._nombre; set => this._nombre = value; }
        public List<Empleado> Empleados { get => this._empleados; set => this._empleados = value; }
        public void AgregarEmpleado(Empleado empleado)
        {
            _empleados.Add(empleado);
        }

        public override string ToString()
        {
            return $"Empresa: {this.Nombre}, Empleados: {this.Empleados.Count}";
        }
    }
}
