using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    public class Pago
    {
        public string NuevoPago(E_Pago pago,E_Cuota cuota)
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
                comando.Parameters.Add("tipoActividad", MySqlDbType.Int32).Value = pago.Actividad?.IdActividad;
                comando.Parameters.Add("idcuotaPagada", MySqlDbType.Int32).Value = cuota.IdCuota;

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
