
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
            tsbUsuario.Text = "USUARIO: " + usuario;
            tsbRol.Text = "Rol: " + "(" + rol + ")";
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            frmRegistrarSocio registro = new frmRegistrarSocio();
            registro.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {

        }
    }
}
