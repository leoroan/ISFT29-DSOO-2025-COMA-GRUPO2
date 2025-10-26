namespace ClubDeportivo.Formularios
{
    partial class frmRegistrarSocio
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código del Diseñador
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarSocio));
            this.lblHeader = new Label();
            this.pnlContenedor = new Panel();
            this.errorProvider1 = new ErrorProvider();

            // Campos
            this.labelNombre = new Label();
            this.labelApellido = new Label();
            this.labelDni = new Label();
            this.labelDom = new Label();
            this.labelTel = new Label();
            this.labelApto = new Label();
            this.labelFechaNac = new Label();
            this.labelFechaIns = new Label();

            this.txtNombre = new TextBox();
            this.txtApellido = new TextBox();
            this.txtDni = new TextBox();
            this.txtDomicilio = new TextBox();
            this.txtTelefono = new TextBox();

            this.cboAptoFisico = new ComboBox();
            this.dtpFechaNacimiento = new DateTimePicker();
            this.dtpFechaInscripcion = new DateTimePicker();

            this.btnIngresar = new Button();
            this.btnLimpiar = new Button();
            this.btnVolver = new Button();

            this.SuspendLayout();

            // FONDO
            this.BackgroundImage = Properties.Resources.Fondo;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.DoubleBuffered = true;
            this.ClientSize = new Size(940, 620);

            // HEADER
            this.lblHeader.Dock = DockStyle.Top;
            this.lblHeader.Text = "🏆 REGISTRAR NUEVO SOCIO";
            this.lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            this.lblHeader.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            this.lblHeader.BackColor = Color.FromArgb(0, 102, 204);
            this.lblHeader.ForeColor = Color.White;
            this.lblHeader.Height = 70;

            // PANEL CENTRAL
            this.pnlContenedor.BackColor = Color.FromArgb(230, Color.White);
            this.pnlContenedor.BorderStyle = BorderStyle.FixedSingle;
            this.pnlContenedor.Size = new Size(540, 440);
            this.pnlContenedor.Location = new Point(
                (this.ClientSize.Width - this.pnlContenedor.Width) / 2,
                (this.ClientSize.Height - this.pnlContenedor.Height) / 2);
            this.pnlContenedor.Anchor = AnchorStyles.None;
            this.pnlContenedor.Padding = new Padding(25);

            // LABELS
            Font labelFont = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            int y = 25, spacing = 38;

            this.labelFechaIns.Text = "Fecha de inscripción:";
            this.labelFechaIns.Location = new Point(30, y);
            this.labelFechaIns.Font = labelFont;
            y += spacing;

            this.labelNombre.Text = "Nombre:";
            this.labelNombre.Location = new Point(30, y);
            this.labelNombre.Font = labelFont;
            y += spacing;

            this.labelApellido.Text = "Apellido:";
            this.labelApellido.Location = new Point(30, y);
            this.labelApellido.Font = labelFont;
            y += spacing;

            this.labelFechaNac.Text = "Fecha Nac.:";
            this.labelFechaNac.Location = new Point(30, y);
            this.labelFechaNac.Font = labelFont;
            y += spacing;

            this.labelDni.Text = "DNI:";
            this.labelDni.Location = new Point(30, y);
            this.labelDni.Font = labelFont;
            y += spacing;

            this.labelDom.Text = "Domicilio:";
            this.labelDom.Location = new Point(30, y);
            this.labelDom.Font = labelFont;
            y += spacing;

            this.labelTel.Text = "Teléfono:";
            this.labelTel.Location = new Point(30, y);
            this.labelTel.Font = labelFont;
            y += spacing;

            this.labelApto.Text = "Apto físico:";
            this.labelApto.Location = new Point(30, y);
            this.labelApto.Font = labelFont;

            // INPUTS
            int xInput = 220;
            Font inputFont = new Font("Segoe UI", 10F);
            y = 22;

            this.dtpFechaInscripcion.Format = DateTimePickerFormat.Short;
            this.dtpFechaInscripcion.Location = new Point(xInput, y);
            this.dtpFechaInscripcion.Width = 230;
            y += spacing;

            this.txtNombre.Location = new Point(xInput, y);
            this.txtNombre.Width = 230;
            y += spacing;

            this.txtApellido.Location = new Point(xInput, y);
            this.txtApellido.Width = 230;
            y += spacing;

            this.dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new Point(xInput, y);
            this.dtpFechaNacimiento.Width = 230;
            y += spacing;

            this.txtDni.Location = new Point(xInput, y);
            this.txtDni.Width = 230;
            y += spacing;

            this.txtDomicilio.Location = new Point(xInput, y);
            this.txtDomicilio.Width = 230;
            y += spacing;

            this.txtTelefono.Location = new Point(xInput, y);
            this.txtTelefono.Width = 230;
            y += spacing;

            this.cboAptoFisico.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboAptoFisico.Location = new Point(xInput, y);
            this.cboAptoFisico.Width = 130;

            // BOTONES
            int yBotones = 370;
            Font btnFont = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);

            this.btnIngresar.Text = "Guardar";
            this.btnIngresar.BackColor = Color.FromArgb(0, 102, 204);
            this.btnIngresar.ForeColor = Color.White;
            this.btnIngresar.FlatStyle = FlatStyle.Flat;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.Font = btnFont;
            this.btnIngresar.Size = new Size(110, 36);
            this.btnIngresar.Location = new Point(40, yBotones);
            this.btnIngresar.Click += btnIngresar_Click;

            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.BackColor = Color.Gray;
            this.btnLimpiar.ForeColor = Color.White;
            this.btnLimpiar.FlatStyle = FlatStyle.Flat;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.Font = btnFont;
            this.btnLimpiar.Size = new Size(110, 36);
            this.btnLimpiar.Location = new Point(180, yBotones);
            this.btnLimpiar.Click += btnLimpiar_Click;

            this.btnVolver.Text = "Cerrar";
            this.btnVolver.BackColor = Color.FromArgb(220, 20, 60);
            this.btnVolver.ForeColor = Color.White;
            this.btnVolver.FlatStyle = FlatStyle.Flat;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.Font = btnFont;
            this.btnVolver.Size = new Size(110, 36);
            this.btnVolver.Location = new Point(330, yBotones);
            this.btnVolver.Click += btnVolver_Click;

            // AGREGAR AL PANEL
            this.pnlContenedor.Controls.AddRange(new Control[]
            {
                labelFechaIns, labelNombre, labelApellido, labelFechaNac, labelDni,
                labelDom, labelTel, labelApto,
                dtpFechaInscripcion, txtNombre, txtApellido, dtpFechaNacimiento,
                txtDni, txtDomicilio, txtTelefono, cboAptoFisico,
                btnIngresar, btnLimpiar, btnVolver
            });

            // ERROR PROVIDER
            this.errorProvider1.ContainerControl = this;

            // FORMULARIO
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pnlContenedor);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Registro de Socios";
            this.Load += frmRegistrarSocio_Load;

            this.ResumeLayout(false);
        }
        #endregion

        private Label lblHeader;
        private Panel pnlContenedor;
        private Label labelNombre, labelApellido, labelDni, labelDom, labelTel, labelApto, labelFechaNac, labelFechaIns;
        private TextBox txtNombre, txtApellido, txtDni, txtDomicilio, txtTelefono;
        private ComboBox cboAptoFisico;
        private DateTimePicker dtpFechaNacimiento, dtpFechaInscripcion;
        private Button btnIngresar, btnLimpiar, btnVolver;
        private ErrorProvider errorProvider1;
    }
}