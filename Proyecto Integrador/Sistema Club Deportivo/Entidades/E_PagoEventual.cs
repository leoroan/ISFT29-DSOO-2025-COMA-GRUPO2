public enum MedioPago
{
    Efectivo,
    TarjetaCredito,
    TarjetaDebito,
    Transferencia
}

public class E_PagoEventual
{
  // Campos privados
  private DateTime fecha;
  private double monto;
  private MedioPago medio;

  // Constructor
  public E_PagoEventual(DateTime fecha, double monto, MedioPago medio)
  {
    Fecha = fecha;
    Monto = monto;
    Medio = medio;
  }

  // Propiedades
  public DateTime Fecha
  {
    get { return fecha; }
    set { fecha = value; }
  }

  public double Monto
  {
    get { return monto; }
    set { monto = value; }
  }

  public MedioPago Medio
  {
    get { return medio; }
    set { medio = value; }
  }
}