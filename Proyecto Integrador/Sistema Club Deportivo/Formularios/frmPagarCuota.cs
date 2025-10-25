using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using static ClubDeportivo.Datos.Persona;

namespace ClubDeportivo.Formularios
{
    public partial class frmPagarCuota : Form
    {
        public frmPagarCuota()
        {
            InitializeComponent();
        }
        bool SocioEncontrado = false;
        bool CuotaDisponible = false;
        E_Socio socioencontrado = null;
        E_Cuota cuotasocio = null;

        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            if (txtNroSocio.Text.Trim() == "")
            {
                MessageBox.Show("DEBE INGRESAR UN NUMERO DE SOCIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNroSocio.Focus();
                return;
            }
            Socio socio = new Socio();
            socioencontrado = socio.BuscarSocio(new E_Socio(0, DateTime.MinValue, null, null, null, null, false, DateTime.MinValue, int.Parse(txtNroSocio.Text), false));
            if (socioencontrado != null)
            {

                lblNombreSocio.Text = "Nombre de Socio: " + socioencontrado.Nombre.ToUpper();
                SocioEncontrado = true;
                Cuota cuota = new Cuota();
                cuotasocio = cuota.TraerCuota(socioencontrado.CarnetNumero);
                if (cuotasocio != null)
                    CuotaDisponible = true;

                else
                {
                    CuotaDisponible = false;
                    MessageBox.Show("No se encontro Cuota para el Socio o la misma se encuentra pagada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                lblPrecioCuota.Text = "Precio Cuota: $" + cuotasocio.Precio.ToString("F2");
            }
            else
            {
                MessageBox.Show("EL NUMERO DE SOCIO NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNroSocio.Focus();
                SocioEncontrado = false;
                CuotaDisponible = false;
            }

        }
        public void ResetControles()
        {
            SocioEncontrado = false;
            CuotaDisponible = false;
            socioencontrado = null;
            cuotasocio = null;
            lblNombreSocio.Text = "Nombre de Socio:";
            btnComprobante.Enabled = false;
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (SocioEncontrado && CuotaDisponible)
            {
                Pago pago = new Pago();
                string resultado = pago.NuevoPago(
                    new E_Pago()
                    {
                        CarnetNumero = int.Parse(txtNroSocio.Text),
                        TipoPersona = (int)TipoPersona.Socio,
                        Precio = cuotasocio.Precio,
                        Fecha = DateTime.Now,
                        MedioPago = 1,
                        Actividad = new E_Actividad(1, "", 0)


                    },
                    cuotasocio);
                if (resultado != "")
                {
                    MessageBox.Show("Pago registrado con exito");
                    btnComprobante.Enabled = true;
                    btnPagar.Enabled = false;
                }
                else MessageBox.Show("El Pago no se registro");

            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {

        }
    }
}
