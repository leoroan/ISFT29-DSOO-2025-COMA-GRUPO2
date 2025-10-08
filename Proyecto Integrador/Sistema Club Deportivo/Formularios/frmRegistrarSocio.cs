using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClubDeportivo.Formularios
{
    public partial class frmRegistrarSocio : Form
    {
        public frmRegistrarSocio()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!Validaciones())
            {
                MessageBox.Show("Debe completar datos requeridos",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                E_Socio socio = new E_Socio
                    (
                        Convert.ToInt32(txtDni.Text),
                        dtpFechaNacimiento.Value,
                        txtNombre.Text,
                        txtApellido.Text,
                        txtTelefono.Text,
                        txtDomicilio.Text,
                        Convert.ToBoolean(cboAptoFisico.SelectedValue),
                        dtpFechaInscripcion.Value
                     );

                // instanciamos para usar el metodo dentro de Socio
                Datos.Socio socioNuevo = new Datos.Socio();
                respuesta = socioNuevo.Nuevo_Socio(socio);
                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("Socio YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("se almaceno con exito con el codigo Nro " + respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                        Limpiar();
                        dtpFechaInscripcion.Focus();

                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmRegistrarSocio_Load(object sender, EventArgs e)
        {
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
        public bool Validaciones()
        {
            bool ok = true;
            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Debe ingresar un nombre");
            }
            if (txtApellido.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtApellido, "Debe ingresar un apellido");
            }
            if (txtDni.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDni, "Debe ingresar un DNI");
            }
            if (txtDomicilio.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtDomicilio, "Debe ingresar un Direccion");
            }
            if (txtTelefono.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtTelefono, "Debe ingresar un Telefono");
            }
            if (cboAptoFisico.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cboAptoFisico, "Debe seleccionar una opcion");
            }
            return ok;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDomicilio.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            cboAptoFisico.Text = "";
            errorProvider1.Clear();
        }
    }
}
