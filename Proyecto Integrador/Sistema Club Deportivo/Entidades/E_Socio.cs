public class E_Socio : E_Persona
{
  // Campos privados
  private DateTime fechaInscripcion;
  private bool estadoMembresia;
  private List<E_Cuota> cuotas;

  // Constructor
  public E_Socio(int dni, DateTime fechaNacimiento, string nombre, string apellido,
              string telefono,string domicilio, bool aptoFisico, DateTime fechaInscripcion)
              : base(dni, fechaNacimiento, nombre, apellido, telefono,domicilio, aptoFisico)
  {
    FechaInscripcion = fechaInscripcion;
    EstadoMembresia = true;
    cuotas = new List<E_Cuota>();
  }

  // Propiedades
  public DateTime FechaInscripcion
  {
    get { return fechaInscripcion; }
    set { fechaInscripcion = value; }
  }

  public bool EstadoMembresia
  {
    get { return estadoMembresia; }
    set { estadoMembresia = value; }
  }

  public List<E_Cuota> Cuotas
  {
    get { return cuotas; }
  }

  // Métodos
  public bool VerificarEstado()
  {
    return EstadoMembresia;
  }

  public void PagarCuota(E_Cuota cuota)
  {
    if (cuota != null)
    {
      cuota.Estado = true;
      Console.WriteLine($"Cuota pagada exitosamente. Monto: ${cuota.Monto}");
    }
  }

  public override E_Persona Registrar()
  {
    Console.WriteLine($"Socio {Nombre} {Apellido} registrado exitosamente.");
    return this;
  }
}