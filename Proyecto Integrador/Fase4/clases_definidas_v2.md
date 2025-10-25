# Modelo de Clases en Markdown

## Enumeración: MedioPago

- **Efectivo**
- **TarjetaCredito**
- **TarjetaDebito**
- **Transferencia**

---

## Clase abstracta: Persona

| Propiedad         | Tipo        | Descripción                |
|-------------------|-------------|----------------------------|
| DNI               | int         | Documento de identidad     |
| FechaNacimiento   | DateTime    | Fecha de nacimiento        |
| Nombre            | string      | Nombre                     |
| Apellido          | string      | Apellido                   |
| Telefono          | string      | Teléfono                   |
| AptoFisico        | bool        | Apto físico                |

**Métodos:**
- `Registrar() : Persona` _(abstracto)_

---

## Clase: Socio _(hereda de Persona)_

| Propiedad         | Tipo              | Descripción                |
|-------------------|-------------------|----------------------------|
| FechaInscripcion  | DateTime          | Fecha de inscripción       |
| EstadoMembresia   | bool              | Estado de la membresía     |
| Cuotas            | List<Cuota>       | Lista de cuotas            |

**Métodos:**
- `VerificarEstado() : bool`
- `PagarCuota(cuota: Cuota) : void`
- `Registrar() : Persona` _(implementación)_

---

## Clase: NoSocio _(hereda de Persona)_

| Propiedad         | Tipo                      | Descripción                |
|-------------------|--------------------------|----------------------------|
| PagosEventuales   | List<PagoEventual>        | Pagos realizados           |

**Métodos:**
- `PagarActividad(actividad: Actividad) : PagoEventual`
- `Registrar() : Persona` _(implementación)_

---

## Clase: Actividad

| Propiedad         | Tipo        | Descripción                |
|-------------------|-------------|----------------------------|
| Nombre            | string      | Nombre de la actividad     |
| Valor             | double      | Valor de la actividad      |

**Métodos:**
- `GetValor() : double`

---

## Clase: Cuota

| Propiedad         | Tipo        | Descripción                |
|-------------------|-------------|----------------------------|
| FechaVencimiento  | DateTime    | Fecha de vencimiento       |
| Monto             | double      | Monto de la cuota          |
| Estado            | bool        | Estado de pago             |

**Métodos:**
- `GenerarListadoVencimientos(cuotas: List<Cuota>) : List<Cuota>`

---

## Clase: PagoEventual

| Propiedad         | Tipo        | Descripción                |
|-------------------|-------------|----------------------------|
| Fecha             | DateTime    | Fecha del pago             |
| Monto             | double      | Monto pagado               |
| Medio             | MedioPago   | Medio de pago              |

---

## Relaciones

- **Socio** y **NoSocio** heredan de **Persona**.
- **Socio** tiene una lista de **Cuota**.
- **NoSocio** tiene una lista de **PagoEventual**.
- **PagoEventual** utiliza **MedioPago**.
- **Cuota** puede ser generada y listada por vencimiento.


CODIGO C#:

// Enumeración para MedioPago
public enum MedioPago
{
    Efectivo,
    TarjetaCredito,
    TarjetaDebito,
    Transferencia
}

// Clase abstracta Persona
public abstract class Persona
{
    // Campos privados
    private int dNI;
    private DateTime fechaNacimiento;
    private string nombre;
    private string apellido;
    private string telefono;
    private bool aptoFisico;

    // Constructor
    protected Persona(int dni, DateTime fechaNacimiento, string nombre, string apellido, string telefono, bool aptoFisico)
    {
        DNI = dni;
        FechaNacimiento = fechaNacimiento;
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        AptoFisico = aptoFisico;
    }

    // Propiedades
    public int DNI
    {
        get { return dNI; }
        set { dNI = value; }
    }

    public DateTime FechaNacimiento
    {
        get { return fechaNacimiento; }
        set { fechaNacimiento = value; }
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }

    public string Telefono
    {
        get { return telefono; }
        set { telefono = value; }
    }

    public bool AptoFisico
    {
        get { return aptoFisico; }
        set { aptoFisico = value; }
    }

    // Método abstracto
    public abstract Persona Registrar();
}

// Clase Socio
public class Socio : Persona
{
    // Campos privados
    private DateTime fechaInscripcion;
    private bool estadoMembresia;
    private List<Cuota> cuotas;

