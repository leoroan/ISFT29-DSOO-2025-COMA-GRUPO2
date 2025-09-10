using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionDeDatos
{
    internal class Lector
    {
        private string nombre;
        private int dni;
        private List<Libro> librosPrestados;

        public Lector(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.librosPrestados = new List<Libro>();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Dni { get => dni; set => dni = value; }
        public List<Libro> LibrosPrestados { get => librosPrestados; set => librosPrestados = value; }

        public void PrestarLibro(Libro libro)
        {
            librosPrestados.Add(libro);
        }

        public void DevolverLibro(Libro libro)
        {
            librosPrestados.Remove(libro);
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}, DNI: {dni}";
        }


    }
}
