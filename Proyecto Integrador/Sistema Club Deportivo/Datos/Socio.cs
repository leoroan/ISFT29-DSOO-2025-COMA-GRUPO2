using MySql.Data.MySqlClient;
using System.Data;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClubDeportivo.Datos;

internal class Socio
{
    E_Socio socioencontrado = null;
    public string Nuevo_Socio(E_Socio socio)
    {
        string? salida;
        MySqlConnection sqlCon = new MySqlConnection();
        try
        {
            sqlCon = Conexion.getInstancia().CrearConexion();
            MySqlCommand comando = new MySqlCommand("NuevoSocio", sqlCon);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("fechaInscripcion", MySqlDbType.Date).Value = socio.FechaInscripcion;

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
    public E_Socio? BuscarSocio(E_Socio socio)
    {

        MySqlConnection sqlCon = new MySqlConnection();
        try
        {
            string query;
            sqlCon = Conexion.getInstancia().CrearConexion();
            query = (@"SELECT dni, fechaNacimiento, nombre, apellido,telefono, direccion,  aptoFisico,  fechaInscripcion,  carnetNumero,  estadoMembresia FROM socio S 
            inner join persona P on P.idPersona = S.carnetNumero
            where carnetNumero =" + socio.CarnetNumero); // <<<------ usamos el dato ingresado                por el usuario
            MySqlCommand comando = new MySqlCommand(query, sqlCon);
            // usamos la consulta y la conexion.-
            comando.CommandType = CommandType.Text;
            sqlCon.Open();
            MySqlDataReader reader; // El DataReader almacena TODAS las filas.-
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                socioencontrado = new E_Socio
                    (
                    reader.GetInt32(0),
                    reader.GetDateTime(1),
                    reader.GetString(2).Trim(),
                    reader.GetString(3).Trim(),
                    reader.GetString(4).Trim(),
                    reader.GetString(5).Trim(),
                    reader.GetBoolean(6),
                    reader.GetDateTime(7),
                    reader.GetInt32(8),
                    reader.GetBoolean(9)
                    ) ;
                
            }
            else
            {
                MessageBox.Show("Número de Socio inexistente", "AVISO DEL SISTEMA",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                socioencontrado = null;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            socioencontrado = null;
        }
        finally
        {
            if (sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }
        return socioencontrado;
    }
   
}

