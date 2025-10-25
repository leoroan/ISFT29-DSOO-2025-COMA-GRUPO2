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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        internal string? rol;
        internal string? usuario;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol +
            ")";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            /* Notifica a todos los surtidores de mensajes que deben
            terminar
            * y, a continuación, cierra todas las ventanas de la
            aplicación
            *
            ____________________________________________________________
            __________ */
            Application.Exit();
        }
        private void btnInscribir_Click(object sender, EventArgs e)
        {
            frmInscripcion inscripcion = new frmInscripcion();
            inscripcion.Show();
            this.Hide();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            /* Notifica a todos los surtidores de mensajes que deben
            terminar
            * y, a continuación, cierra todas las ventanas de la
            aplicación
            *
            ____________________________________________________________
            __________ */
            Application.Exit();
        }
    }
}
