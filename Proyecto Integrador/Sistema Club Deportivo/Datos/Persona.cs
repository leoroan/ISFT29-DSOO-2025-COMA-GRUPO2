using MySql.Data.MySqlClient;
using System.Data;

namespace ClubDeportivo.Datos
{
    internal class Persona
    {
        public string Nuevo_persona(E_Persona persona)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoPersona", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = persona.Nombre;
                comando.Parameters.Add("apellido", MySqlDbType.VarChar).Value = persona.Apellido;
                comando.Parameters.Add("fechaNacimiento", MySqlDbType.Date).Value = persona.FechaNacimiento;
                comando.Parameters.Add("direccion", MySqlDbType.VarChar).Value = persona.Domicilio;
                comando.Parameters.Add("documento", MySqlDbType.Int64).Value = persona.DNI;
                comando.Parameters.Add("telefono", MySqlDbType.Int64).Value = persona.Telefono;
                comando.Parameters.Add("aptoFisico", MySqlDbType.Bit).Value = persona.AptoFisico;
                //comando.Parameters.Add("fecha_inscripcion", MySqlDbType.Date).Value = persona.FechaInscripcion;


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
}
