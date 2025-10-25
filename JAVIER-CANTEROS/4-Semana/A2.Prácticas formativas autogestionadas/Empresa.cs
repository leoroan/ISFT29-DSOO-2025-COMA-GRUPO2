using System;

class Empresa
{
    private string nombreEmpresa;
    private Empleado empleado;

    public Empresa(string nombreEmpresa)
    {
        this.nombreEmpresa = nombreEmpresa;
    }
    public Empleado Empleado
    {
        get { return empleado; }
        set { empleado = value; }
    }

    // Método para mostrar la información del empleado por consola
    public void mostrarInformacion()
    {
        Console.WriteLine("Nombre de la Empresa: " + nombreEmpresa);
        Console.WriteLine("Empleado: ");
        empleado.MostrarInformacion();
    }
}