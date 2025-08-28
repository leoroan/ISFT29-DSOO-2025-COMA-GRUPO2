internal class Program
{
  internal static void Main(string[] args)
  {
    //creamos el domicilio
    Domicilio dom1 = new Domicilio("Jonte", 5299, "Monte Castro");

    //un domicilio distinto de prueba
    Domicilio dom2 = new Domicilio("Jonte", 5301, "Monte Castro");


    //creamos la tele
    Television tv = new Television("Sony", "TV-FHD", 24);

    //creamos las personas en el mismo domicilio
    Persona p1 = new Persona("Facundo", dom1);
    Persona p2 = new Persona("Camila", dom2);

    //Vemos que ambos vivan juntos
    Console.WriteLine("El domicilio es el mismo? (deberia ser falso)");
    Console.WriteLine(p1.ToString());
    Console.WriteLine(p2.ToString());
    Console.WriteLine("assert true?: " + (p1.Domicilio == p2.Domicilio));

    //Ahora asigno el mismo domicilio para ambos 
    p2.Domicilio = dom1;
    Console.WriteLine("El domicilio es el mismo? (ahora deberia ser verdadero)");
    Console.WriteLine("assert true?: " + (p1.Domicilio == p2.Domicilio));

    //le damos la tele a las personas (podría haber sido desde el constructor tambien!)
    p1.Tv = tv;
    p2.Tv = tv;

    //Vemos que ambos compartan la misma television
    Console.WriteLine("La TV es la misma? (deberia ser Verdadero)");
    Console.WriteLine("assert true?: " + (p1.Tv == p2.Tv));

    // probamos que el tv lo tenga una persona y su estado.
    Console.WriteLine(p1.ToString());

    //la encendemos y vemos su estado
    p1.Tv.ToggleEstado();
    Console.WriteLine(p1.ToString());

    //hacemos que cambie de canal
    p1.Tv.cambiarCanal(9);
    Console.WriteLine(p1.ToString());

    //hacemos q intervenga la otra persona
    Console.WriteLine(p2.ToString());
    p2.Tv.cambiarCanal(14);
    Console.WriteLine(p2.ToString());
    p2.Tv.ToggleEstado();
    p1.Tv.cambiarCanal(19);
    Console.WriteLine(p1.ToString());


  }
}
