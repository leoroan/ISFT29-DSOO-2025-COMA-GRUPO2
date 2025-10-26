using ClubDeportivo.Formularios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClubDeportivo.Formularios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public string? rol;
        public string? usuario;

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tsbUsuario.Text = "👤 USUARIO: " + usuario;
            tsbRol.Text = "🏅 ROL: " + rol;
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            frmRegistrarSocio registro = new frmRegistrarSocio();
            registro.ShowDialog();
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            frmPagarCuota frmPagarCuota = new frmPagarCuota();
            frmPagarCuota.ShowDialog();
        }

        private void btnImprimirCarnet_Click(object sender, EventArgs e)
        {
            frmCarnet carnet = new frmCarnet();
            carnet.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlBotones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
