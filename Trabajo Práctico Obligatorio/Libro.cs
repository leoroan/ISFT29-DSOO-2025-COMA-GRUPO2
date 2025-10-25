using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionDeDatos
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private bool prestado;
        public Libro() { }

        public Libro(string titulo, string autor)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.prestado = false;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public bool Prestado { get => prestado; set => prestado = value; }

        public override string ToString()
        {
            return $"Título: {titulo}, Autor: {autor}";
        }
    }
}
    
