using MySql.Data.MySqlClient;
using Proyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Datos
{
    public class Inscripcion
    {
        public string NuevaInscripcion(E_Alumno alumno, E_Edicion edicion)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("NuevaInsc", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Legajo", MySqlDbType.Int64).Value = alumno.Legajo;
                comando.Parameters.Add("idEdicion", MySqlDbType.Int64).Value = edicion.idEdicion;
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
