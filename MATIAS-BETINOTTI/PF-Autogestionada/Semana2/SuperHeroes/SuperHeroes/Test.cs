using System;
using Semana2;
public class Test
{
    public static void Main()
    {
        SuperHeroe batman = new SuperHeroe("Batman", 90, 70, 0);
        SuperHeroe superman = new SuperHeroe("Superman", 95, 60, 70);

        string primeraBatalla = batman.competir(superman);
        string segundaBatalla = superman.competir(batman);

        Console.WriteLine("Resultado de Batman vs. Superman: " + primeraBatalla);
        Console.WriteLine("Resultado de Superman vs. Batman: " + segundaBatalla);
    }
}
