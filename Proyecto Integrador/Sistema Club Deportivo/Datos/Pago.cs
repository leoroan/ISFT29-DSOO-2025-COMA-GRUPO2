using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System.Data;
namespace ClubDeportivo.Datos
{
    public class Pago
    {
        public string NuevoPago(E_Pago pago,int idRegistroaPagar)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoPago", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("CarnetNumero", MySqlDbType.Int32).Value = pago.CarnetNumero;
                comando.Parameters.Add("TipoPersona", MySqlDbType.Int32).Value = pago.TipoPersona;
                comando.Parameters.Add("Precio", MySqlDbType.Float).Value = pago.Precio;
                comando.Parameters.Add("Fecha", MySqlDbType.Date).Value = pago.Fecha;
                comando.Parameters.Add("MedioPago", MySqlDbType.Int32).Value = pago.MedioPago;
                comando.Parameters.Add("tipoActividad", MySqlDbType.Int32).Value = pago.Actividad?.NroActividad;
                comando.Parameters.Add("idRegistroaPagar", MySqlDbType.Int32).Value = idRegistroaPagar;

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
        public enum TipoPago
        {
            Efectivo = 1,
            Tarjeta = 0,

        }
    }
}
