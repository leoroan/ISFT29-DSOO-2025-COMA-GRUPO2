public class Actividad
{
  // Campos privados
  private string nombre;
  private double valor;

  // Constructor
  public Actividad(string nombre, double valor)
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