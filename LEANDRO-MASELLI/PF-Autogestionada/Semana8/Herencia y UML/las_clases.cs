// Clase base Producto
public class Producto
{
    // Campos privados
    private string nombre;
    private double precio;
    private string tipo;

    // Constructor
    public Producto(string nombre, double precio, string tipo)
    {
        Nombre = nombre;
        Precio = precio;
        Tipo = tipo;
    }

    // Propiedades
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public double Precio
    {
        get { return precio; }
        set { precio = value; }
    }

    public string Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }

    public virtual double CalcularPrecioTotal()
    {
        return Precio;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Precio: ${Precio}, Tipo: {Tipo}";
    }
}

public class Perecedero : Producto
{
    // Campo privado
    private int diasACaducar;

    // Constructor
    public Perecedero(string nombre, double precio, string tipo, int diasACaducar)
        : base(nombre, precio, tipo)
    {
        DiasACaducar = diasACaducar;
    }

    // Propiedad
    public int DiasACaducar
    {
        get { return diasACaducar; }
        set { diasACaducar = value; }
    }

    public override double CalcularPrecioTotal()
    {
        // Lógica para calcular el precio total 
    }

    // Método ToString extendido
    public override string ToString()
    {
        return base.ToString() + $", Días a caducar: {DiasACaducar}, Precio final: ${CalcularPrecioTotal():F2}";
    }
}

// Clase NoPerecedero que hereda de Producto
public class NoPerecedero : Producto
{
    private string tipo;

    // Constructor
    public NoPerecedero(string nombre, double precio, string tipo)
        : base(nombre, precio, "No Perecedero")
    {
        TipoEspecifico = tipo;
    }

    // Propiedad
    public string TipoEspecifico
    {
        get { return tipo; }
        set { tipo = value; }
    }

    // Método que sobrescribe CalcularPrecioTotal
    public override double CalcularPrecioTotal()
    {
        // Lógica para calcular el precio total de un producto no perecedero
    }

    // Método ToString extendido
    public override string ToString()
    {
        return base.ToString() + $", Tipo específico: {TipoEspecifico}, Precio final: ${CalcularPrecioTotal():F2}";
    }
}