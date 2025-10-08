public class E_Actividad
{
  // Campos privados
  private string nombre;
  private double valor;

  // Constructor
  public E_Actividad(string nombre, double valor)
  {
    Nombre = nombre;
    Valor = valor;
  }

  // Propiedades
  public string Nombre
  {
    get { return nombre; }
    set { nombre = value; }
  }

  public double Valor
  {
    get { return valor; }
    set { valor = value; }
  }

}