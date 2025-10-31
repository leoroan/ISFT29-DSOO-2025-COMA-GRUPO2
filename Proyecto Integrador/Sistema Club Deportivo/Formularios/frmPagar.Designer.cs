namespace ClubDeportivo.Formularios
{
    partial class frmPagar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            pnlPrincipal = new Panel();
            label1 = new Label();
            cboTipoRegistro = new ComboBox();
            lblNumero = new Label();
            txtNro = new TextBox();
            btnBuscar = new Button();
            lblNombre = new Label();
            lblPrecio = new Label();
            grpFormaPago = new GroupBox();
            optEfvo = new RadioButton();
            optTarjeta = new RadioButton();
            btnPagar = new Button();
            btnComprobante = new Button();
            btnVolver = new Button();
            pnlPrincipal.SuspendLayout();
            grpFormaPago.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(0, 102, 204);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(657, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "💰 PAGO DE CUOTA";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.None;
            pnlPrincipal.BackColor = Color.FromArgb(235, 245, 255);
            pnlPrincipal.BorderStyle = BorderStyle.FixedSingle;
            pnlPrincipal.Controls.Add(label1);
            pnlPrincipal.Controls.Add(cboTipoRegistro);
            pnlPrincipal.Controls.Add(lblNumero);
            pnlPrincipal.Controls.Add(txtNro);
            pnlPrincipal.Controls.Add(btnBuscar);
            pnlPrincipal.Controls.Add(lblNombre);
            pnlPrincipal.Controls.Add(lblPrecio);
            pnlPrincipal.Controls.Add(grpFormaPago);
            pnlPrincipal.Controls.Add(btnPagar);
            pnlPrincipal.Controls.Add(btnComprobante);
            pnlPrincipal.Controls.Add(btnVolver);
            pnlPrincipal.Location = new Point(49, 116);
            pnlPrincipal.Margin = new Padding(3, 2, 3, 2);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(540, 336);
            pnlPrincipal.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 12F);
            label1.Location = new Point(48, 21);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 10;
            label1.Text = "Tipo de Persona";
            // 
            // cboTipoRegistro
            // 
            cboTipoRegistro.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoRegistro.Location = new Point(183, 21);
            cboTipoRegistro.Name = "cboTipoRegistro";
            cboTipoRegistro.Size = new Size(130, 23);
            cboTipoRegistro.TabIndex = 9;
            cboTipoRegistro.SelectedIndexChanged += cboTipoRegistro_SelectedIndexChanged;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI Semilight", 12F);
            lblNumero.Location = new Point(48, 68);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(70, 21);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número:";
            // 
            // txtNro
            // 
            txtNro.Font = new Font("Segoe UI", 11F);
            txtNro.Location = new Point(183, 66);
            txtNro.Margin = new Padding(3, 2, 3, 2);
            txtNro.MaxLength = 6;
            txtNro.Name = "txtNro";
            txtNro.Size = new Size(132, 27);
            txtNro.TabIndex = 1;
            txtNro.KeyPress += txtNro_KeyPress;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 102, 204);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(328, 67);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(83, 24);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semilight", 12F);
            lblNombre.Location = new Point(48, 106);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(70, 21);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semilight", 12F);
            lblPrecio.Location = new Point(48, 136);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(56, 21);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio:";
            // 
            // grpFormaPago
            // 
            grpFormaPago.Controls.Add(optEfvo);
            grpFormaPago.Controls.Add(optTarjeta);
            grpFormaPago.Font = new Font("Segoe UI Semilight", 11F);
            grpFormaPago.Location = new Point(48, 173);
            grpFormaPago.Margin = new Padding(3, 2, 3, 2);
            grpFormaPago.Name = "grpFormaPago";
            grpFormaPago.Padding = new Padding(3, 2, 3, 2);
            grpFormaPago.Size = new Size(175, 82);
            grpFormaPago.TabIndex = 5;
            grpFormaPago.TabStop = false;
            grpFormaPago.Text = "Forma de Pago";
            // 
            // optEfvo
            // 
            optEfvo.AutoSize = true;
            optEfvo.Checked = true;
            optEfvo.Font = new Font("Segoe UI Semilight", 11.5F);
            optEfvo.Location = new Point(18, 26);
            optEfvo.Margin = new Padding(3, 2, 3, 2);
            optEfvo.Name = "optEfvo";
            optEfvo.Size = new Size(81, 25);
            optEfvo.TabIndex = 0;
            optEfvo.TabStop = true;
            optEfvo.Text = "Efectivo";
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Font = new Font("Segoe UI Semilight", 11.5F);
            optTarjeta.Location = new Point(18, 52);
            optTarjeta.Margin = new Padding(3, 2, 3, 2);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(72, 25);
            optTarjeta.TabIndex = 1;
            optTarjeta.Text = "Tarjeta";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(0, 102, 204);
            btnPagar.Cursor = Cursors.Hand;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(25, 281);
            btnPagar.Margin = new Padding(3, 2, 3, 2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(144, 36);
            btnPagar.TabIndex = 6;
            btnPagar.Text = "Registrar Pago";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.BackColor = Color.Gray;
            btnComprobante.Cursor = Cursors.Hand;
            btnComprobante.Enabled = false;
            btnComprobante.FlatAppearance.BorderSize = 0;
            btnComprobante.FlatStyle = FlatStyle.Flat;
            btnComprobante.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnComprobante.ForeColor = Color.White;
            btnComprobante.Location = new Point(200, 281);
            btnComprobante.Margin = new Padding(3, 2, 3, 2);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(144, 36);
            btnComprobante.TabIndex = 7;
            btnComprobante.Text = "Ver Comprobante";
            btnComprobante.UseVisualStyleBackColor = false;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(220, 20, 60);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(376, 281);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(144, 36);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Cerrar";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmPagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(657, 528);
            Controls.Add(lblTitulo);
            Controls.Add(pnlPrincipal);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPagar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagar Cuota";
            Load += frmPagar_Load;
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            grpFormaPago.ResumeLayout(false);
            grpFormaPago.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Label lblTitulo;
        private Panel pnlPrincipal;
        private Label lblNumero;
        private TextBox txtNro;
        private Button btnBuscar;
        private Label lblNombre;
        private Label lblPrecio;
        private GroupBox grpFormaPago;
        private RadioButton optEfvo;
        private RadioButton optTarjeta;
        private Button btnPagar;
        private Button btnComprobante;
        private Button btnVolver;
        private Label label1;
        private ComboBox cboTipoRegistro;
    }
}