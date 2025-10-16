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
    public class Alumno
    {
        public E_Alumno BuscarAlumno(int numLegajo) 
        {
            E_Alumno E_AlumnoEncontrado  = new E_Alumno();
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                string query;
                sqlcon = Conexion.getInstancia().CrearConcexion();
                query = @"SELECT * FROM alumno A
                        INNER JOIN postulante P 
                        ON P.NPostu = A.NPostu
                        where Legajo =" + numLegajo;
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                cmd.CommandType = CommandType.Text;
                sqlcon.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        E_AlumnoEncontrado.Legajo = reader.GetInt32(0);
                        E_AlumnoEncontrado.NroPostulante = reader.GetInt32(1);
                        E_AlumnoEncontrado.Nombre = reader.GetString(3);
                        E_AlumnoEncontrado.Apellido = reader.GetString(4);
                        E_AlumnoEncontrado.TipoDoc = reader.GetString(5);
                        E_AlumnoEncontrado.Documento = reader.GetInt32(6);
                    }
                }
                else E_AlumnoEncontrado = null;
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
                E_AlumnoEncontrado = null;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();
            }
            return E_AlumnoEncontrado;

        }
    }
}
