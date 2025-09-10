using ColeccionDeDatos;
using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        var biblioteca = new Biblioteca();

        var libros = new List<Libro>
    {
        new() { Titulo = "Cien años de soledad", Autor = "Gabriel García Márquez" },
        new() { Titulo = "Don Quijote de la Mancha", Autor = "Miguel de Cervantes" },
        new() { Titulo = "La sombra del viento", Autor = "Carlos Ruiz Zafón" },
        new() { Titulo = "Rayuela", Autor = "Julio Cortázar" },
        new() { Titulo = "El amor en los tiempos del cólera", Autor = "Gabriel García Márquez" },
        new() { Titulo = "Pedro Páramo", Autor = "Juan Rulfo" },
        new() { Titulo = "Ficciones", Autor = "Jorge Luis Borges" },
        new() { Titulo = "El túnel", Autor = "Ernesto Sabato" },
        new() { Titulo = "La ciudad y los perros", Autor = "Mario Vargas Llosa" },
        new() { Titulo = "Sobre héroes y tumbas", Autor = "Ernesto Sabato" }
    };
        foreach (var libro in libros)
            biblioteca.AgregarLibro(libro);

        var lectores = new List<Lector>
    {
        new("Ana", 1),
        new("Luis", 2),
        new("Marta", 3)
    };
        foreach (var lector in lectores)
            biblioteca.AgregarLector(lector);

        Console.WriteLine("Prueba: Debe haber 10 libros en la biblioteca");
        Debug.Assert(biblioteca.Libros.Count == 10, "Debe haber 10 libros en la biblioteca");

        Console.WriteLine("Prueba: Debe haber 3 lectores en la biblioteca");
        Debug.Assert(biblioteca.Lectores.Count == 3, "Debe haber 3 lectores en la biblioteca");

        Console.WriteLine("Prueba: Buscar 'Rayuela' de Julio Cortázar");
        var libroBuscado = biblioteca.BuscarLibroPorTitulo("Rayuela");
        Debug.Assert(libroBuscado != null && libroBuscado.Autor == "Julio Cortázar", "Debe encontrar 'Rayuela' de Julio Cortázar");

        Console.WriteLine("Prueba: Buscar lector 'Luis'");
        var lectorBuscado = biblioteca.BuscarLectorPorNombre("Luis");
        Debug.Assert(lectorBuscado != null && lectorBuscado.Nombre == "Luis", "Debe encontrar al lector Luis");

        Console.WriteLine("Prueba: Prestar 'Rayuela' a Ana");
        bool prestado = biblioteca.PrestarLibro(lectores[0], libroBuscado);
        Debug.Assert(prestado, "Debe poder prestar 'Rayuela'");
        Debug.Assert(libroBuscado.Prestado, "'Rayuela' debe estar marcado como prestado");

        Console.WriteLine("Prueba: No se puede prestar 'Rayuela' dos veces");
        bool prestado2 = biblioteca.PrestarLibro(lectores[0], libroBuscado);
        Debug.Assert(!prestado2, "No debe poder prestar 'Rayuela' dos veces");

        Console.WriteLine("Prueba: Devolver 'Rayuela'");
        bool devuelto = biblioteca.DevolverLibro(libroBuscado);
        Debug.Assert(devuelto, "Debe poder devolver 'Rayuela'");
        Debug.Assert(!libroBuscado.Prestado, "'Rayuela' debe estar marcado como no prestado");

        Console.WriteLine("Prueba: No se puede devolver 'Rayuela' si no está prestado");
        bool devuelto2 = biblioteca.DevolverLibro(libroBuscado);
        Debug.Assert(!devuelto2, "No debe poder devolver 'Rayuela' si no está prestado");

        Console.WriteLine("¡Todas las pruebas pasaron correctamente!");
    }
}