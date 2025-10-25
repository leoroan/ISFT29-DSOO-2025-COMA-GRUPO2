
using ClubDeportivo.Datos;

namespace ClubDeportivo.Formularios
{
    /// <summary>
    /// Formulario para el registro de nuevos socios en el club deportivo.
    /// Permite ingresar y validar los datos personales de un nuevo socio.
    /// </summary>
    public partial class frmRegistrarSocio : Form
    {
        /// <summary>
        /// Constructor del formulario de registro de socios.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public frmRegistrarSocio()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Maneja el evento de click del botón Ingresar.
        /// Valida los datos ingresados y registra un nuevo socio en la base de datos.
        /// </summary>
        /// <param name="sender">Objeto que desencadena el evento</param>
        /// <param name="e">Argumentos del evento</param>
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
                E_Socio persona = new E_Socio
                    (
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

                // instanciamos para usar el metodo dentro de Socio
                Datos.Persona personaNueva = new Datos.Persona();
                respuesta = personaNueva.Nuevo_persona(persona);
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
                        Socio socioNuevo = new Socio();
                        respuesta = socioNuevo.Nuevo_Socio(persona);

                        MessageBox.Show("se almaceno con exito con el codigo Nro " + respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);

                        //obtengo precio de la membresia
                        Actividad actividad = new Actividad();
                        float precio = actividad.TraerPrecioMembresia();

                        //registro cuota mensual
                        Cuota cuota = new Cuota();
                        cuota.NuevaCuota(new E_Cuota(0, int.Parse(respuesta), DateTime.Now, precio, false));

                        //preguntar para imprimir carnet
                        DialogResult resultado = MessageBox.Show(
                                "¿Desea Imprimir el carnet?",  
                                "Confirmación",               
                                MessageBoxButtons.YesNo,      
                                MessageBoxIcon.Question     
);

                        if (resultado == DialogResult.Yes)
                        {
                           frmCarnet frmCarnet = new frmCarnet();
                           frmCarnet.socio = new E_Socio
                               (
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
                            frmCarnet.ShowDialog();
                        }

                        Limpiar();
                        dtpFechaInscripcion.Focus();

                    }
                }
            }
        }
        /// <summary>
        /// Maneja el evento de click del botón Volver.
        /// Cierra el formulario actual.
        /// </summary>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Se ejecuta al cargar el formulario.
        /// Inicializa la fecha de inscripción con la fecha actual y configura el combo box de apto físico.
        /// </summary>
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
        /// <summary>
        /// Valida que todos los campos requeridos estén completos.
        /// Muestra mensajes de error para los campos incompletos.
        /// </summary>
        /// <returns>true si todos los campos son válidos, false en caso contrario</returns>
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
        /// <summary>
        /// Maneja el evento de click del botón Limpiar.
        /// Limpia todos los campos del formulario.
        /// </summary>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Limpia todos los campos del formulario y elimina los mensajes de error.
        /// </summary>
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

        private void btnImprimirCarnet_Click(object sender, EventArgs e)
        {

        }
    }
}
