namespace ClubDeportivo.Formularios
{
    partial class frmComprobante
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código de diseño
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            panelComprobante = new Panel();
            lblNombre = new Label();
            pbLogo = new PictureBox();
            lblDetalle = new Label();
            lblNro = new Label();
            lblTipo = new Label();
            lblFecha = new Label();
            lblPrecio = new Label();
            lblFormaPago = new Label();
            lblActividad = new Label();
            pbQR = new PictureBox();
            btnImprimir = new Button();
            btnCerrar = new Button();
            panelComprobante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQR).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(0, 102, 204);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(630, 52);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "\U0001f9fe COMPROBANTE DE PAGO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelComprobante
            // 
            panelComprobante.BackColor = Color.White;
            panelComprobante.BorderStyle = BorderStyle.FixedSingle;
            panelComprobante.Controls.Add(lblNombre);
            panelComprobante.Controls.Add(pbLogo);
            panelComprobante.Controls.Add(lblDetalle);
            panelComprobante.Controls.Add(lblNro);
            panelComprobante.Controls.Add(lblTipo);
            panelComprobante.Controls.Add(lblFecha);
            panelComprobante.Controls.Add(lblPrecio);
            panelComprobante.Controls.Add(lblFormaPago);
            panelComprobante.Controls.Add(lblActividad);
            panelComprobante.Controls.Add(pbQR);
            panelComprobante.Location = new Point(44, 68);
            panelComprobante.Margin = new Padding(3, 2, 3, 2);
            panelComprobante.Name = "panelComprobante";
            panelComprobante.Padding = new Padding(18, 15, 18, 15);
            panelComprobante.Size = new Size(543, 264);
            panelComprobante.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11F);
            lblNombre.Location = new Point(35, 136);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre:";
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.Icono;
            pbLogo.Location = new Point(22, 11);
            pbLogo.Margin = new Padding(3, 2, 3, 2);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(88, 60);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblDetalle.Location = new Point(122, 15);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(148, 25);
            lblDetalle.TabIndex = 1;
            lblDetalle.Text = "Detalle del Pago";
            // 
            // lblNro
            // 
            lblNro.AutoSize = true;
            lblNro.Font = new Font("Segoe UI", 11F);
            lblNro.Location = new Point(35, 90);
            lblNro.Name = "lblNro";
            lblNro.Size = new Size(29, 20);
            lblNro.TabIndex = 2;
            lblNro.Text = "N°:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 11F);
            lblTipo.Location = new Point(35, 112);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(97, 20);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo Persona:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 11F);
            lblFecha.Location = new Point(35, 159);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 11F);
            lblPrecio.Location = new Point(35, 182);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio:";
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Segoe UI", 11F);
            lblFormaPago.Location = new Point(35, 204);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(113, 20);
            lblFormaPago.TabIndex = 6;
            lblFormaPago.Text = "Medio de Pago:";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Segoe UI", 11F);
            lblActividad.Location = new Point(35, 226);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(75, 20);
            lblActividad.TabIndex = 7;
            lblActividad.Text = "Actividad:";
            // 
            // pbQR
            // 
            pbQR.BorderStyle = BorderStyle.FixedSingle;
            pbQR.Location = new Point(420, 128);
            pbQR.Margin = new Padding(3, 2, 3, 2);
            pbQR.Name = "pbQR";
            pbQR.Size = new Size(88, 76);
            pbQR.SizeMode = PictureBoxSizeMode.Zoom;
            pbQR.TabIndex = 8;
            pbQR.TabStop = false;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(0, 102, 204);
            btnImprimir.Cursor = Cursors.Hand;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(132, 349);
            btnImprimir.Margin = new Padding(3, 2, 3, 2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(131, 30);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(220, 20, 60);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(307, 349);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(131, 30);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmComprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 390);
            Controls.Add(lblTitulo);
            Controls.Add(panelComprobante);
            Controls.Add(btnImprimir);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmComprobante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprobante de Pago";
            Load += frmComprobante_Load;
            panelComprobante.ResumeLayout(false);
            panelComprobante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQR).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Label lblTitulo;
        private Panel panelComprobante;
        private Label lblDetalle;
        private Label lblNro;
        private Label lblTipo;
        private Label lblFecha;
        private Label lblPrecio;
        private Label lblFormaPago;
        private Label lblActividad;
        private Button btnImprimir;
        private Button btnCerrar;
        private PictureBox pbLogo;
        private PictureBox pbQR;
        private Label lblNombre;
    }
}