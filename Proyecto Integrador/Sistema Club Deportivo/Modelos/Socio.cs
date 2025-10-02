public class Socio : Persona
{
  // Campos privados
  private DateTime fechaInscripcion;
  private bool estadoMembresia;
  private List<Cuota> cuotas;

  // Constructor
  public Socio(int dni, DateTime fechaNacimiento, string nombre, string apellido,
              string telefono, bool aptoFisico, DateTime fechaInscripcion)
              : base(dni, fechaNacimiento, nombre, apellido, telefono, aptoFisico)
  {
    FechaInscripcion = fechaInscripcion;
    EstadoMembresia = true;
    cuotas = new List<Cuota>();
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

  public List<Cuota> Cuotas
  {
    get { return cuotas; }
  }

  // Métodos
  public bool VerificarEstado()
  {
    return EstadoMembresia;
  }

  public void PagarCuota(Cuota cuota)
  {
    if (cuota != null)
    {
      cuota.Estado = true;
      Console.WriteLine($"Cuota pagada exitosamente. Monto: ${cuota.Monto}");
    }
  }

  public override Persona Registrar()
  {
    Console.WriteLine($"Socio {Nombre} {Apellido} registrado exitosamente.");
    return this;
  }
}