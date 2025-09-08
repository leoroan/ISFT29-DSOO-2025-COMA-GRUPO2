using VisualizacionCompartida;

internal class Program
{
  internal static void Main(string[] args)
  {
    // Creo el domicilio
    Domicilio dom1 = new Domicilio("Jonte", 5299, "Monte Castro");
    Domicilio dom2 = new Domicilio("Jonte", 5301, "Monte Castro");

    // Creo la tele
    Television tv = new Television("Sony", "TV-FHD", 24);

    // Creo las personas en domicilios distintos
    Persona p1 = new Persona("Facundo", dom1);
    Persona p2 = new Persona("Camila", dom2);

    // veo si los domicilios son iguales (debería ser falso)
    Console.WriteLine("El domicilio es el mismo? (debería ser falso)");
    Console.WriteLine(p1.ToString());
    Console.WriteLine(p2.ToString());
    Console.WriteLine("assert false?: " + (p1.Domicilio == p2.Domicilio));

    // asigno el mismo domicilio a ambos
    p2.Domicilio = dom1;
    Console.WriteLine("El domicilio es el mismo? (ahora debería ser verdadero)");
    Console.WriteLine("assert true?: " + (p1.Domicilio == p2.Domicilio));

    // Asigno la misma TV a ambos
    p1.Tv = tv;
    p2.Tv = tv;

    // me fijo si la TV es la misma
    Console.WriteLine("La TV es la misma? (debería ser verdadero)");
    Console.WriteLine("assert true?: " + (p1.Tv == p2.Tv));

    // Estado inicial de la TV
    Console.WriteLine("Estado inicial de la TV (debería estar apagada):");
    Console.WriteLine(p1.Tv.ToString());

    // Prendo la TV
    p1.Tv.ToggleEstado();
    Console.WriteLine("Estado tras encender la TV:");
    Console.WriteLine(p1.Tv.ToString());

    // Cambio de canal
    bool cambioCanal = p1.Tv.CambiarCanal(9);
    Console.WriteLine($"Cambio de canal a 9 exitoso?: {cambioCanal}");
    Console.WriteLine(p1.Tv.ToString());

    // Cambio de canal al siguiente
    p1.Tv.CambiarCanal();
    Console.WriteLine("Cambio de canal al siguiente:");
    Console.WriteLine(p1.Tv.ToString());

    // Probamos el tope de canales
    p1.Tv.CambiarCanal(150);
    p1.Tv.CambiarCanal(); // cambia al canal 1
    Console.WriteLine("Cambio de canal tras llegar al tope (debería ser canal 1):");
    Console.WriteLine(p1.Tv.ToString());

    // Interviene la otra persona
    Console.WriteLine("Intervención de la otra persona:");
    p2.Tv.CambiarCanal(14);
    Console.WriteLine(p2.Tv.ToString());

    // Apagamos la TV
    p2.Tv.ToggleEstado();
    Console.WriteLine("Estado tras que la otra persona apaga la TV:");
    Console.WriteLine(p2.Tv.ToString());

    // Intentamos cambiar de canal estando apagada (debería fallar)
    bool cambioApagado = p1.Tv.CambiarCanal(19);
    Console.WriteLine($"Intento de cambio de canal estando apagada exitoso?: {cambioApagado}");
    Console.WriteLine(p1.Tv.ToString());
  }
}