using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;

namespace ClubDeportivo.Formularios
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }
        bool comboIniciado = false;
        Actividad actividad = new Actividad();
        List<E_Actividad> actividades;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //C001-Registrar persona-F.uso - 02: El Administrador ingresa los datos
            errorProvider1.Clear();
            //C001-Registrar persona-F.uso - 03:El sistema verifica que todos los datos estén ingresados.
            if (!Validaciones())
            {
                MessageBox.Show("Debe completar datos requeridos",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                //verifico si registro como socio o no socio
                if (cboTipoPersona.SelectedIndex == 0)//socio
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
                    //registro la persona
                    Persona personaNueva = new Persona();
                    //C001-Registrar persona-F.uso - 5. El sistema almacena al postulante del Club
                    respuesta = personaNueva.Nuevo_persona(persona);
                    bool esnumero = int.TryParse(respuesta, out int codigo);
                    if (esnumero)
                    {
                        //C001-Registrar persona-F.uso - 04. El sistema verifica que no exista el postulante como tal.
                        if (codigo == 1)
                        {
                            //C001-Registrar persona-F.alternativo - 8. El sistema muestra un mensaje.
                            MessageBox.Show("Socio YA EXISTE", "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //C002-Registrar Socio - F.uso - 1. El Administrativo Registra a la persona como Socio
                            Socio socioNuevo = new Socio();
                            //C002-Registrar Socio - F.uso - 2.Se le Genera un Número de Socio.(respuesta)
                            respuesta = socioNuevo.Nuevo_Socio(persona, codigo);

                            MessageBox.Show("se almaceno con exito con el codigo Nro " + respuesta, "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK, MessageBoxIcon.Question);

                            //obtengo precio de la membresia
                            Actividad actividad = new Actividad();
                            E_Actividad act = actividad.TraerActividad(1);
                            float precio = act.Precio;

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
                                frmCarnet frmCarnet = new frmCarnet(1);
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
                else //no socio
                {
                    string respuesta;
                    E_NoSocio persona = new E_NoSocio
                        (
                            Convert.ToInt32(txtDni.Text),
                            dtpFechaNacimiento.Value,
                            txtNombre.Text,
                            txtApellido.Text,
                            txtTelefono.Text,
                            txtDomicilio.Text,
                            Convert.ToBoolean(cboAptoFisico.SelectedValue),
                            0

                         );

                    // instanciamos para usar el metodo dentro de Socio
                    //registro la persona
                    //C001-Registrar persona-F.uso - 5. El sistema almacena al postulante del Club
                    Persona personaNueva = new Persona();
                    respuesta = personaNueva.Nuevo_persona(persona);

                    bool esnumero = int.TryParse(respuesta, out int codigo);
                    if (esnumero)
                    {
                        //C001-Registrar persona-F.uso - 04. El sistema verifica que no exista el postulante como tal.
                        if (codigo == 1)
                        {
                            MessageBox.Show("No Socio YA EXISTE", "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //C003-Registrar No Socio - F.uso - 1. El Administrativo Registra a la persona como Socio
                            NoSocio noSocioNuevo = new NoSocio();
                            //C003-Registrar No Socio - F.uso - 2.Se le genera un Numero Temporal de No socio(Respuesta)
                            respuesta = noSocioNuevo.Nuevo_NoSocio(persona, codigo);

                            MessageBox.Show("se almaceno con exito con el No Socio con el codigo Nro " + respuesta, "AVISO DEL SISTEMA",
                            MessageBoxButtons.OK, MessageBoxIcon.Question);

                            //obtengo precio de la actividad
                            Actividad actividad = new Actividad();
                            E_Actividad act = actividad.TraerActividad(int.Parse(cboActividad.SelectedValue.ToString()));
                            float precio = act.Precio;

                            //registro pago de actividad
                            PagoActividad pagoActividad = new PagoActividad();
                            pagoActividad.NuevaPagoActividad(new E_PagoActividad(0, int.Parse(cboActividad.SelectedValue.ToString()), int.Parse(respuesta), precio, false));

                            //preguntar para imprimir carnet
                            DialogResult resultado = MessageBox.Show(
                                    "¿Desea Imprimir el carnet Temporal?",
                                    "Confirmación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question
                            );

                            if (resultado == DialogResult.Yes)
                            {
                                frmCarnet frmCarnet = new frmCarnet(0);
                                frmCarnet.noSocio = new E_NoSocio
                                    (
                                         Convert.ToInt32(txtDni.Text),
                                         dtpFechaNacimiento.Value,
                                         txtNombre.Text,
                                         txtApellido.Text,
                                         txtTelefono.Text,
                                         txtDomicilio.Text,
                                         Convert.ToBoolean(cboAptoFisico.SelectedValue),
                                         int.Parse(respuesta)

                                    );
                                frmCarnet.ShowDialog();
                            }

                            Limpiar();
                            dtpFechaInscripcion.Focus();

                        }
                    }
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

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            dtpFechaInscripcion.Value = DateTime.Now;
            //combo apto fisico
            cboAptoFisico.DataSource = new[]
            {
                new { Texto = "Sí", Valor = true },
                new { Texto = "No", Valor = false }
            };
            cboAptoFisico.DisplayMember = "Texto";
            cboAptoFisico.ValueMember = "Valor";
            cboAptoFisico.SelectedIndex = 0;

            //como tipo de registro
            cboTipoPersona.DataSource = new[]
           {
                new { Texto = "Socio", Valor = 1 },
                new { Texto = "No Socio", Valor = 0 }
            };
            cboTipoPersona.DisplayMember = "Texto";
            cboTipoPersona.ValueMember = "Valor";
            cboTipoPersona.SelectedIndex = 0;

            //cargo actividades

            actividades = actividad.TraerActividades();
            cboActividad.DataSource = actividades;
            cboActividad.DisplayMember = "Nombre";
            cboActividad.ValueMember = "NroActividad";
            cboActividad.SelectedIndex = 0;
            comboIniciado = true;
        }

        private void cboTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboIniciado) return;
            if (cboTipoPersona.SelectedIndex == 0)//socio
            {
                cboActividad.DataSource = actividades;
                cboActividad.SelectedIndex = 0;
                cboActividad.Enabled = false;
            }
            else
            {
                var filtradas = actividades
                .Where(a => a.Nombre != "Todas")
                .ToList();

                cboActividad.DataSource = filtradas;
                cboActividad.Enabled = true;
                cboActividad.SelectedIndex = 1;
            }
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha actual.",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                dtpFechaNacimiento.Value = DateTime.Now;

            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y teclas de control (como borrar o retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y teclas de control (como borrar o retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }
    }
}