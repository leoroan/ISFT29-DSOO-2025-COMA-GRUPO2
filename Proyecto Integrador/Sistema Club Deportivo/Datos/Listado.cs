using ClubDeportivo.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace ClubDeportivo.Datos
{
    public class Listado
    {
        public List<E_Deudor> TraerDeudores()
        {
            List<E_Deudor> deudores = new List<E_Deudor>();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                string query = @"SELECT S.carnetNumero, P.nombre,P.apellido," +
                    "P.direccion,P.dni,P.telefono,C.precio FROM socio S " +
                    "inner join persona P on P.idPersona = S.idPersona " +
                    "inner join cuota C on C.carnetNumero = S.carnetNumero " +
                    "where fechaVencimiento ='" + DateTime.Now.ToString("yyyy-MM-dd") + "' and C.Estado = 0;";
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    E_Deudor act = new E_Deudor()
                    {
                        CarnetNumero = reader.GetInt32("CarnetNumero"),
                        Apellido = reader.GetString("Apellido"),
                        Nombre = reader.GetString("Nombre"),
                        Direccion = reader.GetString("Direccion"),
                        Dni = reader.GetInt32("Dni"),
                        Telefono = reader.GetString("Telefono"),
                        Precio = reader.GetFloat("precio")
                    };

                    deudores.Add(act);
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

            return deudores;
        }
    }
}
