public class E_Cuota
{
  // Campos privados
  private DateTime fechaVencimiento;
  private double monto;
  private bool estado;

  // Constructor
  public E_Cuota(DateTime fechaVencimiento, double monto)
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

  public static List<E_Cuota> GenerarListadoVencimientos(List<E_Cuota> cuotas)
  {
    List<E_Cuota> cuotasVencidas = new List<E_Cuota>();

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
