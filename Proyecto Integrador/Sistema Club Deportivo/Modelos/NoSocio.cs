public class NoSocio : Persona
{
  // Campos privados
  private List<PagoEventual> pagosEventuales;

  // Constructor
  public NoSocio(int dni, DateTime fechaNacimiento, string nombre, string apellido,
                string telefono, bool aptoFisico)
                : base(dni, fechaNacimiento, nombre, apellido, telefono, aptoFisico)
  {
    pagosEventuales = new List<PagoEventual>();
  }

  // Propiedad para la colección de pagos
  public List<PagoEventual> PagosEventuales
  {
    get { return pagosEventuales; }
  }

  // Métodos
  public PagoEventual PagarActividad(Actividad actividad)
  {
    if (actividad == null)
      throw new ArgumentNullException(nameof(actividad));

    var pago = new PagoEventual(DateTime.Now, actividad.Valor, MedioPago.Efectivo);
    pagosEventuales.Add(pago);

    Console.WriteLine($"Actividad '{actividad.Nombre}' pagada. Monto: ${actividad.Valor}");
    return pago;
  }

  public override Persona Registrar()
  {
    Console.WriteLine($"No Socio {Nombre} {Apellido} registrado exitosamente.");
    return this;
  }
}
