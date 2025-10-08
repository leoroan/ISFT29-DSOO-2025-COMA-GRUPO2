public class E_NoSocio : E_Persona
{
  // Campos privados
  private List<E_PagoEventual> pagosEventuales;

  // Constructor
  public E_NoSocio(int dni, DateTime fechaNacimiento, string nombre, string apellido,
                string telefono,string domicilio, bool aptoFisico)
                : base(dni, fechaNacimiento, nombre, apellido, telefono,domicilio, aptoFisico)
  {
    pagosEventuales = new List<E_PagoEventual>();
  }

  // Propiedad para la colección de pagos
  public List<E_PagoEventual> PagosEventuales
  {
    get { return pagosEventuales; }
  }

  // Métodos
  public E_PagoEventual PagarActividad(E_Actividad actividad)
  {
    if (actividad == null)
      throw new ArgumentNullException(nameof(actividad));

    var pago = new E_PagoEventual(DateTime.Now, actividad.Valor, MedioPago.Efectivo);
    pagosEventuales.Add(pago);

    Console.WriteLine($"Actividad '{actividad.Nombre}' pagada. Monto: ${actividad.Valor}");
    return pago;
  }

  public override E_Persona Registrar()
  {
    Console.WriteLine($"No Socio {Nombre} {Apellido} registrado exitosamente.");
    return this;
  }
}
