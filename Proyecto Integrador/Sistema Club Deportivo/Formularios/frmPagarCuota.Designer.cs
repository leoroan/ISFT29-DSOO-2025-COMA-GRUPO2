namespace ClubDeportivo.Formularios
{
    partial class frmPagarCuota
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
            labelNroSocio = new Label();
            txtNroSocio = new TextBox();
            btnBuscarSocio = new Button();
            lblNombreSocio = new Label();
            lblPrecioCuota = new Label();
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
            lblTitulo.Size = new Size(682, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "💰 PAGO DE CUOTA";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.None;
            pnlPrincipal.BackColor = Color.FromArgb(235, 245, 255);
            pnlPrincipal.BorderStyle = BorderStyle.FixedSingle;
            pnlPrincipal.Controls.Add(labelNroSocio);
            pnlPrincipal.Controls.Add(txtNroSocio);
            pnlPrincipal.Controls.Add(btnBuscarSocio);
            pnlPrincipal.Controls.Add(lblNombreSocio);
            pnlPrincipal.Controls.Add(lblPrecioCuota);
            pnlPrincipal.Controls.Add(grpFormaPago);
            pnlPrincipal.Controls.Add(btnPagar);
            pnlPrincipal.Controls.Add(btnComprobante);
            pnlPrincipal.Controls.Add(btnVolver);
            pnlPrincipal.Location = new Point(248, 196);
            pnlPrincipal.Margin = new Padding(3, 2, 3, 2);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(525, 263);
            pnlPrincipal.TabIndex = 1;
            // 
            // labelNroSocio
            // 
            labelNroSocio.AutoSize = true;
            labelNroSocio.Font = new Font("Segoe UI Semilight", 12F);
            labelNroSocio.Location = new Point(44, 30);
            labelNroSocio.Name = "labelNroSocio";
            labelNroSocio.Size = new Size(132, 21);
            labelNroSocio.TabIndex = 0;
            labelNroSocio.Text = "Número de Socio:";
            // 
            // txtNroSocio
            // 
            txtNroSocio.Font = new Font("Segoe UI", 11F);
            txtNroSocio.Location = new Point(175, 28);
            txtNroSocio.Margin = new Padding(3, 2, 3, 2);
            txtNroSocio.Name = "txtNroSocio";
            txtNroSocio.Size = new Size(132, 27);
            txtNroSocio.TabIndex = 1;
            // 
            // btnBuscarSocio
            // 
            btnBuscarSocio.BackColor = Color.FromArgb(0, 102, 204);
            btnBuscarSocio.Cursor = Cursors.Hand;
            btnBuscarSocio.FlatAppearance.BorderSize = 0;
            btnBuscarSocio.FlatStyle = FlatStyle.Flat;
            btnBuscarSocio.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnBuscarSocio.ForeColor = Color.White;
            btnBuscarSocio.Location = new Point(324, 26);
            btnBuscarSocio.Margin = new Padding(3, 2, 3, 2);
            btnBuscarSocio.Name = "btnBuscarSocio";
            btnBuscarSocio.Size = new Size(83, 24);
            btnBuscarSocio.TabIndex = 2;
            btnBuscarSocio.Text = "Buscar";
            btnBuscarSocio.UseVisualStyleBackColor = false;
            btnBuscarSocio.Click += btnBuscarSocio_Click;
            // 
            // lblNombreSocio
            // 
            lblNombreSocio.AutoSize = true;
            lblNombreSocio.Font = new Font("Segoe UI Semilight", 12F);
            lblNombreSocio.Location = new Point(44, 68);
            lblNombreSocio.Name = "lblNombreSocio";
            lblNombreSocio.Size = new Size(136, 21);
            lblNombreSocio.TabIndex = 3;
            lblNombreSocio.Text = "Nombre del Socio:";
            // 
            // lblPrecioCuota
            // 
            lblPrecioCuota.AutoSize = true;
            lblPrecioCuota.Font = new Font("Segoe UI Semilight", 12F);
            lblPrecioCuota.Location = new Point(44, 98);
            lblPrecioCuota.Name = "lblPrecioCuota";
            lblPrecioCuota.Size = new Size(101, 21);
            lblPrecioCuota.TabIndex = 4;
            lblPrecioCuota.Text = "Precio Cuota:";
            // 
            // grpFormaPago
            // 
            grpFormaPago.Controls.Add(optEfvo);
            grpFormaPago.Controls.Add(optTarjeta);
            grpFormaPago.Font = new Font("Segoe UI Semilight", 11F);
            grpFormaPago.Location = new Point(44, 135);
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
            optEfvo.Size = new Size(91, 18);
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
            optTarjeta.Size = new Size(91, 18);
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
            btnPagar.Location = new Point(280, 142);
            btnPagar.Margin = new Padding(3, 2, 3, 2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(175, 34);
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
            btnComprobante.Location = new Point(280, 142);
            btnComprobante.Margin = new Padding(3, 2, 3, 2);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(175, 34);
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
            btnVolver.Location = new Point(280, 142);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(175, 34);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Cerrar";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmPagarCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(682, 390);
            Controls.Add(lblTitulo);
            Controls.Add(pnlPrincipal);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPagarCuota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagar Cuota";
            Load += frmPagarCuota_Load_1;
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            grpFormaPago.ResumeLayout(false);
            grpFormaPago.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Label lblTitulo;
        private Panel pnlPrincipal;
        private Label labelNroSocio;
        private TextBox txtNroSocio;
        private Button btnBuscarSocio;
        private Label lblNombreSocio;
        private Label lblPrecioCuota;
        private GroupBox grpFormaPago;
        private RadioButton optEfvo;
        private RadioButton optTarjeta;
        private Button btnPagar;
        private Button btnComprobante;
        private Button btnVolver;
    }
}