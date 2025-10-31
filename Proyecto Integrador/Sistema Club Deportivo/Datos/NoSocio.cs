using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClubDeportivo.Datos
{
    public class NoSocio
    {
        public string Nuevo_NoSocio(E_NoSocio noSocio, int idPersona)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoNoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("idPersona", MySqlDbType.Int32).Value = idPersona;

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
        public E_NoSocio? BuscarNoSocio(E_NoSocio noSocio)
        {
            E_NoSocio socioencontrado = null;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = (@"SELECT dni, fechaNacimiento, nombre, apellido,telefono, direccion,  aptoFisico,  carnetTemporal FROM nosocio ns 
                        inner join persona P on P.idPersona = ns.idPersona
                        where carnetTemporal =" + noSocio.CarnetTemporal); // <<<------ usamos el dato ingresado                por el usuario
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                // usamos la consulta y la conexion.-
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader; // El DataReader almacena TODAS las filas.-
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    socioencontrado = new E_NoSocio
                        (
                        reader.GetInt32(0),
                        reader.GetDateTime(1),
                        reader.GetString(2).Trim(),
                        reader.GetString(3).Trim(),
                        reader.GetString(4).Trim(),
                        reader.GetString(5).Trim(),
                        reader.GetBoolean(6),
                        reader.GetInt32(7)
                        );
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
}
