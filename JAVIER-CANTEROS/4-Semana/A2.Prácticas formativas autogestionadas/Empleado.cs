using System;

class Empleado
{
    private string nombre;
    private int edad;
    private string cargo;

    public Empleado(string nombre, int edad, string cargo)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.cargo = cargo;
    }
    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: " + nombre + "," + "Edad: " + edad + "," + "Cargo: " + cargo);
    }
}
