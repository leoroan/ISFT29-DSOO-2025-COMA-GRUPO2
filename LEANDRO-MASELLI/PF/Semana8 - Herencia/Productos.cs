using System;
using System.Collections.Generic;

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
    this.nombre = nombre;
    this.precio = precio;
    this.tipo = tipo;
  }

  // Getters y Setters
  public string GetNombre()
  {
    return nombre;
  }

  public void SetNombre(string nombre)
  {
    this.nombre = nombre;
  }

  public double GetPrecio()
  {
    return precio;
  }

  public void SetPrecio(double precio)
  {
    this.precio = precio;
  }

  public string GetTipo()
  {
    return tipo;
  }

  public void SetTipo(string tipo)
  {
    this.tipo = tipo;
  }

  // Método para calcular precio total
  public virtual double CalcularPrecioTotal(int cantidad)
  {
    return precio * cantidad;
  }

  // Método para mostrar datos
  public virtual void MostrarDatos()
  {
    Console.WriteLine($"Nombre: {nombre}");
    Console.WriteLine($"Precio: ${precio}");
    Console.WriteLine($"Tipo: {tipo}");
  }
}

// Clase Perecedero que hereda de Producto
public class Perecedero : Producto
{
  // Campo privado
  private int diasACaducar;

  // Constructor
  public Perecedero(string nombre, double precio, string tipo, int diasACaducar)
      : base(nombre, precio, tipo)
  {
    this.diasACaducar = diasACaducar;
  }

  // Getter y Setter para diasACaducar
  public int GetDiasACaducar()
  {
    return diasACaducar;
  }

  public void SetDiasACaducar(int diasACaducar)
  {
    this.diasACaducar = diasACaducar;
  }

  // Método para calcular precio total con reglas de caducidad
  public override double CalcularPrecioTotal(int cantidad)
  {
    double precioBase = base.CalcularPrecioTotal(cantidad);

    // Aplicar reducciones según días a caducar
    if (diasACaducar == 1)
    {
      return precioBase / 4; // Reduzco 4 veces el precio 
    }
    else if (diasACaducar == 2)
    {
      return precioBase / 3; // Reduzco 3 veces el precio 
    }
    else if (diasACaducar == 3)
    {
      return precioBase / 2; // Reduzco a la mitad
    }
    else
    {
      return precioBase; 
    }
  }

  // Método para mostrar datos extendido
  public override void MostrarDatos()
  {
    base.MostrarDatos();
    Console.WriteLine($"Días a caducar: {diasACaducar}");
  }
}

// Clase NoPerecedero que hereda de Producto
public class NoPerecedero : Producto
{
  // Constructor
  public NoPerecedero(string nombre, double precio, string tipo)
      : base(nombre, precio, tipo)
  {
  }

  // No necesita sobrescribir CalcularPrecioTotal porque se comporta igual que Producto
  // Pero podemos dejarlo explícito si queremos
  public override double CalcularPrecioTotal(int cantidad)
  {
    return base.CalcularPrecioTotal(cantidad);
  }

  // Método para mostrar datos
  public override void MostrarDatos()
  {
    base.MostrarDatos();
    Console.WriteLine("Tipo: No Perecedero");
  }
}

// Clase de prueba Test
public class Test
{
  public static void Main()
  {
    // Creo una lista de productos
    List<Producto> productos = new List<Producto>();

    // Agrego productos perecederos
    productos.Add(new Perecedero("Leche", 100, "Lácteo", 1));
    productos.Add(new Perecedero("Pan", 50, "Panadería", 2));
    productos.Add(new Perecedero("Yogurt", 80, "Lácteo", 3));
    productos.Add(new Perecedero("Queso", 120, "Lácteo", 5));

    // Agrego productos no perecederos
    productos.Add(new NoPerecedero("Arroz", 70, "Granos"));
    productos.Add(new NoPerecedero("Atún enlatado", 90, "Enlatado"));
    productos.Add(new NoPerecedero("Frijoles", 60, "Granos"));
    productos.Add(new NoPerecedero("Aceite", 110, "Aceites"));

    // Agrego otro tipo de productos
    productos.Add(new Producto("Jabón", 40, "Limpieza"));
    productos.Add(new Producto("Shampoo", 150, "Higiene"));

    Console.WriteLine("=== LISTA DE PRODUCTOS ===");
    foreach (var producto in productos)
    {
      producto.MostrarDatos();
      Console.WriteLine("------------------------");
    }

    Console.WriteLine("\n=== PRECIO TOTAL POR VENDER 5 UNIDADES DE CADA PRODUCTO ===");

    double totalGeneral = 0;
    int cantidad = 5;

    foreach (var producto in productos)
    {
      double precioTotal = producto.CalcularPrecioTotal(cantidad);
      totalGeneral += precioTotal;

      Console.WriteLine($"{producto.GetNombre()}: {cantidad} unidades = ${precioTotal}");
    }

    Console.WriteLine($"\nTOTAL GENERAL por vender 5 unidades de cada producto: ${totalGeneral}");

    // Prueba específica mostrando el efecto de la caducidad
    Console.WriteLine("\n=== DEMOSTRACIÓN DEL EFECTO DE CADUCIDAD ===");

    Perecedero leche1Dia = new Perecedero("Leche", 100, "Lácteo", 1);
    Perecedero leche2Dias = new Perecedero("Leche", 100, "Lácteo", 2);
    Perecedero leche3Dias = new Perecedero("Leche", 100, "Lácteo", 3);
    Perecedero leche5Dias = new Perecedero("Leche", 100, "Lácteo", 5);
    NoPerecedero arroz = new NoPerecedero("Arroz", 100, "Granos");

    Console.WriteLine($"Leche (1 día caducar): ${leche1Dia.CalcularPrecioTotal(5)}");
    Console.WriteLine($"Leche (2 días caducar): ${leche2Dias.CalcularPrecioTotal(5)}");
    Console.WriteLine($"Leche (3 días caducar): ${leche3Dias.CalcularPrecioTotal(5)}");
    Console.WriteLine($"Leche (5 días caducar): ${leche5Dias.CalcularPrecioTotal(5)}");
    Console.WriteLine($"Arroz (no perecedero): ${arroz.CalcularPrecioTotal(5)}");
  }
}