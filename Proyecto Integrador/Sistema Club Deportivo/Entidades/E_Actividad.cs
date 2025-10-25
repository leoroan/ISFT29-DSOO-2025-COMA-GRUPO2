public class E_Actividad
{
    // Campos privados
    private int idActividad;
    private string nombre;
    private float precio;


  // Constructor
  public E_Actividad(int idActividad,string nombre, float precio)
  {
    Nombre = nombre;
    Precio = precio;
    IdActividad = idActividad;
  }

  // Propiedades
  public int IdActividad { get; set; }
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