class Test
{
    static void Main()
    {

        Empresa empresa = new Empresa("Girosoft");

        Empleado empleado = new Empleado("Javier Canteros", 43, "Desarrollador");

        empresa.Empleado = empleado;


        empresa.mostrarInformacion();
    }
}

