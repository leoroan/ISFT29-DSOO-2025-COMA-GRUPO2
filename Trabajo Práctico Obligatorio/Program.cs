using ColeccionDeDatos;
using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static Biblioteca biblioteca = new Biblioteca();
    static void Main(string[] args)
    {
        //inicializamos la biblioteca con algunos libros

        List<Libro> libros = new List<Libro>
{
    new() { Titulo = "A", Autor = "Autor A" },
    new() { Titulo = "B", Autor = "Autor B" },
    new() { Titulo = "C", Autor = "Autor C" },
    new() { Titulo = "D", Autor = "Autor D" },
    new() { Titulo = "E", Autor = "Autor E" },
    new() { Titulo = "F", Autor = "Autor F" },
    new() { Titulo = "G", Autor = "Autor G" },
    new() { Titulo = "H", Autor = "Autor H" },
    new() { Titulo = "I", Autor = "Autor I" },
    new() { Titulo = "J", Autor = "Autor J" }
};
        foreach (var libro in libros)
            biblioteca.AgregarLibro(libro);
        ////
        
        ///////////Menu de opciones
        int opcion;
        do
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Alta de Lector");
            Console.WriteLine("2. Prestar Libro");
            Console.WriteLine("0. Salir");
            Console.Write("Elija una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    biblioteca.ProcesarAltaLector();
                    break;
                case 2:
                    Console.WriteLine(biblioteca.ProcesarPrestarLibro());
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción inválida, intente nuevamente.");
                    break;
            }

        } while (opcion != 0);
        
        //foreach (var libro in libros)
        //    biblioteca.AgregarLibro(libro);

        //var lectores = new List<Lector>
        //{
        //    new("Ana", 1),
        //    new("Luis", 2),
        //    new("Marta", 3)
        // };
        //foreach (var lector in lectores)
        //    biblioteca.AgregarLector(lector);

        //Console.WriteLine("Prueba: Debe haber 10 libros en la biblioteca");
        //Debug.Assert(biblioteca.Libros.Count == 10, "Debe haber 10 libros en la biblioteca");

        //Console.WriteLine("Prueba: Debe haber 3 lectores en la biblioteca");
        //Debug.Assert(biblioteca.Lectores.Count == 3, "Debe haber 3 lectores en la biblioteca");

        //Console.WriteLine("Prueba: Buscar 'Rayuela' de Julio Cortázar");
        //var libroBuscado = biblioteca.BuscarLibroPorTitulo("Rayuela");
        //Debug.Assert(libroBuscado != null && libroBuscado.Autor == "Julio Cortázar", "Debe encontrar 'Rayuela' de Julio Cortázar");

        //Console.WriteLine("Prueba: Buscar lector 'Luis'");
        //var lectorBuscado = biblioteca.BuscarLectorPorNombre("Luis");
        //Debug.Assert(lectorBuscado != null && lectorBuscado.Nombre == "Luis", "Debe encontrar al lector Luis");

        //Console.WriteLine("Prueba: Prestar 'Rayuela' a Ana");
        //bool prestado = biblioteca.PrestarLibro(lectores[0], libroBuscado);
        //Debug.Assert(prestado, "Debe poder prestar 'Rayuela'");
        //Debug.Assert(libroBuscado.Prestado, "'Rayuela' debe estar marcado como prestado");

        //Console.WriteLine("Prueba: No se puede prestar 'Rayuela' dos veces");
        //bool prestado2 = biblioteca.PrestarLibro(lectores[0], libroBuscado);
        //Debug.Assert(!prestado2, "No debe poder prestar 'Rayuela' dos veces");

        //Console.WriteLine("Prueba: Devolver 'Rayuela'");
        //bool devuelto = biblioteca.DevolverLibro(libroBuscado);
        //Debug.Assert(devuelto, "Debe poder devolver 'Rayuela'");
        //Debug.Assert(!libroBuscado.Prestado, "'Rayuela' debe estar marcado como no prestado");

        //Console.WriteLine("Prueba: No se puede devolver 'Rayuela' si no está prestado");
        //bool devuelto2 = biblioteca.DevolverLibro(libroBuscado);
        //Debug.Assert(!devuelto2, "No debe poder devolver 'Rayuela' si no está prestado");

        //Console.WriteLine("¡Todas las pruebas pasaron correctamente!");
    }

    
}