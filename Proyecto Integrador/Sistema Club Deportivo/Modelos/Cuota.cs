public class Cuota
{
  // Campos privados
  private DateTime fechaVencimiento;
  private double monto;
  private bool estado;

  // Constructor
  public Cuota(DateTime fechaVencimiento, double monto)
  {
    FechaVencimiento = fechaVencimiento;
    Monto = monto;
    Estado = false;
  }

  // Propiedades
  public DateTime FechaVencimiento
  {
    get { return fechaVencimiento; }
    set { fechaVencimiento = value; }
  }

  public double Monto
  {
    get { return monto; }
    set { monto = value; }
  }

  public bool Estado
  {
    get { return estado; }
    set { estado = value; }
  }

  public static List<Cuota> GenerarListadoVencimientos(List<Cuota> cuotas)
  {
    List<Cuota> cuotasVencidas = new List<Cuota>();

    foreach (var cuota in cuotas)
    {
      if (cuota.FechaVencimiento < DateTime.Now && !cuota.Estado)
      {
        cuotasVencidas.Add(cuota);
      }
    }

    return cuotasVencidas;
  }
}
