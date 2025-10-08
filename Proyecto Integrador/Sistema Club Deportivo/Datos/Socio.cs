using MySql.Data.MySqlClient;
using System.Data;

namespace ClubDeportivo.Datos;

internal class Socio
{
    public string Nuevo_Socio(E_Socio socio)
    {
        string? salida;
        MySqlConnection sqlCon = new MySqlConnection();
        try
        {
            sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand comando = new MySqlCommand("NuevoSocio", sqlCon);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = socio.Nombre;
            comando.Parameters.Add("apellido", MySqlDbType.VarChar).Value = socio.Apellido;
            comando.Parameters.Add("fecha_nacimiento", MySqlDbType.Date).Value = socio.FechaNacimiento;
            comando.Parameters.Add("direccion", MySqlDbType.VarChar).Value = socio.Domicilio;
            comando.Parameters.Add("documento", MySqlDbType.Int32).Value = socio.DNI;
            comando.Parameters.Add("telefono", MySqlDbType.Int64).Value = socio.Telefono;
            comando.Parameters.Add("aptoFisico", MySqlDbType.Bit).Value = socio.AptoFisico;
            comando.Parameters.Add("fecha_inscripcion", MySqlDbType.Date).Value = socio.FechaInscripcion;


            MySqlParameter ParCodigo = new MySqlParameter();
            ParCodigo.ParameterName = "rta";
            ParCodigo.MySqlDbType = MySqlDbType.Int32;
            ParCodigo.Direction = ParameterDirection.Output;
            comando.Parameters.Add(ParCodigo);
            sqlCon.Open();
            comando.ExecuteNonQuery();
            salida = Convert.ToString(ParCodigo.Value);
        }
        catch (Exception ex)
        {
            salida = ex.Message;
        }
        // como proceso final
        finally
        {
            if (sqlCon.State == ConnectionState.Open)
            { sqlCon.Close(); }
            ;
        }
        return salida;
    }
}

