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

        private void btnImprimirCarnet_Click(object sender, EventArgs e)
        {
            //frmCarnet carnet = new frmCarnet();
            //carnet.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnImprimirListado_Click(object sender, EventArgs e)
        {
            frmListado frmListado = new frmListado();
            frmListado.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //C001-Registrar persona -F.uso - 01:El CU inicia cuando el empleado del Club (Administrador) selecciona la opción Registrar Persona
            frmRegistrar registro = new frmRegistrar();
            registro.ShowDialog();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //C004-Pagar -F.uso - 01:Inicia cuando un socio quiere pagar la cuota o cuando un no socio quiere pagar la actividad
            frmPagar frmPagar = new frmPagar();
            frmPagar.ShowDialog();
        }
    }
}
