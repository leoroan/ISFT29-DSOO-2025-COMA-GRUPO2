using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPostulantesForm
{
    internal class Postulante
    {
        private string _nombre;
        private string _apellido;
        private string _tipoDocumento;
        private string _numeroDocumento;

        public Postulante(string nombre, string apellido, string tipoDocumento, string numeroDocumento)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.TipoDocumento = tipoDocumento;
            this.NumeroDocumento = numeroDocumento;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string TipoDocumento { get => _tipoDocumento; set => _tipoDocumento = value; }
        public string NumeroDocumento { get => _numeroDocumento; set => _numeroDocumento = value; }

        public override string ToString()
        {
            return $"Datos postulante: Nombre: {this.Nombre}, Apellido: {this.Apellido}, Tipo de Documento: {this.TipoDocumento}, Número de Documento: {this.NumeroDocumento}";
        }




    }
}
