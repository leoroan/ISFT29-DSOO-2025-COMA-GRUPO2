using ClubDeportivo.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo.Formularios
{
    public partial class frmListado : Form
    {
        public frmListado()
        {
            InitializeComponent();
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            lblTitulo.Text ="Listado de Socios deudores a la fecha "+ DateTime.Now.ToShortDateString()+ ":";
            //Listado listado = new Listado();
            //dtgListado.DataSource = listado.TraerDeudores();
        }
    }
}
