using MySql.Data.MySqlClient;
using Proyecto.Datos;
using Proyecto.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Formularios
{
    public partial class frmPagar : Form
    {
        public frmPagar()
        {
            InitializeComponent();
        }
        public frmFactura doc = new frmFactura();

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConcexion();
                /*
                --------------------------------------------------------
                -------------------------
                * Consulta simple que proyecta los datos necesarios
                * para rellenar el documento
                * En este caso se trata del comprobante de pago del
                curso
                *
                --------------------------------------------------------
                ------------------------------------ */
                query = (@"select idinscri, nombre, concat(nombrep, '
                    ', apellidop) alumno, precio,e.fecha 
                    from inscripcion i inner join edicion e on
                    i.idEdicion = e.idEdicion
                    inner join curso c on c.ncurso = e.ncurso inner
                    join alumno a on a.legajo = i.legajo
                    inner join postulante p on p.NPostu = a.Npostu
                    where idinscri =" + txtNro.Text); // <<<------ usamos el dato ingresado                por el usuario
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                // usamos la consulta y la conexion.-
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader; // El DataReader almacena TODAS las filas.-
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read(); // En este caso sabemos que si tiene datos es UNA SOLA FILA
                    doc.numero_f = reader.GetInt32(0);
                    doc.curso_f = reader.GetString(1);
                    doc.alumno_f = reader.GetString(2).Trim();
                    doc.monto_f = reader.GetFloat(3);
                    doc.fecha_f = reader.GetDateTime(4);
                    if (optEfvo.Checked == true) // Evaluamos que opcion es la seleccionada
                    {
                        doc.forma_f = "Efectivo";
                        /* ---------------------------------
                        * Pago en efvo se descuenta 10%
                        * --------------------------------- */
                        doc.monto_f = (float)(doc.monto_f * 0.90);
                    }
                    else
                    {
                        doc.forma_f = "Tarjeta";
                    }
                    //guardar pago
                    Pago pago = new Pago();
                    string rta = pago.NuevoPago(new E_Pago
                    {
                        IdInscripcion = doc.numero_f,
                        Monto = doc.monto_f,
                        Fecha = DateTime.Now
                    });

                    if (rta != "1")
                    {
                        MessageBox.Show("Pago registrado con exito bajo en numero: " + rta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnComprobante.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("El pago ya existe", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Número de inscripcion inexistente", "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
                ;
            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            doc.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
