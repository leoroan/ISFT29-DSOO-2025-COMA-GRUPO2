public class E_NoSocio : E_Persona
{
    // Campos privados
    private int carnetTemporal;

    // Constructor
    public E_NoSocio(int dni, DateTime fechaNacimiento, string nombre, string apellido,
                string telefono, string domicilio, bool aptoFisico, int carnetTemporal)
                : base(dni, fechaNacimiento, nombre, apellido, telefono, domicilio, aptoFisico)
    {
        CarnetTemporal = carnetTemporal;
    }

    // Propiedad para la colección de pagos
    public int CarnetTemporal
    {
        get { return carnetTemporal; }
        set { carnetTemporal = value; }
    }

}
