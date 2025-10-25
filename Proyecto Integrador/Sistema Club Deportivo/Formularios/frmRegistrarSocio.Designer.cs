namespace ClubDeportivo.Formularios
{
    partial class frmRegistrarSocio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnVolver = new Button();
            btnLimpiar = new Button();
            btnIngresar = new Button();
            cboAptoFisico = new ComboBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dtpFechaNacimiento = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            txtDomicilio = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label7 = new Label();
            dtpFechaInscripcion = new DateTimePicker();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(459, 336);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 28;
            label5.Text = "Dni:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 444);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 27;
            label4.Text = "Apto Fisico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 183);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 26;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 133);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 25;
            label2.Text = "Nombre:";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(763, 487);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 31);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(625, 487);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(481, 487);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(86, 31);
            btnIngresar.TabIndex = 8;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // cboAptoFisico
            // 
            cboAptoFisico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAptoFisico.FormattingEnabled = true;
            cboAptoFisico.Location = new Point(568, 440);
            cboAptoFisico.Margin = new Padding(3, 4, 3, 4);
            cboAptoFisico.Name = "cboAptoFisico";
            cboAptoFisico.Size = new Size(118, 28);
            cboAptoFisico.TabIndex = 7;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(568, 332);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(270, 27);
            txtDni.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(568, 177);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.MaxLength = 40;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(270, 27);
            txtApellido.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(568, 127);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(270, 27);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(552, 12);
            label1.Name = "label1";
            label1.Size = new Size(246, 32);
            label1.TabIndex = 17;
            label1.Text = "REGISTRO DE SOCIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Socio;
            pictureBox1.Location = new Point(-1, 37);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(454, 481);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(568, 228);
            dtpFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(118, 27);
            dtpFechaNacimiento.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(459, 233);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 35;
            label10.Text = "Fec.Nac:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(459, 287);
            label11.Name = "label11";
            label11.Size = new Size(77, 20);
            label11.TabIndex = 37;
            label11.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(568, 281);
            txtDomicilio.Margin = new Padding(3, 4, 3, 4);
            txtDomicilio.MaxLength = 40;
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(270, 27);
            txtDomicilio.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(459, 392);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 39;
            label6.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(568, 388);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.MaxLength = 20;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(270, 27);
            txtTelefono.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(459, 87);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 41;
            label7.Text = "Fec.Inscripcion:";
            // 
            // dtpFechaInscripcion
            // 
            dtpFechaInscripcion.Format = DateTimePickerFormat.Short;
            dtpFechaInscripcion.Location = new Point(568, 81);
            dtpFechaInscripcion.Margin = new Padding(3, 4, 3, 4);
            dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            dtpFechaInscripcion.Size = new Size(118, 27);
            dtpFechaInscripcion.TabIndex = 0;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmRegistrarSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 541);
            Controls.Add(label7);
            Controls.Add(dtpFechaInscripcion);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label11);
            Controls.Add(txtDomicilio);
            Controls.Add(label10);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(cboAptoFisico);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegistrarSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alta";
            Load += frmRegistrarSocio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnVolver;
        private Button btnLimpiar;
        private Button btnIngresar;
        private ComboBox cboAptoFisico;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label1;
        private PictureBox pictureBox1;
        private DateTimePicker dtpFechaNacimiento;
        private Label label10;
        private Label label11;
        private TextBox txtDomicilio;
        private Label label6;
        private TextBox txtTelefono;
        private Label label7;
        private DateTimePicker dtpFechaInscripcion;
        private ErrorProvider errorProvider1;
    }
}