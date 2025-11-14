using ClubDeportivo.Datos;

public class E_Socio : E_Persona
{
  // Campos privados
  private DateTime fechaInscripcion;
  private bool estadoMembresia;
  private int carnetNumero;
  // Constructor
  public E_Socio(int dni, DateTime fechaNacimiento, string nombre, string apellido,
              string telefono,string domicilio, bool aptoFisico, DateTime fechaInscripcion, int carnetNumero, bool estadoMembresia)
              : base(dni, fechaNacimiento, nombre, apellido, telefono,domicilio, aptoFisico)
  {
    FechaInscripcion = fechaInscripcion;
    EstadoMembresia = estadoMembresia;
    CarnetNumero = carnetNumero;
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
public int CarnetNumero
    {
    get { return carnetNumero; }
    set { carnetNumero = value; }
}

  // Métodos
  public bool VerificarEstado()
  {
    return EstadoMembresia;
  }

}