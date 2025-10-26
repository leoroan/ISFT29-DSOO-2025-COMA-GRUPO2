using ClubDeportivo.Datos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClubDeportivo.Formularios
{
    public partial class frmRegistrarSocio : Form
    {
        public frmRegistrarSocio()
        {
            InitializeComponent();
        }

        private void frmRegistrarSocio_Load(object sender, EventArgs e)
        {
            // Configuración inicial
            dtpFechaInscripcion.Value = DateTime.Now;
            cboAptoFisico.DataSource = new[]
            {
                new { Texto = "Sí", Valor = true },
                new { Texto = "No", Valor = false }
            };
            cboAptoFisico.DisplayMember = "Texto";
            cboAptoFisico.ValueMember = "Valor";
            cboAptoFisico.SelectedIndex = 0;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!Validaciones())
            {
                MessageBox.Show("Debe completar los datos requeridos.",
                    "AVISO DEL SISTEMA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string respuesta;
            E_Socio persona = new E_Socio(
                Convert.ToInt32(txtDni.Text),
                dtpFechaNacimiento.Value,
                txtNombre.Text,
                txtApellido.Text,
                txtTelefono.Text,
                txtDomicilio.Text,
                Convert.ToBoolean(cboAptoFisico.SelectedValue),
                dtpFechaInscripcion.Value,
                0,
                true
            );

            Datos.Persona personaNueva = new Datos.Persona();
            respuesta = personaNueva.Nuevo_persona(persona);

            bool esNumero = int.TryParse(respuesta, out int codigo);
            if (esNumero)
            {
                if (codigo == 1)
                {
                    MessageBox.Show("El socio ya existe.", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Socio socioNuevo = new Socio();
                    respuesta = socioNuevo.Nuevo_Socio(persona);

                    MessageBox.Show($"¡Socio registrado con éxito!\nCódigo asignado: {respuesta}",
                        "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Registrar cuota automáticamente
                    Actividad actividad = new Actividad();
                    float precio = actividad.TraerPrecioMembresia();
                    Cuota cuota = new Cuota();
                    cuota.NuevaCuota(new E_Cuota(0, int.Parse(respuesta), DateTime.Now, precio, false));

                    DialogResult resultado = MessageBox.Show(
                        "¿Desea imprimir el carnet ahora?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        frmCarnet carnetForm = new frmCarnet();
                        carnetForm.socio = new E_Socio(
                            Convert.ToInt32(txtDni.Text),
                            dtpFechaNacimiento.Value,
                            txtNombre.Text,
                            txtApellido.Text,
                            txtTelefono.Text,
                            txtDomicilio.Text,
                            Convert.ToBoolean(cboAptoFisico.SelectedValue),
                            dtpFechaInscripcion.Value,
                            int.Parse(respuesta),
                            true
                        );
                        carnetForm.ShowDialog();
                    }

                    Limpiar();
                    dtpFechaInscripcion.Focus();
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public bool Validaciones()
        {
            bool ok = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Debe ingresar un nombre");
            }
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                ok = false;
                errorProvider1.SetError(txtApellido, "Debe ingresar un apellido");
            }
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                ok = false;
                errorProvider1.SetError(txtDni, "Debe ingresar el DNI");
            }
            if (string.IsNullOrWhiteSpace(txtDomicilio.Text))
            {
                ok = false;
                errorProvider1.SetError(txtDomicilio, "Debe ingresar un domicilio");
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                ok = false;
                errorProvider1.SetError(txtTelefono, "Debe ingresar un teléfono");
            }

            return ok;
        }

        public void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
            cboAptoFisico.SelectedIndex = 0;
            errorProvider1.Clear();
        }
    }
}