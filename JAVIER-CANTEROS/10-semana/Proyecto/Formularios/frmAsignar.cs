using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Cursor;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto.Formularios
{
    public partial class frmAsignar : Form
    {
        public frmAsignar()
        {
            InitializeComponent();
        }
        bool AluumnoEncontrado = false;
        E_Alumno alumnoEncontrado;
        private void frmAsignar_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                string query;
                sqlcon = Conexion.getInstancia().CrearConcexion();
                query = @"select c.nombre Curso,fecha,concat(nombreD,' ',apellidoD) as Docente,precio,e.idEdicion
                        from curso c
                        inner
                        join edicion e
                         on c.NCurso = e.ncurso
                        inner
                        join docente d
                        on e.Docente = d.nDocente
                        where fecha > curdate()
                        order by nombre";
                MySqlCommand cmd = new MySqlCommand(query, sqlcon);
                cmd.CommandType = CommandType.Text;
                sqlcon.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dtgvCurso.Rows.Add(reader.GetString(0), reader.GetDateTime(1).ToString("dd/MM/yyyy"),
                            reader.GetString(2), reader.GetDecimal(3).ToString("0.00"), reader.GetInt32(4));
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY DATOS PARA LA CARGA DE GRILLA");
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();
            }
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            if (txtNumLegajo.Text.Trim() == "")
            {
                MessageBox.Show("DEBE INGRESAR UN NUMERO DE LEGAJO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumLegajo.Focus();
                return;
            }
            Alumno alumno = new Alumno();
            alumnoEncontrado = alumno.BuscarAlumno(Convert.ToInt32(txtNumLegajo.Text.Trim()));
            if (alumnoEncontrado != null)
            {

                lblNombreAlumno.Text = "NOMBRE Y APELLIDO DEL ALUMNO: "+ alumnoEncontrado.Apellido?.ToUpper() + " "+ alumnoEncontrado.Nombre?.ToUpper();
                AluumnoEncontrado = true;
            }
            else
            {
                MessageBox.Show("EL NUMERO DE LEGAJO NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumLegajo.Focus();
                AluumnoEncontrado = false;
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (!AluumnoEncontrado)
            {
                MessageBox.Show("DEBE BUSCAR UN ALUMNO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumLegajo.Focus();
                return;
            }
            if (dtgvCurso.CurrentRow == null)
            {
                MessageBox.Show("DEBE SELECCIONAR UN CURSO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtgvCurso.Focus();
                return;
            }
            Inscripcion inscripcion = new Inscripcion();
            string rta = inscripcion.NuevaInscripcion
                (
                    new E_Alumno 
                    { 
                        Legajo = Convert.ToInt32(txtNumLegajo.Text.Trim()) 
                    },
                    new E_Edicion
                    {
                        idEdicion =
                    Convert.ToInt32(dtgvCurso.CurrentRow.Cells["NROEDICION"].Value?.ToString())
                    }
                );
            if (rta == "1")
            {
                MessageBox.Show("El Registro para esa materia del alumno " + alumnoEncontrado.Apellido + " " + alumnoEncontrado.Nombre + " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                MessageBox.Show("El alumno " + alumnoEncontrado.Apellido + " " + alumnoEncontrado.Nombre + " registro el numero de inscripcion: " + rta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
