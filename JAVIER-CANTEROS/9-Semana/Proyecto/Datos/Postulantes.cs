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
    internal class Postulantes
    {
        public string Nuevo_Postu(E_Postulante postu)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();
                MySqlCommand comando = new MySqlCommand("NuevoPos",sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = postu.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = postu.Apellido;
                comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value = postu.TipoDoc;
                comando.Parameters.Add("Doc", MySqlDbType.Int32).Value =   postu.Documento;
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
    }   }
}
