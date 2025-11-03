using ClubDeportivo.Datos;

namespace ClubDeportivo.Formularios
{
    public partial class frmListado : Form
    {
        #region Variables y Contructor
        public frmListado()
        {
            InitializeComponent();
        }
        #endregion
        #region Eventos
        private void frmListado_Load(object sender, EventArgs e)
        {
            lblTitulo.Text ="Listado de Socios deudores a la fecha "+ DateTime.Now.ToShortDateString()+ ":";
            Listado listado = new Listado();
            dtgListado.DataSource = listado.TraerDeudores();
        }
        #endregion
    }
}
