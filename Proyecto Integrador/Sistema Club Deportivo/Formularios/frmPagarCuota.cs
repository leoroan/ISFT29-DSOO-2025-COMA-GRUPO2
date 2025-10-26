using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using static ClubDeportivo.Datos.Persona;
using System;
using System.Drawing;
using System.Windows.Forms;

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

        private void frmPagarCuota_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(240, 248, 255);
            lblTitulo.BackColor = Color.FromArgb(0, 102, 204);
            lblTitulo.ForeColor = Color.White;
        }

        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            if (txtNroSocio.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un número de socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                {
                    CuotaDisponible = true;
                    lblPrecioCuota.Text = "Precio Cuota: $" + cuotasocio.Precio.ToString("F2");
                }
                else
                {
                    CuotaDisponible = false;
                    MessageBox.Show("No se encontró una cuota pendiente para este socio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("El número de socio no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNroSocio.Focus();
                SocioEncontrado = false;
                CuotaDisponible = false;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (SocioEncontrado && CuotaDisponible)
            {
                // Crear un nuevo pago
                Pago pago = new Pago();

                // Construir el objeto con los datos de la cuota y el socio
                E_Pago nuevoPago = new E_Pago()
                {
                    CarnetNumero = int.Parse(txtNroSocio.Text),
                    TipoPersona = (int)TipoPersona.Socio,
                    Precio = cuotasocio.Precio,
                    Fecha = DateTime.Now,
                    MedioPago = optEfvo.Checked ? 1 : 2, // 1 = Efectivo | 2 = Tarjeta
                    Actividad = new E_Actividad(1, "Membresía", 0)
                };

                // Registrar el pago
                string resultado = pago.NuevoPago(nuevoPago, cuotasocio);

                if (!string.IsNullOrEmpty(resultado))
                {
                    MessageBox.Show("Pago registrado con éxito ✅", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnComprobante.Enabled = true;
                    btnPagar.Enabled = false;

                    // Mostrar comprobante automáticamente con QR
                    frmComprobante frm = new frmComprobante();
                    frm.PagoRealizado = nuevoPago; // se pasa el objeto completo al comprobante
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe buscar un socio con cuota disponible antes de pagar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí podrías generar e imprimir el comprobante 🧾", "Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPagarCuota_Load_1(object sender, EventArgs e)
        {

        }
    }
}