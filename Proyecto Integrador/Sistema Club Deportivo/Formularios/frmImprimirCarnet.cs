using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using static ClubDeportivo.Datos.Persona;

namespace ClubDeportivo.Formularios
{
    public partial class frmImprimirCarnet : Form
    {
        #region Variables y Contructor
        bool SocioEncontrado = false;
        bool NoSocioEncontrado = false;
        E_Socio socioencontrado = null;
        E_NoSocio nosocioencontrado = null;
        bool comboIniciado = false;
        public frmImprimirCarnet()
        {
            InitializeComponent();
        }
        #endregion
        #region Eventos
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmPagar_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(240, 248, 255);
            lblTitulo.BackColor = Color.FromArgb(0, 102, 204);
            lblTitulo.ForeColor = Color.White;

            //como tipo de registro
            cboTipoRegistro.DataSource = new[]
            {
                new { Texto = "Socio", Valor = 1 },
                new { Texto = "No Socio", Valor = 0 }
            };
            cboTipoRegistro.DisplayMember = "Texto";
            cboTipoRegistro.ValueMember = "Valor";
            cboTipoRegistro.SelectedIndex = 0;
            comboIniciado = true;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SocioEncontrado = false;
            if (cboTipoRegistro.SelectedIndex == 0)//socio
            {
                if (txtNro.Text.Trim() == "")
                {
                    MessageBox.Show("DEBE INGRESAR UN NUMERO DE SOCIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNro.Focus();
                    return;
                }
                Socio socio = new Socio();
                socioencontrado = socio.BuscarSocio(new E_Socio(0, DateTime.MinValue, null, null, null, null, false, DateTime.MinValue, int.Parse(txtNro.Text), false));
                if (socioencontrado != null)
                {
                    lblNombre.Text = "Nombre de Socio: " + socioencontrado.Nombre.ToUpper() + " " + socioencontrado.Apellido.ToUpper();
                    SocioEncontrado = true;
                    btnImprimir.Enabled = true;
                }
                else
                {
                    MessageBox.Show("EL NUMERO DE SOCIO NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNro.Focus();
                    SocioEncontrado = false;
                    btnImprimir.Enabled = false;
                }
            }
            else //no socio
            {
                if (txtNro.Text.Trim() == "")
                {
                    MessageBox.Show("DEBE INGRESAR UN NUMERO DE NO SOCIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNro.Focus();
                    return;
                }
                NoSocio noSocio = new NoSocio();
                nosocioencontrado = noSocio.BuscarNoSocio(new E_NoSocio(0, DateTime.MinValue, null, null, null, null, false, int.Parse(txtNro.Text)));
                if (nosocioencontrado != null)
                {

                    lblNombre.Text = "Nombre de No Socio: " + nosocioencontrado.Nombre.ToUpper() + " " + nosocioencontrado.Apellido;
                    NoSocioEncontrado = true;
                    btnImprimir.Enabled = true;
                }
                else 
                {
                    MessageBox.Show("EL NUMERO DE NO SOCIO NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNro.Focus();
                    SocioEncontrado = false;
                }
            }
        }
        private void cboTipoRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboIniciado) return;
            if (cboTipoRegistro.SelectedIndex == 0)//socio
            {
                lblNombre.Text = "Nombre de Socio:";
                lblNumero.Text = "Numero de socio:";
            }
            else //no socio
            {
                lblNombre.Text = "Nombre de No Socio:";
                lblNumero.Text = "Numero No Socio:";
            }
        }
        private void txtNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y teclas de control (como borrar o retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }
        #endregion
        #region Métodos
        public void ResetControles()
        {
            SocioEncontrado = false;
         
            txtNro.Text = "";
            lblNombre.Text = "Nombre:";
        }
        #endregion

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (SocioEncontrado )
            {

                frmCarnet frmCarnet = new frmCarnet(1);
                frmCarnet.socio = new E_Socio
                    (
                         socioencontrado.DNI,
                         socioencontrado.FechaNacimiento,
                         socioencontrado.Nombre,
                         socioencontrado.Apellido,
                         socioencontrado.Telefono,
                         socioencontrado.Domicilio,
                         socioencontrado.AptoFisico,
                         socioencontrado.FechaInscripcion,
                         socioencontrado.CarnetNumero,
                         true
                    );
                frmCarnet.ShowDialog();
            }
            else if (NoSocioEncontrado)
            {
                frmCarnet frmCarnet = new frmCarnet(2);
                frmCarnet.noSocio = new E_NoSocio
                    (
                         nosocioencontrado.DNI,
                         nosocioencontrado.FechaNacimiento,
                         nosocioencontrado.Nombre,
                         nosocioencontrado.Apellido,
                         nosocioencontrado.Telefono,
                         nosocioencontrado.Domicilio,
                         nosocioencontrado.AptoFisico,
                         nosocioencontrado.CarnetTemporal
                    );
                frmCarnet.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe Elegir una Persona para imprimir  el carnet", "impresion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}