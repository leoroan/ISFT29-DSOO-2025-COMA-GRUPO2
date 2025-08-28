public class Program
{
    internal static void Main(string[] args)
    {
        SuperHeroe superHeroe1 = new SuperHeroe("Batman", 90, 70, 0);
        SuperHeroe superHeroe2 = new SuperHeroe("Superman", 95, 60, 70);
        Console.WriteLine(superHeroe1.ToString());
        Console.WriteLine(superHeroe2.ToString());
        string resultado1 = superHeroe1.Competir(superHeroe2);
        Console.WriteLine("1° " + resultado1); // Debería ser DERROTA
        string resultado2 = superHeroe2.Competir(superHeroe1);
        Console.WriteLine("2° " + resultado2); // Debería ser TRIUNFO
    }
}