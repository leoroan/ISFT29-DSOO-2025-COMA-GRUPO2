public class E_Actividad
{
    // Campos privados
    private int nroActividad;
    private string nombre;
    private float precio;


  // Constructor
  public E_Actividad(int nroActividad, string nombre, float precio)
  {
    Nombre = nombre;
    Precio = precio;
    NroActividad = nroActividad;
  }

  // Propiedades
  public int NroActividad { get; set; }
  public string Nombre
  {
    get { return nombre; }
    set { nombre = value; }
  }

  public float Precio
  {
    get { return precio; }
    set { precio = value; }
  }

}