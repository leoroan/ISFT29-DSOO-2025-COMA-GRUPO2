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
    public class Cuota
    {
        public string NuevaCuota(E_Cuota cuota)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevaCuota", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("CarnetNumero", MySqlDbType.Int32).Value = cuota.CarnetNumero;
                comando.Parameters.Add("fechaVencimiento", MySqlDbType.Date).Value = cuota.FechaVencimiento;
                comando.Parameters.Add("precio", MySqlDbType.Float).Value = cuota.Precio;

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
        public E_Cuota TraerCuota(int carnetNumero)
        {
            E_Cuota cuota =null;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = (@"SELECT *
                        FROM cuota
                        WHERE carnetNumero = "+ carnetNumero +
                        @" AND fechaVencimiento BETWEEN DATE_FORMAT(CURDATE(), '%Y-%m-01')
                        AND LAST_DAY(CURDATE()) and estado=0;");
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                // usamos la consulta y la conexion.-
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader; // El DataReader almacena TODAS las filas.-
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read(); // En este caso sabemos que si tiene datos es UNA SOLA FILA
                    cuota=new E_Cuota( reader.GetInt32(0), reader.GetInt32(1),reader.GetDateTime(2),reader.GetFloat(3),reader.GetBoolean(4));
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
            return cuota;
        }
    }
}
