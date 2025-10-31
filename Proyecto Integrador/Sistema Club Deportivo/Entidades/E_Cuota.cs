public class E_Cuota
{
  // Campos privados
    private DateTime fechaVencimiento;
    private float precio;
    private bool estado;
    private int carnetNumero;
    private int idCuota;

  // Constructor
  public E_Cuota(int idCuota,int carnetNumero,DateTime fechaVencimiento, float precio, bool estado)
  {
    FechaVencimiento = fechaVencimiento;
    Precio = precio;
    CarnetNumero = carnetNumero;
    IdCuota = idCuota;
    Estado=estado;
  }

    // Propiedades
    public int IdCuota
    {
        get { return idCuota; }
        set { idCuota = value; }
    }
    public int CarnetNumero
    {
        get { return carnetNumero; }
        set { carnetNumero = value; }
    }
    public DateTime FechaVencimiento
    {
        get { return fechaVencimiento; }
        set { fechaVencimiento = value; }
    }

    public float Precio
    {
        get { return precio; }
        set { precio = value; }
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
