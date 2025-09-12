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

        //public void RemoverLibro(Libro libro)
        //{
        //    libros.Remove(libro);
        //}

        //public void RemoverLector(Lector lector)
        //{
        //    lectores.Remove(lector);
        //}
        public Libro BuscarLibroPorTitulo(string titulo)
        {
            return libros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }

        //public Lector BuscarLectorPorNombre(string nombre)
        //{
        //    return lectores.FirstOrDefault(l => l.Nombre == nombre);
        //}
        public bool ExisteLectorPorDni(long Dni)
        {
            bool existe = false;
            Lector lector = lectores.FirstOrDefault(l => l.Dni == Dni);
            if (lector!=null) existe = true;
            return existe;
        }
        public bool ExisteLectorLibro(string titulo)
        {
            bool existe = false;
            Libro libro = libros.FirstOrDefault(l => l.Titulo == titulo);
            if (libro != null) existe = true;
            return existe;
        }

        //public bool PrestarLibro(Lector lector, Libro libro)
        //{
        //    return (!libro.Prestado && lector.LibrosPrestados.Count < MAX_LIBROS_PRESTADOS)
        //        ? Prestar(lector, libro)
        //        : false;
        //}
        public string PrestarLibro()
        {
            //pido lector y libro
            string TituloLibro = string.Empty;
            int DNI = 0;
            do
            {
                Console.Write("Ingrese el titulo del libro: ");
                TituloLibro = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(TituloLibro))
                {
                    Console.WriteLine("⚠️ El valor no puede estar vacío, por favor intente de nuevo.\n");
                }

            } while (string.IsNullOrWhiteSpace(TituloLibro));

            string entrada = string.Empty;
            do
            {
                Console.Write("Ingrese el DNI del Lector: ");
                entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("⚠️ El valor no puede estar vacío, por favor intente de nuevo.\n");
                    continue; // vuelve al inicio del bucle
                }

                // Intentar convertir a número
                if (!int.TryParse(entrada, out DNI))
                {
                    Console.WriteLine("⚠️ Debe ingresar solo números válidos.\n");
                    entrada = null; // fuerza a repetir
                }

            } while (string.IsNullOrWhiteSpace(entrada));

            Lector lectorBusqueda = new Lector() {Dni = DNI };
            Libro libroBusqueda = new Libro() { Titulo = TituloLibro };

            Lector lectorEncontrado = lectores.FirstOrDefault(l => l.Dni == lectorBusqueda.Dni);
            Libro libroEncontrado = libros.FirstOrDefault(l => l.Titulo == libroBusqueda.Titulo);


            if (lectorEncontrado != null)//existe el lector
            {
                if (libroEncontrado != null) //existe el libro
                {
                    if (!libroEncontrado.Prestado && lectorEncontrado.LibrosPrestados.Count < MAX_LIBROS_PRESTADOS)
                    {
                        Prestar(lectorEncontrado, libroEncontrado);
                        return "PRESTAMO EXITOSO";
                    }
                    else if (libroEncontrado.Prestado) 
                    {
                        return "LIBRO NO DISPONIBLE";
                    }
                    else // lector tiene 3 libros prestados
                    {
                        return "TOPE DE PRESTAMO ALCAZADO";
                    }
                }
                else //no existe el libro
                {
                    return "LIBRO INEXISTENTE";
                }
            }
            else //no existe el lector
            {
                return "LECTOR INEXISTENTE";
            }
        }

        private bool Prestar(Lector lector, Libro libro)
        {
            lector.PrestarLibro(libro);
            libro.Prestado = true;
            //this.RemoverLibro(libro);
            return true;
        }

        //public bool DevolverLibro(Libro libro)
        //{
        //    var lector = lectores.FirstOrDefault(l => l.LibrosPrestados.Contains(libro));
        //    if (lector != null && libro.Prestado)
        //    {
        //        return Devolver(lector, libro);
        //    }
        //    return false;
        //}

        //private bool Devolver(Lector lector, Libro libro)
        //{
        //    lector.DevolverLibro(libro);
        //    libro.Prestado = false;
        //    this.AgregarLibro(libro);
        //    return true;
        //}
        public bool altaLector()
        {
            string NombreLector = string.Empty;
            int DNI = 0;
            do
            {
                Console.Write("Ingrese el Nombre  del Lector: ");
                NombreLector = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(NombreLector))
                {
                    Console.WriteLine("El valor no puede estar vacío, por favor intente de nuevo.\n");
                }

            } while (string.IsNullOrWhiteSpace(NombreLector));

            string entrada = string.Empty;
            do
            {
                Console.Write("Ingrese el DNI del Lector: ");
                entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("El valor no puede estar vacío, por favor intente de nuevo.\n");
                    continue; // vuelve al inicio del bucle
                }

                // Intentar convertir a número
                if (!int.TryParse(entrada, out DNI))
                {
                    Console.WriteLine("Debe ingresar solo números válidos.\n");
                    entrada = null; // fuerza a repetir
                }

            } while (string.IsNullOrWhiteSpace(entrada));

            //verificamos si el lector ya existe
            if (ExisteLectorPorDni(DNI))
            {
                Console.WriteLine("El lector ya existe en la base de datos.");
                return false;
            }
            else 
            {
                Console.WriteLine("Lector dado de Alta.");
                lectores.Add( new Lector(NombreLector,DNI));
                return true;
            }
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
