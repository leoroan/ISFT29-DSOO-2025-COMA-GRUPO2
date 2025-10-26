namespace ClubDeportivo.Formularios
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            staSistema = new StatusStrip();
            tsbUsuario = new ToolStripStatusLabel();
            tsbRol = new ToolStripStatusLabel();
            pnlHeader = new Panel();
            lblTitulo = new Label();
            pnlBotones = new Panel();
            btnRegistrarSocio = new Button();
            btnPagarCuota = new Button();
            btnImprimirCarnet = new Button();
            btnSalir = new Button();
            staSistema.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlBotones.SuspendLayout();
            SuspendLayout();
            // 
            // staSistema
            // 
            staSistema.BackColor = Color.FromArgb(0, 51, 102);
            staSistema.ImageScalingSize = new Size(20, 20);
            staSistema.Items.AddRange(new ToolStripItem[] { tsbUsuario, tsbRol });
            staSistema.Location = new Point(0, 398);
            staSistema.Name = "staSistema";
            staSistema.Padding = new Padding(1, 0, 16, 0);
            staSistema.Size = new Size(720, 22);
            staSistema.SizingGrip = false;
            staSistema.TabIndex = 0;
            // 
            // tsbUsuario
            // 
            tsbUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tsbUsuario.ForeColor = Color.White;
            tsbUsuario.Name = "tsbUsuario";
            tsbUsuario.Size = new Size(23, 23);
            tsbUsuario.Text = "Usuario:";
            // 
            // tsbRol
            // 
            tsbRol.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tsbRol.ForeColor = Color.White;
            tsbRol.Name = "tsbRol";
            tsbRol.Size = new Size(23, 23);
            tsbRol.Text = "Rol:";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(0, 102, 204);
            pnlHeader.Controls.Add(lblTitulo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(720, 90);
            pnlHeader.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(100, 23);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🏆 CLUB DEPORTIVO - PANEL PRINCIPAL";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBotones
            // 
            pnlBotones.BackColor = Color.WhiteSmoke;
            pnlBotones.Controls.Add(btnRegistrarSocio);
            pnlBotones.Controls.Add(btnPagarCuota);
            pnlBotones.Controls.Add(btnImprimirCarnet);
            pnlBotones.Controls.Add(btnSalir);
            pnlBotones.Dock = DockStyle.Fill;
            pnlBotones.Location = new Point(0, 90);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Padding = new Padding(40);
            pnlBotones.Size = new Size(720, 308);
            pnlBotones.TabIndex = 0;
            pnlBotones.Paint += pnlBotones_Paint;
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.Location = new Point(0, 0);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(75, 23);
            btnRegistrarSocio.TabIndex = 0;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.Location = new Point(0, 0);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(75, 23);
            btnPagarCuota.TabIndex = 1;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // btnImprimirCarnet
            // 
            btnImprimirCarnet.Location = new Point(0, 0);
            btnImprimirCarnet.Name = "btnImprimirCarnet";
            btnImprimirCarnet.Size = new Size(75, 23);
            btnImprimirCarnet.TabIndex = 2;
            btnImprimirCarnet.Click += btnImprimirCarnet_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(0, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 248, 255);
            ClientSize = new Size(720, 420);
            Controls.Add(pnlBotones);
            Controls.Add(pnlHeader);
            Controls.Add(staSistema);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(30, 30, 30);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Club Deportivo - Panel Principal";
            Load += frmPrincipal_Load;
            staSistema.ResumeLayout(false);
            staSistema.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlBotones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button CrearBoton(string texto, Point ubicacion, int ancho, int alto, Font fuente, Color colorFondo, Color colorTexto)
        {
            Button btn = new Button
            {
                Text = texto,
                Location = ubicacion,
                Size = new Size(ancho, alto),
                Font = fuente,
                ForeColor = colorTexto,
                BackColor = colorFondo,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                FlatAppearance = {
            BorderSize = 0,
            MouseDownBackColor = Color.FromArgb(
                Math.Max(0, colorFondo.R - 20),
                Math.Max(0, colorFondo.G - 20),
                Math.Max(0, colorFondo.B - 20))
        }
            };
            return btn;
        }

        #endregion

        private StatusStrip staSistema;
        private ToolStripStatusLabel tsbUsuario;
        private ToolStripStatusLabel tsbRol;
        private Panel pnlHeader;
        private Label lblTitulo;
        private Panel pnlBotones;
        private Button btnRegistrarSocio;
        private Button btnPagarCuota;
        private Button btnImprimirCarnet;
        private Button btnSalir;
    }
}