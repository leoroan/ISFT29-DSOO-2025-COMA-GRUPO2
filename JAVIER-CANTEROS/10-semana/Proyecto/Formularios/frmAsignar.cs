using MySql.Data.MySqlClient;
using Proyecto.Datos;
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
    public partial class frmAsignar : Form
    {
        public frmAsignar()
        {
            InitializeComponent();
        }

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
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