    // Constructor
    public Socio(int dni, DateTime fechaNacimiento, string nombre, string apellido, 
                string telefono, bool aptoFisico, DateTime fechaInscripcion) 
                : base(dni, fechaNacimiento, nombre, apellido, telefono, aptoFisico)
    {
        FechaInscripcion = fechaInscripcion;
        EstadoMembresia = true; // Por defecto activo al crear
        cuotas = new List<Cuota>();
    }

    // Propiedades
    public DateTime FechaInscripcion
    {
        get { return fechaInscripcion; }
        set { fechaInscripcion = value; }
    }

    public bool EstadoMembresia
    {
        get { return estadoMembresia; }
        set { estadoMembresia = value; }
    }

    public List<Cuota> Cuotas
    {
        get { return cuotas; }
    }

    // Métodos
    public bool VerificarEstado()
    {
        return EstadoMembresia;
    }

    public void PagarCuota(Cuota cuota)
    {
        if (cuota != null)
        {
            cuota.Estado = true; // Marcar como pagada
            Console.WriteLine($"Cuota pagada exitosamente. Monto: ${cuota.Monto}");
        }
    }

    // Implementación del método abstracto
    public override Persona Registrar()
    {
        Console.WriteLine($"Socio {Nombre} {Apellido} registrado exitosamente.");
        return this;
    }
}

// Clase NoSocio
public class NoSocio : Persona
{
    // Campos privados
    private List<PagoEventual> pagosEventuales;

    // Constructor
    public NoSocio(int dni, DateTime fechaNacimiento, string nombre, string apellido, 
                  string telefono, bool aptoFisico) 
                  : base(dni, fechaNacimiento, nombre, apellido, telefono, aptoFisico)
    {
        pagosEventuales = new List<PagoEventual>();
    }

    // Propiedad para la colección de pagos
    public List<PagoEventual> PagosEventuales
    {
        get { return pagosEventuales; }
    }

    // Métodos
    public PagoEventual PagarActividad(Actividad actividad)
    {
        if (actividad == null)
            throw new ArgumentNullException(nameof(actividad));

        var pago = new PagoEventual(DateTime.Now, actividad.Valor, MedioPago.Efectivo);
        pagosEventuales.Add(pago);
        
        Console.WriteLine($"Actividad '{actividad.Nombre}' pagada. Monto: ${actividad.Valor}");
        return pago;
    }

    // Implementación del método abstracto
    public override Persona Registrar()
    {
        Console.WriteLine($"No Socio {Nombre} {Apellido} registrado exitosamente.");
        return this;
    }
}

// Clase Actividad
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

    // Método getValor (propiedad ya lo hace, pero por el diagrama lo incluimos)
    public double GetValor()
    {
        return Valor;
    }
}

// Clase Cuota
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
        Estado = false; // Por defecto no pagada
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

    // Método estático para generar listado de vencimientos
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

// Clase PagoEventual
public class PagoEventual
{
    // Campos privados
    private DateTime fecha;
    private double monto;
    private MedioPago medio;

    // Constructor
    public PagoEventual(DateTime fecha, double monto, MedioPago medio)
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

// Ejemplo de uso
public class Program
{
    public static void Main()
    {
        // Crear actividades
        var natacion = new Actividad("Natación", 500.0);
        var gym = new Actividad("Gimnasio", 300.0);

        // Crear socio
        var socio = new Socio(12345678, new DateTime(1990, 5, 15), "Juan", "Pérez", 
                             "123-456-789", true, DateTime.Now);
        
        socio.Registrar();
        
        // Crear cuotas para el socio
        var cuota1 = new Cuota(DateTime.Now.AddDays(30), 1000.0);
        var cuota2 = new Cuota(DateTime.Now.AddDays(-5), 1000.0); // Vencida
        
        socio.Cuotas.Add(cuota1);
        socio.Cuotas.Add(cuota2);
        
        // Pagar cuota
        socio.PagarCuota(cuota1);
        
        // Verificar estado de membresía
        Console.WriteLine($"Estado membresía: {socio.VerificarEstado()}");

        // Crear no socio
        var noSocio = new NoSocio(87654321, new DateTime(1985, 8, 20), "María", "Gómez", 
                                 "987-654-321", true);
        
        noSocio.Registrar();
        
        // Pagar actividad como no socio
        var pago = noSocio.PagarActividad(natacion);
        
        // Generar listado de cuotas vencidas
        var cuotasVencidas = Cuota.GenerarListadoVencimientos(socio.Cuotas);
        Console.WriteLine($"Cuotas vencidas: {cuotasVencidas.Count}");
    }
}