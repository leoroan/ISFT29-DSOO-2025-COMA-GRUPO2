using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionDeDatos
{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;
        private const int MAX_LIBROS_PRESTADOS = 3;
        public Biblioteca()
        {
            libros = new List<Libro>();
            lectores = new List<Lector>();
        }
        public List<Libro> Libros { get => libros; set => libros = value; }
        public List<Lector> Lectores { get => lectores; set => lectores = value; }

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public void AgregarLector(Lector lector)
        {
            lectores.Add(lector);
        }

        public void RemoverLibro(Libro libro)
        {
            libros.Remove(libro);
        }

        public void RemoverLector(Lector lector)
        {
            lectores.Remove(lector);
        }
        public Libro BuscarLibroPorTitulo(string titulo)
        {
            return libros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }

        public Lector BuscarLectorPorNombre(string nombre)
        {
            return lectores.FirstOrDefault(l => l.Nombre == nombre);
        }

        public bool PrestarLibro(Lector lector, Libro libro)
        {
            return (!libro.Prestado && lector.LibrosPrestados.Count < MAX_LIBROS_PRESTADOS)
                ? Prestar(lector, libro)
                : false;
        }

        private bool Prestar(Lector lector, Libro libro)
        {
            lector.PrestarLibro(libro);
            libro.Prestado = true;
            this.RemoverLibro(libro);
            return true;
        }

        public bool DevolverLibro(Libro libro)
        {
            var lector = lectores.FirstOrDefault(l => l.LibrosPrestados.Contains(libro));
            if (lector != null && libro.Prestado)
            {
                return Devolver(lector, libro);
            }
            return false;
        }

        private bool Devolver(Lector lector, Libro libro)
        {
            lector.DevolverLibro(libro);
            libro.Prestado = false;
            this.AgregarLibro(libro);
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Libros en la biblioteca:");
            foreach (var libro in libros)
            {
                sb.AppendLine(libro.ToString());
            }
            sb.AppendLine("Lectores registrados:");
            foreach (var lector in lectores)
            {
                sb.AppendLine(lector.ToString());
            }
            return sb.ToString();
        }
    }
}
