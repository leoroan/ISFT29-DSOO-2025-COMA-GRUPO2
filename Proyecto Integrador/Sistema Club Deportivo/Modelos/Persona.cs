public abstract class Persona
{
  // Campos privados
  private int dni;
  private DateTime fechaNacimiento;
  private string nombre;
  private string apellido;
  private string telefono;
  private bool aptoFisico;

  // Constructor
  protected Persona(int dni, DateTime fechaNacimiento, string nombre, string apellido, string telefono, bool aptoFisico)
  {
    DNI = dni;
    FechaNacimiento = fechaNacimiento;
    Nombre = nombre;
    Apellido = apellido;
    Telefono = telefono;
    AptoFisico = aptoFisico;
  }

  // Propiedades
  public int DNI
  {
    get { return dni; }
    set { dni = value; }
  }

  public DateTime FechaNacimiento
  {
    get { return fechaNacimiento; }
    set { fechaNacimiento = value; }
  }

  public string Nombre
  {
    get { return nombre; }
    set { nombre = value; }
  }

  public string Apellido
  {
    get { return apellido; }
    set { apellido = value; }
  }

  public string Telefono
  {
    get { return telefono; }
    set { telefono = value; }
  }

  public bool AptoFisico
  {
    get { return aptoFisico; }
    set { aptoFisico = value; }
  }

  // Método abstracto
  public abstract Persona Registrar();
}