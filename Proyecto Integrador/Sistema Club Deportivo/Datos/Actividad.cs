using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    public class Actividad
    {
        public List<E_Actividad> TraerActividades()
        {
            List<E_Actividad> actividades = new List<E_Actividad>();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                string query = "SELECT * FROM actividad;";
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    E_Actividad act = new E_Actividad(
                        reader.GetInt32("NroActividad"),   // o índice 0 si preferís
                        reader.GetString("nombre"),
                        reader.GetFloat("precio")
                    );

                    actividades.Add(act);
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

            return actividades;
        }

        public E_Actividad TraerActividad(int NroActividad)
        {
            E_Actividad actividad = null;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = (@"SELECT * FROM actividad where NroActividad=" + NroActividad);
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                // usamos la consulta y la conexion.-
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader; // El DataReader almacena TODAS las filas.-
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read(); // En este caso sabemos que si tiene datos es UNA SOLA FILA
                    actividad = new E_Actividad(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetFloat(2)
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
            return actividad;
        }
    }
}
