using EmpleadosEmpresa;
using System.ComponentModel;
internal class Program
{
    internal static void Main(string[] args)
    {
        Empresa empresa = new Empresa("Tech Solutions");

        Empleado empleado1 = new Empleado("Ana", 1, "administrativo");
        Empleado empleado2 = new Empleado("Luis", 2, "administrativo");
        Empleado empleado3 = new Empleado("Marta", 3, "gerente");

        //empresa.AgregarEmpleado(empleado1);
        //empresa.AgregarEmpleado(empleado2);
        //empresa.AgregarEmpleado(empleado3);

        List<Empleado> empleados = new List<Empleado> { empleado1, empleado2, empleado3 };
        empresa.Empleados = empleados;

        Console.WriteLine(empresa.ToString());
        foreach (var empleado in empresa.Empleados)
        {
            Console.WriteLine(empleado.ToString());
        }
    }
}