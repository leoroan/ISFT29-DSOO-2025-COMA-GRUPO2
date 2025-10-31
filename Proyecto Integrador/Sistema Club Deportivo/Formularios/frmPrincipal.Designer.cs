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
            btnImprimirListado = new Button();
            btnImprimirCarnet = new Button();
            btnPagar = new Button();
            btnSalir = new Button();
            btnRegistrar = new Button();
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
            tsbUsuario.Size = new Size(52, 17);
            tsbUsuario.Text = "Usuario:";
            // 
            // tsbRol
            // 
            tsbRol.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tsbRol.ForeColor = Color.White;
            tsbRol.Name = "tsbRol";
            tsbRol.Size = new Size(28, 17);
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
            lblTitulo.Size = new Size(720, 90);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🏆 CLUB DEPORTIVO - PANEL PRINCIPAL";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBotones
            // 
            pnlBotones.BackColor = Color.WhiteSmoke;
            pnlBotones.Controls.Add(btnImprimirListado);
            pnlBotones.Controls.Add(btnImprimirCarnet);
            pnlBotones.Controls.Add(btnPagar);
            pnlBotones.Controls.Add(btnSalir);
            pnlBotones.Controls.Add(btnRegistrar);
            pnlBotones.Dock = DockStyle.Fill;
            pnlBotones.Location = new Point(0, 90);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Padding = new Padding(40);
            pnlBotones.Size = new Size(720, 308);
            pnlBotones.TabIndex = 0;
            // 
            // btnImprimirListado
            // 
            btnImprimirListado.BackColor = SystemColors.HotTrack;
            btnImprimirListado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnImprimirListado.ForeColor = Color.White;
            btnImprimirListado.Image = Properties.Resources.listado_48;
            btnImprimirListado.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprimirListado.Location = new Point(357, 127);
            btnImprimirListado.Name = "btnImprimirListado";
            btnImprimirListado.Size = new Size(207, 65);
            btnImprimirListado.TabIndex = 10;
            btnImprimirListado.Text = "Listado Deudores";
            btnImprimirListado.UseVisualStyleBackColor = false;
            btnImprimirListado.Click += btnImprimirListado_Click;
            // 
            // btnImprimirCarnet
            // 
            btnImprimirCarnet.BackColor = SystemColors.HotTrack;
            btnImprimirCarnet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnImprimirCarnet.ForeColor = Color.White;
            btnImprimirCarnet.Image = Properties.Resources.imprimir_48;
            btnImprimirCarnet.ImageAlign = ContentAlignment.MiddleLeft;
            btnImprimirCarnet.Location = new Point(140, 127);
            btnImprimirCarnet.Name = "btnImprimirCarnet";
            btnImprimirCarnet.Size = new Size(207, 65);
            btnImprimirCarnet.TabIndex = 9;
            btnImprimirCarnet.Text = "Imprimir Carnet";
            btnImprimirCarnet.UseVisualStyleBackColor = false;
            btnImprimirCarnet.Click += btnImprimirCarnet_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = SystemColors.HotTrack;
            btnPagar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPagar.ForeColor = Color.White;
            btnPagar.Image = Properties.Resources.pagar_48;
            btnPagar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPagar.Location = new Point(356, 43);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(208, 65);
            btnPagar.TabIndex = 8;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.HotTrack;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Image = Properties.Resources.salir_48;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(254, 204);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(207, 65);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.HotTrack;
            btnRegistrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Image = Properties.Resources.registrar_48;
            btnRegistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.Location = new Point(140, 43);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(207, 65);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
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
        private Button btnImprimirListado;
        private Button btnImprimirCarnet;
        private Button btnPagar;
        private Button btnSalir;
        private Button btnRegistrar;
    }
}