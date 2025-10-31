namespace ClubDeportivo.Formularios
{
    partial class frmRegistrar
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
            components = new System.ComponentModel.Container();
            lblHeader = new Label();
            pnlContenedor = new Panel();
            label2 = new Label();
            label1 = new Label();
            cboActividad = new ComboBox();
            cboTipoPersona = new ComboBox();
            labelFechaIns = new Label();
            labelNombre = new Label();
            labelApellido = new Label();
            labelFechaNac = new Label();
            labelDni = new Label();
            labelDom = new Label();
            labelTel = new Label();
            labelApto = new Label();
            dtpFechaInscripcion = new DateTimePicker();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            txtDni = new TextBox();
            txtDomicilio = new TextBox();
            txtTelefono = new TextBox();
            cboAptoFisico = new ComboBox();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            errorProvider1 = new ErrorProvider(components);
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.FromArgb(0, 102, 204);
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(940, 70);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "🏆 REGISTRAR NUEVO SOCIO";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Anchor = AnchorStyles.None;
            pnlContenedor.BackColor = Color.FromArgb(230, 255, 255, 255);
            pnlContenedor.BorderStyle = BorderStyle.FixedSingle;
            pnlContenedor.Controls.Add(label2);
            pnlContenedor.Controls.Add(label1);
            pnlContenedor.Controls.Add(cboActividad);
            pnlContenedor.Controls.Add(cboTipoPersona);
            pnlContenedor.Controls.Add(labelFechaIns);
            pnlContenedor.Controls.Add(labelNombre);
            pnlContenedor.Controls.Add(labelApellido);
            pnlContenedor.Controls.Add(labelFechaNac);
            pnlContenedor.Controls.Add(labelDni);
            pnlContenedor.Controls.Add(labelDom);
            pnlContenedor.Controls.Add(labelTel);
            pnlContenedor.Controls.Add(labelApto);
            pnlContenedor.Controls.Add(dtpFechaInscripcion);
            pnlContenedor.Controls.Add(txtNombre);
            pnlContenedor.Controls.Add(txtApellido);
            pnlContenedor.Controls.Add(dtpFechaNacimiento);
            pnlContenedor.Controls.Add(txtDni);
            pnlContenedor.Controls.Add(txtDomicilio);
            pnlContenedor.Controls.Add(txtTelefono);
            pnlContenedor.Controls.Add(cboAptoFisico);
            pnlContenedor.Controls.Add(btnIngresar);
            pnlContenedor.Controls.Add(btnLimpiar);
            pnlContenedor.Controls.Add(btnVolver);
            pnlContenedor.Location = new Point(193, 95);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Padding = new Padding(25);
            pnlContenedor.Size = new Size(540, 487);
            pnlContenedor.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(30, 98);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 22;
            label2.Text = "Tipo de Actividad:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(30, 61);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 21;
            label1.Text = "Tipo de Persona:";
            // 
            // cboActividad
            // 
            cboActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActividad.Location = new Point(210, 98);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(130, 23);
            cboActividad.TabIndex = 2;
            // 
            // cboTipoPersona
            // 
            cboTipoPersona.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoPersona.Location = new Point(210, 60);
            cboTipoPersona.Name = "cboTipoPersona";
            cboTipoPersona.Size = new Size(130, 23);
            cboTipoPersona.TabIndex = 1;
            cboTipoPersona.SelectedIndexChanged += cboTipoPersona_SelectedIndexChanged;
            // 
            // labelFechaIns
            // 
            labelFechaIns.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelFechaIns.Location = new Point(28, 22);
            labelFechaIns.Name = "labelFechaIns";
            labelFechaIns.Size = new Size(154, 23);
            labelFechaIns.TabIndex = 0;
            labelFechaIns.Text = "Fecha de inscripción:";
            // 
            // labelNombre
            // 
            labelNombre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelNombre.Location = new Point(30, 136);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(100, 23);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            labelApellido.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelApellido.Location = new Point(30, 175);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(100, 23);
            labelApellido.TabIndex = 2;
            labelApellido.Text = "Apellido:";
            // 
            // labelFechaNac
            // 
            labelFechaNac.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelFechaNac.Location = new Point(30, 212);
            labelFechaNac.Name = "labelFechaNac";
            labelFechaNac.Size = new Size(100, 23);
            labelFechaNac.TabIndex = 3;
            labelFechaNac.Text = "Fecha Nac.:";
            // 
            // labelDni
            // 
            labelDni.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelDni.Location = new Point(30, 250);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(100, 23);
            labelDni.TabIndex = 4;
            labelDni.Text = "DNI:";
            // 
            // labelDom
            // 
            labelDom.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelDom.Location = new Point(30, 289);
            labelDom.Name = "labelDom";
            labelDom.Size = new Size(100, 23);
            labelDom.TabIndex = 5;
            labelDom.Text = "Domicilio:";
            // 
            // labelTel
            // 
            labelTel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelTel.Location = new Point(30, 326);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(100, 23);
            labelTel.TabIndex = 6;
            labelTel.Text = "Teléfono:";
            // 
            // labelApto
            // 
            labelApto.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelApto.Location = new Point(30, 365);
            labelApto.Name = "labelApto";
            labelApto.Size = new Size(100, 23);
            labelApto.TabIndex = 7;
            labelApto.Text = "Apto físico:";
            // 
            // dtpFechaInscripcion
            // 
            dtpFechaInscripcion.Format = DateTimePickerFormat.Short;
            dtpFechaInscripcion.Location = new Point(210, 22);
            dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            dtpFechaInscripcion.Size = new Size(230, 23);
            dtpFechaInscripcion.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(210, 136);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(230, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(210, 174);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(230, 23);
            txtApellido.TabIndex = 4;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(210, 212);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(230, 23);
            dtpFechaNacimiento.TabIndex = 5;
            dtpFechaNacimiento.ValueChanged += dtpFechaNacimiento_ValueChanged;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(210, 250);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(230, 23);
            txtDni.TabIndex = 6;
            txtDni.KeyPress += txtDni_KeyPress;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(210, 288);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(230, 23);
            txtDomicilio.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(210, 326);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(230, 23);
            txtTelefono.TabIndex = 8;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // cboAptoFisico
            // 
            cboAptoFisico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAptoFisico.Location = new Point(210, 364);
            cboAptoFisico.Name = "cboAptoFisico";
            cboAptoFisico.Size = new Size(130, 23);
            cboAptoFisico.TabIndex = 9;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(0, 102, 204);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(72, 421);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(110, 36);
            btnIngresar.TabIndex = 10;
            btnIngresar.Text = "Guardar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gray;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(212, 421);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 36);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(220, 20, 60);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(362, 421);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(110, 36);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Cerrar";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRegistrar
            // 
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(940, 620);
            Controls.Add(lblHeader);
            Controls.Add(pnlContenedor);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegistrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Socios";
            Load += frmRegistrar_Load;
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
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
        private ComboBox cboActividad;
        private ComboBox cboTipoPersona;
        private Label label2;
        private Label label1;
    }
}