using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using static ClubDeportivo.Datos.Persona;

namespace ClubDeportivo.Formularios
{
    public partial class frmPagar : Form
    {
        public frmPagar()
        {
            InitializeComponent();
        }
        bool SocioEncontrado = false;
        bool NoSocioEncontrado = false;
        bool CuotaDisponible = false;
        bool PagoActividadDisponible = false;
        E_Socio socioencontrado = null;
        E_NoSocio nosocioencontrado = null;
        E_Cuota cuotasocio = null;
        E_PagoActividad pagoactividad = null;
        E_Pago PagoRealizado = null;
        bool comboIniciado = false;
        public void ResetControles()
        {
            SocioEncontrado = false;
            CuotaDisponible = false;
            cuotasocio = null;
            txtNro.Text = "";
            lblNombre.Text = "Nombre:";
            lblPrecio.Text = "Precio:";
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            //C004-Pagar -F.uso - 04:se registra el pago en el sistema
            if ((SocioEncontrado && CuotaDisponible) || (NoSocioEncontrado && PagoActividadDisponible))
            {
                int tipoRegistro = int.Parse(cboTipoRegistro.SelectedValue.ToString());
                float precio;
                int idRegistroaPagar;
                E_Actividad actividad;

                /////aqui aqui
                Pago pago = new Pago();
                if (tipoRegistro == 1)
                {
                    // Es socio
                    precio = cuotasocio.Precio;
                    idRegistroaPagar = cuotasocio.IdCuota;
                    actividad = new E_Actividad(1, "Todas", 0);
                }
                else
                {
                    // No socio
                    precio = pagoactividad.Precio;
                    idRegistroaPagar = pagoactividad.IdPagoActividad;
                    Actividad actividad1 = new Actividad();
                    actividad = actividad1.TraerActividad(pagoactividad.NroActividad);
                }

                PagoRealizado = new E_Pago()
                {
                    CarnetNumero = int.Parse(txtNro.Text),
                    TipoPersona = tipoRegistro == 1 ? (int)TipoPersona.Socio : (int)TipoPersona.NoSocio,
                    Precio = precio,
                    Fecha = DateTime.Now,
                    MedioPago = 1,
                    Actividad = actividad
                };
                string resultado = pago.NuevoPago(PagoRealizado, idRegistroaPagar);

                //ver error no funciona control
                if (resultado != "")
                {
                    MessageBox.Show("Pago registrado con exito", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnComprobante.Enabled = true;
                    btnPagar.Enabled = false;
                    ResetControles();
                    btnComprobante.Enabled = true;
                }
                else //C004-Pago-F.alternativo -07:no se pudo realizar el pago.
                {
                    //C004-Pago-F.alternativo -07:muestra un error y permite reintentar
                    MessageBox.Show("El Pago no se registro", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe Elegir una Persona para registrar el pago", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnComprobante_Click(object sender, EventArgs e)
        {
            frmComprobante frmComprobante = new frmComprobante(cboTipoRegistro.SelectedIndex == 0 ? 1 : 2);
            frmComprobante.noSocio = nosocioencontrado;
            frmComprobante.socio = socioencontrado;
            frmComprobante.E_Pago = PagoRealizado;
            frmComprobante.TipoPersona = cboTipoRegistro.SelectedIndex == 0 ? 1 : 2;
            frmComprobante.ShowDialog();
        }
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
            if (cboTipoRegistro.SelectedIndex == 0)//socio
            {
                if (txtNro.Text.Trim() == "")
                {
                    MessageBox.Show("DEBE INGRESAR UN NUMERO DE SOCIO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNro.Focus();
                    return;
                }
                //C004-Pagar -F.uso - 02:Se verifica que exista el socio o no socio
                Socio socio = new Socio();
                socioencontrado = socio.BuscarSocio(new E_Socio(0, DateTime.MinValue, null, null, null, null, false, DateTime.MinValue, int.Parse(txtNro.Text), false));
                if (socioencontrado != null)
                {
                    lblNombre.Text = "Nombre de Socio: " + socioencontrado.Nombre.ToUpper() + " " + socioencontrado.Apellido.ToUpper();
                    SocioEncontrado = true;
                    //C004-Pagar -F.uso - 03:Se verifica que tenga cuota a pagar o actividad a pagar
                    Cuota cuota = new Cuota();
                    cuotasocio = cuota.TraerCuota(socioencontrado.CarnetNumero);
                    if (cuotasocio != null)
                        CuotaDisponible = true;
                    else
                    {
                        CuotaDisponible = false;
                        MessageBox.Show("No se encontro Cuota para el Socio o la misma se encuentra pagada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    lblPrecio.Text = "Precio Cuota: $" + cuotasocio.Precio.ToString("F2");
                    btnPagar.Enabled = true;
                }
                else //C004-Pago-F.alternativo -05:no se encuentra socio o no socio.
                {
                    //C004-Pago-F.alternativo - 06:muestra un error y permite reintentar.
                    MessageBox.Show("EL NUMERO DE SOCIO NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNro.Focus();
                    SocioEncontrado = false;
                    CuotaDisponible = false;
                    btnPagar.Enabled = false;
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
                //C004-Pagar -F.uso - 02:Se verifica que exista el socio o no socio
                NoSocio noSocio = new NoSocio();
                nosocioencontrado = noSocio.BuscarNoSocio(new E_NoSocio(0, DateTime.MinValue, null, null, null, null, false, int.Parse(txtNro.Text)));
                if (nosocioencontrado != null)
                {

                    lblNombre.Text = "Nombre de No Socio: " + nosocioencontrado.Nombre.ToUpper() + " " + nosocioencontrado.Apellido;
                    NoSocioEncontrado = true;
                    //C004-Pagar -F.uso - 03:Se verifica que tenga cuota a pagar o actividad a pagar
                    PagoActividad pagoActividad = new PagoActividad();
                    pagoactividad = pagoActividad.TraerPagoActividad(nosocioencontrado.CarnetTemporal);
                    if (pagoactividad != null)
                        PagoActividadDisponible = true;
                    else
                    {
                        PagoActividadDisponible = false;
                        MessageBox.Show("No se encontro Cuota para el Socio o la misma se encuentra pagada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    lblPrecio.Text = "Precio de la Actividad: $" + pagoactividad.Precio.ToString("F2");
                    btnPagar.Enabled = true;
                }
                else //C004-Pago-F.alternativo -05:no se encuentra socio o no socio.
                {
                    //C004-Pago-F.alternativo - 06:muestra un error y permite reintentar.
                    MessageBox.Show("EL NUMERO DE NO SOCIO NO EXISTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNro.Focus();
                    SocioEncontrado = false;
                    CuotaDisponible = false;
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
                lblPrecio.Text = "Precio Cuota:";
            }
            else //no socio
            {
                lblNombre.Text = "Nombre de No Socio:";
                lblNumero.Text = "Numero No Socio:";
                lblPrecio.Text = "Precio de Actividad:";
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
    }
}