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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(frmComprobante));

            this.lblTitulo = new Label();
            this.panelComprobante = new Panel();
            this.lblDetalle = new Label();
            this.lblSocio = new Label();
            this.lblTipo = new Label();
            this.lblFecha = new Label();
            this.lblImporte = new Label();
            this.lblMedio = new Label();
            this.lblActividad = new Label();

            this.pbLogo = new PictureBox();
            this.pbQR = new PictureBox();

            this.btnImprimir = new Button();
            this.btnCerrar = new Button();

            ((System.ComponentModel.ISupportInitialize)this.pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.pbQR).BeginInit();
            this.SuspendLayout();

            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = DockStyle.Top;
            this.lblTitulo.Text = "🧾 COMPROBANTE DE PAGO";
            this.lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitulo.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            this.lblTitulo.BackColor = Color.FromArgb(0, 102, 204);
            this.lblTitulo.ForeColor = Color.White;
            this.lblTitulo.Height = 70;

            // 
            // panelComprobante
            // 
            this.panelComprobante.BackColor = Color.White;
            this.panelComprobante.BorderStyle = BorderStyle.FixedSingle;
            this.panelComprobante.Location = new Point(50, 90);
            this.panelComprobante.Size = new Size(620, 330);
            this.panelComprobante.Padding = new Padding(20);

            Font infoFont = new Font("Segoe UI", 11F, FontStyle.Regular);

            // 
            // pbLogo
            // 
            this.pbLogo.Image = Properties.Resources.Icono; 
            this.pbLogo.Location = new Point(25, 15);
            this.pbLogo.Size = new Size(100, 80);
            this.pbLogo.SizeMode = PictureBoxSizeMode.Zoom;

            // 
            // lblDetalle
            // 
            this.lblDetalle.Text = "Detalle del Pago";
            this.lblDetalle.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            this.lblDetalle.Location = new Point(140, 20);
            this.lblDetalle.AutoSize = true;

            // 
            // Labels de datos
            // 
            this.lblSocio.Text = "N° de Socio:";
            this.lblSocio.Location = new Point(40, 120);
            this.lblSocio.Font = infoFont;
            this.lblSocio.AutoSize = true;

            this.lblTipo.Text = "Tipo Persona:";
            this.lblTipo.Location = new Point(40, 150);
            this.lblTipo.Font = infoFont;
            this.lblTipo.AutoSize = true;

            this.lblFecha.Text = "Fecha:";
            this.lblFecha.Location = new Point(40, 180);
            this.lblFecha.Font = infoFont;
            this.lblFecha.AutoSize = true;

            this.lblImporte.Text = "Importe:";
            this.lblImporte.Location = new Point(40, 210);
            this.lblImporte.Font = infoFont;
            this.lblImporte.AutoSize = true;

            this.lblMedio.Text = "Medio de Pago:";
            this.lblMedio.Location = new Point(40, 240);
            this.lblMedio.Font = infoFont;
            this.lblMedio.AutoSize = true;

            this.lblActividad.Text = "Actividad:";
            this.lblActividad.Location = new Point(40, 270);
            this.lblActividad.Font = infoFont;
            this.lblActividad.AutoSize = true;

            // 
            // pbQR
            // 
            this.pbQR.Location = new Point(480, 170);
            this.pbQR.Size = new Size(100, 100);
            this.pbQR.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbQR.BorderStyle = BorderStyle.FixedSingle;

            // 
            // Botones
            // 
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            this.btnImprimir.BackColor = Color.FromArgb(0, 102, 204);
            this.btnImprimir.ForeColor = Color.White;
            this.btnImprimir.FlatStyle = FlatStyle.Flat;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.Size = new Size(150, 40);
            this.btnImprimir.Location = new Point(150, 440);
            this.btnImprimir.Cursor = Cursors.Hand;
            this.btnImprimir.Click += new EventHandler(this.btnImprimir_Click);

            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            this.btnCerrar.BackColor = Color.FromArgb(220, 20, 60);
            this.btnCerrar.ForeColor = Color.White;
            this.btnCerrar.FlatStyle = FlatStyle.Flat;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.Size = new Size(150, 40);
            this.btnCerrar.Location = new Point(350, 440);
            this.btnCerrar.Cursor = Cursors.Hand;
            this.btnCerrar.Click += new EventHandler(this.btnCerrar_Click);

            // Añadir controles al panel
            this.panelComprobante.Controls.Add(this.pbLogo);
            this.panelComprobante.Controls.Add(this.lblDetalle);
            this.panelComprobante.Controls.Add(this.lblSocio);
            this.panelComprobante.Controls.Add(this.lblTipo);
            this.panelComprobante.Controls.Add(this.lblFecha);
            this.panelComprobante.Controls.Add(this.lblImporte);
            this.panelComprobante.Controls.Add(this.lblMedio);
            this.panelComprobante.Controls.Add(this.lblActividad);
            this.panelComprobante.Controls.Add(this.pbQR);

            // Form principal
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(720, 520);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelComprobante);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCerrar);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Comprobante de Pago";
            this.Load += new EventHandler(this.frmComprobante_Load);

            ((System.ComponentModel.ISupportInitialize)this.pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.pbQR).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private Label lblTitulo;
        private Panel panelComprobante;
        private Label lblDetalle;
        private Label lblSocio;
        private Label lblTipo;
        private Label lblFecha;
        private Label lblImporte;
        private Label lblMedio;
        private Label lblActividad;
        private Button btnImprimir;
        private Button btnCerrar;
        private PictureBox pbLogo;
        private PictureBox pbQR;
    }
}