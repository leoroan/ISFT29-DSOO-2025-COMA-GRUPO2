using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace ClubDeportivo.Datos
{
    public class PagoActividad
    {
        public string NuevaPagoActividad(E_PagoActividad pagoActividad)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevaPagoActividad", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("nroActividad", MySqlDbType.Int32).Value = pagoActividad.NroActividad;
                comando.Parameters.Add("carnetTemporal", MySqlDbType.Int32).Value = pagoActividad.CarnetTemporal;
                comando.Parameters.Add("precio", MySqlDbType.Float).Value = pagoActividad.Precio;

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
        public E_PagoActividad TraerPagoActividad(int carnetTemporal)
        {
            E_PagoActividad pagoActividad = null;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = (@"SELECT *
                        FROM pagoactividad
                        WHERE carnetTemporal = " + carnetTemporal +
                        " and estado=0;");
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                // usamos la consulta y la conexion.-
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader; // El DataReader almacena TODAS las filas.-
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read(); // En este caso sabemos que si tiene datos es UNA SOLA FILA
                    pagoActividad = new E_PagoActividad
                        (
                        reader.GetInt32(0), 
                        reader.GetInt32(1), 
                        reader.GetInt32(2), 
                        reader.GetFloat(3), 
                        reader.GetBoolean(4)
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            return pagoActividad;
        }
    }
}
